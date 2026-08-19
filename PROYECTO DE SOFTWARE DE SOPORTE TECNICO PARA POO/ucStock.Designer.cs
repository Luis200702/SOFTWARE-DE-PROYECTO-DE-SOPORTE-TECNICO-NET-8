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
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInfo = new Panel();
            btnAlertas = new Sunny.UI.UIButton();
            btnNuevoRepuesto = new Sunny.UI.UIButton();
            cmbCategorias = new Sunny.UI.UIComboBox();
            txtBuscar = new Sunny.UI.UITextBox();
            imageListStock = new ImageList(components);
            dgvNuevo = new DataGridView();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(243, 246, 250);
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
            pnlInfo.BackColor = Color.FromArgb(243, 246, 250);
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
            btnAlertas.RectColor = Color.FromArgb(220, 226, 232);
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
            btnNuevoRepuesto.Text = "Agregar Repuesto";
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
            cmbCategorias.FillColor = Color.FromArgb(248, 249, 251);
            cmbCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.ForeColor = Color.White;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbCategorias.Items.AddRange(new object[] { "Todas las categorías", "Pantalla", "Bateria", "Conector", "Placa", "Cámara", "Bóton", "Tapa", "Parlante", "Micrófono", "Otro" });
            cmbCategorias.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCategorias.Location = new Point(384, 19);
            cmbCategorias.Margin = new Padding(4, 5, 4, 5);
            cmbCategorias.MinimumSize = new Size(63, 0);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Padding = new Padding(0, 0, 30, 2);
            cmbCategorias.Radius = 12;
            cmbCategorias.RectColor = Color.FromArgb(220, 226, 232);
            cmbCategorias.Size = new Size(185, 37);
            cmbCategorias.SymbolSize = 24;
            cmbCategorias.TabIndex = 25;
            cmbCategorias.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategorias.Watermark = "";
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(243, 246, 250);
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(235, 239, 240);
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(31, 19);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(220, 226, 232);
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
            // dgvNuevo
            // 
            dgvNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
            Controls.Add(pnlSuperior);
            Name = "ucStock";
            Size = new Size(1123, 832);
            Load += ucStock_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInfo;
        private Sunny.UI.UITextBox txtBuscar;
        private Sunny.UI.UIComboBox cmbCategorias;
        private Sunny.UI.UIButton btnNuevoRepuesto;
        private ImageList imageListStock;
        private DataGridView dgvNuevo;
        private Sunny.UI.UIButton btnAlertas;
    }
}
