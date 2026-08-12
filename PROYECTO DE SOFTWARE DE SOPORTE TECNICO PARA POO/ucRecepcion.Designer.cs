namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucRecepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecepcion));
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            lblFecha = new Label();
            lblOrden = new Label();
            pnlCentral = new Panel();
            pnlInferior = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnGuardarRegistro = new Sunny.UI.UIButton();
            btnCancelar = new Sunny.UI.UIButton();
            btnLimpiar = new Sunny.UI.UIButton();
            flpEquipos = new Sunny.UI.UIFlowLayoutPanel();
            lblEquipos = new Label();
            btnEquipo = new Sunny.UI.UIButton();
            btnAgregarEquipo = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            txtCosto = new Sunny.UI.UITextBox();
            dtmFecha = new Sunny.UI.UIDatetimePicker();
            cmbSucursal = new Sunny.UI.UIComboBox();
            cmbTecnico = new Sunny.UI.UIComboBox();
            lblCosto = new Label();
            txtObservaciones = new Sunny.UI.UITextBox();
            lblFechaEntrega = new Label();
            picReparacion = new PictureBox();
            lblReparacion = new Label();
            lblTecnico = new Label();
            lblSucursal = new Label();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            txtDescripcionProblema = new Sunny.UI.UITextBox();
            lblProblema = new Label();
            lblDiagnostico = new Label();
            pnlDatosCliente = new Sunny.UI.UIPanel();
            pictureBox6 = new PictureBox();
            lbId = new Label();
            txtIdentificacionCliente = new Sunny.UI.UITextBox();
            txtCorreo = new Sunny.UI.UITextBox();
            txtNumeroTelefonico = new Sunny.UI.UITextBox();
            lblCorreo = new Label();
            txtNombres = new Sunny.UI.UITextBox();
            pictureBox5 = new PictureBox();
            lblTelefono = new Label();
            lblCliente = new Label();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            lblDatosCliente = new Label();
            pnlDispositivo = new Sunny.UI.UIPanel();
            lblEstado = new Label();
            cmbEstado = new Sunny.UI.UIComboBox();
            btnTelefono = new Sunny.UI.UIButton();
            lblTipoDispositivo = new Label();
            txtModelo = new Sunny.UI.UITextBox();
            btnComputadora = new Sunny.UI.UIButton();
            txtMarca = new Sunny.UI.UITextBox();
            txtColor = new Sunny.UI.UITextBox();
            txtSerie = new Sunny.UI.UITextBox();
            lblColor = new Label();
            lblSerie = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            airSeparator4 = new ReaLTaiizor.Controls.AirSeparator();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlCentral.SuspendLayout();
            pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flpEquipos.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReparacion).BeginInit();
            pnlDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlDispositivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(240, 244, 248);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1123, 59);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(240, 244, 248);
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(75, 92, 108);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(505, 59);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepción de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.AutoSize = true;
            pnlInformacion.BackColor = Color.FromArgb(240, 244, 248);
            pnlInformacion.Controls.Add(lblFecha);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1123, 59);
            pnlInformacion.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.BackColor = Color.FromArgb(240, 244, 248);
            lblFecha.BorderStyle = BorderStyle.FixedSingle;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(147, 162, 183);
            lblFecha.Location = new Point(184, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(145, 30);
            lblFecha.TabIndex = 1;
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrden
            // 
            lblOrden.BackColor = Color.FromArgb(240, 244, 248);
            lblOrden.BorderStyle = BorderStyle.FixedSingle;
            lblOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrden.ForeColor = Color.FromArgb(147, 162, 183);
            lblOrden.Location = new Point(31, 15);
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
            pnlCentral.BackColor = Color.FromArgb(240, 244, 248);
            pnlCentral.Controls.Add(pnlInferior);
            pnlCentral.Controls.Add(flpEquipos);
            pnlCentral.Controls.Add(uiPanel1);
            pnlCentral.Controls.Add(pnlSuperior);
            pnlCentral.Controls.Add(pnlInformacion);
            pnlCentral.Controls.Add(pnlDatosCliente);
            pnlCentral.Controls.Add(pnlDispositivo);
            pnlCentral.Location = new Point(0, 0);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1123, 832);
            pnlCentral.TabIndex = 3;
            // 
            // pnlInferior
            // 
            pnlInferior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInferior.BackColor = Color.FromArgb(240, 244, 248);
            pnlInferior.Controls.Add(pictureBox4);
            pnlInferior.Controls.Add(pictureBox2);
            pnlInferior.Controls.Add(pictureBox3);
            pnlInferior.Controls.Add(btnGuardarRegistro);
            pnlInferior.Controls.Add(btnCancelar);
            pnlInferior.Controls.Add(btnLimpiar);
            pnlInferior.Location = new Point(0, 748);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1125, 84);
            pnlInferior.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(0, 150, 137);
            pictureBox4.Image = Properties.Resources.MaterialSymbolsRestartAltRounded1;
            pictureBox4.Location = new Point(572, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(0, 150, 137);
            pictureBox2.Image = Properties.Resources.MaterialSymbolsSaveOutline;
            pictureBox2.Location = new Point(892, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(0, 150, 137);
            pictureBox3.Image = Properties.Resources.TablerX;
            pictureBox3.Location = new Point(731, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarRegistro.BackColor = Color.Transparent;
            btnGuardarRegistro.FillColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.FillHoverColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.FillPressColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarRegistro.Location = new Point(882, 8);
            btnGuardarRegistro.MinimumSize = new Size(1, 1);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Radius = 12;
            btnGuardarRegistro.RectPressColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnGuardarRegistro.Size = new Size(200, 50);
            btnGuardarRegistro.TabIndex = 14;
            btnGuardarRegistro.Text = "Guardar Registro    ";
            btnGuardarRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarRegistro.TipsFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarRegistro.TipsForeColor = Color.Black;
            btnGuardarRegistro.Click += btnGuardarRegistro_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.FillHoverColor = Color.FromArgb(0, 150, 137);
            btnCancelar.FillPressColor = Color.FromArgb(0, 150, 137);
            btnCancelar.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(225, 29, 72);
            btnCancelar.Location = new Point(715, 8);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectPressColor = Color.FromArgb(0, 150, 137);
            btnCancelar.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(140, 50);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar    ";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.TipsForeColor = Color.Black;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.FillColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.FillHoverColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.FillPressColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(555, 8);
            btnLimpiar.MinimumSize = new Size(1, 1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Radius = 12;
            btnLimpiar.RectPressColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnLimpiar.Size = new Size(140, 50);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar    ";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLimpiar.TipsForeColor = Color.Black;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // flpEquipos
            // 
            flpEquipos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flpEquipos.Controls.Add(lblEquipos);
            flpEquipos.Controls.Add(btnEquipo);
            flpEquipos.Controls.Add(btnAgregarEquipo);
            flpEquipos.FillColor = Color.FromArgb(75, 92, 108);
            flpEquipos.Font = new Font("Microsoft Sans Serif", 12F);
            flpEquipos.Location = new Point(31, 132);
            flpEquipos.Margin = new Padding(4, 5, 4, 5);
            flpEquipos.MinimumSize = new Size(1, 1);
            flpEquipos.Name = "flpEquipos";
            flpEquipos.Padding = new Padding(2);
            flpEquipos.Radius = 12;
            flpEquipos.RectColor = Color.FromArgb(75, 92, 108);
            flpEquipos.ShowText = false;
            flpEquipos.Size = new Size(1054, 63);
            flpEquipos.TabIndex = 5;
            flpEquipos.Text = null;
            flpEquipos.TextAlignment = ContentAlignment.MiddleCenter;
            flpEquipos.Click += flpEquipos_Click;
            // 
            // lblEquipos
            // 
            lblEquipos.Anchor = AnchorStyles.None;
            lblEquipos.AutoSize = true;
            lblEquipos.BackColor = Color.Transparent;
            lblEquipos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipos.ForeColor = Color.FromArgb(240, 244, 248);
            lblEquipos.Location = new Point(20, 20);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(71, 21);
            lblEquipos.TabIndex = 23;
            lblEquipos.Text = "Equipos";
            lblEquipos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEquipo
            // 
            btnEquipo.BackColor = Color.FromArgb(75, 92, 108);
            btnEquipo.FillColor = Color.FromArgb(0, 150, 137);
            btnEquipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipo.ForeColor = Color.FromArgb(240, 244, 248);
            btnEquipo.Location = new Point(112, 15);
            btnEquipo.MinimumSize = new Size(1, 1);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Radius = 12;
            btnEquipo.RectColor = Color.FromArgb(0, 150, 137);
            btnEquipo.Size = new Size(100, 34);
            btnEquipo.TabIndex = 21;
            btnEquipo.Text = "Equipo 1";
            btnEquipo.TipsFont = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquipo.Click += btnEquipo_Click;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.FromArgb(75, 92, 108);
            btnAgregarEquipo.FillColor = Color.White;
            btnAgregarEquipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEquipo.ForeColor = Color.Black;
            btnAgregarEquipo.Location = new Point(227, 15);
            btnAgregarEquipo.MinimumSize = new Size(1, 1);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Radius = 12;
            btnAgregarEquipo.RectColor = Color.FromArgb(0, 150, 137);
            btnAgregarEquipo.Size = new Size(145, 34);
            btnAgregarEquipo.TabIndex = 22;
            btnAgregarEquipo.Text = "Añadir Equipo";
            btnAgregarEquipo.TipsFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            uiPanel1.Controls.Add(txtCosto);
            uiPanel1.Controls.Add(dtmFecha);
            uiPanel1.Controls.Add(cmbSucursal);
            uiPanel1.Controls.Add(cmbTecnico);
            uiPanel1.Controls.Add(lblCosto);
            uiPanel1.Controls.Add(txtObservaciones);
            uiPanel1.Controls.Add(lblFechaEntrega);
            uiPanel1.Controls.Add(picReparacion);
            uiPanel1.Controls.Add(lblReparacion);
            uiPanel1.Controls.Add(lblTecnico);
            uiPanel1.Controls.Add(lblSucursal);
            uiPanel1.Controls.Add(airSeparator3);
            uiPanel1.Controls.Add(txtDescripcionProblema);
            uiPanel1.Controls.Add(lblProblema);
            uiPanel1.Controls.Add(lblDiagnostico);
            uiPanel1.FillColor = Color.FromArgb(198, 199, 189);
            uiPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiPanel1.Location = new Point(755, 210);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 12;
            uiPanel1.RectColor = Color.FromArgb(240, 244, 248);
            uiPanel1.Size = new Size(330, 516);
            uiPanel1.TabIndex = 4;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.Transparent;
            txtCosto.FillColor = Color.FromArgb(240, 244, 248);
            txtCosto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCosto.ForeColor = Color.FromArgb(75, 92, 108);
            txtCosto.Location = new Point(177, 451);
            txtCosto.Margin = new Padding(4, 5, 4, 5);
            txtCosto.MaxLength = 255;
            txtCosto.Minimum = 0D;
            txtCosto.MinimumSize = new Size(1, 16);
            txtCosto.Name = "txtCosto";
            txtCosto.Padding = new Padding(5);
            txtCosto.Radius = 12;
            txtCosto.RectColor = Color.FromArgb(240, 244, 248);
            txtCosto.ShowText = false;
            txtCosto.Size = new Size(136, 37);
            txtCosto.TabIndex = 47;
            txtCosto.TextAlignment = ContentAlignment.MiddleLeft;
            txtCosto.Watermark = "0$";
            txtCosto.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // dtmFecha
            // 
            dtmFecha.BackColor = Color.FromArgb(198, 199, 189);
            dtmFecha.DateCultureInfo = new System.Globalization.CultureInfo("es-ES");
            dtmFecha.DateFormat = "yyyy-MM-dd";
            dtmFecha.FillColor = Color.FromArgb(75, 92, 108);
            dtmFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmFecha.ForeColor = Color.White;
            dtmFecha.Location = new Point(19, 451);
            dtmFecha.Margin = new Padding(4, 5, 4, 5);
            dtmFecha.MaxLength = 10;
            dtmFecha.MinimumSize = new Size(63, 0);
            dtmFecha.Name = "dtmFecha";
            dtmFecha.Padding = new Padding(0, 0, 30, 2);
            dtmFecha.Radius = 12;
            dtmFecha.RectColor = Color.FromArgb(148, 163, 184);
            dtmFecha.Size = new Size(136, 37);
            dtmFecha.SymbolDropDown = 61555;
            dtmFecha.SymbolNormal = 61555;
            dtmFecha.SymbolSize = 24;
            dtmFecha.TabIndex = 46;
            dtmFecha.Text = "2026-08-03";
            dtmFecha.TextAlignment = ContentAlignment.MiddleLeft;
            dtmFecha.Value = new DateTime(2026, 8, 3, 0, 0, 0, 0);
            dtmFecha.Watermark = "";
            // 
            // cmbSucursal
            // 
            cmbSucursal.BackColor = Color.Transparent;
            cmbSucursal.DataSource = null;
            cmbSucursal.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbSucursal.FillColor = Color.FromArgb(75, 92, 108);
            cmbSucursal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.ForeColor = Color.FromArgb(235, 239, 240);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbSucursal.Items.AddRange(new object[] { "Seleccionar...", "Sucursal Centro", "Sucursal Sur" });
            cmbSucursal.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbSucursal.Location = new Point(177, 377);
            cmbSucursal.Margin = new Padding(4, 5, 4, 5);
            cmbSucursal.MinimumSize = new Size(63, 0);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Padding = new Padding(0, 0, 30, 2);
            cmbSucursal.Radius = 12;
            cmbSucursal.RectColor = Color.FromArgb(148, 163, 184);
            cmbSucursal.Size = new Size(136, 37);
            cmbSucursal.SymbolSize = 24;
            cmbSucursal.TabIndex = 45;
            cmbSucursal.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursal.Watermark = "";
            // 
            // cmbTecnico
            // 
            cmbTecnico.BackColor = Color.Transparent;
            cmbTecnico.DataSource = null;
            cmbTecnico.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbTecnico.FillColor = Color.FromArgb(75, 92, 108);
            cmbTecnico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTecnico.ForeColor = Color.FromArgb(235, 239, 240);
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbTecnico.Items.AddRange(new object[] { "Seleccionar...", "Juan Pablo", "Juan Pérez", "Fatima Benalcazar" });
            cmbTecnico.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbTecnico.Location = new Point(19, 377);
            cmbTecnico.Margin = new Padding(4, 5, 4, 5);
            cmbTecnico.MinimumSize = new Size(63, 0);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Padding = new Padding(0, 0, 30, 2);
            cmbTecnico.Radius = 12;
            cmbTecnico.RectColor = Color.FromArgb(148, 163, 184);
            cmbTecnico.Size = new Size(136, 37);
            cmbTecnico.SymbolSize = 24;
            cmbTecnico.TabIndex = 44;
            cmbTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTecnico.Watermark = "";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = Color.Transparent;
            lblCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCosto.ForeColor = Color.Black;
            lblCosto.Location = new Point(174, 425);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(153, 21);
            lblCosto.TabIndex = 25;
            lblCosto.Text = "Costo estimado ($)";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.Transparent;
            txtObservaciones.FillColor = Color.FromArgb(240, 244, 248);
            txtObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.ForeColor = Color.FromArgb(75, 92, 108);
            txtObservaciones.Location = new Point(19, 268);
            txtObservaciones.Margin = new Padding(4, 5, 4, 5);
            txtObservaciones.MaxLength = 255;
            txtObservaciones.Minimum = 0D;
            txtObservaciones.MinimumSize = new Size(1, 16);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Padding = new Padding(5);
            txtObservaciones.Radius = 12;
            txtObservaciones.RectColor = Color.FromArgb(240, 244, 248);
            txtObservaciones.ShowText = false;
            txtObservaciones.Size = new Size(294, 73);
            txtObservaciones.TabIndex = 24;
            txtObservaciones.TextAlignment = ContentAlignment.MiddleLeft;
            txtObservaciones.Watermark = "Observaciones preliminares";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.BackColor = Color.Transparent;
            lblFechaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaEntrega.ForeColor = Color.Black;
            lblFechaEntrega.Location = new Point(16, 425);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(147, 21);
            lblFechaEntrega.TabIndex = 24;
            lblFechaEntrega.Text = "Fecha est. entrega";
            // 
            // picReparacion
            // 
            picReparacion.BackColor = Color.Transparent;
            picReparacion.Image = (Image)resources.GetObject("picReparacion.Image");
            picReparacion.Location = new Point(19, 14);
            picReparacion.Name = "picReparacion";
            picReparacion.Size = new Size(30, 21);
            picReparacion.SizeMode = PictureBoxSizeMode.Zoom;
            picReparacion.TabIndex = 32;
            picReparacion.TabStop = false;
            // 
            // lblReparacion
            // 
            lblReparacion.AutoSize = true;
            lblReparacion.BackColor = Color.Transparent;
            lblReparacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReparacion.ForeColor = Color.FromArgb(75, 92, 108);
            lblReparacion.Location = new Point(55, 14);
            lblReparacion.Name = "lblReparacion";
            lblReparacion.Size = new Size(185, 21);
            lblReparacion.TabIndex = 6;
            lblReparacion.Text = "Datos de la Reparación";
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.BackColor = Color.Transparent;
            lblTecnico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTecnico.ForeColor = Color.Black;
            lblTecnico.Location = new Point(17, 351);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(142, 21);
            lblTecnico.TabIndex = 27;
            lblTecnico.Text = "Técnico asignado";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.BackColor = Color.Transparent;
            lblSucursal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.Black;
            lblSucursal.Location = new Point(177, 351);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(74, 21);
            lblSucursal.TabIndex = 26;
            lblSucursal.Text = "Sucursal";
            // 
            // airSeparator3
            // 
            airSeparator3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            airSeparator3.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator3.Customization = "";
            airSeparator3.Font = new Font("Verdana", 8F);
            airSeparator3.Image = null;
            airSeparator3.Location = new Point(20, 42);
            airSeparator3.Name = "airSeparator3";
            airSeparator3.NoRounding = false;
            airSeparator3.Size = new Size(293, 1);
            airSeparator3.TabIndex = 1;
            airSeparator3.Text = "airSeparator3";
            airSeparator3.Transparent = false;
            // 
            // txtDescripcionProblema
            // 
            txtDescripcionProblema.BackColor = Color.Transparent;
            txtDescripcionProblema.FillColor = Color.FromArgb(240, 244, 248);
            txtDescripcionProblema.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcionProblema.ForeColor = Color.FromArgb(75, 92, 108);
            txtDescripcionProblema.Location = new Point(19, 88);
            txtDescripcionProblema.Margin = new Padding(4, 5, 4, 5);
            txtDescripcionProblema.MaxLength = 255;
            txtDescripcionProblema.Minimum = 0D;
            txtDescripcionProblema.MinimumSize = new Size(1, 16);
            txtDescripcionProblema.Multiline = true;
            txtDescripcionProblema.Name = "txtDescripcionProblema";
            txtDescripcionProblema.Padding = new Padding(5);
            txtDescripcionProblema.Radius = 12;
            txtDescripcionProblema.RectColor = Color.FromArgb(240, 244, 248);
            txtDescripcionProblema.ShowText = false;
            txtDescripcionProblema.Size = new Size(294, 141);
            txtDescripcionProblema.TabIndex = 23;
            txtDescripcionProblema.TextAlignment = ContentAlignment.MiddleLeft;
            txtDescripcionProblema.Watermark = "Describe el problema tal como lo describe el cliente...";
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.BackColor = Color.Transparent;
            lblProblema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProblema.ForeColor = Color.Black;
            lblProblema.Location = new Point(17, 62);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(164, 21);
            lblProblema.TabIndex = 17;
            lblProblema.Text = "Problema reportado";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.BackColor = Color.Transparent;
            lblDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.Black;
            lblDiagnostico.Location = new Point(20, 242);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(153, 21);
            lblDiagnostico.TabIndex = 19;
            lblDiagnostico.Text = "Diagnóstico inicial";
            // 
            // pnlDatosCliente
            // 
            pnlDatosCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlDatosCliente.AutoSize = true;
            pnlDatosCliente.BackColor = Color.Transparent;
            pnlDatosCliente.Controls.Add(pictureBox6);
            pnlDatosCliente.Controls.Add(lbId);
            pnlDatosCliente.Controls.Add(txtIdentificacionCliente);
            pnlDatosCliente.Controls.Add(txtCorreo);
            pnlDatosCliente.Controls.Add(txtNumeroTelefonico);
            pnlDatosCliente.Controls.Add(lblCorreo);
            pnlDatosCliente.Controls.Add(txtNombres);
            pnlDatosCliente.Controls.Add(pictureBox5);
            pnlDatosCliente.Controls.Add(lblTelefono);
            pnlDatosCliente.Controls.Add(lblCliente);
            pnlDatosCliente.Controls.Add(airSeparator1);
            pnlDatosCliente.Controls.Add(lblDatosCliente);
            pnlDatosCliente.FillColor = Color.FromArgb(198, 199, 189);
            pnlDatosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDatosCliente.ForeColor = Color.Black;
            pnlDatosCliente.Location = new Point(31, 210);
            pnlDatosCliente.Margin = new Padding(4, 5, 4, 5);
            pnlDatosCliente.MinimumSize = new Size(1, 1);
            pnlDatosCliente.Name = "pnlDatosCliente";
            pnlDatosCliente.Radius = 12;
            pnlDatosCliente.RectColor = Color.FromArgb(198, 199, 189);
            pnlDatosCliente.Size = new Size(330, 370);
            pnlDatosCliente.TabIndex = 3;
            pnlDatosCliente.Text = null;
            pnlDatosCliente.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(17, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 21);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 48;
            pictureBox6.TabStop = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbId.ForeColor = Color.Black;
            lbId.Location = new Point(19, 134);
            lbId.Name = "lbId";
            lbId.Size = new Size(164, 21);
            lbId.TabIndex = 17;
            lbId.Text = "Cedula de Identidad";
            // 
            // txtIdentificacionCliente
            // 
            txtIdentificacionCliente.FillColor = Color.FromArgb(240, 244, 248);
            txtIdentificacionCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentificacionCliente.ForeColor = Color.FromArgb(75, 92, 108);
            txtIdentificacionCliente.Location = new Point(18, 160);
            txtIdentificacionCliente.Margin = new Padding(4, 5, 4, 5);
            txtIdentificacionCliente.Maximum = 0D;
            txtIdentificacionCliente.MaxLength = 10;
            txtIdentificacionCliente.Minimum = 0D;
            txtIdentificacionCliente.MinimumSize = new Size(1, 16);
            txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            txtIdentificacionCliente.Padding = new Padding(5);
            txtIdentificacionCliente.Radius = 12;
            txtIdentificacionCliente.RectColor = Color.FromArgb(240, 244, 248);
            txtIdentificacionCliente.ShowText = false;
            txtIdentificacionCliente.Size = new Size(294, 37);
            txtIdentificacionCliente.TabIndex = 16;
            txtIdentificacionCliente.TextAlignment = ContentAlignment.MiddleLeft;
            txtIdentificacionCliente.Watermark = "Ej. 1203807183";
            txtIdentificacionCliente.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // txtCorreo
            // 
            txtCorreo.FillColor = Color.FromArgb(240, 244, 248);
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.FromArgb(75, 92, 108);
            txtCorreo.Location = new Point(18, 304);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 255;
            txtCorreo.Minimum = 0D;
            txtCorreo.MinimumSize = new Size(1, 16);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(5);
            txtCorreo.Radius = 12;
            txtCorreo.RectColor = Color.FromArgb(240, 244, 248);
            txtCorreo.ShowText = false;
            txtCorreo.Size = new Size(294, 37);
            txtCorreo.TabIndex = 13;
            txtCorreo.TextAlignment = ContentAlignment.MiddleLeft;
            txtCorreo.Watermark = "correo@ejemplo.com";
            txtCorreo.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.FillColor = Color.FromArgb(240, 244, 248);
            txtNumeroTelefonico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroTelefonico.ForeColor = Color.FromArgb(75, 92, 108);
            txtNumeroTelefonico.Location = new Point(19, 234);
            txtNumeroTelefonico.Margin = new Padding(4, 5, 4, 5);
            txtNumeroTelefonico.Maximum = 0D;
            txtNumeroTelefonico.MaxLength = 10;
            txtNumeroTelefonico.Minimum = 0D;
            txtNumeroTelefonico.MinimumSize = new Size(1, 16);
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.Padding = new Padding(5);
            txtNumeroTelefonico.Radius = 12;
            txtNumeroTelefonico.RectColor = Color.FromArgb(240, 244, 248);
            txtNumeroTelefonico.ShowText = false;
            txtNumeroTelefonico.Size = new Size(294, 37);
            txtNumeroTelefonico.TabIndex = 14;
            txtNumeroTelefonico.TextAlignment = ContentAlignment.MiddleLeft;
            txtNumeroTelefonico.Watermark = "0993425009";
            txtNumeroTelefonico.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.Black;
            lblCorreo.Location = new Point(17, 278);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(151, 21);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtNombres
            // 
            txtNombres.FillColor = Color.FromArgb(240, 244, 248);
            txtNombres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombres.ForeColor = Color.FromArgb(75, 92, 108);
            txtNombres.Location = new Point(19, 88);
            txtNombres.Margin = new Padding(4, 5, 4, 5);
            txtNombres.MaxLength = 255;
            txtNombres.Minimum = 0D;
            txtNombres.MinimumSize = new Size(1, 16);
            txtNombres.Name = "txtNombres";
            txtNombres.Padding = new Padding(5);
            txtNombres.Radius = 12;
            txtNombres.RectColor = Color.FromArgb(240, 244, 248);
            txtNombres.ShowText = false;
            txtNombres.Size = new Size(294, 37);
            txtNombres.TabIndex = 14;
            txtNombres.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombres.Watermark = "Nombre y apellidos";
            txtNombres.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Location = new Point(-69, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(20, 208);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(146, 21);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono / Celular";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.FromArgb(75, 92, 108);
            lblCliente.Location = new Point(55, 13);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(140, 21);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Datos del Cliente";
            // 
            // airSeparator1
            // 
            airSeparator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            airSeparator1.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(19, 42);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(293, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.ForeColor = Color.Black;
            lblDatosCliente.Location = new Point(19, 62);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(150, 21);
            lblDatosCliente.TabIndex = 7;
            lblDatosCliente.Text = "Nombre completo";
            // 
            // pnlDispositivo
            // 
            pnlDispositivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlDispositivo.BackColor = Color.Transparent;
            pnlDispositivo.Controls.Add(lblEstado);
            pnlDispositivo.Controls.Add(cmbEstado);
            pnlDispositivo.Controls.Add(btnTelefono);
            pnlDispositivo.Controls.Add(lblTipoDispositivo);
            pnlDispositivo.Controls.Add(txtModelo);
            pnlDispositivo.Controls.Add(btnComputadora);
            pnlDispositivo.Controls.Add(txtMarca);
            pnlDispositivo.Controls.Add(txtColor);
            pnlDispositivo.Controls.Add(txtSerie);
            pnlDispositivo.Controls.Add(lblColor);
            pnlDispositivo.Controls.Add(lblSerie);
            pnlDispositivo.Controls.Add(lblModelo);
            pnlDispositivo.Controls.Add(lblMarca);
            pnlDispositivo.Controls.Add(pictureBox7);
            pnlDispositivo.Controls.Add(label5);
            pnlDispositivo.Controls.Add(airSeparator4);
            pnlDispositivo.FillColor = Color.FromArgb(198, 199, 189);
            pnlDispositivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDispositivo.Location = new Point(395, 210);
            pnlDispositivo.Margin = new Padding(4, 5, 4, 5);
            pnlDispositivo.MinimumSize = new Size(1, 1);
            pnlDispositivo.Name = "pnlDispositivo";
            pnlDispositivo.Radius = 12;
            pnlDispositivo.RectColor = Color.FromArgb(198, 199, 189);
            pnlDispositivo.Size = new Size(330, 516);
            pnlDispositivo.TabIndex = 2;
            pnlDispositivo.Text = null;
            pnlDispositivo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(16, 425);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(159, 21);
            lblEstado.TabIndex = 44;
            lblEstado.Text = "Estado en que llega";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.Transparent;
            cmbEstado.DataSource = null;
            cmbEstado.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEstado.FillColor = Color.FromArgb(75, 92, 108);
            cmbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.ForeColor = Color.FromArgb(235, 239, 240);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbEstado.Items.AddRange(new object[] { "Seleccionar estado...", "Bueno", "Regular", "Malo" });
            cmbEstado.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbEstado.Location = new Point(17, 451);
            cmbEstado.Margin = new Padding(4, 5, 4, 5);
            cmbEstado.MinimumSize = new Size(63, 0);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Padding = new Padding(0, 0, 30, 2);
            cmbEstado.Radius = 12;
            cmbEstado.RectColor = Color.FromArgb(148, 163, 184);
            cmbEstado.Size = new Size(294, 37);
            cmbEstado.SymbolSize = 24;
            cmbEstado.TabIndex = 43;
            cmbEstado.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEstado.Watermark = "";
            cmbEstado.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // btnTelefono
            // 
            btnTelefono.FillColor = Color.FromArgb(75, 92, 108);
            btnTelefono.FillHoverColor = Color.FromArgb(80, 160, 255);
            btnTelefono.FillPressColor = Color.FromArgb(0, 150, 137);
            btnTelefono.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTelefono.ForeColor = Color.FromArgb(240, 244, 248);
            btnTelefono.Location = new Point(176, 88);
            btnTelefono.MinimumSize = new Size(1, 1);
            btnTelefono.Name = "btnTelefono";
            btnTelefono.Radius = 12;
            btnTelefono.RectColor = Color.FromArgb(75, 92, 108);
            btnTelefono.RectPressColor = Color.FromArgb(0, 150, 137);
            btnTelefono.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnTelefono.Size = new Size(136, 37);
            btnTelefono.TabIndex = 6;
            btnTelefono.Text = "Teléfono";
            btnTelefono.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTelefono.Click += btnTelefono_Click;
            // 
            // lblTipoDispositivo
            // 
            lblTipoDispositivo.AutoSize = true;
            lblTipoDispositivo.BackColor = Color.Transparent;
            lblTipoDispositivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDispositivo.ForeColor = Color.Black;
            lblTipoDispositivo.Location = new Point(18, 62);
            lblTipoDispositivo.Name = "lblTipoDispositivo";
            lblTipoDispositivo.Size = new Size(155, 21);
            lblTipoDispositivo.TabIndex = 10;
            lblTipoDispositivo.Text = "Tipo de dispositivo";
            // 
            // txtModelo
            // 
            txtModelo.FillColor = Color.FromArgb(240, 244, 248);
            txtModelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.ForeColor = Color.FromArgb(75, 92, 108);
            txtModelo.Location = new Point(18, 234);
            txtModelo.Margin = new Padding(4, 5, 4, 5);
            txtModelo.MaxLength = 255;
            txtModelo.Minimum = 0D;
            txtModelo.MinimumSize = new Size(1, 16);
            txtModelo.Name = "txtModelo";
            txtModelo.Padding = new Padding(5);
            txtModelo.Radius = 12;
            txtModelo.RectColor = Color.FromArgb(240, 244, 248);
            txtModelo.ShowText = false;
            txtModelo.Size = new Size(294, 37);
            txtModelo.TabIndex = 42;
            txtModelo.TextAlignment = ContentAlignment.MiddleLeft;
            txtModelo.Watermark = "Ej. Galaxy S26";
            txtModelo.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // btnComputadora
            // 
            btnComputadora.FillColor = Color.FromArgb(75, 92, 108);
            btnComputadora.FillHoverColor = Color.FromArgb(80, 160, 255);
            btnComputadora.FillPressColor = Color.FromArgb(0, 150, 137);
            btnComputadora.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnComputadora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComputadora.ForeColor = Color.FromArgb(240, 244, 248);
            btnComputadora.Location = new Point(18, 88);
            btnComputadora.MinimumSize = new Size(1, 1);
            btnComputadora.Name = "btnComputadora";
            btnComputadora.Radius = 12;
            btnComputadora.RectColor = Color.FromArgb(75, 92, 108);
            btnComputadora.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnComputadora.RectPressColor = Color.FromArgb(0, 150, 137);
            btnComputadora.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnComputadora.Size = new Size(136, 37);
            btnComputadora.TabIndex = 5;
            btnComputadora.Text = "Computadora";
            btnComputadora.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnComputadora.TipsForeColor = Color.Transparent;
            btnComputadora.Click += btnComputadora_Click;
            // 
            // txtMarca
            // 
            txtMarca.FillColor = Color.FromArgb(240, 244, 248);
            txtMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.ForeColor = Color.FromArgb(75, 92, 108);
            txtMarca.Location = new Point(18, 160);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.MaxLength = 255;
            txtMarca.Minimum = 0D;
            txtMarca.MinimumSize = new Size(1, 16);
            txtMarca.Name = "txtMarca";
            txtMarca.Padding = new Padding(5);
            txtMarca.Radius = 12;
            txtMarca.RectColor = Color.FromArgb(240, 244, 248);
            txtMarca.ShowText = false;
            txtMarca.Size = new Size(294, 37);
            txtMarca.TabIndex = 41;
            txtMarca.TextAlignment = ContentAlignment.MiddleLeft;
            txtMarca.Watermark = "Ej. Samsung";
            txtMarca.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // txtColor
            // 
            txtColor.FillColor = Color.FromArgb(240, 244, 248);
            txtColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.ForeColor = Color.FromArgb(75, 92, 108);
            txtColor.Location = new Point(18, 377);
            txtColor.Margin = new Padding(4, 5, 4, 5);
            txtColor.MaxLength = 255;
            txtColor.Minimum = 0D;
            txtColor.MinimumSize = new Size(1, 16);
            txtColor.Name = "txtColor";
            txtColor.Padding = new Padding(5);
            txtColor.Radius = 12;
            txtColor.RectColor = Color.FromArgb(240, 244, 248);
            txtColor.ShowText = false;
            txtColor.Size = new Size(294, 37);
            txtColor.TabIndex = 40;
            txtColor.TextAlignment = ContentAlignment.MiddleLeft;
            txtColor.Watermark = "Ej. Negro";
            txtColor.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // txtSerie
            // 
            txtSerie.FillColor = Color.FromArgb(240, 244, 248);
            txtSerie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSerie.ForeColor = Color.FromArgb(75, 92, 108);
            txtSerie.Location = new Point(18, 304);
            txtSerie.Margin = new Padding(4, 5, 4, 5);
            txtSerie.MaxLength = 15;
            txtSerie.Minimum = 0D;
            txtSerie.MinimumSize = new Size(1, 16);
            txtSerie.Name = "txtSerie";
            txtSerie.Padding = new Padding(5);
            txtSerie.Radius = 12;
            txtSerie.RectColor = Color.FromArgb(240, 244, 248);
            txtSerie.ShowText = false;
            txtSerie.Size = new Size(294, 37);
            txtSerie.TabIndex = 36;
            txtSerie.TextAlignment = ContentAlignment.MiddleLeft;
            txtSerie.Watermark = "15 dígitos";
            txtSerie.WatermarkColor = Color.FromArgb(198, 199, 189);
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.ForeColor = Color.Black;
            lblColor.Location = new Point(17, 351);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(51, 21);
            lblColor.TabIndex = 39;
            lblColor.Text = "Color";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSerie.ForeColor = Color.Black;
            lblSerie.Location = new Point(17, 278);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(97, 21);
            lblSerie.TabIndex = 38;
            lblSerie.Text = "Serie / IMEI";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.ForeColor = Color.Black;
            lblModelo.Location = new Point(18, 208);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(69, 21);
            lblModelo.TabIndex = 37;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.ForeColor = Color.Black;
            lblMarca.Location = new Point(16, 134);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(57, 21);
            lblMarca.TabIndex = 34;
            lblMarca.Text = "Marca";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 13);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 21);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(75, 92, 108);
            label5.Location = new Point(54, 14);
            label5.Name = "label5";
            label5.Size = new Size(172, 21);
            label5.TabIndex = 7;
            label5.Text = "Datos del Dispositivo";
            // 
            // airSeparator4
            // 
            airSeparator4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            airSeparator4.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator4.Customization = "";
            airSeparator4.Font = new Font("Verdana", 8F);
            airSeparator4.Image = null;
            airSeparator4.Location = new Point(17, 42);
            airSeparator4.Name = "airSeparator4";
            airSeparator4.NoRounding = false;
            airSeparator4.Size = new Size(293, 1);
            airSeparator4.TabIndex = 2;
            airSeparator4.Text = "airSeparator4";
            airSeparator4.Transparent = false;
            // 
            // ucRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(235, 239, 240);
            Controls.Add(pnlCentral);
            Name = "ucRecepcion";
            Size = new Size(1123, 832);
            Load += ucRecepcion_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlCentral.ResumeLayout(false);
            pnlCentral.PerformLayout();
            pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flpEquipos.ResumeLayout(false);
            flpEquipos.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picReparacion).EndInit();
            pnlDatosCliente.ResumeLayout(false);
            pnlDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlDispositivo.ResumeLayout(false);
            pnlDispositivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Label lblFecha;
        private Label lblOrden;
        private Panel pnlCentral;
        private Sunny.UI.UIPanel pnlDispositivo;
        private Sunny.UI.UITextBox txtMarca;
        private Sunny.UI.UITextBox txtColor;
        private Sunny.UI.UITextBox txtSerie;
        private Label lblColor;
        private Label lblSerie;
        private Label lblModelo;
        private Label lblMarca;
        private PictureBox pictureBox7;
        private Label label5;
        private ReaLTaiizor.Controls.AirSeparator airSeparator4;
        private Label lblReparacion;
        private PictureBox picReparacion;
        private Sunny.UI.UITextBox txtObservaciones;
        private Sunny.UI.UITextBox txtDescripcionProblema;
        private Label lblTecnico;
        private Label lblSucursal;
        private Label lblCosto;
        private Label lblFechaEntrega;
        private Label lblDiagnostico;
        private Label lblProblema;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private Label lblTelefono;
        private Label lblDatosCliente;
        private Label lblCliente;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private PictureBox pictureBox5;
        private Sunny.UI.UITextBox txtNombres;
        private Sunny.UI.UITextBox txtNumeroTelefonico;
        private Panel pnlInferior;
        private Sunny.UI.UIButton btnLimpiar;
        private Sunny.UI.UITextBox txtModelo;
        private Label lblEstado;
        private Sunny.UI.UIComboBox cmbEstado;
        private Sunny.UI.UIPanel pnlDatosCliente;
        private Sunny.UI.UITextBox txtCorreo;
        private Label lblCorreo;
        private Label lblTipoDispositivo;
        private Sunny.UI.UIButton btnTelefono;
        private Sunny.UI.UIButton btnComputadora;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnGuardarRegistro;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cmbTecnico;
        private Sunny.UI.UIComboBox cmbSucursal;
        private Sunny.UI.UIDatetimePicker dtmFecha;
        private Sunny.UI.UITextBox txtCosto;
        private Label lbId;
        private Sunny.UI.UITextBox txtIdentificacionCliente;
        private Sunny.UI.UIFlowLayoutPanel flpEquipos;
        private Label lblEquipos;
        private Sunny.UI.UIButton btnAgregarEquipo;
        private Sunny.UI.UIButton btnEquipo;
        private PictureBox pictureBox6;
    }
}
