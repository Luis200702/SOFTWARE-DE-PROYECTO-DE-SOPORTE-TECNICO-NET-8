namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucRecepcionEquipos
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
            lblFecha = new Label();
            lblOrden = new Label();
            pnlCentral = new Panel();
            pnlInferior = new Panel();
            btnGuardarRegistro = new FontAwesome.Sharp.IconButton();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlCentral.SuspendLayout();
            pnlInferior.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
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
            pnlSuperior.Size = new Size(1040, 59);
            pnlSuperior.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GgScreen__1_;
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
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(342, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepción de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.AutoSize = true;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.Controls.Add(lblFecha);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1025, 59);
            pnlInformacion.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.BorderStyle = BorderStyle.FixedSingle;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(147, 162, 183);
            lblFecha.Location = new Point(170, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(145, 30);
            lblFecha.TabIndex = 1;
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrden
            // 
            lblOrden.BorderStyle = BorderStyle.FixedSingle;
            lblOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrden.ForeColor = Color.FromArgb(147, 162, 183);
            lblOrden.Location = new Point(15, 15);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(122, 30);
            lblOrden.TabIndex = 0;
            lblOrden.Text = "Orden: #XXX";
            lblOrden.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCentral
            // 
            pnlCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCentral.AutoSize = true;
            pnlCentral.BackColor = Color.FromArgb(15, 23, 42);
            pnlCentral.Controls.Add(materialCard3);
            pnlCentral.Controls.Add(materialCard2);
            pnlCentral.Controls.Add(materialCard1);
            pnlCentral.Location = new Point(0, 118);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1025, 483);
            pnlCentral.TabIndex = 2;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(30, 41, 59);
            pnlInferior.Controls.Add(btnGuardarRegistro);
            pnlInferior.Controls.Add(btnCancelar);
            pnlInferior.Controls.Add(btnLimpiar);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 601);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1025, 85);
            pnlInferior.TabIndex = 3;
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarRegistro.BackColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarRegistro.IconColor = Color.Black;
            btnGuardarRegistro.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardarRegistro.IconSize = 30;
            btnGuardarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarRegistro.Location = new Point(868, 22);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new Size(135, 51);
            btnGuardarRegistro.TabIndex = 3;
            btnGuardarRegistro.Text = "Guardar Registro";
            btnGuardarRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.Location = new Point(754, 22);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 51);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.Location = new Point(640, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 51);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(airSeparator1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(40, 40);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(299, 377);
            materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(airSeparator2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(367, 40);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(299, 377);
            materialCard2.TabIndex = 1;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(airSeparator3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(694, 40);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(299, 377);
            materialCard3.TabIndex = 1;
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.FromArgb(15, 144, 157);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(23, 34);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(256, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // airSeparator2
            // 
            airSeparator2.BackColor = Color.FromArgb(15, 144, 157);
            airSeparator2.Customization = "";
            airSeparator2.Font = new Font("Verdana", 8F);
            airSeparator2.Image = null;
            airSeparator2.ImeMode = ImeMode.Off;
            airSeparator2.Location = new Point(23, 34);
            airSeparator2.Name = "airSeparator2";
            airSeparator2.NoRounding = false;
            airSeparator2.Size = new Size(256, 1);
            airSeparator2.TabIndex = 1;
            airSeparator2.Text = "airSeparator2";
            airSeparator2.Transparent = false;
            // 
            // airSeparator3
            // 
            airSeparator3.BackColor = Color.FromArgb(15, 144, 157);
            airSeparator3.Customization = "";
            airSeparator3.Font = new Font("Verdana", 8F);
            airSeparator3.Image = null;
            airSeparator3.Location = new Point(23, 34);
            airSeparator3.Name = "airSeparator3";
            airSeparator3.NoRounding = false;
            airSeparator3.Size = new Size(256, 1);
            airSeparator3.TabIndex = 1;
            airSeparator3.Text = "airSeparator3";
            airSeparator3.Transparent = false;
            // 
            // ucRecepcionEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInferior);
            Controls.Add(pnlCentral);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucRecepcionEquipos";
            Size = new Size(1025, 686);
            Load += ucRecepcionEquipos_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlCentral.ResumeLayout(false);
            pnlInferior.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlInformacion;
        private Panel pnlCentral;
        private Panel pnlInferior;
        private Button btnCancelar;
        private Button btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardarRegistro;
        private Label lblFecha;
        private Label lblOrden;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
    }
}
