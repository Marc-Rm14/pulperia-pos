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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            cboUnidad = new ComboBox();
            cboCategorias = new ComboBox();
            chkEsPerecedero = new CheckBox();
            chkEstaActivo = new CheckBox();
            txtPrecio = new TextBox();
            txtStockMinimo = new TextBox();
            txtNombre = new TextBox();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cboUnidad);
            panel1.Controls.Add(cboCategorias);
            panel1.Controls.Add(chkEsPerecedero);
            panel1.Controls.Add(chkEstaActivo);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtStockMinimo);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 393);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(508, 106);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 12;
            label5.Text = "Unidad de Medida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(29, 192);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 11;
            label4.Text = "Stock Minimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(30, 106);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 10;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(30, 13);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(523, 13);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 8;
            label1.Text = "Categorias";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnCancelar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 69);
            panel2.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Right;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(634, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 45);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(439, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboUnidad
            // 
            cboUnidad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cboUnidad.FormattingEnabled = true;
            cboUnidad.Location = new Point(439, 140);
            cboUnidad.Name = "cboUnidad";
            cboUnidad.Size = new Size(314, 33);
            cboUnidad.TabIndex = 7;
            // 
            // cboCategorias
            // 
            cboCategorias.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(439, 54);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(314, 33);
            cboCategorias.TabIndex = 6;
            // 
            // chkEsPerecedero
            // 
            chkEsPerecedero.AutoSize = true;
            chkEsPerecedero.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsPerecedero.Location = new Point(601, 240);
            chkEsPerecedero.Name = "chkEsPerecedero";
            chkEsPerecedero.Size = new Size(128, 29);
            chkEsPerecedero.TabIndex = 5;
            chkEsPerecedero.Text = "Perecedero";
            chkEsPerecedero.UseVisualStyleBackColor = true;
            // 
            // chkEstaActivo
            // 
            chkEstaActivo.AutoSize = true;
            chkEstaActivo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstaActivo.Location = new Point(439, 240);
            chkEstaActivo.Name = "chkEstaActivo";
            chkEstaActivo.Size = new Size(86, 29);
            chkEstaActivo.TabIndex = 4;
            chkEstaActivo.Text = "Activo";
            chkEstaActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtPrecio.Location = new Point(30, 142);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(266, 31);
            txtPrecio.TabIndex = 3;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.BorderStyle = BorderStyle.FixedSingle;
            txtStockMinimo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtStockMinimo.Location = new Point(30, 238);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(266, 31);
            txtStockMinimo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtNombre.Location = new Point(30, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 31);
            txtNombre.TabIndex = 0;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(12, 98, 145);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(800, 57);
            panelTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HighlightText;
            lblTitulo.Location = new Point(3, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editar ";
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarProducto";
            Load += FrmEditarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
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
        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}