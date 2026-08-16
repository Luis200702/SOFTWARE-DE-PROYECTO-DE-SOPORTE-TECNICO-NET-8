namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucDerivacion
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
            uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip(components);
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            btnNuevaDerivacion = new Sunny.UI.UISymbolButton();
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // uiContextMenuStrip1
            // 
            uiContextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            uiContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F);
            uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            uiContextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(btnNuevaDerivacion);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-8, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 37;
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
            lblTitulo.Size = new Size(376, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Derivación entre Sucursales";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevaDerivacion
            // 
            btnNuevaDerivacion.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevaDerivacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaDerivacion.Location = new Point(954, 13);
            btnNuevaDerivacion.MinimumSize = new Size(1, 1);
            btnNuevaDerivacion.Name = "btnNuevaDerivacion";
            btnNuevaDerivacion.Radius = 12;
            btnNuevaDerivacion.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevaDerivacion.Size = new Size(157, 31);
            btnNuevaDerivacion.Symbol = 61543;
            btnNuevaDerivacion.TabIndex = 2;
            btnNuevaDerivacion.Text = "Nueva derivación";
            btnNuevaDerivacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(0, 59);
            uiTabControl1.MainPage = "";
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1125, 603);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 38;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1125, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1050, 563);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(uiTabControl1);
            Controls.Add(pnlSuperior);
            Name = "ucDerivacion";
            Size = new Size(1125, 764);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiTabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Sunny.UI.UISymbolButton btnNuevaDerivacion;
        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
