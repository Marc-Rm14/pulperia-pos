namespace Pulperia.WinForms.Modales
{
    partial class FrmEditarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboUnidad = new ComboBox();
            cboCategorias = new ComboBox();
            chkEsPerecedero = new CheckBox();
            chkEstaActivo = new CheckBox();
            txtPrecio = new TextBox();
            txtStockMinimo = new TextBox();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cboUnidad);
            panel1.Controls.Add(cboCategorias);
            panel1.Controls.Add(chkEsPerecedero);
            panel1.Controls.Add(chkEstaActivo);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtStockMinimo);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(43, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 383);
            panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(70, 309);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(512, 309);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 45);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboUnidad
            // 
            cboUnidad.FormattingEnabled = true;
            cboUnidad.Location = new Point(512, 205);
            cboUnidad.Name = "cboUnidad";
            cboUnidad.Size = new Size(151, 28);
            cboUnidad.TabIndex = 7;
            // 
            // cboCategorias
            // 
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(512, 27);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(151, 28);
            cboCategorias.TabIndex = 6;
            // 
            // chkEsPerecedero
            // 
            chkEsPerecedero.AutoSize = true;
            chkEsPerecedero.Location = new Point(283, 198);
            chkEsPerecedero.Name = "chkEsPerecedero";
            chkEsPerecedero.Size = new Size(105, 24);
            chkEsPerecedero.TabIndex = 5;
            chkEsPerecedero.Text = "Perecedero";
            chkEsPerecedero.UseVisualStyleBackColor = true;
            // 
            // chkEstaActivo
            // 
            chkEstaActivo.AutoSize = true;
            chkEstaActivo.Location = new Point(283, 97);
            chkEstaActivo.Name = "chkEstaActivo";
            chkEstaActivo.Size = new Size(73, 24);
            chkEstaActivo.TabIndex = 4;
            chkEstaActivo.Text = "Activo";
            chkEstaActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(283, 27);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(22, 196);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(125, 27);
            txtStockMinimo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarProducto";
            Load += FrmEditarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboUnidad;
        private ComboBox cboCategorias;
        private CheckBox chkEsPerecedero;
        private CheckBox chkEstaActivo;
        private TextBox txtPrecio;
        private TextBox txtStockMinimo;
        private TextBox txtNombre;
    }
}