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
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            cmbListaOrdenes = new Sunny.UI.UIComboBox();
            btnBuscar = new Sunny.UI.UIButton();
            lblOrden = new Label();
            txtBuscarOrden = new Sunny.UI.UITextBox();
            pnlPrincipal = new Panel();
            btnComprobante = new Sunny.UI.UIButton();
            btnRegistraEntrega = new Sunny.UI.UIButton();
            pnlFormaDePago = new Sunny.UI.UIPanel();
            pnlTotalCobrar = new Sunny.UI.UIPanel();
            label4 = new Label();
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
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            pnlFormaDePago.SuspendLayout();
            pnlTotalCobrar.SuspendLayout();
            pnlDesgloseCosto.SuspendLayout();
            pnlTrabajoRealizado.SuspendLayout();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-6, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SolarBoxOutline;
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
            lblTitulo.Size = new Size(308, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Devolución / Entrega";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(cmbListaOrdenes);
            pnlInformacion.Controls.Add(btnBuscar);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Controls.Add(txtBuscarOrden);
            pnlInformacion.ForeColor = Color.White;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 59);
            pnlInformacion.TabIndex = 2;
            // 
            // cmbListaOrdenes
            // 
            cmbListaOrdenes.BackColor = Color.Transparent;
            cmbListaOrdenes.DataSource = null;
            cmbListaOrdenes.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbListaOrdenes.FillColor = Color.FromArgb(41, 53, 72);
            cmbListaOrdenes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbListaOrdenes.ForeColor = Color.White;
            cmbListaOrdenes.FormattingEnabled = true;
            cmbListaOrdenes.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbListaOrdenes.Items.AddRange(new object[] { "Seleccionar...", "Efectivo", "Transferencia" });
            cmbListaOrdenes.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbListaOrdenes.Location = new Point(331, 22);
            cmbListaOrdenes.Margin = new Padding(4, 5, 4, 5);
            cmbListaOrdenes.MinimumSize = new Size(63, 0);
            cmbListaOrdenes.Name = "cmbListaOrdenes";
            cmbListaOrdenes.Padding = new Padding(0, 0, 30, 2);
            cmbListaOrdenes.Radius = 12;
            cmbListaOrdenes.RectColor = Color.FromArgb(148, 163, 184);
            cmbListaOrdenes.Size = new Size(169, 30);
            cmbListaOrdenes.SymbolSize = 24;
            cmbListaOrdenes.TabIndex = 25;
            cmbListaOrdenes.TextAlignment = ContentAlignment.MiddleLeft;
            cmbListaOrdenes.Watermark = "";
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            btnBuscar.Location = new Point(518, 21);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.RectColor = Color.FromArgb(0, 150, 137);
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
            lblOrden.ForeColor = Color.Black;
            lblOrden.Location = new Point(29, 3);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(265, 17);
            lblOrden.TabIndex = 19;
            lblOrden.Text = "Ingrese el número de cedula y elija la orden";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscarOrden.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrden.ForeColor = Color.White;
            txtBuscarOrden.Location = new Point(29, 22);
            txtBuscarOrden.Margin = new Padding(4, 5, 4, 5);
            txtBuscarOrden.MinimumSize = new Size(1, 16);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Padding = new Padding(5);
            txtBuscarOrden.Radius = 12;
            txtBuscarOrden.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscarOrden.ShowText = false;
            txtBuscarOrden.Size = new Size(295, 30);
            txtBuscarOrden.TabIndex = 3;
            txtBuscarOrden.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarOrden.Watermark = "Ej. ORD-2024-003";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(btnComprobante);
            pnlPrincipal.Controls.Add(btnRegistraEntrega);
            pnlPrincipal.Controls.Add(pnlFormaDePago);
            pnlPrincipal.Controls.Add(pnlDesgloseCosto);
            pnlPrincipal.Controls.Add(pnlTrabajoRealizado);
            pnlPrincipal.Controls.Add(pnlResumen);
            pnlPrincipal.Location = new Point(0, 118);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1128, 663);
            pnlPrincipal.TabIndex = 3;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.Transparent;
            btnComprobante.FillColor = Color.FromArgb(22, 35, 52);
            btnComprobante.FillHoverColor = Color.Transparent;
            btnComprobante.FillPressColor = Color.FromArgb(0, 150, 137);
            btnComprobante.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobante.Location = new Point(854, 529);
            btnComprobante.MinimumSize = new Size(1, 1);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Radius = 12;
            btnComprobante.RectColor = Color.FromArgb(39, 53, 72);
            btnComprobante.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnComprobante.RectPressColor = Color.FromArgb(0, 150, 137);
            btnComprobante.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnComprobante.Size = new Size(144, 31);
            btnComprobante.TabIndex = 30;
            btnComprobante.Text = "Comprobante";
            btnComprobante.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnComprobante.TipsForeColor = Color.Transparent;
            btnComprobante.Visible = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnRegistraEntrega
            // 
            btnRegistraEntrega.BackColor = Color.Transparent;
            btnRegistraEntrega.FillColor = Color.FromArgb(0, 150, 137);
            btnRegistraEntrega.FillHoverColor = Color.Transparent;
            btnRegistraEntrega.FillPressColor = Color.FromArgb(0, 150, 137);
            btnRegistraEntrega.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnRegistraEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistraEntrega.Location = new Point(546, 529);
            btnRegistraEntrega.MinimumSize = new Size(1, 1);
            btnRegistraEntrega.Name = "btnRegistraEntrega";
            btnRegistraEntrega.Radius = 12;
            btnRegistraEntrega.RectColor = Color.FromArgb(39, 53, 72);
            btnRegistraEntrega.RectHoverColor = Color.Transparent;
            btnRegistraEntrega.RectPressColor = Color.FromArgb(0, 150, 137);
            btnRegistraEntrega.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnRegistraEntrega.Size = new Size(302, 31);
            btnRegistraEntrega.TabIndex = 29;
            btnRegistraEntrega.Text = "Registrar Entrega";
            btnRegistraEntrega.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRegistraEntrega.TipsForeColor = Color.Transparent;
            btnRegistraEntrega.Visible = false;
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
            pnlFormaDePago.FillColor = Color.FromArgb(30, 41, 59);
            pnlFormaDePago.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFormaDePago.Location = new Point(608, 20);
            pnlFormaDePago.Margin = new Padding(4, 5, 4, 5);
            pnlFormaDePago.MinimumSize = new Size(1, 1);
            pnlFormaDePago.Name = "pnlFormaDePago";
            pnlFormaDePago.Radius = 12;
            pnlFormaDePago.RectColor = Color.FromArgb(39, 53, 72);
            pnlFormaDePago.Size = new Size(452, 475);
            pnlFormaDePago.TabIndex = 6;
            pnlFormaDePago.Text = null;
            pnlFormaDePago.TextAlignment = ContentAlignment.MiddleCenter;
            pnlFormaDePago.Visible = false;
            // 
            // pnlTotalCobrar
            // 
            pnlTotalCobrar.BackColor = Color.Transparent;
            pnlTotalCobrar.Controls.Add(label4);
            pnlTotalCobrar.FillColor = Color.FromArgb(22, 35, 52);
            pnlTotalCobrar.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTotalCobrar.ForeColor = Color.FromArgb(147, 162, 183);
            pnlTotalCobrar.Location = new Point(18, 309);
            pnlTotalCobrar.Margin = new Padding(4, 5, 4, 5);
            pnlTotalCobrar.MinimumSize = new Size(1, 1);
            pnlTotalCobrar.Name = "pnlTotalCobrar";
            pnlTotalCobrar.Radius = 12;
            pnlTotalCobrar.RectColor = Color.FromArgb(41, 53, 72);
            pnlTotalCobrar.Size = new Size(409, 66);
            pnlTotalCobrar.TabIndex = 33;
            pnlTotalCobrar.Text = "Total a cobrar";
            pnlTotalCobrar.TextAlignment = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 150, 137);
            label4.Location = new Point(190, 22);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 15;
            label4.Text = "$0";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.Transparent;
            txtObservaciones.FillColor = Color.FromArgb(41, 53, 72);
            txtObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.ForeColor = Color.White;
            txtObservaciones.Location = new Point(18, 205);
            txtObservaciones.Margin = new Padding(4, 5, 4, 5);
            txtObservaciones.MaxLength = 255;
            txtObservaciones.Minimum = 0D;
            txtObservaciones.MinimumSize = new Size(1, 16);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Padding = new Padding(5);
            txtObservaciones.Radius = 12;
            txtObservaciones.RectColor = Color.FromArgb(41, 53, 72);
            txtObservaciones.ShowText = false;
            txtObservaciones.Size = new Size(409, 87);
            txtObservaciones.TabIndex = 32;
            txtObservaciones.TextAlignment = ContentAlignment.MiddleLeft;
            txtObservaciones.Watermark = "Notas Adicionales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(147, 162, 183);
            label3.Location = new Point(18, 183);
            label3.Name = "label3";
            label3.Size = new Size(168, 17);
            label3.TabIndex = 31;
            label3.Text = "Observaciones de entrega";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(147, 162, 183);
            label2.Location = new Point(18, 126);
            label2.Name = "label2";
            label2.Size = new Size(184, 17);
            label2.TabIndex = 30;
            label2.Text = "Condición en que se entrega";
            // 
            // btnReparado
            // 
            btnReparado.BackColor = Color.Transparent;
            btnReparado.FillColor = Color.FromArgb(22, 35, 52);
            btnReparado.FillHoverColor = Color.Transparent;
            btnReparado.FillPressColor = Color.FromArgb(0, 150, 137);
            btnReparado.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReparado.Location = new Point(18, 146);
            btnReparado.MinimumSize = new Size(1, 1);
            btnReparado.Name = "btnReparado";
            btnReparado.Radius = 12;
            btnReparado.RectColor = Color.FromArgb(39, 53, 72);
            btnReparado.RectHoverColor = Color.Transparent;
            btnReparado.RectPressColor = Color.FromArgb(0, 150, 137);
            btnReparado.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparado.Size = new Size(138, 24);
            btnReparado.TabIndex = 29;
            btnReparado.Text = "Reparado";
            btnReparado.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReparado.TipsForeColor = Color.Transparent;
            btnReparado.Click += uiButton3_Click;
            // 
            // btnSinReparar
            // 
            btnSinReparar.BackColor = Color.Transparent;
            btnSinReparar.FillColor = Color.FromArgb(22, 35, 52);
            btnSinReparar.FillHoverColor = Color.Transparent;
            btnSinReparar.FillPressColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinReparar.Location = new Point(293, 146);
            btnSinReparar.MinimumSize = new Size(1, 1);
            btnSinReparar.Name = "btnSinReparar";
            btnSinReparar.Radius = 12;
            btnSinReparar.RectColor = Color.FromArgb(39, 53, 72);
            btnSinReparar.RectHoverColor = Color.Transparent;
            btnSinReparar.RectPressColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnSinReparar.Size = new Size(134, 24);
            btnSinReparar.TabIndex = 28;
            btnSinReparar.Text = "Sin Reparación";
            btnSinReparar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSinReparar.TipsForeColor = Color.Transparent;
            btnSinReparar.Click += btnSinReparar_Click;
            // 
            // btnParcial
            // 
            btnParcial.BackColor = Color.Transparent;
            btnParcial.FillColor = Color.FromArgb(22, 35, 52);
            btnParcial.FillHoverColor = Color.Transparent;
            btnParcial.FillPressColor = Color.FromArgb(0, 150, 137);
            btnParcial.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnParcial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParcial.Location = new Point(162, 146);
            btnParcial.MinimumSize = new Size(1, 1);
            btnParcial.Name = "btnParcial";
            btnParcial.Radius = 12;
            btnParcial.RectColor = Color.FromArgb(39, 53, 72);
            btnParcial.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnParcial.RectPressColor = Color.FromArgb(0, 150, 137);
            btnParcial.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnParcial.Size = new Size(125, 24);
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
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(147, 162, 183);
            label1.Location = new Point(18, 63);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 25;
            label1.Text = "Forma de pago ";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.BackColor = Color.Transparent;
            cmbFormaPago.DataSource = null;
            cmbFormaPago.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbFormaPago.FillColor = Color.FromArgb(41, 53, 72);
            cmbFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPago.ForeColor = Color.White;
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbFormaPago.Items.AddRange(new object[] { "Seleccionar...", "Efectivo", "Transferencia" });
            cmbFormaPago.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbFormaPago.Location = new Point(18, 85);
            cmbFormaPago.Margin = new Padding(4, 5, 4, 5);
            cmbFormaPago.MinimumSize = new Size(63, 0);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Padding = new Padding(0, 0, 30, 2);
            cmbFormaPago.Radius = 12;
            cmbFormaPago.RectColor = Color.FromArgb(148, 163, 184);
            cmbFormaPago.Size = new Size(409, 22);
            cmbFormaPago.SymbolSize = 24;
            cmbFormaPago.TabIndex = 24;
            cmbFormaPago.TextAlignment = ContentAlignment.MiddleLeft;
            cmbFormaPago.Watermark = "";
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // lblRegistrarEntrega
            // 
            lblRegistrarEntrega.AutoSize = true;
            lblRegistrarEntrega.BackColor = Color.Transparent;
            lblRegistrarEntrega.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarEntrega.ForeColor = Color.White;
            lblRegistrarEntrega.Location = new Point(18, 23);
            lblRegistrarEntrega.Name = "lblRegistrarEntrega";
            lblRegistrarEntrega.Size = new Size(114, 17);
            lblRegistrarEntrega.TabIndex = 2;
            lblRegistrarEntrega.Text = "Registrar entrega";
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
            pnlDesgloseCosto.Controls.Add(airSeparator5);
            pnlDesgloseCosto.Controls.Add(lblDesglose);
            pnlDesgloseCosto.Controls.Add(airSeparator3);
            pnlDesgloseCosto.FillColor = Color.FromArgb(30, 41, 59);
            pnlDesgloseCosto.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDesgloseCosto.Location = new Point(29, 428);
            pnlDesgloseCosto.Margin = new Padding(4, 5, 4, 5);
            pnlDesgloseCosto.MinimumSize = new Size(1, 1);
            pnlDesgloseCosto.Name = "pnlDesgloseCosto";
            pnlDesgloseCosto.Radius = 12;
            pnlDesgloseCosto.RectColor = Color.FromArgb(39, 53, 72);
            pnlDesgloseCosto.Size = new Size(500, 198);
            pnlDesgloseCosto.TabIndex = 5;
            pnlDesgloseCosto.Text = null;
            pnlDesgloseCosto.TextAlignment = ContentAlignment.MiddleCenter;
            pnlDesgloseCosto.Visible = false;
            // 
            // airSeparator5
            // 
            airSeparator5.BackColor = Color.FromArgb(43, 55, 75);
            airSeparator5.Customization = "";
            airSeparator5.Font = new Font("Verdana", 8F);
            airSeparator5.Image = null;
            airSeparator5.Location = new Point(18, 161);
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
            lblDesglose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesglose.ForeColor = Color.White;
            lblDesglose.Location = new Point(18, 23);
            lblDesglose.Name = "lblDesglose";
            lblDesglose.Size = new Size(126, 17);
            lblDesglose.TabIndex = 2;
            lblDesglose.Text = "Desglose de costos";
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
            pnlTrabajoRealizado.Controls.Add(lblDescripcionTrabajo);
            pnlTrabajoRealizado.Controls.Add(lblTrabajoRealizado);
            pnlTrabajoRealizado.Controls.Add(airSeparator2);
            pnlTrabajoRealizado.FillColor = Color.FromArgb(30, 41, 59);
            pnlTrabajoRealizado.Font = new Font("Microsoft Sans Serif", 12F);
            pnlTrabajoRealizado.Location = new Point(29, 298);
            pnlTrabajoRealizado.Margin = new Padding(4, 5, 4, 5);
            pnlTrabajoRealizado.MinimumSize = new Size(1, 1);
            pnlTrabajoRealizado.Name = "pnlTrabajoRealizado";
            pnlTrabajoRealizado.Radius = 12;
            pnlTrabajoRealizado.RectColor = Color.FromArgb(39, 53, 72);
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
            lblDescripcionTrabajo.ForeColor = Color.FromArgb(199, 204, 196);
            lblDescripcionTrabajo.Location = new Point(24, 57);
            lblDescripcionTrabajo.Name = "lblDescripcionTrabajo";
            lblDescripcionTrabajo.Size = new Size(455, 47);
            lblDescripcionTrabajo.TabIndex = 3;
            // 
            // lblTrabajoRealizado
            // 
            lblTrabajoRealizado.AutoSize = true;
            lblTrabajoRealizado.BackColor = Color.Transparent;
            lblTrabajoRealizado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrabajoRealizado.ForeColor = Color.White;
            lblTrabajoRealizado.Location = new Point(18, 23);
            lblTrabajoRealizado.Name = "lblTrabajoRealizado";
            lblTrabajoRealizado.Size = new Size(114, 17);
            lblTrabajoRealizado.TabIndex = 2;
            lblTrabajoRealizado.Text = "Trabajo realizado";
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
            pnlResumen.FillColor = Color.FromArgb(30, 41, 59);
            pnlResumen.Font = new Font("Microsoft Sans Serif", 12F);
            pnlResumen.ForeColor = Color.FromArgb(147, 162, 183);
            pnlResumen.Location = new Point(29, 17);
            pnlResumen.Margin = new Padding(4, 5, 4, 5);
            pnlResumen.MinimumSize = new Size(1, 1);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Radius = 12;
            pnlResumen.RectColor = Color.FromArgb(39, 53, 72);
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
            lblCedula.Font = new Font("Segoe UI", 9.75F);
            lblCedula.ForeColor = Color.FromArgb(147, 162, 183);
            lblCedula.Location = new Point(348, 109);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(14, 17);
            lblCedula.TabIndex = 16;
            lblCedula.Text = "x";
            // 
            // lblTituloCedula
            // 
            lblTituloCedula.AutoSize = true;
            lblTituloCedula.BackColor = Color.Transparent;
            lblTituloCedula.Font = new Font("Segoe UI", 9.75F);
            lblTituloCedula.ForeColor = Color.FromArgb(147, 162, 183);
            lblTituloCedula.Location = new Point(18, 109);
            lblTituloCedula.Name = "lblTituloCedula";
            lblTituloCedula.Size = new Size(48, 17);
            lblTituloCedula.TabIndex = 15;
            lblTituloCedula.Text = "Cedula";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.BackColor = Color.Transparent;
            lblFechaIngreso.Font = new Font("Segoe UI", 9.75F);
            lblFechaIngreso.ForeColor = Color.FromArgb(147, 162, 183);
            lblFechaIngreso.Location = new Point(348, 242);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(14, 17);
            lblFechaIngreso.TabIndex = 14;
            lblFechaIngreso.Text = "x";
            // 
            // lblTecnicoAsignado
            // 
            lblTecnicoAsignado.AutoSize = true;
            lblTecnicoAsignado.BackColor = Color.Transparent;
            lblTecnicoAsignado.Font = new Font("Segoe UI", 9.75F);
            lblTecnicoAsignado.ForeColor = Color.FromArgb(147, 162, 183);
            lblTecnicoAsignado.Location = new Point(348, 218);
            lblTecnicoAsignado.Name = "lblTecnicoAsignado";
            lblTecnicoAsignado.Size = new Size(14, 17);
            lblTecnicoAsignado.TabIndex = 13;
            lblTecnicoAsignado.Text = "x";
            // 
            // lblDispositivo
            // 
            lblDispositivo.BackColor = Color.Transparent;
            lblDispositivo.Font = new Font("Segoe UI", 9.75F);
            lblDispositivo.ForeColor = Color.FromArgb(147, 162, 183);
            lblDispositivo.Location = new Point(348, 158);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(133, 45);
            lblDispositivo.TabIndex = 12;
            lblDispositivo.Text = "x";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Segoe UI", 9.75F);
            lblTelefono.ForeColor = Color.FromArgb(147, 162, 183);
            lblTelefono.Location = new Point(348, 134);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(14, 17);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "x";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 9.75F);
            lblCliente.ForeColor = Color.FromArgb(147, 162, 183);
            lblCliente.Location = new Point(348, 85);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(14, 17);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "x";
            // 
            // lblNumeroOrden
            // 
            lblNumeroOrden.AutoSize = true;
            lblNumeroOrden.BackColor = Color.Transparent;
            lblNumeroOrden.Font = new Font("Segoe UI", 9.75F);
            lblNumeroOrden.ForeColor = Color.FromArgb(70, 237, 213);
            lblNumeroOrden.Location = new Point(348, 59);
            lblNumeroOrden.Name = "lblNumeroOrden";
            lblNumeroOrden.Size = new Size(14, 17);
            lblNumeroOrden.TabIndex = 9;
            lblNumeroOrden.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.ForeColor = Color.FromArgb(147, 162, 183);
            label6.Location = new Point(18, 242);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 8;
            label6.Text = "Ingreso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(147, 162, 183);
            label5.Location = new Point(18, 218);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 7;
            label5.Text = "Técnico";
            // 
            // lblTituloDispositivo
            // 
            lblTituloDispositivo.AutoSize = true;
            lblTituloDispositivo.BackColor = Color.Transparent;
            lblTituloDispositivo.Font = new Font("Segoe UI", 9.75F);
            lblTituloDispositivo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTituloDispositivo.Location = new Point(18, 158);
            lblTituloDispositivo.Name = "lblTituloDispositivo";
            lblTituloDispositivo.Size = new Size(78, 17);
            lblTituloDispositivo.TabIndex = 6;
            lblTituloDispositivo.Text = "Dispositivos";
            // 
            // lblTituloTelefono
            // 
            lblTituloTelefono.AutoSize = true;
            lblTituloTelefono.BackColor = Color.Transparent;
            lblTituloTelefono.Font = new Font("Segoe UI", 9.75F);
            lblTituloTelefono.ForeColor = Color.FromArgb(147, 162, 183);
            lblTituloTelefono.Location = new Point(18, 134);
            lblTituloTelefono.Name = "lblTituloTelefono";
            lblTituloTelefono.Size = new Size(58, 17);
            lblTituloTelefono.TabIndex = 5;
            lblTituloTelefono.Text = "Teléfono";
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.BackColor = Color.Transparent;
            lblTituloCliente.Font = new Font("Segoe UI", 9.75F);
            lblTituloCliente.ForeColor = Color.FromArgb(147, 162, 183);
            lblTituloCliente.Location = new Point(18, 85);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(47, 17);
            lblTituloCliente.TabIndex = 4;
            lblTituloCliente.Text = "Cliente";
            // 
            // lblTituloorden
            // 
            lblTituloorden.AutoSize = true;
            lblTituloorden.BackColor = Color.Transparent;
            lblTituloorden.Font = new Font("Segoe UI", 9.75F);
            lblTituloorden.ForeColor = Color.FromArgb(147, 162, 183);
            lblTituloorden.Location = new Point(18, 59);
            lblTituloorden.Name = "lblTituloorden";
            lblTituloorden.Size = new Size(114, 17);
            lblTituloorden.TabIndex = 3;
            lblTituloorden.Text = "Número de orden";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.SolarBoxOutline;
            pictureBox2.Location = new Point(18, 13);
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
            lblResumen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = Color.White;
            lblResumen.Location = new Point(53, 23);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(138, 17);
            lblResumen.TabIndex = 1;
            lblResumen.Text = "Resumen de la orden";
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
            // ucDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPrincipal);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucDevolucion";
            Size = new Size(1125, 764);
            Load += ucDevolucion_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            pnlFormaDePago.ResumeLayout(false);
            pnlFormaDePago.PerformLayout();
            pnlTotalCobrar.ResumeLayout(false);
            pnlTotalCobrar.PerformLayout();
            pnlDesgloseCosto.ResumeLayout(false);
            pnlDesgloseCosto.PerformLayout();
            pnlTrabajoRealizado.ResumeLayout(false);
            pnlTrabajoRealizado.PerformLayout();
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label4;
        private Sunny.UI.UIButton btnComprobante;
        private Sunny.UI.UIButton btnRegistraEntrega;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private PrintDialog pdComprobante;
        private Label lblCedula;
        private Label lblTituloCedula;
        private Sunny.UI.UIComboBox cmbListaOrdenes;
    }
}
