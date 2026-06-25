using Pulperia.Data.Repositories;
using Pulperia.Domain.Entities;
using Pulperia.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;


namespace Pulperia.WinForms.Modales
{
    public partial class FrmEditarCategoria : Form
    {
        private Categoria? _categoriaOrginal;
        private bool _esEdicion = false;
        private readonly ICategoriaRepository _categoriaRepository;
        public FrmEditarCategoria(ICategoriaRepository categoriaRepository, Categoria? categoria = null)
        {
            InitializeComponent();

            _categoriaRepository = categoriaRepository;


            _categoriaOrginal = categoria;

            if (_categoriaOrginal != null)
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


            Categoria categoriaParaGuardar = _esEdicion ? _categoriaOrginal! : new Categoria();

            categoriaParaGuardar.Nombre = txtNombre.Text.Trim();


            bool exito;
            if (_esEdicion)
                exito = _categoriaRepository.Update(categoriaParaGuardar); // Debes tener este método implementado
            else
                exito = _categoriaRepository.Insert(categoriaParaGuardar);

            if (exito)
            {
                MessageBox.Show("Categoria Guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Esto avisa a la grilla que debe refrescarse
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la categoria en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (_esEdicion && _categoriaOrginal != null)
            {
                txtNombre.Text = _categoriaOrginal.Nombre;
                btnGuardar.Text = "Actualizar";
                lblTitulo.Text = "Editar Categoria";
            }
            else 
            {
                // MODO CREACIÓN: Títulos por defecto limpios
                this.Text = "Nueva Categoria";
                btnGuardar.Text = "Guardar";
                
                lblTitulo.Text = "Agregar Categoria";
            }
        }
    }
}
