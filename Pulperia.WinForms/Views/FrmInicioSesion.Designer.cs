namespace Pulperia.WinForms.Views
{
    partial class FrmInicioSesion
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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnConfirmar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(96, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(259, 31);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.Gray;
            txtContrasena.Location = new Point(96, 210);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(259, 31);
            txtContrasena.TabIndex = 1;
            txtContrasena.Text = "Contraseña";
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(261, 373);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 49);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.Location = new Point(55, 373);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 49);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(65, 64, 115);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 64);
            label1.TabIndex = 4;
            label1.Text = "Acceso Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnConfirmar;
        private Button btnCerrar;
        private Label label1;
    }
}