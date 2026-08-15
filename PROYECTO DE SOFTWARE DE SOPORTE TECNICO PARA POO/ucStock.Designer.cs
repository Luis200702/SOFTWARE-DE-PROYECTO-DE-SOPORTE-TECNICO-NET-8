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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStock));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInfo = new Panel();
            btnAlertas = new Sunny.UI.UIButton();
            btnNuevoRepuesto = new Sunny.UI.UIButton();
            cmbCategorias = new Sunny.UI.UIComboBox();
            txtBuscar = new Sunny.UI.UITextBox();
            imageListStock = new ImageList(components);
            dgvControl = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Compatible = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Agregar = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            dgvNuevo = new DataGridView();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(235, 239, 240);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1123, 59);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(75, 92, 108);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(406, 59);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control de Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            pnlInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInfo.AutoSize = true;
            pnlInfo.BackColor = Color.FromArgb(235, 239, 240);
            pnlInfo.Controls.Add(btnAlertas);
            pnlInfo.Controls.Add(btnNuevoRepuesto);
            pnlInfo.Controls.Add(cmbCategorias);
            pnlInfo.Controls.Add(txtBuscar);
            pnlInfo.Location = new Point(0, 59);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(1123, 73);
            pnlInfo.TabIndex = 2;
            // 
            // btnAlertas
            // 
            btnAlertas.FillColor = Color.White;
            btnAlertas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlertas.ForeColor = Color.Black;
            btnAlertas.Location = new Point(681, 19);
            btnAlertas.MinimumSize = new Size(1, 1);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.Radius = 12;
            btnAlertas.Size = new Size(102, 37);
            btnAlertas.TabIndex = 31;
            btnAlertas.Text = "Alertas";
            btnAlertas.TextAlign = ContentAlignment.MiddleLeft;
            btnAlertas.TipsFont = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlertas.Click += btnAlertas_Click;
            btnAlertas.Paint += btnAlertas_Paint;
            // 
            // btnNuevoRepuesto
            // 
            btnNuevoRepuesto.BackColor = Color.Transparent;
            btnNuevoRepuesto.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.FillHoverColor = Color.Transparent;
            btnNuevoRepuesto.FillPressColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoRepuesto.ForeColor = Color.FromArgb(235, 239, 240);
            btnNuevoRepuesto.Location = new Point(886, 19);
            btnNuevoRepuesto.MinimumSize = new Size(1, 1);
            btnNuevoRepuesto.Name = "btnNuevoRepuesto";
            btnNuevoRepuesto.Radius = 12;
            btnNuevoRepuesto.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.RectHoverColor = Color.Transparent;
            btnNuevoRepuesto.RectPressColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnNuevoRepuesto.Size = new Size(192, 37);
            btnNuevoRepuesto.TabIndex = 30;
            btnNuevoRepuesto.Text = "Registrar Entrega  ";
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
            cmbCategorias.FillColor = Color.FromArgb(75, 92, 108);
            cmbCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.ForeColor = Color.White;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbCategorias.Items.AddRange(new object[] { "Todas las categorías", "Pantalla", "Bateria", "Conector", "Placa", "Cámara", "Bóton", "Tapa", "Parlante", "Micrófono", "Otro" });
            cmbCategorias.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCategorias.Location = new Point(417, 19);
            cmbCategorias.Margin = new Padding(4, 5, 4, 5);
            cmbCategorias.MinimumSize = new Size(63, 0);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Padding = new Padding(0, 0, 30, 2);
            cmbCategorias.Radius = 12;
            cmbCategorias.RectColor = Color.FromArgb(148, 163, 184);
            cmbCategorias.Size = new Size(185, 37);
            cmbCategorias.SymbolSize = 24;
            cmbCategorias.TabIndex = 25;
            cmbCategorias.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategorias.Watermark = "";
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(75, 92, 108);
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(235, 239, 240);
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(31, 19);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(75, 92, 108);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(345, 37);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Buscar repuesto, marca...";
            // 
            // imageListStock
            // 
            imageListStock.ColorDepth = ColorDepth.Depth32Bit;
            imageListStock.ImageStream = (ImageListStreamer)resources.GetObject("imageListStock.ImageStream");
            imageListStock.TransparentColor = Color.Transparent;
            imageListStock.Images.SetKeyName(0, "SolarDangerOutline (2).png");
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
            dgvControl.Columns.AddRange(new DataGridViewColumn[] { Nombre, Categoria, Compatible, Stock, Costo, Venta, Proveedor, Estado, Agregar, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvControl.DefaultCellStyle = dataGridViewCellStyle3;
            dgvControl.EnableHeadersVisualStyles = false;
            dgvControl.GridColor = Color.Black;
            dgvControl.Location = new Point(774, 239);
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
            dgvControl.Size = new Size(1120, 690);
            dgvControl.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 200F;
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.FillWeight = 120F;
            Categoria.HeaderText = "CATEGORIA";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Resizable = DataGridViewTriState.True;
            // 
            // Compatible
            // 
            Compatible.DataPropertyName = "Compatible";
            Compatible.FillWeight = 180F;
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
            Proveedor.FillWeight = 150F;
            Proveedor.HeaderText = "PROVEEDOR";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Resizable = DataGridViewTriState.True;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.FillWeight = 60F;
            Estado.HeaderText = "ESTADO";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Resizable = DataGridViewTriState.True;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Agregar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.ForeColor = Color.Transparent;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            Agregar.DefaultCellStyle = dataGridViewCellStyle2;
            Agregar.FillWeight = 40F;
            Agregar.HeaderText = "";
            Agregar.Image = Properties.Resources.Code_Generated_Image;
            Agregar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.ReadOnly = true;
            Agregar.Resizable = DataGridViewTriState.True;
            // 
            // Delete
            // 
            Delete.FillWeight = 40F;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Code_Generated_Image__1_;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            // 
            // dgvNuevo
            // 
            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevo.Location = new Point(0, 133);
            dgvNuevo.Name = "dgvNuevo";
            dgvNuevo.Size = new Size(1123, 699);
            dgvNuevo.TabIndex = 4;
            dgvNuevo.CellContentClick += dgvNuevo_CellContentClick;
            dgvNuevo.CellFormatting += dgvNuevo_CellFormatting;
            dgvNuevo.CellPainting += dgvNuevo_CellPainting;
            // 
            // ucStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 239, 240);
            Controls.Add(dgvNuevo);
            Controls.Add(pnlInfo);
            Controls.Add(dgvControl);
            Controls.Add(pnlSuperior);
            Name = "ucStock";
            Size = new Size(1123, 832);
            Load += ucStock_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInfo;
        private DataGridView dgvControl;
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
        private DataGridViewImageColumn Agregar;
        private DataGridViewImageColumn Delete;
        private ImageList imageListStock;
        private DataGridView dgvNuevo;
        private Sunny.UI.UIButton btnAlertas;
    }
}
