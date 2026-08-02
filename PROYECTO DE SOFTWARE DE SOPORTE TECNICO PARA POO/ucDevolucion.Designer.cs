namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucDevolucion
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
            btnBuscar = new Sunny.UI.UIButton();
            lblOrden = new Label();
            txtBuscarOrden = new Sunny.UI.UITextBox();
            pnlPrincipal = new Panel();
            pnlRegistrarEntrega = new Sunny.UI.UIPanel();
            airSeparator4 = new ReaLTaiizor.Controls.AirSeparator();
            pnlDesgloseCosto = new Sunny.UI.UIPanel();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            pnlTrabajoRealizado = new Sunny.UI.UIPanel();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            pnlResumen = new Sunny.UI.UIPanel();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            pnlRegistrarEntrega.SuspendLayout();
            pnlDesgloseCosto.SuspendLayout();
            pnlTrabajoRealizado.SuspendLayout();
            pnlResumen.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-6, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1052, 59);
            pnlSuperior.TabIndex = 1;
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
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Devolución / Entrega";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.Controls.Add(btnBuscar);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Controls.Add(txtBuscarOrden);
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1022, 59);
            pnlInformacion.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            btnBuscar.Location = new Point(331, 21);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.Size = new Size(90, 31);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrden.ForeColor = Color.FromArgb(147, 162, 183);
            lblOrden.Location = new Point(29, 3);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(246, 17);
            lblOrden.TabIndex = 19;
            lblOrden.Text = "Ingrese el número de orden para buscar";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscarOrden.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrden.Location = new Point(29, 22);
            txtBuscarOrden.Margin = new Padding(4, 5, 4, 5);
            txtBuscarOrden.MinimumSize = new Size(1, 16);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Padding = new Padding(5);
            txtBuscarOrden.Radius = 12;
            txtBuscarOrden.ShowText = false;
            txtBuscarOrden.Size = new Size(295, 30);
            txtBuscarOrden.TabIndex = 3;
            txtBuscarOrden.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarOrden.Watermark = "Ej. ORD-2024-003";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.BackColor = Color.FromArgb(15, 23, 42);
            pnlPrincipal.Controls.Add(pnlRegistrarEntrega);
            pnlPrincipal.Controls.Add(pnlDesgloseCosto);
            pnlPrincipal.Controls.Add(pnlTrabajoRealizado);
            pnlPrincipal.Controls.Add(pnlResumen);
            pnlPrincipal.Location = new Point(0, 118);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1025, 663);
            pnlPrincipal.TabIndex = 3;
            // 
            // pnlRegistrarEntrega
            // 
            pnlRegistrarEntrega.Controls.Add(airSeparator4);
            pnlRegistrarEntrega.Font = new Font("Microsoft Sans Serif", 12F);
            pnlRegistrarEntrega.Location = new Point(546, 46);
            pnlRegistrarEntrega.Margin = new Padding(4, 5, 4, 5);
            pnlRegistrarEntrega.MinimumSize = new Size(1, 1);
            pnlRegistrarEntrega.Name = "pnlRegistrarEntrega";
            pnlRegistrarEntrega.Radius = 12;
            pnlRegistrarEntrega.Size = new Size(452, 475);
            pnlRegistrarEntrega.TabIndex = 6;
            pnlRegistrarEntrega.Text = null;
            pnlRegistrarEntrega.TextAlignment = ContentAlignment.MiddleCenter;
            pnlRegistrarEntrega.Visible = false;
            // 
            // airSeparator4
            // 
            airSeparator4.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator4.Customization = "";
            airSeparator4.Font = new Font("Verdana", 8F);
            airSeparator4.Image = null;
            airSeparator4.Location = new Point(18, 43);
            airSeparator4.Name = "airSeparator4";
            airSeparator4.NoRounding = false;
            airSeparator4.Size = new Size(409, 1);
            airSeparator4.TabIndex = 1;
            airSeparator4.Text = "airSeparator4";
            airSeparator4.Transparent = false;
            // 
            // pnlDesgloseCosto
            // 
            pnlDesgloseCosto.Controls.Add(airSeparator3);
            pnlDesgloseCosto.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDesgloseCosto.Location = new Point(29, 428);
            pnlDesgloseCosto.Margin = new Padding(4, 5, 4, 5);
            pnlDesgloseCosto.MinimumSize = new Size(1, 1);
            pnlDesgloseCosto.Name = "pnlDesgloseCosto";
            pnlDesgloseCosto.Radius = 12;
            pnlDesgloseCosto.Size = new Size(500, 171);
            pnlDesgloseCosto.TabIndex = 5;
            pnlDesgloseCosto.Text = null;
            pnlDesgloseCosto.TextAlignment = ContentAlignment.MiddleCenter;
            pnlDesgloseCosto.Visible = false;
            // 
            // airSeparator3
            // 
            airSeparator3.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator3.Customization = "";
            airSeparator3.Font = new Font("Verdana", 8F);
            airSeparator3.Image = null;
            airSeparator3.Location = new Point(18, 43);
            airSeparator3.Name = "airSeparator3";
            airSeparator3.NoRounding = false;
            airSeparator3.Size = new Size(463, 1);
            airSeparator3.TabIndex = 1;
            airSeparator3.Text = "airSeparator3";
            airSeparator3.Transparent = false;
            // 
            // pnlTrabajoRealizado
            // 
            pnlTrabajoRealizado.Controls.Add(airSeparator2);
            pnlTrabajoRealizado.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTrabajoRealizado.Location = new Point(29, 231);
            pnlTrabajoRealizado.Margin = new Padding(4, 5, 4, 5);
            pnlTrabajoRealizado.MinimumSize = new Size(1, 1);
            pnlTrabajoRealizado.Name = "pnlTrabajoRealizado";
            pnlTrabajoRealizado.Radius = 12;
            pnlTrabajoRealizado.Size = new Size(500, 187);
            pnlTrabajoRealizado.TabIndex = 5;
            pnlTrabajoRealizado.Text = null;
            pnlTrabajoRealizado.TextAlignment = ContentAlignment.MiddleCenter;
            pnlTrabajoRealizado.Visible = false;
            // 
            // airSeparator2
            // 
            airSeparator2.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator2.Customization = "";
            airSeparator2.Font = new Font("Verdana", 8F);
            airSeparator2.Image = null;
            airSeparator2.Location = new Point(18, 43);
            airSeparator2.Name = "airSeparator2";
            airSeparator2.NoRounding = false;
            airSeparator2.Size = new Size(463, 1);
            airSeparator2.TabIndex = 1;
            airSeparator2.Text = "airSeparator2";
            airSeparator2.Transparent = false;
            // 
            // pnlResumen
            // 
            pnlResumen.Controls.Add(airSeparator1);
            pnlResumen.Font = new Font("Microsoft Sans Serif", 12F);
            pnlResumen.Location = new Point(29, 46);
            pnlResumen.Margin = new Padding(4, 5, 4, 5);
            pnlResumen.MinimumSize = new Size(1, 1);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Radius = 12;
            pnlResumen.Size = new Size(500, 175);
            pnlResumen.TabIndex = 4;
            pnlResumen.Text = null;
            pnlResumen.TextAlignment = ContentAlignment.MiddleCenter;
            pnlResumen.Visible = false;
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(18, 43);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(463, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // ucDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPrincipal);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucDevolucion";
            Size = new Size(1022, 781);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            pnlRegistrarEntrega.ResumeLayout(false);
            pnlDesgloseCosto.ResumeLayout(false);
            pnlTrabajoRealizado.ResumeLayout(false);
            pnlResumen.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UITextBox txtBuscarOrden;
        private Label lblOrden;
        private Panel pnlPrincipal;
        private Sunny.UI.UIButton btnBuscar;
        private Sunny.UI.UIPanel pnlRegistrarEntrega;
        private Sunny.UI.UIPanel pnlDesgloseCosto;
        private Sunny.UI.UIPanel pnlTrabajoRealizado;
        private Sunny.UI.UIPanel pnlResumen;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator4;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
    }
}
