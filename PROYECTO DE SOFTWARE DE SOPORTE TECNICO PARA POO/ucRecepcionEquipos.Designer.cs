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
            mcReparacion = new ReaLTaiizor.Controls.MaterialCard();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            mcDispositivo = new ReaLTaiizor.Controls.MaterialCard();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            mcCliente = new ReaLTaiizor.Controls.MaterialCard();
            txtCorreo = new TextBox();
            txtNumeroTelefonico = new TextBox();
            txtNombre = new TextBox();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            pnlInferior = new Panel();
            btnGuardarRegistro = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new Button();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlCentral.SuspendLayout();
            mcReparacion.SuspendLayout();
            mcDispositivo.SuspendLayout();
            mcCliente.SuspendLayout();
            pnlInferior.SuspendLayout();
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
            pnlCentral.Controls.Add(mcReparacion);
            pnlCentral.Controls.Add(mcDispositivo);
            pnlCentral.Controls.Add(mcCliente);
            pnlCentral.Location = new Point(0, 118);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1025, 483);
            pnlCentral.TabIndex = 2;
            pnlCentral.Resize += pnlCentral_Resize;
            // 
            // mcReparacion
            // 
            mcReparacion.BackColor = Color.FromArgb(255, 255, 255);
            mcReparacion.Controls.Add(airSeparator3);
            mcReparacion.Depth = 0;
            mcReparacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcReparacion.Location = new Point(694, 40);
            mcReparacion.Margin = new Padding(14);
            mcReparacion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcReparacion.Name = "mcReparacion";
            mcReparacion.Padding = new Padding(14);
            mcReparacion.Size = new Size(299, 377);
            mcReparacion.TabIndex = 1;
            // 
            // airSeparator3
            // 
            airSeparator3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // mcDispositivo
            // 
            mcDispositivo.BackColor = Color.FromArgb(255, 255, 255);
            mcDispositivo.Controls.Add(airSeparator2);
            mcDispositivo.Depth = 0;
            mcDispositivo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcDispositivo.Location = new Point(367, 40);
            mcDispositivo.Margin = new Padding(14);
            mcDispositivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcDispositivo.Name = "mcDispositivo";
            mcDispositivo.Padding = new Padding(14);
            mcDispositivo.Size = new Size(299, 377);
            mcDispositivo.TabIndex = 1;
            // 
            // airSeparator2
            // 
            airSeparator2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // mcCliente
            // 
            mcCliente.BackColor = Color.FromArgb(255, 255, 255);
            mcCliente.Controls.Add(txtCorreo);
            mcCliente.Controls.Add(txtNumeroTelefonico);
            mcCliente.Controls.Add(txtNombre);
            mcCliente.Controls.Add(airSeparator1);
            mcCliente.Depth = 0;
            mcCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcCliente.Location = new Point(40, 40);
            mcCliente.Margin = new Padding(14);
            mcCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcCliente.Name = "mcCliente";
            mcCliente.Padding = new Padding(14);
            mcCliente.Size = new Size(299, 377);
            mcCliente.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(23, 227);
            txtCorreo.MaxLength = 255;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "correo@ejemplo.com";
            txtCorreo.Size = new Size(256, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.Location = new Point(23, 177);
            txtNumeroTelefonico.MaxLength = 10;
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.PlaceholderText = "099 342 5009";
            txtNumeroTelefonico.Size = new Size(256, 23);
            txtNumeroTelefonico.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 139);
            txtNombre.MaxLength = 255;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombres y apellidos";
            txtNombre.Size = new Size(256, 23);
            txtNombre.TabIndex = 1;
            // 
            // airSeparator1
            // 
            airSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(30, 41, 59);
            pnlInferior.Controls.Add(btnCancelar);
            pnlInferior.Controls.Add(btnGuardarRegistro);
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
            btnGuardarRegistro.Margin = new Padding(0);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new Size(135, 51);
            btnGuardarRegistro.TabIndex = 3;
            btnGuardarRegistro.Text = "Guardar Registro";
            btnGuardarRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarRegistro.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.Location = new Point(592, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 51);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(0, 150, 137);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.Red;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(756, 22);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 51);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
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
            mcReparacion.ResumeLayout(false);
            mcDispositivo.ResumeLayout(false);
            mcCliente.ResumeLayout(false);
            mcCliente.PerformLayout();
            pnlInferior.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlInformacion;
        private Panel pnlCentral;
        private Panel pnlInferior;
        private Button btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardarRegistro;
        private Label lblFecha;
        private Label lblOrden;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCard mcReparacion;
        private ReaLTaiizor.Controls.MaterialCard mcDispositivo;
        private ReaLTaiizor.Controls.MaterialCard mcCliente;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private TextBox txtCorreo;
        private TextBox txtNumeroTelefonico;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}
