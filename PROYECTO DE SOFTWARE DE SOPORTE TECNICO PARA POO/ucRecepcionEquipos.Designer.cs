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
            lblReparacion = new Label();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            mcDispositivo = new ReaLTaiizor.Controls.MaterialCard();
            cmbEstado = new ComboBox();
            txtColor = new TextBox();
            txtSerieImei = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            lblDispositivo = new Label();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            mcCliente = new ReaLTaiizor.Controls.MaterialCard();
            btnTelefono = new Sunny.UI.UIButton();
            btnComputadora = new Sunny.UI.UIButton();
            lblCliente = new Label();
            txtCorreo = new TextBox();
            txtNumeroTelefonico = new TextBox();
            txtNombre = new TextBox();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            pnlInferior = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardarRegistro = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new Button();
            lblDatosCliente = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            label3 = new Label();
            lblColor = new Label();
            label5 = new Label();
            lblMarca = new Label();
            lblEstado = new Label();
            lblTipoDispositivo = new Label();
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
            mcReparacion.Controls.Add(lblReparacion);
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
            // lblReparacion
            // 
            lblReparacion.AutoSize = true;
            lblReparacion.Location = new Point(45, 14);
            lblReparacion.Name = "lblReparacion";
            lblReparacion.Size = new Size(127, 15);
            lblReparacion.TabIndex = 6;
            lblReparacion.Text = "Datos de la Reparación";
            // 
            // airSeparator3
            // 
            airSeparator3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            airSeparator3.BackColor = Color.FromArgb(142, 113, 30);
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
            mcDispositivo.Controls.Add(lblEstado);
            mcDispositivo.Controls.Add(lblMarca);
            mcDispositivo.Controls.Add(label5);
            mcDispositivo.Controls.Add(lblColor);
            mcDispositivo.Controls.Add(label3);
            mcDispositivo.Controls.Add(cmbEstado);
            mcDispositivo.Controls.Add(txtColor);
            mcDispositivo.Controls.Add(txtSerieImei);
            mcDispositivo.Controls.Add(txtMarca);
            mcDispositivo.Controls.Add(txtModelo);
            mcDispositivo.Controls.Add(lblDispositivo);
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
            // cmbEstado
            // 
            cmbEstado.DisplayMember = "Seleccionar estado...";
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Seleccionar estado...", "Bueno", "Regular", "Malo" });
            cmbEstado.Location = new Point(23, 200);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(256, 23);
            cmbEstado.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(157, 146);
            txtColor.MaxLength = 255;
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = "Ej. Negro";
            txtColor.Size = new Size(122, 23);
            txtColor.TabIndex = 11;
            // 
            // txtSerieImei
            // 
            txtSerieImei.Location = new Point(23, 146);
            txtSerieImei.MaxLength = 255;
            txtSerieImei.Name = "txtSerieImei";
            txtSerieImei.PlaceholderText = "15 digitos";
            txtSerieImei.Size = new Size(122, 23);
            txtSerieImei.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(23, 91);
            txtMarca.MaxLength = 255;
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Ej. Samsung";
            txtMarca.Size = new Size(122, 23);
            txtMarca.TabIndex = 9;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(157, 91);
            txtModelo.MaxLength = 255;
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Ej. Galaxy S22";
            txtModelo.Size = new Size(122, 23);
            txtModelo.TabIndex = 8;
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.Location = new Point(45, 14);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(117, 15);
            lblDispositivo.TabIndex = 5;
            lblDispositivo.Text = "Datos del Dispositivo";
            // 
            // airSeparator2
            // 
            airSeparator2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            airSeparator2.BackColor = Color.FromArgb(98, 86, 159);
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
            mcCliente.Controls.Add(lblTipoDispositivo);
            mcCliente.Controls.Add(lblCorreo);
            mcCliente.Controls.Add(lblTelefono);
            mcCliente.Controls.Add(lblDatosCliente);
            mcCliente.Controls.Add(btnTelefono);
            mcCliente.Controls.Add(btnComputadora);
            mcCliente.Controls.Add(lblCliente);
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
            // btnTelefono
            // 
            btnTelefono.FillColor = Color.FromArgb(22, 35, 52);
            btnTelefono.FillHoverColor = Color.Transparent;
            btnTelefono.FillPressColor = Color.FromArgb(0, 150, 137);
            btnTelefono.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            btnTelefono.Location = new Point(154, 263);
            btnTelefono.MinimumSize = new Size(1, 1);
            btnTelefono.Name = "btnTelefono";
            btnTelefono.Radius = 12;
            btnTelefono.RectPressColor = Color.FromArgb(0, 150, 137);
            btnTelefono.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnTelefono.Size = new Size(125, 26);
            btnTelefono.TabIndex = 6;
            btnTelefono.Text = "Teléfono";
            btnTelefono.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTelefono.Click += btnTelefono_Click;
            // 
            // btnComputadora
            // 
            btnComputadora.FillColor = Color.FromArgb(22, 35, 52);
            btnComputadora.FillHoverColor = Color.Transparent;
            btnComputadora.FillPressColor = Color.FromArgb(0, 150, 137);
            btnComputadora.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnComputadora.Font = new Font("Microsoft Sans Serif", 12F);
            btnComputadora.Location = new Point(25, 265);
            btnComputadora.MinimumSize = new Size(1, 1);
            btnComputadora.Name = "btnComputadora";
            btnComputadora.Radius = 12;
            btnComputadora.RectColor = Color.FromArgb(22, 35, 52);
            btnComputadora.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnComputadora.RectPressColor = Color.FromArgb(0, 150, 137);
            btnComputadora.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnComputadora.Size = new Size(125, 24);
            btnComputadora.TabIndex = 5;
            btnComputadora.Text = "Computadora";
            btnComputadora.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnComputadora.TipsForeColor = Color.Transparent;
            btnComputadora.Click += btnComputadora_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(45, 14);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(96, 15);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Datos del Cliente";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(23, 200);
            txtCorreo.MaxLength = 255;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "correo@ejemplo.com";
            txtCorreo.Size = new Size(256, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.Location = new Point(23, 146);
            txtNumeroTelefonico.MaxLength = 10;
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.PlaceholderText = "099 342 5009";
            txtNumeroTelefonico.Size = new Size(256, 23);
            txtNumeroTelefonico.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 91);
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
            btnCancelar.Location = new Point(760, 22);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 51);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
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
            btnLimpiar.Location = new Point(640, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 51);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(23, 73);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(109, 15);
            lblDatosCliente.TabIndex = 7;
            lblDatosCliente.Text = "Nombre completo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(23, 128);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(105, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono / Celular";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(23, 182);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(111, 15);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Serie / IMEI";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(157, 128);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 14;
            lblColor.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(157, 73);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 15;
            label5.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(23, 73);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(41, 15);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(23, 182);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(113, 15);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado en que llega";
            // 
            // lblTipoDispositivo
            // 
            lblTipoDispositivo.AutoSize = true;
            lblTipoDispositivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDispositivo.Location = new Point(25, 247);
            lblTipoDispositivo.Name = "lblTipoDispositivo";
            lblTipoDispositivo.Size = new Size(110, 15);
            lblTipoDispositivo.TabIndex = 10;
            lblTipoDispositivo.Text = "Tipo de dispositivo";
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
            mcReparacion.PerformLayout();
            mcDispositivo.ResumeLayout(false);
            mcDispositivo.PerformLayout();
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
        private Label lblReparacion;
        private Label lblDispositivo;
        private Label lblCliente;
        private TextBox txtColor;
        private TextBox txtSerieImei;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private ComboBox cmbEstado;
        private Sunny.UI.UIButton btnComputadora;
        private Sunny.UI.UIButton btnTelefono;
        private Label lblMarca;
        private Label label5;
        private Label lblColor;
        private Label label3;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblDatosCliente;
        private Label lblEstado;
        private Label lblTipoDispositivo;
    }
}
