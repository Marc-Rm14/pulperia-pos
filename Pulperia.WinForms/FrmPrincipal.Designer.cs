namespace Pulperia.WinForms
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSuperior = new Panel();
            lblEstablecimiento = new Label();
            lblTitulo = new Label();
            pnlBarraBotones = new Panel();
            btnCatalogo = new Button();
            btnSalir = new Button();
            BtnPuntoVenta = new Button();
            pnlContenedor = new Panel();
            pnlSuperior.SuspendLayout();
            pnlBarraBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(65, 64, 115);
            pnlSuperior.Controls.Add(lblEstablecimiento);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1262, 67);
            pnlSuperior.TabIndex = 0;
            // 
            // lblEstablecimiento
            // 
            lblEstablecimiento.AutoSize = true;
            lblEstablecimiento.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstablecimiento.ForeColor = SystemColors.HighlightText;
            lblEstablecimiento.Location = new Point(322, 12);
            lblEstablecimiento.Name = "lblEstablecimiento";
            lblEstablecimiento.Size = new Size(320, 38);
            lblEstablecimiento.TabIndex = 1;
            lblEstablecimiento.Text = "Pulperia La Chamorrito";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HighlightText;
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema De Ventas";
            // 
            // pnlBarraBotones
            // 
            pnlBarraBotones.BackColor = Color.FromArgb(65, 64, 115);
            pnlBarraBotones.Controls.Add(btnCatalogo);
            pnlBarraBotones.Controls.Add(btnSalir);
            pnlBarraBotones.Controls.Add(BtnPuntoVenta);
            pnlBarraBotones.Dock = DockStyle.Left;
            pnlBarraBotones.Location = new Point(0, 67);
            pnlBarraBotones.Name = "pnlBarraBotones";
            pnlBarraBotones.Size = new Size(190, 606);
            pnlBarraBotones.TabIndex = 1;
            // 
            // btnCatalogo
            // 
            btnCatalogo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCatalogo.Location = new Point(48, 93);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(94, 42);
            btnCatalogo.TabIndex = 2;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.Location = new Point(48, 167);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 43);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnPuntoVenta
            // 
            BtnPuntoVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            BtnPuntoVenta.Location = new Point(48, 26);
            BtnPuntoVenta.Name = "BtnPuntoVenta";
            BtnPuntoVenta.Size = new Size(94, 39);
            BtnPuntoVenta.TabIndex = 0;
            BtnPuntoVenta.Text = "Ventas";
            BtnPuntoVenta.UseVisualStyleBackColor = true;
            BtnPuntoVenta.Click += BtnPuntoVenta_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(190, 67);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1072, 606);
            pnlContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlBarraBotones);
            Controls.Add(pnlSuperior);
            Name = "FrmPrincipal";
            Text = "Form1";
            Load += FrmPrincipal_Load;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlBarraBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlBarraBotones;
        private Panel pnlContenedor;
        private Button BtnPuntoVenta;
        private Button btnSalir;
        private Button btnCatalogo;
        private Label lblEstablecimiento;
        private Label lblTitulo;
    }
}
