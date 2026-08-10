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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStock));
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnNuevoRepuesto = new Sunny.UI.UIButton();
            cmbCategorias = new Sunny.UI.UIComboBox();
            txtBuscar = new Sunny.UI.UITextBox();
            lblAlertas = new Label();
            btnAlertas = new Button();
            dgvControl = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Compatible = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvControl).BeginInit();
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
            pnlSuperior.Location = new Point(-7, -8);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1142, 71);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MaterialSymbolsInventory__1_;
            pictureBox1.Location = new Point(21, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 69);
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
            panel1.Controls.Add(btnNuevoRepuesto);
            panel1.Controls.Add(cmbCategorias);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblAlertas);
            panel1.Controls.Add(btnAlertas);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 59);
            panel1.TabIndex = 2;
            // 
            // btnNuevoRepuesto
            // 
            btnNuevoRepuesto.BackColor = Color.Transparent;
            btnNuevoRepuesto.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.FillHoverColor = Color.Transparent;
            btnNuevoRepuesto.FillPressColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoRepuesto.Location = new Point(969, 10);
            btnNuevoRepuesto.MinimumSize = new Size(1, 1);
            btnNuevoRepuesto.Name = "btnNuevoRepuesto";
            btnNuevoRepuesto.Radius = 12;
            btnNuevoRepuesto.RectColor = Color.FromArgb(39, 53, 72);
            btnNuevoRepuesto.RectHoverColor = Color.Transparent;
            btnNuevoRepuesto.RectPressColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.Size = new Size(133, 31);
            btnNuevoRepuesto.TabIndex = 30;
            btnNuevoRepuesto.Text = "Registrar Entrega";
            btnNuevoRepuesto.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoRepuesto.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevoRepuesto.TipsForeColor = Color.Transparent;
            btnNuevoRepuesto.Click += btnNuevoRepuesto_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = Color.Transparent;
            cmbCategorias.DataSource = null;
            cmbCategorias.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbCategorias.FillColor = Color.FromArgb(41, 53, 72);
            cmbCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.ForeColor = Color.White;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbCategorias.Items.AddRange(new object[] { "Todas las categorías", "Pantalla", "Bateria", "Conector", "Placa", "Cámara", "Bóton", "Tapa", "Parlante", "Micrófono", "Otro" });
            cmbCategorias.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCategorias.Location = new Point(383, 10);
            cmbCategorias.Margin = new Padding(4, 5, 4, 5);
            cmbCategorias.MinimumSize = new Size(63, 0);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Padding = new Padding(0, 0, 30, 2);
            cmbCategorias.Radius = 12;
            cmbCategorias.RectColor = Color.FromArgb(148, 163, 184);
            cmbCategorias.Size = new Size(185, 32);
            cmbCategorias.SymbolSize = 24;
            cmbCategorias.TabIndex = 25;
            cmbCategorias.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategorias.Watermark = "";
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(14, 12);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(345, 30);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Buscar repuesto, marca...";
            // 
            // lblAlertas
            // 
            lblAlertas.AutoSize = true;
            lblAlertas.BackColor = Color.FromArgb(254, 154, 0);
            lblAlertas.FlatStyle = FlatStyle.Flat;
            lblAlertas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertas.ForeColor = Color.FromArgb(147, 162, 183);
            lblAlertas.Location = new Point(736, 14);
            lblAlertas.Name = "lblAlertas";
            lblAlertas.Size = new Size(23, 25);
            lblAlertas.TabIndex = 7;
            lblAlertas.Text = "0";
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
            btnAlertas.Location = new Point(613, 10);
            btnAlertas.Margin = new Padding(3, 2, 3, 2);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.RightToLeft = RightToLeft.No;
            btnAlertas.Size = new Size(117, 31);
            btnAlertas.TabIndex = 3;
            btnAlertas.Text = "Alertas";
            btnAlertas.TextAlign = ContentAlignment.MiddleRight;
            btnAlertas.UseVisualStyleBackColor = false;
            // 
            // dgvControl
            // 
            dgvControl.AllowUserToAddRows = false;
            dgvControl.AllowUserToDeleteRows = false;
            dgvControl.AllowUserToResizeColumns = false;
            dgvControl.AllowUserToResizeRows = false;
            dgvControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvControl.BackgroundColor = Color.White;
            dgvControl.BorderStyle = BorderStyle.None;
            dgvControl.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvControl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvControl.ColumnHeadersHeight = 50;
            dgvControl.Columns.AddRange(new DataGridViewColumn[] { Nombre, Categoria, Compatible, Stock, Costo, Venta, Proveedor, Estado, Editar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(147, 162, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvControl.DefaultCellStyle = dataGridViewCellStyle3;
            dgvControl.EnableHeadersVisualStyles = false;
            dgvControl.GridColor = Color.Black;
            dgvControl.Location = new Point(3, 118);
            dgvControl.Margin = new Padding(3, 2, 3, 2);
            dgvControl.Name = "dgvControl";
            dgvControl.ReadOnly = true;
            dgvControl.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 12, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(147, 162, 183);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvControl.RowHeadersVisible = false;
            dgvControl.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.Transparent;
            dgvControl.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvControl.RowTemplate.Height = 40;
            dgvControl.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvControl.Size = new Size(1122, 641);
            dgvControl.TabIndex = 3;
            dgvControl.CellContentClick += dgv4_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "CATEGORIA";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Resizable = DataGridViewTriState.True;
            // 
            // Compatible
            // 
            Compatible.DataPropertyName = "Compatible";
            Compatible.HeaderText = "COMPATIBLE";
            Compatible.MinimumWidth = 6;
            Compatible.Name = "Compatible";
            Compatible.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "STOCK";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "COSTO";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // Venta
            // 
            Venta.DataPropertyName = "Venta";
            Venta.HeaderText = "VENTA";
            Venta.MinimumWidth = 6;
            Venta.Name = "Venta";
            Venta.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.DataPropertyName = "Proveedor";
            Proveedor.HeaderText = "PROVEEDOR";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Resizable = DataGridViewTriState.True;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "ESTADO";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Resizable = DataGridViewTriState.True;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            Editar.DefaultCellStyle = dataGridViewCellStyle2;
            Editar.HeaderText = "ED";
            Editar.Image = Properties.Resources.Editar;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.True;
            // 
            // ucStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 35, 54);
            Controls.Add(panel1);
            Controls.Add(dgvControl);
            Controls.Add(pnlSuperior);
            Name = "ucStock";
            Size = new Size(1125, 764);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel panel1;
        private Button btnAlertas;
        private DataGridView dgvControl;
        private Label lblAlertas;
        private Sunny.UI.UITextBox txtBuscar;
        private Sunny.UI.UIComboBox cmbCategorias;
        private Sunny.UI.UIButton btnNuevoRepuesto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Compatible;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn Editar;
    }
}
