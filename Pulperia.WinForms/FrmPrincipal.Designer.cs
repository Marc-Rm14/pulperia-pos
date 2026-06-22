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
            pnlBarraBotones = new Panel();
            btnSalir = new Button();
            BtnPuntoVenta = new Button();
            pnlContenedor = new Panel();
            btnCatalogo = new Button();
            pnlBarraBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(65, 64, 115);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1262, 67);
            pnlSuperior.TabIndex = 0;
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
            // btnSalir
            // 
            btnSalir.Location = new Point(48, 489);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 43);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnPuntoVenta
            // 
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
            // btnCatalogo
            // 
            btnCatalogo.Location = new Point(48, 93);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(94, 42);
            btnCatalogo.TabIndex = 2;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click;
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
    }
}
