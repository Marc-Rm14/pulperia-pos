using Pulperia.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pulperia.Domain.Interfaces;
using Pulperia.WinForms.Modales;
namespace Pulperia.WinForms.UserControls
{
    public partial class UcInventario : UserControl
    {
        private readonly IProductoRepository _productoRepository;
        public UcInventario(IProductoRepository ProductoRepository)
        {
            InitializeComponent();


            _productoRepository = ProductoRepository;



        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            tbcContenido.SelectedIndex = 0;
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            tbcContenido.SelectedIndex = 1;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            tbcContenido.SelectedIndex = 2;
        }

        private void UcInventario_Load(object sender, EventArgs e)
        {
            CargarListadoProductos();
        }

        private void CargarListadoProductos()
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();

                
                if (criterio == "Buscar Productos...")
                {
                    criterio = "";
                }

                var lista = _productoRepository.ObtenerTodosConFiltro(criterio);

                // Vinculamos la lista al DataGridView
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                // Formateamos las columnas para que se vea profesional
                ConfigurarColumnasGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el catálogo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasGrilla()
        {
            // 1. Ocultar columnas que no aportan valor visual directo (Primero validamos que existan)
            if (dgvProductos.Columns["Precio"] != null) dgvProductos.Columns["Precio"].Visible = false;
            if (dgvProductos.Columns["IdProducto"] != null) dgvProductos.Columns["IdProducto"].Visible = false;
            if (dgvProductos.Columns["IdCategoria"] != null) dgvProductos.Columns["IdCategoria"].Visible = false;
            if (dgvProductos.Columns["IdUnidad"] != null) dgvProductos.Columns["IdUnidad"].Visible = false;
            if (dgvProductos.Columns["EsPerecedero"] != null) dgvProductos.Columns["EsPerecedero"].Visible = false;

            // 2. Configurar y dar formato a las columnas visibles de forma segura

            // Precio Decimal
            var colPrecio = dgvProductos.Columns["PrecioDecimal"];
            if (colPrecio != null)
            {
                colPrecio.HeaderText = "Precio de Venta";
                colPrecio.DefaultCellStyle.Format = "C2"; // Formato moneda local
                colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Nombre del Producto
            var colNombre = dgvProductos.Columns["NombreProducto"];
            if (colNombre != null)
            {
                colNombre.HeaderText = "Descripción del Producto";
            }

            // Stock Disponible
            var colStockActual = dgvProductos.Columns["StockActual"];
            if (colStockActual != null)
            {
                colStockActual.HeaderText = "Stock Disponible";
                colStockActual.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Stock Mínimo
            var colStockMinimo = dgvProductos.Columns["StockMinimo"];
            if (colStockMinimo != null)
            {
                colStockMinimo.HeaderText = "Stock Mínimo";
                colStockMinimo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Estado Activo
            var colEstaActivo = dgvProductos.Columns["EstaActivo"];
            if (colEstaActivo != null)
            {
                colEstaActivo.HeaderText = "Activo";
            }


            var colCategoria = dgvProductos.Columns["CategoriaNombre"];
            if (colCategoria != null)
            {
                colCategoria.HeaderText = "Categoria";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar Productos...") return;
            CargarListadoProductos();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarListadoProductos();
                e.Handled = true; // Evita el pitido clásico de Windows al presionar Enter
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar Productos...")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {

            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar Productos...";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmEditarProducto(_productoRepository, null))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    CargarListadoProductos(); // Se refresca tu grilla automáticamente
                }
            }
        }
    }
}
