namespace Pulperia.WinForms.UserControls
{
    partial class UCVentas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblDetallesLista = new Label();
            label1 = new Label();
            lblTituloModulo = new Label();
            lblTotal = new Label();
            lstResultados = new ListBox();
            btnConfirmar = new Button();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            numericUpDown1 = new NumericUpDown();
            txtBoxBuscarProducto = new TextBox();
            productoBusquedaBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBusquedaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDetallesLista);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTituloModulo);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lstResultados);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(dgvDetalle);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(txtBoxBuscarProducto);
            panel1.Location = new Point(29, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 561);
            panel1.TabIndex = 0;
            // 
            // lblDetallesLista
            // 
            lblDetallesLista.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDetallesLista.AutoSize = true;
            lblDetallesLista.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetallesLista.Location = new Point(703, 153);
            lblDetallesLista.Name = "lblDetallesLista";
            lblDetallesLista.Size = new Size(89, 28);
            lblDetallesLista.TabIndex = 9;
            lblDetallesLista.Text = "Detalles:";
            lblDetallesLista.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 153);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 8;
            label1.Text = "Carrito:";
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloModulo.Location = new Point(321, 9);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(223, 38);
            lblTituloModulo.TabIndex = 7;
            lblTituloModulo.Text = "Punto De Venta";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(62, 528);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "label1";
            // 
            // lstResultados
            // 
            lstResultados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstResultados.BorderStyle = BorderStyle.FixedSingle;
            lstResultados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(703, 184);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(223, 114);
            lstResultados.TabIndex = 5;
            lstResultados.Visible = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(765, 441);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 55);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar Y Cobrar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(32, 184);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(606, 328);
            dgvDetalle.TabIndex = 3;
            dgvDetalle.CellContentClick += dgvDetalle_CellContentClick;
            dgvDetalle.CellValueChanged += dgvDetalle_CellValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(778, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 63);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(574, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // txtBoxBuscarProducto
            // 
            txtBoxBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtBoxBuscarProducto.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxBuscarProducto.Location = new Point(32, 60);
            txtBoxBuscarProducto.Name = "txtBoxBuscarProducto";
            txtBoxBuscarProducto.Size = new Size(488, 31);
            txtBoxBuscarProducto.TabIndex = 0;
            txtBoxBuscarProducto.Text = "Buscar Producto...";
            txtBoxBuscarProducto.TextChanged += txtBoxBuscarProducto_TextChanged;
            txtBoxBuscarProducto.Enter += txtBoxBuscarProducto_Enter;
            txtBoxBuscarProducto.Leave += txtBoxBuscarProducto_Leave;
            // 
            // productoBusquedaBindingSource
            // 
            productoBusquedaBindingSource.DataSource = typeof(Domain.DTOS.ProductoBusqueda);
            // 
            // UCVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(panel1);
            Name = "UCVentas";
            Size = new Size(1024, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBusquedaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBoxBuscarProducto;
        private Button btnAgregar;
        private NumericUpDown numericUpDown1;
        private DataGridView dgvDetalle;
        private ListBox lstResultados;
        private Button btnConfirmar;
        private BindingSource productoBusquedaBindingSource;
        private Label lblTotal;
        private Label label1;
        private Label lblTituloModulo;
        private Label lblDetallesLista;
    }
}
