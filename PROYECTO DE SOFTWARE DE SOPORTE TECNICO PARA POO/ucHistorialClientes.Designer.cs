namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucHistorialClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHistorialClientes));
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlIzquierdo = new Panel();
            dgvClientesNuevo = new DataGridView();
            btnBuscar = new Sunny.UI.UIButton();
            txtBuscar = new Sunny.UI.UITextBox();
            pnlHistorial = new Panel();
            dgvNuevoHistorial = new DataGridView();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pnlSuperiorCliente = new Panel();
            llblTitleVisitas = new Label();
            lblTotalGastado = new Label();
            lblTotalVisitas = new Label();
            lblContacto = new Label();
            lblNombreCompleto = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientesNuevo).BeginInit();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevoHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlSuperiorCliente.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.FromArgb(20, 184, 166);
            materialButton1.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton1.Depth = 0;
            materialButton1.FlatAppearance.BorderColor = Color.FromArgb(20, 184, 166);
            materialButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialButton1.ForeColor = Color.White;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.buqueda_blanca;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            materialButton1.Location = new Point(25, 48);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(254, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Buscar Cliente";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(235, 239, 240);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.MaximumSize = new Size(1123, 59);
            pnlSuperior.MinimumSize = new Size(1123, 59);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1123, 59);
            pnlSuperior.TabIndex = 2;
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
            lblTitulo.Size = new Size(569, 59);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Historial de Equipos por Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.Controls.Add(dgvClientesNuevo);
            pnlIzquierdo.Controls.Add(btnBuscar);
            pnlIzquierdo.Controls.Add(txtBuscar);
            pnlIzquierdo.Location = new Point(0, 59);
            pnlIzquierdo.MinimumSize = new Size(274, 705);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(274, 773);
            pnlIzquierdo.TabIndex = 3;
            // 
            // dgvClientesNuevo
            // 
            dgvClientesNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesNuevo.Location = new Point(0, 125);
            dgvClientesNuevo.Name = "dgvClientesNuevo";
            dgvClientesNuevo.Size = new Size(274, 647);
            dgvClientesNuevo.TabIndex = 22;
            dgvClientesNuevo.CellClick += dgvClientesNuevo_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.FillHoverColor = Color.FromArgb(80, 160, 255);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(235, 239, 240);
            btnBuscar.Location = new Point(17, 74);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.RectColor = Color.FromArgb(0, 150, 137);
            btnBuscar.RectHoverColor = Color.FromArgb(80, 160, 255);
            btnBuscar.Size = new Size(238, 37);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar cliente";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBuscar.Click += btnBuscarCliente_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(75, 92, 108);
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(235, 239, 240);
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(18, 23);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(75, 92, 108);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(238, 37);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Nombre, cedula o Correo";
            txtBuscar.WatermarkColor = Color.FromArgb(198, 199, 189);
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Controls.Add(dgvNuevoHistorial);
            pnlHistorial.Controls.Add(label1);
            pnlHistorial.Controls.Add(pictureBox2);
            pnlHistorial.Controls.Add(pnlSuperiorCliente);
            pnlHistorial.Location = new Point(274, 59);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(851, 773);
            pnlHistorial.TabIndex = 5;
            pnlHistorial.Visible = false;
            // 
            // dgvNuevoHistorial
            // 
            dgvNuevoHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevoHistorial.Location = new Point(0, 125);
            dgvNuevoHistorial.Name = "dgvNuevoHistorial";
            dgvNuevoHistorial.Size = new Size(851, 648);
            dgvNuevoHistorial.TabIndex = 26;
            dgvNuevoHistorial.CellFormatting += dgvNuevoHistorial_CellFormatting;
            dgvNuevoHistorial.CellPainting += dgvNuevoHistorial_CellPainting;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 92, 108);
            label1.Location = new Point(226, 355);
            label1.Name = "label1";
            label1.Size = new Size(394, 37);
            label1.TabIndex = 24;
            label1.Text = "Selecciona un cliente para ver su historial";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(381, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pnlSuperiorCliente
            // 
            pnlSuperiorCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperiorCliente.Controls.Add(llblTitleVisitas);
            pnlSuperiorCliente.Controls.Add(lblTotalGastado);
            pnlSuperiorCliente.Controls.Add(lblTotalVisitas);
            pnlSuperiorCliente.Controls.Add(lblContacto);
            pnlSuperiorCliente.Controls.Add(lblNombreCompleto);
            pnlSuperiorCliente.Location = new Point(0, 0);
            pnlSuperiorCliente.Name = "pnlSuperiorCliente";
            pnlSuperiorCliente.Size = new Size(851, 126);
            pnlSuperiorCliente.TabIndex = 0;
            // 
            // llblTitleVisitas
            // 
            llblTitleVisitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            llblTitleVisitas.ForeColor = Color.Black;
            llblTitleVisitas.Location = new Point(521, 53);
            llblTitleVisitas.Name = "llblTitleVisitas";
            llblTitleVisitas.Size = new Size(58, 20);
            llblTitleVisitas.TabIndex = 6;
            llblTitleVisitas.Text = "visitas";
            llblTitleVisitas.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalGastado.ForeColor = Color.Black;
            lblTotalGastado.Location = new Point(626, 23);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(90, 40);
            lblTotalGastado.TabIndex = 5;
            lblTotalGastado.Text = "x";
            // 
            // lblTotalVisitas
            // 
            lblTotalVisitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalVisitas.ForeColor = Color.Black;
            lblTotalVisitas.Location = new Point(521, 23);
            lblTotalVisitas.Name = "lblTotalVisitas";
            lblTotalVisitas.Size = new Size(99, 40);
            lblTotalVisitas.TabIndex = 4;
            lblTotalVisitas.Text = "x";
            // 
            // lblContacto
            // 
            lblContacto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContacto.ForeColor = Color.Black;
            lblContacto.Location = new Point(18, 53);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(212, 20);
            lblContacto.TabIndex = 3;
            lblContacto.Text = "x";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreCompleto.ForeColor = Color.Black;
            lblNombreCompleto.Location = new Point(18, 20);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(212, 20);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "x";
            // 
            // ucHistorialClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 239, 240);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlHistorial);
            Name = "ucHistorialClientes";
            Size = new Size(1123, 832);
            Load += ucHistorialClientes_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientesNuevo).EndInit();
            pnlHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuevoHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlSuperiorCliente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton materialButton1;                         private Sunny.UI.UITextBox txtContraseña;
        private Sunny.UI.UIButton btnAcceder;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlIzquierdo;
        private Sunny.UI.UITextBox txtBuscar;
        private Sunny.UI.UIButton btnBuscar;
        private Panel pnlHistorial;
        private Panel pnlSuperiorCliente;
        private Label lblTotalVisitas;
        private Label lblContacto;
        private Label lblNombreCompleto;
        private Label lblTotalGastado;
        private PictureBox pictureBox2;
        private Label label1;
        private Label llblTitleVisitas;
        private DataGridView dgvNuevoHistorial;
        private DataGridView dgvClientesNuevo;
    }
}
