using Pulperia.Domain.Entities;
using Pulperia.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pulperia.WinForms.Modales
{
    public partial class FrmEditarProducto : Form
    {
        private readonly IProductoRepository _productoRepository;
        private Producto? _productoOriginal; // Guardará el producto si es edición
        private bool _esEdicion = false;
        public FrmEditarProducto(IProductoRepository productoRepository, Producto? producto = null)
        {
            InitializeComponent();
            _productoRepository = productoRepository;
            _productoOriginal = producto;

            if (_productoOriginal != null)
            {
                _esEdicion = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (decimal.TryParse(txtPrecio.Text, out decimal precioIngresado)) 
            {
                MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Producto productoParaGuardar = _esEdicion ? _productoOriginal! : new Producto();


            

            productoParaGuardar.NombreProducto = txtNombre.Text.Trim();
            productoParaGuardar.IdCategoria = Convert.ToInt32(cboCategorias.SelectedValue);
            productoParaGuardar.IdUnidad = Convert.ToInt32(cboUnidad.SelectedValue);

            // Convertimos de vuelta a entero para la base de datos (ej: 45.00 -> 4500)
            productoParaGuardar.Precio = Convert.ToInt32(precioIngresado * 100);

            productoParaGuardar.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
            productoParaGuardar.EsPerecedero = chkEsPerecedero.Checked;
            productoParaGuardar.EstaActivo = chkEstaActivo.Checked;

            if (!_esEdicion)
            {
                productoParaGuardar.StockActual = Convert.ToDouble(txtStockActual.Text);
            }

            
           
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            //CargarCombos(); // Primero llenas tus ComboBoxes de Categorías y Unidades

            if (_esEdicion && _productoOriginal != null)
            {
                // MODO EDICIÓN: Cambiamos títulos y cargamos los datos
                this.Text = "Editar Producto";
                btnGuardar.Text = "Actualizar";

                txtNombre.Text = _productoOriginal.NombreProducto;
                cboCategorias.SelectedValue = _productoOriginal.IdCategoria;
                cboUnidad.SelectedValue = _productoOriginal.IdUnidad;

                // Convertimos el entero de la DB a decimal visible para el usuario (ej: 4500 -> 45)
                txtPrecio.Text = (_productoOriginal.Precio / 100m).ToString("0.00");

                txtStockActual.Text = _productoOriginal.StockActual.ToString();
                txtStockMinimo.Text = _productoOriginal.StockMinimo.ToString();
                chkEsPerecedero.Checked = _productoOriginal.EsPerecedero;
                chkEstaActivo.Checked = _productoOriginal.EstaActivo;

                
                txtStockActual.Enabled = false;
            }
            else
            {
                // MODO CREACIÓN: Títulos por defecto limpios
                this.Text = "Nuevo Producto";
                btnGuardar.Text = "Guardar";
                chkEstaActivo.Checked = true; // Por defecto activo
            }
        }
    }
}
