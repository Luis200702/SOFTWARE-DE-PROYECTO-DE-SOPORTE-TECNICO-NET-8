namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucVentaDispositivos
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
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            lblVentas = new Label();
            label1 = new Label();
            btnNuevaVenta = new Sunny.UI.UIButton();
            txtBuscar = new Sunny.UI.UITextBox();
            dgvNuevo = new DataGridView();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(235, 239, 240);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-7, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MdiCartVariant;
            pictureBox1.Location = new Point(31, 12);
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
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Venta de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.FromArgb(235, 239, 240);
            pnlInformacion.Controls.Add(lblVentas);
            pnlInformacion.Controls.Add(label1);
            pnlInformacion.Controls.Add(btnNuevaVenta);
            pnlInformacion.Controls.Add(txtBuscar);
            pnlInformacion.ForeColor = SystemColors.ControlLight;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // lblVentas
            // 
            lblVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.Black;
            lblVentas.Location = new Point(877, 13);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(27, 31);
            lblVentas.TabIndex = 22;
            lblVentas.Text = "x";
            lblVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(901, 14);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 21;
            label1.Text = "ventas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevaVenta.Font = new Font("Microsoft Sans Serif", 12F);
            btnNuevaVenta.Location = new Point(979, 14);
            btnNuevaVenta.MinimumSize = new Size(1, 1);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Radius = 12;
            btnNuevaVenta.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevaVenta.Size = new Size(129, 31);
            btnNuevaVenta.TabIndex = 20;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(244, 244, 244);
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(29, 14);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(295, 30);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Buscar dispositivo o comprador";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvNuevo
            // 
            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevo.Location = new Point(0, 118);
            dgvNuevo.Name = "dgvNuevo";
            dgvNuevo.Size = new Size(1125, 646);
            dgvNuevo.TabIndex = 4;
            dgvNuevo.CellContentClick += dgvNuevo_CellContentClick;
            dgvNuevo.CellFormatting += dgvNuevo_CellFormatting;
            dgvNuevo.CellPainting += dgvNuevo_CellPainting;
            // 
            // ucVentaDispositivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvNuevo);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucVentaDispositivos";
            Size = new Size(1125, 764);
            Load += ucVentaDispositivos_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UIButton btnNuevaVenta;
        private Sunny.UI.UITextBox txtBuscar;
        private Label label1;
        private Label lblVentas;
        private DataGridView dgvNuevo;
    }
}
