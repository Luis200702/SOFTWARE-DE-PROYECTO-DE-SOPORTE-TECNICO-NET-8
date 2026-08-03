namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucTradeIn
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
            picTradeIn = new PictureBox();
            lblTitulo = new Label();
            pnlCentral = new Panel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            picIcon = new PictureBox();
            lblDispositivoRecibido = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTradeIn).BeginInit();
            pnlCentral.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(picTradeIn);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-6, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1034, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // picTradeIn
            // 
            picTradeIn.Image = Properties.Resources.TablerArrowsLeftRight;
            picTradeIn.Location = new Point(31, 12);
            picTradeIn.Name = "picTradeIn";
            picTradeIn.Size = new Size(36, 30);
            picTradeIn.SizeMode = PictureBoxSizeMode.Zoom;
            picTradeIn.TabIndex = 0;
            picTradeIn.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Trade-In";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCentral
            // 
            pnlCentral.BackColor = Color.FromArgb(15, 23, 42);
            pnlCentral.Controls.Add(uiPanel3);
            pnlCentral.Controls.Add(uiPanel2);
            pnlCentral.Controls.Add(uiPanel1);
            pnlCentral.Location = new Point(0, 59);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1022, 722);
            pnlCentral.TabIndex = 3;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(lblDispositivoRecibido);
            uiPanel1.Controls.Add(picIcon);
            uiPanel1.Controls.Add(airSeparator1);
            uiPanel1.FillColor = Color.FromArgb(30, 41, 59);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(26, 20);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 12;
            uiPanel1.RectColor = Color.FromArgb(39, 53, 72);
            uiPanel1.Size = new Size(316, 598);
            uiPanel1.TabIndex = 0;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.FillColor = Color.FromArgb(30, 41, 59);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(350, 20);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 12;
            uiPanel2.RectColor = Color.FromArgb(39, 53, 72);
            uiPanel2.Size = new Size(316, 598);
            uiPanel2.TabIndex = 1;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.FillColor = Color.FromArgb(30, 41, 59);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(674, 20);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 12;
            uiPanel3.RectColor = Color.FromArgb(39, 53, 72);
            uiPanel3.Size = new Size(316, 182);
            uiPanel3.TabIndex = 1;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.FromArgb(120, 99, 35);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(16, 34);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(285, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // picIcon
            // 
            picIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picIcon.BackColor = Color.Transparent;
            picIcon.Image = Properties.Resources.TablerArrowsLeftRight__1_;
            picIcon.Location = new Point(16, 7);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(30, 21);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 16;
            picIcon.TabStop = false;
            // 
            // lblDispositivoRecibido
            // 
            lblDispositivoRecibido.AutoSize = true;
            lblDispositivoRecibido.BackColor = Color.Transparent;
            lblDispositivoRecibido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDispositivoRecibido.ForeColor = Color.White;
            lblDispositivoRecibido.Location = new Point(52, 13);
            lblDispositivoRecibido.Name = "lblDispositivoRecibido";
            lblDispositivoRecibido.Size = new Size(165, 15);
            lblDispositivoRecibido.TabIndex = 17;
            lblDispositivoRecibido.Text = "Dispositivo recibido en canje";
            // 
            // ucTradeIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCentral);
            Controls.Add(pnlSuperior);
            Name = "ucTradeIn";
            Size = new Size(1022, 781);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTradeIn).EndInit();
            pnlCentral.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox picTradeIn;
        private Label lblTitulo;
        private Panel pnlCentral;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private PictureBox picIcon;
        private Label lblDispositivoRecibido;
    }
}
