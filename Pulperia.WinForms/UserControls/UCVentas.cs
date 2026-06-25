using Pulperia.Business;
using Pulperia.Domain.DTOS;
using Pulperia.Domain.Events;
using Pulperia.Domain.Interfaces;
using System.ComponentModel;

namespace Pulperia.WinForms.UserControls
{
    public partial class UCVentas : UserControl
    {
        private readonly IProductoRepository _productoRepository;

        private BindingList<DetalleVentaVista> _detalleVentaGrid = new BindingList<DetalleVentaVista>();


        private readonly VentaService _ventaService;


        public UCVentas(IProductoRepository productoRepository, VentaService ventaService)
        {
            InitializeComponent();

            _productoRepository = productoRepository;

            dgvDetalle.AutoGenerateColumns = false;


            ConfigurarColumnasGrid();

            dgvDetalle.DataSource = _detalleVentaGrid;

            numericUpDown1.Minimum = 0.01M; // Evita que agreguen cantidades en cero o negativas
            numericUpDown1.DecimalPlaces = 2; // Permite dos decimales para las libras/onzas
            numericUpDown1.Value = 1;
            _ventaService = ventaService;


            _detalleVentaGrid.ListChanged += (s, e) => ActualizarTotalVenta();
        }

        private void ConfigurarColumnasGrid()
        {
            dgvDetalle.Columns.Clear();

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "NombreProducto";
            colNombre.DataPropertyName = "NombreProducto"; // Coincide con la propiedad de la clase de abajo
            colNombre.HeaderText = "Producto";
            colNombre.ReadOnly = true;
            dgvDetalle.Columns.Add(colNombre);

            // Columna Precio
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.DataPropertyName = "PrecioUnitario";
            colPrecio.HeaderText = "Precio";
            colPrecio.ReadOnly = true;
            colPrecio.DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns.Add(colPrecio);

            // Columna Cantidad
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "Cantidad";
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.HeaderText = "Cant.";
            dgvDetalle.Columns.Add(colCantidad);

            // Columna Subtotal
            DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
            colSubtotal.Name = "Subtotal";
            colSubtotal.DataPropertyName = "Subtotal";
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns.Add(colSubtotal);

            //
            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.Text = "Eliminar";
            eliminar.HeaderText = "";
            eliminar.Name = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;
            dgvDetalle.Columns.Add(eliminar);
        }

        private void txtBoxBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBoxBuscarProducto.Text == "Buscar Producto...")
            {
                txtBoxBuscarProducto.Text = "";
            }
        }

        private void txtBoxBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBoxBuscarProducto.Text == "")
            {
                txtBoxBuscarProducto.Text = "Buscar Producto...";
            }
        }

        private void txtBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBoxBuscarProducto.Text.Trim();

            // Solo busca si el usuario ha escrito al menos 2 caracteres (para evitar consultas innecesarias)
            if (busqueda.Length >= 2)
            {
                var resultados = _productoRepository.BuscarPorNombre(busqueda);
                if (resultados.Any())
                {
                    lstResultados.DataSource = resultados;
                    lstResultados.DisplayMember = "Descripcion"; // Lo que el usuario lee
                    lstResultados.ValueMember = "IdProducto"; // El ID oculto

                    lstResultados.Visible = true;
                    lblDetallesLista.Visible = true;
                }

            }
            else
            {
                lstResultados.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya un producto seleccionado en la lista de resultados
            if (lstResultados.SelectedItem == null || !lstResultados.Visible)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista de resultados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el producto seleccionado (es un ProductoBusqueda)
            ProductoBusqueda productoSeleccionado = (ProductoBusqueda)lstResultados.SelectedItem;

            // 3. Verificar si el producto ya existe en el Grid para solo sumarle cantidad
            var itemExistente = _detalleVentaGrid.FirstOrDefault(d => d.IdProducto == productoSeleccionado.IdProducto);


            decimal cantidadA_Agregar = numericUpDown1.Value;

            if (itemExistente != null)
            {
                // Si ya existe, le sumamos 1 a la cantidad
                itemExistente.Cantidad += cantidadA_Agregar;


                _detalleVentaGrid.ResetBindings(); // Avisa a la lista que un objeto interno cambió
                ActualizarTotalVenta();
            }
            else
            {
                // Si es nuevo, lo creamos y lo agregamos a la lista
                DetalleVentaVista nuevoDetalle = new DetalleVentaVista
                {
                    IdProducto = productoSeleccionado.IdProducto,
                    NombreProducto = productoSeleccionado.Nombre,
                    PrecioVentaCentavos = productoSeleccionado.PrecioVenta,
                    Cantidad = cantidadA_Agregar // Por defecto agregamos 1
                };

                _detalleVentaGrid.Add(nuevoDetalle);
            }

            // Opcional: Limpiar el buscador y ocultar la lista tras agregar
            txtBoxBuscarProducto.Text = "Buscar Producto...";
            lstResultados.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 1. Validación de UI (Evita viajar al servicio si la pantalla está vacía)
            if (!_detalleVentaGrid.Any())
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mapeo/Armado del DTO desde los datos de la pantalla
            var nuevaVenta = new RegistrarVenta
            {
                IdUsuario = 1, // Id del usuario logueado
                Detalles = _detalleVentaGrid.ToList()
            };

            try
            {
                // 3. Invocamos a la Capa de Negocio (un Servicio, no el Repositorio directo)
                ResultadoVenta resultado =  _ventaService.RegistrarNuevaVenta(nuevaVenta);


                if (!resultado.EsExitosa) 
                {
                    MessageBox.Show($"Error: {resultado.MensajeError}", "Error al procesar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Venta procesada con éxito.", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InventarioEvents.NotificarVenta();
                // 5. Abrir el documento después de confirmar
                if (File.Exists(resultado.RutaPdf))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(resultado.RutaPdf) { UseShellExecute = true });
                }

                // Limpieza de controles visuales
                _detalleVentaGrid.Clear();
                numericUpDown1.Value = 1;
                lblTotal.Text = "Total: ₡0.00";
            }
            catch (Exception ex)
            {
                // 5. Manejo de errores de negocio en la UI
                MessageBox.Show($"Error: {ex.Message}", "Error al procesar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotalVenta()
        {

            decimal total = _detalleVentaGrid.Sum(item => item.Subtotal);


            lblTotal.Text = $"Total: ₡{total:N2}";
        }



        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalle.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                _detalleVentaGrid.RemoveAt(e.RowIndex);
            }
        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalle.Columns[e.ColumnIndex].Name == "Cantidad") 
            {
                _detalleVentaGrid.ResetBindings();
                ActualizarTotalVenta();
            }
        }
    }




}
