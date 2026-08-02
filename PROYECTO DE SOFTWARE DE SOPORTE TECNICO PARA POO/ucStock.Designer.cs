namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucStock
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            lblAlertas = new Label();
            btnAgregar = new Button();
            btnAlertas = new Button();
            cmbCategorias = new ComboBox();
            txtBuscar = new TextBox();
            pictureBox2 = new PictureBox();
            dgv4 = new DataGridView();
            Nomnre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewComboBoxColumn();
            Compatible = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewComboBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv4).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-8, -11);
            pnlSuperior.Margin = new Padding(3, 4, 3, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1190, 94);
            pnlSuperior.TabIndex = 1;
            pnlSuperior.Paint += pnlSuperior_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MaterialSymbolsInventory__1_;
            pictureBox1.Location = new Point(24, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(328, 92);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control de Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAlertas);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnAlertas);
            panel1.Controls.Add(cmbCategorias);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-8, 76);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 72);
            panel1.TabIndex = 2;
            // 
            // lblAlertas
            // 
            lblAlertas.AutoSize = true;
            lblAlertas.BackColor = Color.OrangeRed;
            lblAlertas.FlatStyle = FlatStyle.Flat;
            lblAlertas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertas.ForeColor = Color.FromArgb(147, 162, 183);
            lblAlertas.Location = new Point(841, 18);
            lblAlertas.Name = "lblAlertas";
            lblAlertas.Size = new Size(27, 31);
            lblAlertas.TabIndex = 7;
            lblAlertas.Text = "0";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(62, 155, 139);
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Image = Properties.Resources.WeuiAdd2Outlined__2_;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(1021, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(141, 41);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAlertas
            // 
            btnAlertas.BackColor = Color.FromArgb(30, 41, 59);
            btnAlertas.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlertas.Cursor = Cursors.Hand;
            btnAlertas.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            btnAlertas.FlatStyle = FlatStyle.Flat;
            btnAlertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlertas.ForeColor = Color.FromArgb(147, 162, 183);
            btnAlertas.Image = Properties.Resources.SolarDangerOutline__2_;
            btnAlertas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlertas.Location = new Point(701, 13);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.RightToLeft = RightToLeft.No;
            btnAlertas.Size = new Size(134, 41);
            btnAlertas.TabIndex = 3;
            btnAlertas.Text = "Alertas";
            btnAlertas.TextAlign = ContentAlignment.MiddleRight;
            btnAlertas.UseVisualStyleBackColor = false;
            btnAlertas.Click += btnAlertas_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = Color.FromArgb(30, 41, 59);
            cmbCategorias.Cursor = Cursors.Hand;
            cmbCategorias.FlatStyle = FlatStyle.Flat;
            cmbCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategorias.ForeColor = Color.FromArgb(147, 162, 183);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Items.AddRange(new object[] { "Telefonos", "Computadoras", "Accesorios ", "Repuestos" });
            cmbCategorias.Location = new Point(472, 18);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(211, 31);
            cmbCategorias.TabIndex = 2;
            cmbCategorias.Tag = "";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(30, 41, 59);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Cursor = Cursors.Hand;
            txtBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(147, 162, 183);
            txtBuscar.Location = new Point(71, 18);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar....";
            txtBuscar.Size = new Size(385, 36);
            txtBuscar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TablerSearch;
            pictureBox2.Location = new Point(24, 14);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dgv4
            // 
            dgv4.AllowUserToAddRows = false;
            dgv4.BackgroundColor = Color.FromArgb(10, 12, 30);
            dgv4.BorderStyle = BorderStyle.None;
            dgv4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(147, 162, 183);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv4.ColumnHeadersHeight = 50;
            dgv4.Columns.AddRange(new DataGridViewColumn[] { Nomnre, Categoria, Compatible, Stock, Costo, Venta, Proveedor, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 35, 54);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(147, 162, 183);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv4.DefaultCellStyle = dataGridViewCellStyle3;
            dgv4.EnableHeadersVisualStyles = false;
            dgv4.Location = new Point(0, 143);
            dgv4.Name = "dgv4";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 12, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(147, 162, 183);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv4.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv4.RowHeadersVisible = false;
            dgv4.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(10, 12, 30);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(147, 162, 183);
            dgv4.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv4.RowTemplate.Height = 40;
            dgv4.Size = new Size(1171, 769);
            dgv4.TabIndex = 3;
            dgv4.CellClick += dgv4_CellClick;
            // 
            // Nomnre
            // 
            Nomnre.HeaderText = "NOMBRE";
            Nomnre.MinimumWidth = 6;
            Nomnre.Name = "Nomnre";
            Nomnre.Width = 300;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "CATEGORIA";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Resizable = DataGridViewTriState.True;
            Categoria.SortMode = DataGridViewColumnSortMode.Automatic;
            Categoria.Width = 160;
            // 
            // Compatible
            // 
            Compatible.HeaderText = "COMPATIBLE";
            Compatible.MinimumWidth = 6;
            Compatible.Name = "Compatible";
            Compatible.Width = 160;
            // 
            // Stock
            // 
            Stock.HeaderText = "STOCK";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // Costo
            // 
            Costo.HeaderText = "COSTO";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.Width = 125;
            // 
            // Venta
            // 
            Venta.HeaderText = "VENTA";
            Venta.MinimumWidth = 6;
            Venta.Name = "Venta";
            Venta.Width = 125;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "PROVEEDOR";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.Resizable = DataGridViewTriState.True;
            Proveedor.SortMode = DataGridViewColumnSortMode.Automatic;
            Proveedor.Width = 125;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            Eliminar.HeaderText = "   X";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 50;
            // 
            // ucStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 35, 54);
            Controls.Add(panel1);
            Controls.Add(dgv4);
            Controls.Add(pnlSuperior);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucStock";
            Size = new Size(1171, 915);
            Load += ucStock_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox txtBuscar;
        private ComboBox cmbCategorias;
        private Button btnAlertas;
        private Button btnAgregar;
        private DataGridView dgv4;
        private Label lblAlertas;
        private DataGridViewTextBoxColumn Nomnre;
        private DataGridViewComboBoxColumn Categoria;
        private DataGridViewTextBoxColumn Compatible;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewComboBoxColumn Proveedor;
        private DataGridViewButtonColumn Eliminar;
    }
}
