namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucGestionUsuarios
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
            btnNuevoTecnico = new Sunny.UI.UIButton();
            txtBuscarTecnico = new Sunny.UI.UITextBox();
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
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-6, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1137, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
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
            lblTitulo.Size = new Size(308, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de Usuarios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(btnNuevoTecnico);
            pnlInformacion.Controls.Add(txtBuscarTecnico);
            pnlInformacion.ForeColor = Color.Coral;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1131, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // btnNuevoTecnico
            // 
            btnNuevoTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoTecnico.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevoTecnico.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoTecnico.Location = new Point(974, 16);
            btnNuevoTecnico.MinimumSize = new Size(1, 1);
            btnNuevoTecnico.Name = "btnNuevoTecnico";
            btnNuevoTecnico.Radius = 3;
            btnNuevoTecnico.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevoTecnico.Size = new Size(117, 30);
            btnNuevoTecnico.TabIndex = 20;
            btnNuevoTecnico.Text = "Nuevo Técnico";
            btnNuevoTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevoTecnico.Click += btnNuevoTecnico_Click;
            // 
            // txtBuscarTecnico
            // 
            txtBuscarTecnico.BackColor = Color.Transparent;
            txtBuscarTecnico.FillColor = Color.LightGray;
            txtBuscarTecnico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTecnico.ForeColor = Color.Black;
            txtBuscarTecnico.Icon = Properties.Resources.TablerSearch;
            txtBuscarTecnico.Location = new Point(29, 16);
            txtBuscarTecnico.Margin = new Padding(4, 5, 4, 5);
            txtBuscarTecnico.MinimumSize = new Size(1, 16);
            txtBuscarTecnico.Name = "txtBuscarTecnico";
            txtBuscarTecnico.Padding = new Padding(5);
            txtBuscarTecnico.Radius = 12;
            txtBuscarTecnico.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscarTecnico.ShowText = false;
            txtBuscarTecnico.Size = new Size(295, 30);
            txtBuscarTecnico.TabIndex = 3;
            txtBuscarTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarTecnico.Watermark = "Buscar usuario...";
            // 
            // dgvNuevo
            // 
            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevo.Location = new Point(0, 118);
            dgvNuevo.Name = "dgvNuevo";
            dgvNuevo.Size = new Size(1125, 646);
            dgvNuevo.TabIndex = 5;
            dgvNuevo.CellContentClick += dgvNuevo_CellContentClick;
            dgvNuevo.CellPainting += dgvNuevo_CellPainting;
            // 
            // ucGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNuevo);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucGestionUsuarios";
            Size = new Size(1125, 764);
            Load += ucGestionUsuarios_Load;
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
        private Sunny.UI.UIButton btnNuevoTecnico;
        private Sunny.UI.UITextBox txtBuscarTecnico;
        private DataGridView dgvNuevo;
    }
}
