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
            pnlInformacion = new Panel();
            btnNuevoTecnico = new Sunny.UI.UISymbolButton();
            txtBuscarTecnico = new Sunny.UI.UITextBox();
            dgvNuevo = new DataGridView();
            lblTitulo = new Label();
            label16 = new Label();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pnlSuperior.SuspendLayout();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.Controls.Add(uiSymbolLabel1);
            pnlSuperior.Controls.Add(label16);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-6, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1135, 88);
            pnlSuperior.TabIndex = 2;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(btnNuevoTecnico);
            pnlInformacion.Controls.Add(txtBuscarTecnico);
            pnlInformacion.ForeColor = Color.Coral;
            pnlInformacion.Location = new Point(0, 88);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1126, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // btnNuevoTecnico
            // 
            btnNuevoTecnico.FillColor = Color.FromArgb(0, 165, 155);
            btnNuevoTecnico.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnNuevoTecnico.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNuevoTecnico.Location = new Point(950, 16);
            btnNuevoTecnico.MinimumSize = new Size(1, 1);
            btnNuevoTecnico.Name = "btnNuevoTecnico";
            btnNuevoTecnico.Radius = 12;
            btnNuevoTecnico.RectColor = Color.Transparent;
            btnNuevoTecnico.RectHoverColor = Color.Transparent;
            btnNuevoTecnico.Size = new Size(147, 30);
            btnNuevoTecnico.Symbol = 61525;
            btnNuevoTecnico.TabIndex = 21;
            btnNuevoTecnico.Text = "Nuevo perfil";
            btnNuevoTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevoTecnico.Click += btnNuevoTecnico_Click;
            // 
            // txtBuscarTecnico
            // 
            txtBuscarTecnico.BackColor = Color.Transparent;
            txtBuscarTecnico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTecnico.ForeColor = Color.FromArgb(70, 86, 103);
            txtBuscarTecnico.Location = new Point(29, 16);
            txtBuscarTecnico.Margin = new Padding(4, 5, 4, 5);
            txtBuscarTecnico.MinimumSize = new Size(1, 16);
            txtBuscarTecnico.Name = "txtBuscarTecnico";
            txtBuscarTecnico.Padding = new Padding(5);
            txtBuscarTecnico.Radius = 12;
            txtBuscarTecnico.RectColor = Color.FromArgb(220, 226, 232);
            txtBuscarTecnico.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtBuscarTecnico.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtBuscarTecnico.ShowText = false;
            txtBuscarTecnico.Size = new Size(295, 30);
            txtBuscarTecnico.Symbol = 61442;
            txtBuscarTecnico.SymbolColor = Color.FromArgb(70, 86, 103);
            txtBuscarTecnico.TabIndex = 3;
            txtBuscarTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarTecnico.Watermark = "Buscar usuario...";
            txtBuscarTecnico.WatermarkColor = Color.FromArgb(145, 158, 172);
            txtBuscarTecnico.TextChanged += txtBuscarTecnico_TextChanged;
            // 
            // dgvNuevo
            // 
            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevo.Location = new Point(0, 147);
            dgvNuevo.Name = "dgvNuevo";
            dgvNuevo.Size = new Size(1125, 685);
            dgvNuevo.TabIndex = 5;
            dgvNuevo.CellContentClick += dgvNuevo_CellContentClick;
            dgvNuevo.CellPainting += dgvNuevo_CellPainting;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 43, 62);
            lblTitulo.Location = new Point(6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(406, 59);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Gestión de perfiles";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(70, 86, 103);
            label16.Location = new Point(97, 45);
            label16.Name = "label16";
            label16.Size = new Size(406, 20);
            label16.TabIndex = 64;
            label16.Text = "Administra los perfiles del sistema y sus permisos asignados";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolLabel1.Location = new Point(25, 11);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(62, 48);
            uiSymbolLabel1.Symbol = 61463;
            uiSymbolLabel1.SymbolColor = Color.FromArgb(0, 165, 155);
            uiSymbolLabel1.SymbolSize = 40;
            uiSymbolLabel1.TabIndex = 65;
            // 
            // ucGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNuevo);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucGestionUsuarios";
            Size = new Size(1123, 832);
            Load += ucGestionUsuarios_Load;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuevo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Panel pnlInformacion;
        private Sunny.UI.UITextBox txtBuscarTecnico;
        private DataGridView dgvNuevo;
        private Sunny.UI.UISymbolButton btnNuevoTecnico;
        private Label lblTitulo;
        private Label label16;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
