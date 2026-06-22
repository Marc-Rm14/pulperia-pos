namespace Pulperia.WinForms.Views
{
    partial class FrmConfiguracion
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
            panelContendor = new Panel();
            txtContrasena = new TextBox();
            lblDB = new Label();
            btnSalir = new Button();
            btnAceptar = new Button();
            btnExaminar = new Button();
            txtRutaActual = new TextBox();
            openFileDialogBaseDatos = new OpenFileDialog();
            panelContendor.SuspendLayout();
            SuspendLayout();
            // 
            // panelContendor
            // 
            panelContendor.Controls.Add(txtContrasena);
            panelContendor.Controls.Add(lblDB);
            panelContendor.Controls.Add(btnSalir);
            panelContendor.Controls.Add(btnAceptar);
            panelContendor.Controls.Add(btnExaminar);
            panelContendor.Controls.Add(txtRutaActual);
            panelContendor.Location = new Point(26, 29);
            panelContendor.Name = "panelContendor";
            panelContendor.Size = new Size(745, 399);
            panelContendor.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(46, 182);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(380, 27);
            txtContrasena.TabIndex = 5;
            // 
            // lblDB
            // 
            lblDB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDB.Location = new Point(46, 22);
            lblDB.Name = "lblDB";
            lblDB.Size = new Size(380, 47);
            lblDB.TabIndex = 4;
            lblDB.Text = "Ruta de Base de Datos";
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(109, 288);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 52);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(497, 288);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 52);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(575, 86);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(116, 52);
            btnExaminar.TabIndex = 0;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // txtRutaActual
            // 
            txtRutaActual.Location = new Point(46, 86);
            txtRutaActual.Multiline = true;
            txtRutaActual.Name = "txtRutaActual";
            txtRutaActual.ReadOnly = true;
            txtRutaActual.Size = new Size(380, 52);
            txtRutaActual.TabIndex = 1;
            // 
            // openFileDialogBaseDatos
            // 
            openFileDialogBaseDatos.DefaultExt = "db";
            openFileDialogBaseDatos.Filter = "Base de Datos SQLite (*.db)|*.db";
            // 
            // FrmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContendor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfiguracion";
            panelContendor.ResumeLayout(false);
            panelContendor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContendor;
        private Button btnExaminar;
        private TextBox txtRutaActual;
        private Button btnAceptar;
        private OpenFileDialog openFileDialogBaseDatos;
        private Button btnSalir;
        private Label lblDB;
        private TextBox txtContrasena;
    }
}