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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlIzquierdo = new Panel();
            dgvClientes = new DataGridView();
            btnBuscar = new Sunny.UI.UIButton();
            txtBuscar = new Sunny.UI.UITextBox();
            pnlVacio = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pnlHistorial = new Panel();
            dgvHistorialOrdenes = new DataGridView();
            pnlSuperiorCliente = new Panel();
            lblTotalGastado = new Label();
            lblTotalVisitas = new Label();
            lblContacto = new Label();
            lblNombreCompleto = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlVacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialOrdenes).BeginInit();
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
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.MaximumSize = new Size(1140, 59);
            pnlSuperior.MinimumSize = new Size(1140, 59);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tictoc;
            pictureBox1.Location = new Point(34, 13);
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
            lblTitulo.Size = new Size(394, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Historial de Equipos por Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.Controls.Add(dgvClientes);
            pnlIzquierdo.Controls.Add(btnBuscar);
            pnlIzquierdo.Controls.Add(txtBuscar);
            pnlIzquierdo.Location = new Point(0, 59);
            pnlIzquierdo.MaximumSize = new Size(274, 705);
            pnlIzquierdo.MinimumSize = new Size(274, 705);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(274, 705);
            pnlIzquierdo.TabIndex = 3;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Location = new Point(0, 101);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(274, 604);
            dgvClientes.TabIndex = 22;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            btnBuscar.Location = new Point(18, 56);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.RectColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Size = new Size(238, 31);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar cliente";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBuscar.Click += btnBuscarCliente_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(18, 8);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(238, 40);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Nombre, cedula o Correo";
            // 
            // pnlVacio
            // 
            pnlVacio.Controls.Add(pictureBox2);
            pnlVacio.Controls.Add(label1);
            pnlVacio.Location = new Point(274, 59);
            pnlVacio.Name = "pnlVacio";
            pnlVacio.Size = new Size(851, 705);
            pnlVacio.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tictoc;
            pictureBox2.Location = new Point(406, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(241, 320);
            label1.Name = "label1";
            label1.Size = new Size(394, 57);
            label1.TabIndex = 2;
            label1.Text = "Selecciona un cliente para ver su historial";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Controls.Add(dgvHistorialOrdenes);
            pnlHistorial.Controls.Add(pnlSuperiorCliente);
            pnlHistorial.Location = new Point(274, 59);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(851, 705);
            pnlHistorial.TabIndex = 5;
            // 
            // dgvHistorialOrdenes
            // 
            dgvHistorialOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialOrdenes.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorialOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialOrdenes.Location = new Point(0, 87);
            dgvHistorialOrdenes.Name = "dgvHistorialOrdenes";
            dgvHistorialOrdenes.RowHeadersVisible = false;
            dgvHistorialOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialOrdenes.Size = new Size(851, 618);
            dgvHistorialOrdenes.TabIndex = 23;
            // 
            // pnlSuperiorCliente
            // 
            pnlSuperiorCliente.Controls.Add(lblTotalGastado);
            pnlSuperiorCliente.Controls.Add(lblTotalVisitas);
            pnlSuperiorCliente.Controls.Add(lblContacto);
            pnlSuperiorCliente.Controls.Add(lblNombreCompleto);
            pnlSuperiorCliente.Location = new Point(0, 0);
            pnlSuperiorCliente.Name = "pnlSuperiorCliente";
            pnlSuperiorCliente.Size = new Size(851, 87);
            pnlSuperiorCliente.TabIndex = 0;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGastado.ForeColor = Color.Black;
            lblTotalGastado.Location = new Point(625, 8);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(90, 40);
            lblTotalGastado.TabIndex = 5;
            lblTotalGastado.Text = "x";
            // 
            // lblTotalVisitas
            // 
            lblTotalVisitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVisitas.ForeColor = Color.Black;
            lblTotalVisitas.Location = new Point(536, 8);
            lblTotalVisitas.Name = "lblTotalVisitas";
            lblTotalVisitas.Size = new Size(99, 40);
            lblTotalVisitas.TabIndex = 4;
            lblTotalVisitas.Text = "x";
            // 
            // lblContacto
            // 
            lblContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.ForeColor = Color.Black;
            lblContacto.Location = new Point(18, 28);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(212, 20);
            lblContacto.TabIndex = 3;
            lblContacto.Text = "x";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCompleto.ForeColor = Color.Black;
            lblNombreCompleto.Location = new Point(18, 8);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(212, 20);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "x";
            // 
            // ucHistorialClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlSuperior);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlVacio);
            Controls.Add(pnlHistorial);
            Name = "ucHistorialClientes";
            Size = new Size(1125, 764);
            Load += ucHistorialClientes_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlVacio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialOrdenes).EndInit();
            pnlSuperiorCliente.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlVacio;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;                         private Sunny.UI.UITextBox txtContraseña;
        private Sunny.UI.UIButton btnAcceder;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlIzquierdo;
        private Sunny.UI.UITextBox txtBuscar;
        private DataGridView dgvClientes;
        private Sunny.UI.UIButton btnBuscar;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel pnlHistorial;
        private Panel pnlSuperiorCliente;
        private Label lblTotalVisitas;
        private Label lblContacto;
        private Label lblNombreCompleto;
        private DataGridView dgvHistorialOrdenes;
        private Label lblTotalGastado;
    }
}
