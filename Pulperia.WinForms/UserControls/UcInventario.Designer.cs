namespace Pulperia.WinForms.UserControls
{
    partial class UcInventario
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
            panelMenu = new Panel();
            lblTituloModulo = new Label();
            btnStock = new FontAwesome.Sharp.IconButton();
            btnCategorias = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            tbcContenido = new TabControl();
            tPageProductos = new TabPage();
            statusStrip1 = new StatusStrip();
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            tPageCategorias = new TabPage();
            dgvCategorias = new DataGridView();
            panel2 = new Panel();
            btnEditarCategoria = new FontAwesome.Sharp.IconButton();
            btnNuevaCategoria = new FontAwesome.Sharp.IconButton();
            tPageAlertas = new TabPage();
            panelMenu.SuspendLayout();
            tbcContenido.SuspendLayout();
            tPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            tPageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(12, 98, 145);
            panelMenu.Controls.Add(lblTituloModulo);
            panelMenu.Controls.Add(btnStock);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(994, 90);
            panelMenu.TabIndex = 0;
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloModulo.ForeColor = SystemColors.HighlightText;
            lblTituloModulo.Location = new Point(4, 0);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(252, 87);
            lblTituloModulo.TabIndex = 3;
            lblTituloModulo.Text = "Inventario  (Productos)";
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnStock.IconChar = FontAwesome.Sharp.IconChar.Message;
            btnStock.IconColor = Color.Black;
            btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStock.Location = new Point(815, 17);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(158, 46);
            btnStock.TabIndex = 2;
            btnStock.Text = "Alertas";
            btnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnCategorias.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnCategorias.IconColor = Color.Black;
            btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategorias.Location = new Point(537, 17);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(182, 46);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProductos.IconColor = Color.Black;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.IconSize = 40;
            btnProductos.Location = new Point(276, 17);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(153, 46);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // tbcContenido
            // 
            tbcContenido.Controls.Add(tPageProductos);
            tbcContenido.Controls.Add(tPageCategorias);
            tbcContenido.Controls.Add(tPageAlertas);
            tbcContenido.Dock = DockStyle.Fill;
            tbcContenido.ItemSize = new Size(0, 1);
            tbcContenido.Location = new Point(0, 90);
            tbcContenido.Name = "tbcContenido";
            tbcContenido.SelectedIndex = 0;
            tbcContenido.Size = new Size(994, 469);
            tbcContenido.SizeMode = TabSizeMode.Fixed;
            tbcContenido.TabIndex = 0;
            // 
            // tPageProductos
            // 
            tPageProductos.Controls.Add(statusStrip1);
            tPageProductos.Controls.Add(dgvProductos);
            tPageProductos.Controls.Add(panel1);
            tPageProductos.Location = new Point(4, 5);
            tPageProductos.Name = "tPageProductos";
            tPageProductos.Size = new Size(986, 460);
            tPageProductos.TabIndex = 0;
            tPageProductos.Text = "tabPage1";
            tPageProductos.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 438);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(986, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = SystemColors.Control;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 135);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(986, 325);
            dgvProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 135);
            panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 40;
            btnBuscar.Location = new Point(624, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 46);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 40;
            btnEditar.Location = new Point(811, 40);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 46);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 40;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(426, 41);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 46);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscar.Location = new Point(36, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(346, 31);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar Productos...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // tPageCategorias
            // 
            tPageCategorias.Controls.Add(dgvCategorias);
            tPageCategorias.Controls.Add(panel2);
            tPageCategorias.Location = new Point(4, 5);
            tPageCategorias.Name = "tPageCategorias";
            tPageCategorias.Size = new Size(986, 460);
            tPageCategorias.TabIndex = 0;
            tPageCategorias.Text = "tabPage2";
            tPageCategorias.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = SystemColors.Control;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.Location = new Point(0, 135);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(986, 325);
            dgvCategorias.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditarCategoria);
            panel2.Controls.Add(btnNuevaCategoria);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 135);
            panel2.TabIndex = 1;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Anchor = AnchorStyles.Right;
            btnEditarCategoria.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEditarCategoria.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditarCategoria.IconColor = Color.Black;
            btnEditarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarCategoria.IconSize = 40;
            btnEditarCategoria.Location = new Point(830, 49);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(110, 46);
            btnEditarCategoria.TabIndex = 2;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.Anchor = AnchorStyles.Right;
            btnNuevaCategoria.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnNuevaCategoria.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevaCategoria.IconColor = Color.Black;
            btnNuevaCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaCategoria.IconSize = 40;
            btnNuevaCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaCategoria.Location = new Point(629, 49);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(123, 46);
            btnNuevaCategoria.TabIndex = 1;
            btnNuevaCategoria.Text = "Nuevo";
            btnNuevaCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaCategoria.UseVisualStyleBackColor = true;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // tPageAlertas
            // 
            tPageAlertas.Location = new Point(4, 5);
            tPageAlertas.Name = "tPageAlertas";
            tPageAlertas.Padding = new Padding(3);
            tPageAlertas.Size = new Size(986, 460);
            tPageAlertas.TabIndex = 1;
            tPageAlertas.Text = "tabPage3";
            tPageAlertas.UseVisualStyleBackColor = true;
            // 
            // UcInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcContenido);
            Controls.Add(panelMenu);
            Name = "UcInventario";
            Size = new Size(994, 559);
            Load += UcInventario_Load;
            panelMenu.ResumeLayout(false);
            tbcContenido.ResumeLayout(false);
            tPageProductos.ResumeLayout(false);
            tPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tPageCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnProductos;
        private TabControl tbcContenido;
        private TabPage tPageProductos;
        private TabPage tPageCategorias;
        private TabPage tPageAlertas;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private TextBox txtBuscar;
        private StatusStrip statusStrip1;
        private DataGridView dgvProductos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label lblTituloModulo;
        private DataGridView dgvCategorias;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnEditarCategoria;
        private FontAwesome.Sharp.IconButton btnNuevaCategoria;
    }
}
