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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDevolucion));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            cmbListaOrdenes = new Sunny.UI.UIComboBox();
            btnBuscar = new Sunny.UI.UIButton();
            lblOrden = new Label();
            txtBuscarOrden = new Sunny.UI.UITextBox();
            pnlPrincipal = new Panel();
            pnlFormaDePago = new Sunny.UI.UIPanel();
            pnlTotalCobrar = new Sunny.UI.UIPanel();
            lblTotalCobrar = new Label();
            txtObservaciones = new Sunny.UI.UITextBox();
            label3 = new Label();
            label2 = new Label();
            btnReparado = new Sunny.UI.UIButton();
            btnSinReparar = new Sunny.UI.UIButton();
            btnParcial = new Sunny.UI.UIButton();
            label1 = new Label();
            cmbFormaPago = new Sunny.UI.UIComboBox();
            lblRegistrarEntrega = new Label();
            airSeparator4 = new ReaLTaiizor.Controls.AirSeparator();
            pnlDesgloseCosto = new Sunny.UI.UIPanel();
            label4 = new Label();
            lblTotalDesglose = new Label();
            dgvDesglose = new Sunny.UI.UIDataGridView();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            airSeparator5 = new ReaLTaiizor.Controls.AirSeparator();
            lblDesglose = new Label();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            pnlTrabajoRealizado = new Sunny.UI.UIPanel();
            lblDescripcionTrabajo = new Label();
            lblTrabajoRealizado = new Label();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            pnlResumen = new Sunny.UI.UIPanel();
            lblCedula = new Label();
            lblTituloCedula = new Label();
            lblFechaIngreso = new Label();
            lblTecnicoAsignado = new Label();
            lblDispositivo = new Label();
            lblTelefono = new Label();
            lblCliente = new Label();
            lblNumeroOrden = new Label();
            label6 = new Label();
            label5 = new Label();
            lblTituloDispositivo = new Label();
            lblTituloTelefono = new Label();
            lblTituloCliente = new Label();
            lblTituloorden = new Label();
            pictureBox2 = new PictureBox();
            lblResumen = new Label();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip(components);
            pdComprobante = new PrintDialog();
            btnRegistraEntrega = new Sunny.UI.UISymbolButton();
            btnComprobante = new Sunny.UI.UISymbolButton();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            pnlFormaDePago.SuspendLayout();
            pnlTotalCobrar.SuspendLayout();
            pnlDesgloseCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesglose).BeginInit();
            pnlTrabajoRealizado.SuspendLayout();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(243, 246, 250);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1125, 59);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(243, 246, 250);
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(24, 43, 62);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 59);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Devolución / Entrega";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.FromArgb(243, 246, 250);
            pnlInformacion.Controls.Add(cmbListaOrdenes);
            pnlInformacion.Controls.Add(btnBuscar);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Controls.Add(txtBuscarOrden);
            pnlInformacion.ForeColor = Color.White;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 100);
            pnlInformacion.TabIndex = 2;
            // 
            // cmbListaOrdenes
            // 
            cmbListaOrdenes.BackColor = Color.Transparent;
            cmbListaOrdenes.DataSource = null;
            cmbListaOrdenes.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbListaOrdenes.FillColor = Color.White;
            cmbListaOrdenes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbListaOrdenes.ForeColor = Color.FromArgb(70, 86, 103);
            cmbListaOrdenes.FormattingEnabled = true;
            cmbListaOrdenes.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbListaOrdenes.Items.AddRange(new object[] { "Seleccionar...", "Efectivo", "Transferencia" });
            cmbListaOrdenes.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbListaOrdenes.Location = new Point(351, 45);
            cmbListaOrdenes.Margin = new Padding(4, 5, 4, 5);
            cmbListaOrdenes.MinimumSize = new Size(63, 0);
            cmbListaOrdenes.Name = "cmbListaOrdenes";
            cmbListaOrdenes.Padding = new Padding(0, 0, 30, 2);
            cmbListaOrdenes.Radius = 12;
            cmbListaOrdenes.RectColor = Color.FromArgb(220, 226, 232);
            cmbListaOrdenes.RectDisableColor = Color.FromArgb(0, 165, 155);
            cmbListaOrdenes.Size = new Size(294, 37);
            cmbListaOrdenes.SymbolSize = 24;
            cmbListaOrdenes.TabIndex = 25;
            cmbListaOrdenes.TextAlignment = ContentAlignment.MiddleLeft;
            cmbListaOrdenes.Watermark = "";
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(677, 45);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.RectColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Size = new Size(112, 37);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrden.ForeColor = Color.FromArgb(75, 92, 108);
            lblOrden.Location = new Point(32, 14);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(311, 21);
            lblOrden.TabIndex = 19;
            lblOrden.Text = "Ingrese el número de cedula y elija la orden";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.ButtonRectHoverColor = Color.FromArgb(0, 165, 155);
            txtBuscarOrden.ButtonRectPressColor = Color.FromArgb(0, 165, 155);
            txtBuscarOrden.ButtonStyleInherited = false;
            txtBuscarOrden.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrden.ForeColor = Color.FromArgb(70, 86, 103);
            txtBuscarOrden.Location = new Point(28, 45);
            txtBuscarOrden.Margin = new Padding(4, 5, 4, 5);
            txtBuscarOrden.MinimumSize = new Size(1, 16);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Padding = new Padding(5);
            txtBuscarOrden.Radius = 12;
            txtBuscarOrden.RectColor = Color.FromArgb(220, 226, 232);
            txtBuscarOrden.ShowText = false;
            txtBuscarOrden.Size = new Size(294, 37);
            txtBuscarOrden.Symbol = 62144;
            txtBuscarOrden.TabIndex = 3;
            txtBuscarOrden.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarOrden.Watermark = "Ej. 0953485638";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.BackColor = Color.FromArgb(243, 246, 250);
            pnlPrincipal.Controls.Add(btnComprobante);
            pnlPrincipal.Controls.Add(btnRegistraEntrega);
            pnlPrincipal.Controls.Add(pnlSuperior);
            pnlPrincipal.Controls.Add(pnlInformacion);
            pnlPrincipal.Controls.Add(pnlFormaDePago);
            pnlPrincipal.Controls.Add(pnlDesgloseCosto);
            pnlPrincipal.Controls.Add(pnlTrabajoRealizado);
            pnlPrincipal.Controls.Add(pnlResumen);
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1123, 832);
            pnlPrincipal.TabIndex = 3;
            // 
            // pnlFormaDePago
            // 
            pnlFormaDePago.Controls.Add(pnlTotalCobrar);
            pnlFormaDePago.Controls.Add(txtObservaciones);
            pnlFormaDePago.Controls.Add(label3);
            pnlFormaDePago.Controls.Add(label2);
            pnlFormaDePago.Controls.Add(btnReparado);
            pnlFormaDePago.Controls.Add(btnSinReparar);
            pnlFormaDePago.Controls.Add(btnParcial);
            pnlFormaDePago.Controls.Add(label1);
            pnlFormaDePago.Controls.Add(cmbFormaPago);
            pnlFormaDePago.Controls.Add(lblRegistrarEntrega);
            pnlFormaDePago.Controls.Add(airSeparator4);
            pnlFormaDePago.FillColor = Color.White;
            pnlFormaDePago.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFormaDePago.Location = new Point(560, 180);
            pnlFormaDePago.Margin = new Padding(4, 5, 4, 5);
            pnlFormaDePago.MinimumSize = new Size(1, 1);
            pnlFormaDePago.Name = "pnlFormaDePago";
            pnlFormaDePago.Radius = 12;
            pnlFormaDePago.RectColor = Color.FromArgb(225, 230, 235);
            pnlFormaDePago.Size = new Size(530, 475);
            pnlFormaDePago.TabIndex = 6;
            pnlFormaDePago.Text = null;
            pnlFormaDePago.TextAlignment = ContentAlignment.MiddleCenter;
            pnlFormaDePago.Visible = false;
            // 
            // pnlTotalCobrar
            // 
            pnlTotalCobrar.BackColor = Color.Transparent;
            pnlTotalCobrar.Controls.Add(lblTotalCobrar);
            pnlTotalCobrar.FillColor = Color.FromArgb(75, 92, 108);
            pnlTotalCobrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlTotalCobrar.ForeColor = Color.FromArgb(235, 239, 240);
            pnlTotalCobrar.Location = new Point(18, 360);
            pnlTotalCobrar.Margin = new Padding(4, 5, 4, 5);
            pnlTotalCobrar.MinimumSize = new Size(1, 1);
            pnlTotalCobrar.Name = "pnlTotalCobrar";
            pnlTotalCobrar.Radius = 12;
            pnlTotalCobrar.RectColor = Color.FromArgb(75, 92, 108);
            pnlTotalCobrar.Size = new Size(493, 90);
            pnlTotalCobrar.TabIndex = 33;
            pnlTotalCobrar.Text = "Total a cobrar";
            pnlTotalCobrar.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lblTotalCobrar
            // 
            lblTotalCobrar.AutoSize = true;
            lblTotalCobrar.BackColor = Color.Transparent;
            lblTotalCobrar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCobrar.ForeColor = Color.Lime;
            lblTotalCobrar.Location = new Point(220, 38);
            lblTotalCobrar.Name = "lblTotalCobrar";
            lblTotalCobrar.Size = new Size(51, 40);
            lblTotalCobrar.TabIndex = 15;
            lblTotalCobrar.Text = "$0";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.Transparent;
            txtObservaciones.FillColor = Color.FromArgb(244, 244, 244);
            txtObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.ForeColor = Color.FromArgb(24, 43, 62);
            txtObservaciones.Location = new Point(18, 240);
            txtObservaciones.Margin = new Padding(4, 5, 4, 5);
            txtObservaciones.MaxLength = 255;
            txtObservaciones.Minimum = 0D;
            txtObservaciones.MinimumSize = new Size(1, 16);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Padding = new Padding(5);
            txtObservaciones.Radius = 12;
            txtObservaciones.RectColor = Color.FromArgb(220, 226, 232);
            txtObservaciones.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtObservaciones.ShowText = false;
            txtObservaciones.Size = new Size(493, 110);
            txtObservaciones.TabIndex = 32;
            txtObservaciones.TextAlignment = ContentAlignment.MiddleLeft;
            txtObservaciones.Watermark = "Notas Adicionales";
            txtObservaciones.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 214);
            label3.Name = "label3";
            label3.Size = new Size(208, 21);
            label3.TabIndex = 31;
            label3.Text = "Observaciones de entrega";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 138);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 30;
            label2.Text = "Condición en que se entrega";
            // 
            // btnReparado
            // 
            btnReparado.BackColor = Color.Transparent;
            btnReparado.FillColor = Color.FromArgb(239, 243, 247);
            btnReparado.FillHoverColor = Color.Transparent;
            btnReparado.FillPressColor = Color.FromArgb(0, 150, 137);
            btnReparado.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReparado.ForeColor = Color.FromArgb(70, 86, 103);
            btnReparado.Location = new Point(18, 162);
            btnReparado.MinimumSize = new Size(1, 1);
            btnReparado.Name = "btnReparado";
            btnReparado.Radius = 12;
            btnReparado.RectColor = Color.FromArgb(220, 226, 232);
            btnReparado.RectHoverColor = Color.Transparent;
            btnReparado.RectPressColor = Color.FromArgb(0, 150, 137);
            btnReparado.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparado.Size = new Size(150, 37);
            btnReparado.TabIndex = 29;
            btnReparado.Text = "Reparado";
            btnReparado.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReparado.TipsForeColor = Color.Transparent;
            btnReparado.Click += uiButton3_Click;
            // 
            // btnSinReparar
            // 
            btnSinReparar.BackColor = Color.Transparent;
            btnSinReparar.FillColor = Color.FromArgb(239, 243, 247);
            btnSinReparar.FillHoverColor = Color.Transparent;
            btnSinReparar.FillPressColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSinReparar.ForeColor = Color.FromArgb(70, 86, 103);
            btnSinReparar.Location = new Point(361, 162);
            btnSinReparar.MinimumSize = new Size(1, 1);
            btnSinReparar.Name = "btnSinReparar";
            btnSinReparar.Radius = 12;
            btnSinReparar.RectColor = Color.FromArgb(220, 226, 232);
            btnSinReparar.RectHoverColor = Color.Transparent;
            btnSinReparar.RectPressColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.Size = new Size(150, 37);
            btnSinReparar.TabIndex = 28;
            btnSinReparar.Text = "Sin Reparación";
            btnSinReparar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSinReparar.TipsForeColor = Color.Transparent;
            btnSinReparar.Click += btnSinReparar_Click;
            // 
            // btnParcial
            // 
            btnParcial.BackColor = Color.Transparent;
            btnParcial.FillColor = Color.FromArgb(239, 243, 247);
            btnParcial.FillHoverColor = Color.Transparent;
            btnParcial.FillPressColor = Color.FromArgb(0, 150, 137);
            btnParcial.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnParcial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnParcial.ForeColor = Color.FromArgb(70, 86, 103);
            btnParcial.Location = new Point(189, 162);
            btnParcial.MinimumSize = new Size(1, 1);
            btnParcial.Name = "btnParcial";
            btnParcial.Radius = 12;
            btnParcial.RectColor = Color.FromArgb(220, 226, 232);
            btnParcial.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnParcial.RectPressColor = Color.FromArgb(0, 150, 137);
            btnParcial.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnParcial.Size = new Size(150, 37);
            btnParcial.TabIndex = 27;
            btnParcial.Text = "Parcial";
            btnParcial.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnParcial.TipsForeColor = Color.Transparent;
            btnParcial.Click += btnParcial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 25;
            label1.Text = "Forma de pago ";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.BackColor = Color.Transparent;
            cmbFormaPago.DataSource = null;
            cmbFormaPago.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbFormaPago.FillColor = Color.White;
            cmbFormaPago.FillColor2 = Color.FromArgb(240, 252, 251);
            cmbFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPago.ForeColor = Color.FromArgb(70, 86, 103);
            cmbFormaPago.ForeDisableColor = Color.FromArgb(0, 165, 155);
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbFormaPago.Items.AddRange(new object[] { "Seleccionar...", "Efectivo", "Transferencia" });
            cmbFormaPago.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbFormaPago.Location = new Point(18, 86);
            cmbFormaPago.Margin = new Padding(4, 5, 4, 5);
            cmbFormaPago.MinimumSize = new Size(63, 0);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Padding = new Padding(0, 0, 30, 2);
            cmbFormaPago.Radius = 12;
            cmbFormaPago.RectColor = Color.FromArgb(220, 226, 232);
            cmbFormaPago.RectDisableColor = Color.FromArgb(0, 165, 155);
            cmbFormaPago.Size = new Size(493, 37);
            cmbFormaPago.SymbolSize = 24;
            cmbFormaPago.TabIndex = 24;
            cmbFormaPago.TextAlignment = ContentAlignment.MiddleLeft;
            cmbFormaPago.Watermark = "";
            cmbFormaPago.WatermarkColor = Color.FromArgb(145, 158, 172);
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // lblRegistrarEntrega
            // 
            lblRegistrarEntrega.AutoSize = true;
            lblRegistrarEntrega.BackColor = Color.Transparent;
            lblRegistrarEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarEntrega.ForeColor = Color.FromArgb(24, 43, 62);
            lblRegistrarEntrega.Location = new Point(18, 13);
            lblRegistrarEntrega.Name = "lblRegistrarEntrega";
            lblRegistrarEntrega.Size = new Size(141, 21);
            lblRegistrarEntrega.TabIndex = 2;
            lblRegistrarEntrega.Text = "Registrar entrega";
            // 
            // airSeparator4
            // 
            airSeparator4.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator4.Customization = "";
            airSeparator4.Font = new Font("Verdana", 8F);
            airSeparator4.Image = null;
            airSeparator4.Location = new Point(18, 42);
            airSeparator4.Name = "airSeparator4";
            airSeparator4.NoRounding = false;
            airSeparator4.Size = new Size(493, 1);
            airSeparator4.TabIndex = 1;
            airSeparator4.Text = "airSeparator4";
            airSeparator4.Transparent = false;
            // 
            // pnlDesgloseCosto
            // 
            pnlDesgloseCosto.Controls.Add(label4);
            pnlDesgloseCosto.Controls.Add(lblTotalDesglose);
            pnlDesgloseCosto.Controls.Add(dgvDesglose);
            pnlDesgloseCosto.Controls.Add(airSeparator5);
            pnlDesgloseCosto.Controls.Add(lblDesglose);
            pnlDesgloseCosto.Controls.Add(airSeparator3);
            pnlDesgloseCosto.FillColor = Color.White;
            pnlDesgloseCosto.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDesgloseCosto.Location = new Point(31, 610);
            pnlDesgloseCosto.Margin = new Padding(4, 5, 4, 5);
            pnlDesgloseCosto.MinimumSize = new Size(1, 1);
            pnlDesgloseCosto.Name = "pnlDesgloseCosto";
            pnlDesgloseCosto.Radius = 12;
            pnlDesgloseCosto.RectColor = Color.FromArgb(225, 230, 235);
            pnlDesgloseCosto.Size = new Size(500, 200);
            pnlDesgloseCosto.TabIndex = 5;
            pnlDesgloseCosto.Text = null;
            pnlDesgloseCosto.TextAlignment = ContentAlignment.MiddleCenter;
            pnlDesgloseCosto.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(24, 43, 62);
            label4.Location = new Point(18, 164);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 10;
            label4.Text = "Total";
            // 
            // lblTotalDesglose
            // 
            lblTotalDesglose.AutoSize = true;
            lblTotalDesglose.BackColor = Color.Transparent;
            lblTotalDesglose.Font = new Font("Segoe UI", 15.75F);
            lblTotalDesglose.ForeColor = Color.FromArgb(0, 150, 137);
            lblTotalDesglose.Location = new Point(407, 164);
            lblTotalDesglose.Name = "lblTotalDesglose";
            lblTotalDesglose.Size = new Size(23, 30);
            lblTotalDesglose.TabIndex = 9;
            lblTotalDesglose.Text = "x";
            // 
            // dgvDesglose
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(235, 243, 255);
            dgvDesglose.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvDesglose.BackgroundColor = Color.FromArgb(235, 239, 240);
            dgvDesglose.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDesglose.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvDesglose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvDesglose.ColumnHeadersHeight = 32;
            dgvDesglose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDesglose.ColumnHeadersVisible = false;
            dgvDesglose.Columns.AddRange(new DataGridViewColumn[] { colDescripcion, colCosto });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvDesglose.DefaultCellStyle = dataGridViewCellStyle10;
            dgvDesglose.EnableHeadersVisualStyles = false;
            dgvDesglose.Font = new Font("Microsoft Sans Serif", 12F);
            dgvDesglose.GridColor = Color.FromArgb(80, 160, 255);
            dgvDesglose.Location = new Point(18, 54);
            dgvDesglose.Name = "dgvDesglose";
            dgvDesglose.RectColor = Color.FromArgb(41, 53, 72);
            dgvDesglose.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvDesglose.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvDesglose.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12F);
            dgvDesglose.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvDesglose.SelectedIndex = -1;
            dgvDesglose.Size = new Size(463, 94);
            dgvDesglose.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvDesglose.TabIndex = 4;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.DataPropertyName = "colDescripcion";
            colDescripcion.HeaderText = "";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colCosto
            // 
            colCosto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCosto.DataPropertyName = "colCosto";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCosto.DefaultCellStyle = dataGridViewCellStyle9;
            colCosto.HeaderText = "";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            colCosto.Width = 20;
            // 
            // airSeparator5
            // 
            airSeparator5.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator5.Customization = "";
            airSeparator5.Font = new Font("Verdana", 8F);
            airSeparator5.Image = null;
            airSeparator5.Location = new Point(18, 160);
            airSeparator5.Name = "airSeparator5";
            airSeparator5.NoRounding = false;
            airSeparator5.Size = new Size(463, 1);
            airSeparator5.TabIndex = 3;
            airSeparator5.Text = "airSeparator5";
            airSeparator5.Transparent = false;
            // 
            // lblDesglose
            // 
            lblDesglose.AutoSize = true;
            lblDesglose.BackColor = Color.Transparent;
            lblDesglose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesglose.ForeColor = Color.FromArgb(24, 43, 62);
            lblDesglose.Location = new Point(18, 13);
            lblDesglose.Name = "lblDesglose";
            lblDesglose.Size = new Size(154, 21);
            lblDesglose.TabIndex = 2;
            lblDesglose.Text = "Desglose de costos";
            // 
            // airSeparator3
            // 
            airSeparator3.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator3.Customization = "";
            airSeparator3.Font = new Font("Verdana", 8F);
            airSeparator3.Image = null;
            airSeparator3.Location = new Point(18, 42);
            airSeparator3.Name = "airSeparator3";
            airSeparator3.NoRounding = false;
            airSeparator3.Size = new Size(463, 1);
            airSeparator3.TabIndex = 1;
            airSeparator3.Text = "airSeparator3";
            airSeparator3.Transparent = false;
            // 
            // pnlTrabajoRealizado
            // 
            pnlTrabajoRealizado.Controls.Add(lblDescripcionTrabajo);
            pnlTrabajoRealizado.Controls.Add(lblTrabajoRealizado);
            pnlTrabajoRealizado.Controls.Add(airSeparator2);
            pnlTrabajoRealizado.FillColor = Color.White;
            pnlTrabajoRealizado.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTrabajoRealizado.Location = new Point(31, 468);
            pnlTrabajoRealizado.Margin = new Padding(4, 5, 4, 5);
            pnlTrabajoRealizado.MinimumSize = new Size(1, 1);
            pnlTrabajoRealizado.Name = "pnlTrabajoRealizado";
            pnlTrabajoRealizado.Radius = 12;
            pnlTrabajoRealizado.RectColor = Color.FromArgb(225, 230, 235);
            pnlTrabajoRealizado.Size = new Size(500, 120);
            pnlTrabajoRealizado.TabIndex = 5;
            pnlTrabajoRealizado.Text = null;
            pnlTrabajoRealizado.TextAlignment = ContentAlignment.MiddleCenter;
            pnlTrabajoRealizado.Visible = false;
            // 
            // lblDescripcionTrabajo
            // 
            lblDescripcionTrabajo.BackColor = Color.Transparent;
            lblDescripcionTrabajo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionTrabajo.ForeColor = Color.Black;
            lblDescripcionTrabajo.Location = new Point(24, 57);
            lblDescripcionTrabajo.Name = "lblDescripcionTrabajo";
            lblDescripcionTrabajo.Size = new Size(455, 47);
            lblDescripcionTrabajo.TabIndex = 3;
            // 
            // lblTrabajoRealizado
            // 
            lblTrabajoRealizado.AutoSize = true;
            lblTrabajoRealizado.BackColor = Color.Transparent;
            lblTrabajoRealizado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrabajoRealizado.ForeColor = Color.FromArgb(24, 43, 62);
            lblTrabajoRealizado.Location = new Point(18, 13);
            lblTrabajoRealizado.Name = "lblTrabajoRealizado";
            lblTrabajoRealizado.Size = new Size(142, 21);
            lblTrabajoRealizado.TabIndex = 2;
            lblTrabajoRealizado.Text = "Trabajo realizado";
            // 
            // airSeparator2
            // 
            airSeparator2.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator2.Customization = "";
            airSeparator2.Font = new Font("Verdana", 8F);
            airSeparator2.Image = null;
            airSeparator2.Location = new Point(18, 42);
            airSeparator2.Name = "airSeparator2";
            airSeparator2.NoRounding = false;
            airSeparator2.Size = new Size(463, 1);
            airSeparator2.TabIndex = 1;
            airSeparator2.Text = "airSeparator2";
            airSeparator2.Transparent = false;
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.Transparent;
            pnlResumen.Controls.Add(lblCedula);
            pnlResumen.Controls.Add(lblTituloCedula);
            pnlResumen.Controls.Add(lblFechaIngreso);
            pnlResumen.Controls.Add(lblTecnicoAsignado);
            pnlResumen.Controls.Add(lblDispositivo);
            pnlResumen.Controls.Add(lblTelefono);
            pnlResumen.Controls.Add(lblCliente);
            pnlResumen.Controls.Add(lblNumeroOrden);
            pnlResumen.Controls.Add(label6);
            pnlResumen.Controls.Add(label5);
            pnlResumen.Controls.Add(lblTituloDispositivo);
            pnlResumen.Controls.Add(lblTituloTelefono);
            pnlResumen.Controls.Add(lblTituloCliente);
            pnlResumen.Controls.Add(lblTituloorden);
            pnlResumen.Controls.Add(pictureBox2);
            pnlResumen.Controls.Add(lblResumen);
            pnlResumen.Controls.Add(airSeparator1);
            pnlResumen.FillColor = Color.White;
            pnlResumen.Font = new Font("Microsoft Sans Serif", 12F);
            pnlResumen.ForeColor = Color.FromArgb(147, 162, 183);
            pnlResumen.Location = new Point(31, 180);
            pnlResumen.Margin = new Padding(4, 5, 4, 5);
            pnlResumen.MinimumSize = new Size(1, 1);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Radius = 12;
            pnlResumen.RectColor = Color.FromArgb(225, 230, 235);
            pnlResumen.Size = new Size(500, 268);
            pnlResumen.TabIndex = 4;
            pnlResumen.Text = null;
            pnlResumen.TextAlignment = ContentAlignment.MiddleCenter;
            pnlResumen.Visible = false;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.Transparent;
            lblCedula.Font = new Font("Segoe UI", 12F);
            lblCedula.ForeColor = Color.Black;
            lblCedula.Location = new Point(358, 112);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(17, 21);
            lblCedula.TabIndex = 16;
            lblCedula.Text = "x";
            // 
            // lblTituloCedula
            // 
            lblTituloCedula.AutoSize = true;
            lblTituloCedula.BackColor = Color.Transparent;
            lblTituloCedula.Font = new Font("Segoe UI", 12F);
            lblTituloCedula.ForeColor = Color.Black;
            lblTituloCedula.Location = new Point(40, 112);
            lblTituloCedula.Name = "lblTituloCedula";
            lblTituloCedula.Size = new Size(58, 21);
            lblTituloCedula.TabIndex = 15;
            lblTituloCedula.Text = "Cedula";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.BackColor = Color.Transparent;
            lblFechaIngreso.Font = new Font("Segoe UI", 12F);
            lblFechaIngreso.ForeColor = Color.Black;
            lblFechaIngreso.Location = new Point(358, 232);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(17, 21);
            lblFechaIngreso.TabIndex = 14;
            lblFechaIngreso.Text = "x";
            // 
            // lblTecnicoAsignado
            // 
            lblTecnicoAsignado.AutoSize = true;
            lblTecnicoAsignado.BackColor = Color.Transparent;
            lblTecnicoAsignado.Font = new Font("Segoe UI", 12F);
            lblTecnicoAsignado.ForeColor = Color.Black;
            lblTecnicoAsignado.Location = new Point(358, 206);
            lblTecnicoAsignado.Name = "lblTecnicoAsignado";
            lblTecnicoAsignado.Size = new Size(17, 21);
            lblTecnicoAsignado.TabIndex = 13;
            lblTecnicoAsignado.Text = "x";
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.BackColor = Color.Transparent;
            lblDispositivo.Font = new Font("Segoe UI", 12F);
            lblDispositivo.ForeColor = Color.Black;
            lblDispositivo.Location = new Point(358, 164);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(17, 21);
            lblDispositivo.TabIndex = 12;
            lblDispositivo.Text = "x";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(358, 138);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(17, 21);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "x";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 12F);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(358, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(17, 21);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "x";
            // 
            // lblNumeroOrden
            // 
            lblNumeroOrden.AutoSize = true;
            lblNumeroOrden.BackColor = Color.Transparent;
            lblNumeroOrden.Font = new Font("Segoe UI", 12F);
            lblNumeroOrden.ForeColor = Color.Black;
            lblNumeroOrden.Location = new Point(358, 60);
            lblNumeroOrden.Name = "lblNumeroOrden";
            lblNumeroOrden.Size = new Size(17, 21);
            lblNumeroOrden.TabIndex = 9;
            lblNumeroOrden.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 232);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 8;
            label6.Text = "Ingreso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 206);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 7;
            label5.Text = "Técnico";
            // 
            // lblTituloDispositivo
            // 
            lblTituloDispositivo.AutoSize = true;
            lblTituloDispositivo.BackColor = Color.Transparent;
            lblTituloDispositivo.Font = new Font("Segoe UI", 12F);
            lblTituloDispositivo.ForeColor = Color.Black;
            lblTituloDispositivo.Location = new Point(40, 164);
            lblTituloDispositivo.Name = "lblTituloDispositivo";
            lblTituloDispositivo.Size = new Size(94, 21);
            lblTituloDispositivo.TabIndex = 6;
            lblTituloDispositivo.Text = "Dispositivos";
            // 
            // lblTituloTelefono
            // 
            lblTituloTelefono.AutoSize = true;
            lblTituloTelefono.BackColor = Color.Transparent;
            lblTituloTelefono.Font = new Font("Segoe UI", 12F);
            lblTituloTelefono.ForeColor = Color.Black;
            lblTituloTelefono.Location = new Point(40, 138);
            lblTituloTelefono.Name = "lblTituloTelefono";
            lblTituloTelefono.Size = new Size(68, 21);
            lblTituloTelefono.TabIndex = 5;
            lblTituloTelefono.Text = "Teléfono";
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.BackColor = Color.Transparent;
            lblTituloCliente.Font = new Font("Segoe UI", 12F);
            lblTituloCliente.ForeColor = Color.Black;
            lblTituloCliente.Location = new Point(40, 86);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(58, 21);
            lblTituloCliente.TabIndex = 4;
            lblTituloCliente.Text = "Cliente";
            // 
            // lblTituloorden
            // 
            lblTituloorden.AutoSize = true;
            lblTituloorden.BackColor = Color.Transparent;
            lblTituloorden.Font = new Font("Segoe UI", 12F);
            lblTituloorden.ForeColor = Color.Black;
            lblTituloorden.Location = new Point(40, 60);
            lblTituloorden.Name = "lblTituloorden";
            lblTituloorden.Size = new Size(134, 21);
            lblTituloorden.TabIndex = 3;
            lblTituloorden.Text = "Número de orden";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.BackColor = Color.Transparent;
            lblResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = Color.FromArgb(24, 43, 62);
            lblResumen.Location = new Point(53, 13);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(170, 21);
            lblResumen.TabIndex = 1;
            lblResumen.Text = "Resumen de la orden";
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(18, 42);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(463, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // uiContextMenuStrip1
            // 
            uiContextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            uiContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F);
            uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            uiContextMenuStrip1.Size = new Size(61, 4);
            // 
            // pdComprobante
            // 
            pdComprobante.UseEXDialog = true;
            // 
            // btnRegistraEntrega
            // 
            btnRegistraEntrega.FillColor = Color.FromArgb(0, 165, 155);
            btnRegistraEntrega.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnRegistraEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegistraEntrega.Location = new Point(631, 664);
            btnRegistraEntrega.MinimumSize = new Size(1, 1);
            btnRegistraEntrega.Name = "btnRegistraEntrega";
            btnRegistraEntrega.Radius = 12;
            btnRegistraEntrega.Size = new Size(200, 50);
            btnRegistraEntrega.Symbol = 61562;
            btnRegistraEntrega.TabIndex = 31;
            btnRegistraEntrega.Text = "Registrar Entrega";
            btnRegistraEntrega.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnComprobante
            // 
            btnComprobante.FillColor = Color.FromArgb(239, 243, 247);
            btnComprobante.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnComprobante.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprobante.ForeColor = Color.FromArgb(70, 86, 103);
            btnComprobante.Location = new Point(837, 664);
            btnComprobante.MinimumSize = new Size(1, 1);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Radius = 12;
            btnComprobante.RectColor = Color.FromArgb(220, 226, 232);
            btnComprobante.Size = new Size(200, 50);
            btnComprobante.Symbol = 61487;
            btnComprobante.SymbolColor = Color.FromArgb(70, 86, 103);
            btnComprobante.TabIndex = 32;
            btnComprobante.Text = "Comprobante";
            btnComprobante.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnComprobante.Click += btnComprobante_Click;
            // 
            // ucDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 239, 240);
            Controls.Add(pnlPrincipal);
            Name = "ucDevolucion";
            Size = new Size(1123, 832);
            Load += ucDevolucion_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            pnlFormaDePago.ResumeLayout(false);
            pnlFormaDePago.PerformLayout();
            pnlTotalCobrar.ResumeLayout(false);
            pnlTotalCobrar.PerformLayout();
            pnlDesgloseCosto.ResumeLayout(false);
            pnlDesgloseCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesglose).EndInit();
            pnlTrabajoRealizado.ResumeLayout(false);
            pnlTrabajoRealizado.PerformLayout();
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
        private Sunny.UI.UIPanel pnlFormaDePago;
        private Sunny.UI.UIPanel pnlDesgloseCosto;
        private Sunny.UI.UIPanel pnlTrabajoRealizado;
        private Sunny.UI.UIPanel pnlResumen;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator4;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
        private Label lblRegistrarEntrega;
        private Label lblDesglose;
        private Label lblTrabajoRealizado;
        private Label lblResumen;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label lblTituloDispositivo;
        private Label lblTituloTelefono;
        private Label lblTituloCliente;
        private Label lblTituloorden;
        private Label lblDescripcionTrabajo;
        private Label lblFechaIngreso;
        private Label lblTecnicoAsignado;
        private Label lblDispositivo;
        private Label lblTelefono;
        private Label lblCliente;
        private Label lblNumeroOrden;
        private ReaLTaiizor.Controls.AirSeparator airSeparator5;
        private Sunny.UI.UIComboBox cmbFormaPago;
        private Label label1;
        private Sunny.UI.UIButton btnSinReparar;
        private Sunny.UI.UIButton btnParcial;
        private Label label2;
        private Sunny.UI.UIButton btnReparado;
        private Label label3;
        private Sunny.UI.UITextBox txtObservaciones;
        private Sunny.UI.UIPanel pnlTotalCobrar;
        private Label lblTotalCobrar;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private PrintDialog pdComprobante;
        private Label lblCedula;
        private Label lblTituloCedula;
        private Sunny.UI.UIComboBox cmbListaOrdenes;
        private Sunny.UI.UIDataGridView dgvDesglose;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCosto;
        private Label lblTotalDesglose;
        private Label label4;
        private Sunny.UI.UISymbolButton btnRegistraEntrega;
        private Sunny.UI.UISymbolButton btnComprobante;
    }
}
