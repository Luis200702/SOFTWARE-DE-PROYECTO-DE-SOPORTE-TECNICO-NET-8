namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucDerivacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Sunny.UI.UITabControl tcDerivaciones;
        private System.Windows.Forms.TabPage tpEntrantes;
        private System.Windows.Forms.TabPage tpSalientes;
    

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
            btnNuevaDerivacion = new Sunny.UI.UISymbolButton();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            tcDerivaciones = new Sunny.UI.UITabControl();
            tpEntrantes = new TabPage();
            pnlIzquierdoE = new Panel();
            flpIzquierdoE = new FlowLayoutPanel();
            pnlDerechoE = new Panel();
            tpSalientes = new TabPage();
            pnlIzquierdoS = new Panel();
            pnlDerechoS = new Panel();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tcDerivaciones.SuspendLayout();
            tpEntrantes.SuspendLayout();
            pnlIzquierdoE.SuspendLayout();
            tpSalientes.SuspendLayout();
            pnlIzquierdoS.SuspendLayout();
            SuspendLayout();
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
            pnlSuperior.Size = new Size(1138, 59);
            pnlSuperior.TabIndex = 37;
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
            // tcDerivaciones
            // 
            tcDerivaciones.Controls.Add(tpEntrantes);
            tcDerivaciones.Controls.Add(tpSalientes);
            tcDerivaciones.DrawMode = TabDrawMode.OwnerDrawFixed;
            tcDerivaciones.FillColor = Color.FromArgb(245, 247, 250);
            tcDerivaciones.Font = new Font("Microsoft Sans Serif", 12F);
            tcDerivaciones.ItemSize = new Size(190, 40);
            tcDerivaciones.Location = new Point(0, 59);
            tcDerivaciones.MainPage = "";
            tcDerivaciones.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            tcDerivaciones.Name = "tcDerivaciones";
            tcDerivaciones.SelectedIndex = 0;
            tcDerivaciones.Size = new Size(1125, 773);
            tcDerivaciones.SizeMode = TabSizeMode.Fixed;
            tcDerivaciones.Style = Sunny.UI.UIStyle.Custom;
            tcDerivaciones.TabBackColor = Color.FromArgb(240, 240, 240);
            tcDerivaciones.TabIndex = 38;
            tcDerivaciones.TabSelectedColor = Color.FromArgb(223, 241, 241);
            tcDerivaciones.TabSelectedForeColor = Color.Black;
            tcDerivaciones.TabSelectedHighColor = Color.FromArgb(0, 150, 137);
            tcDerivaciones.TabUnSelectedColor = Color.FromArgb(240, 240, 240);
            tcDerivaciones.TabUnSelectedForeColor = Color.FromArgb(48, 48, 48);
            tcDerivaciones.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // tpEntrantes
            // 
            tpEntrantes.BackColor = Color.FromArgb(245, 247, 250);
            tpEntrantes.Controls.Add(pnlIzquierdoE);
            tpEntrantes.Location = new Point(0, 40);
            tpEntrantes.Name = "tpEntrantes";
            tpEntrantes.Size = new Size(1125, 733);
            tpEntrantes.TabIndex = 0;
            tpEntrantes.Text = "Entrantes (Recibidas)";
            // 
            // pnlIzquierdoE
            // 
            pnlIzquierdoE.Controls.Add(flpIzquierdoE);
            pnlIzquierdoE.Controls.Add(pnlDerechoE);
            pnlIzquierdoE.Location = new Point(0, 0);
            pnlIzquierdoE.Name = "pnlIzquierdoE";
            pnlIzquierdoE.Size = new Size(477, 733);
            pnlIzquierdoE.TabIndex = 0;
            // 
            // flpIzquierdoE
            // 
            flpIzquierdoE.AutoScroll = true;
            flpIzquierdoE.Dock = DockStyle.Fill;
            flpIzquierdoE.Location = new Point(0, 0);
            flpIzquierdoE.Name = "flpIzquierdoE";
            flpIzquierdoE.Size = new Size(477, 733);
            flpIzquierdoE.TabIndex = 2;
            // 
            // pnlDerechoE
            // 
            pnlDerechoE.Location = new Point(476, 0);
            pnlDerechoE.Name = "pnlDerechoE";
            pnlDerechoE.Size = new Size(649, 733);
            pnlDerechoE.TabIndex = 1;
            // 
            // tpSalientes
            // 
            tpSalientes.BackColor = Color.FromArgb(245, 247, 250);
            tpSalientes.Controls.Add(pnlIzquierdoS);
            tpSalientes.Location = new Point(0, 40);
            tpSalientes.Name = "tpSalientes";
            tpSalientes.Size = new Size(1125, 733);
            tpSalientes.TabIndex = 1;
            tpSalientes.Text = "Salientes (Enviadas)";
            // 
            // pnlIzquierdoS
            // 
            pnlIzquierdoS.Controls.Add(pnlDerechoS);
            pnlIzquierdoS.Location = new Point(0, 0);
            pnlIzquierdoS.Name = "pnlIzquierdoS";
            pnlIzquierdoS.Size = new Size(477, 733);
            pnlIzquierdoS.TabIndex = 1;
            // 
            // pnlDerechoS
            // 
            pnlDerechoS.Location = new Point(478, 3);
            pnlDerechoS.Name = "pnlDerechoS";
            pnlDerechoS.Size = new Size(644, 730);
            pnlDerechoS.TabIndex = 1;
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcDerivaciones);
            Controls.Add(pnlSuperior);
            Name = "ucDerivacion";
            Size = new Size(1123, 832);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tcDerivaciones.ResumeLayout(false);
            tpEntrantes.ResumeLayout(false);
            pnlIzquierdoE.ResumeLayout(false);
            tpSalientes.ResumeLayout(false);
            pnlIzquierdoS.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Sunny.UI.UISymbolButton btnNuevaDerivacion;
        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage1;
        private Panel pnlIzquierdoE;
        private Panel pnlDerechoE;
        private Panel pnlIzquierdoS;
        private Panel pnlDerechoS;
        private FlowLayoutPanel flpIzquierdoE;
    }
}
