namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblNombreNegocio = new Label();
            lblFacturaComprobante = new Label();
            Fecha = new Label();
            lblFactuaranumero = new Label();
            Orden = new Label();
            lblCliente = new Label();
            Cedula = new Label();
            lblTelefono = new Label();
            lblDatosCliente = new Label();
            label5 = new Label();
            lblTipoDispositivo = new Label();
            Tecnico = new Label();
            lblDetalle = new Label();
            dgvDetalleFactura = new Sunny.UI.UIDataGridView();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblNumeroFactura = new Label();
            lblFecha = new Label();
            lblOrden = new Label();
            lblCedula = new Label();
            lblNombre = new Label();
            lblDispositivo = new Label();
            lblTecnico = new Label();
            lblFormaPago = new Label();
            Telefono = new Label();
            btnCerrar = new Sunny.UI.UIButton();
            btnPDF = new Sunny.UI.UIButton();
            btnImprimir = new Sunny.UI.UIButton();
            pnlFactura = new Sunny.UI.UIPanel();
            airSeparator4 = new ReaLTaiizor.Controls.AirSeparator();
            airSeparator3 = new ReaLTaiizor.Controls.AirSeparator();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            pnlFactura.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreNegocio
            // 
            lblNombreNegocio.AutoSize = true;
            lblNombreNegocio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreNegocio.ForeColor = Color.FromArgb(24, 43, 62);
            lblNombreNegocio.Location = new Point(19, 9);
            lblNombreNegocio.Name = "lblNombreNegocio";
            lblNombreNegocio.Size = new Size(117, 30);
            lblNombreNegocio.TabIndex = 5;
            lblNombreNegocio.Text = "TECH_DKV";
            // 
            // lblFacturaComprobante
            // 
            lblFacturaComprobante.AutoSize = true;
            lblFacturaComprobante.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFacturaComprobante.ForeColor = Color.FromArgb(24, 43, 62);
            lblFacturaComprobante.Location = new Point(163, 9);
            lblFacturaComprobante.Name = "lblFacturaComprobante";
            lblFacturaComprobante.Size = new Size(228, 30);
            lblFacturaComprobante.TabIndex = 6;
            lblFacturaComprobante.Text = "Factura/Comprobante";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Fecha.ForeColor = Color.FromArgb(24, 43, 62);
            Fecha.Location = new Point(19, 92);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(54, 21);
            Fecha.TabIndex = 7;
            Fecha.Text = "Fecha";
            // 
            // lblFactuaranumero
            // 
            lblFactuaranumero.AutoSize = true;
            lblFactuaranumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFactuaranumero.ForeColor = Color.FromArgb(24, 43, 62);
            lblFactuaranumero.Location = new Point(19, 60);
            lblFactuaranumero.Name = "lblFactuaranumero";
            lblFactuaranumero.Size = new Size(156, 21);
            lblFactuaranumero.TabIndex = 8;
            lblFactuaranumero.Text = "Numero de Factura";
            // 
            // Orden
            // 
            Orden.AutoSize = true;
            Orden.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Orden.ForeColor = Color.FromArgb(24, 43, 62);
            Orden.Location = new Point(19, 126);
            Orden.Name = "Orden";
            Orden.Size = new Size(57, 21);
            Orden.TabIndex = 9;
            Orden.Text = "Orden";
            // 
            // lblCliente
            // 
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.FromArgb(24, 43, 62);
            lblCliente.Location = new Point(104, 166);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(227, 25);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "Datos del Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cedula
            // 
            Cedula.AutoSize = true;
            Cedula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cedula.ForeColor = Color.FromArgb(24, 43, 62);
            Cedula.Location = new Point(19, 216);
            Cedula.Name = "Cedula";
            Cedula.Size = new Size(164, 21);
            Cedula.TabIndex = 23;
            Cedula.Text = "Cedula de Identidad";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(24, 43, 62);
            lblTelefono.Location = new Point(220, 284);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(19, 21);
            lblTelefono.TabIndex = 19;
            lblTelefono.Text = "x";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.ForeColor = Color.FromArgb(24, 43, 62);
            lblDatosCliente.Location = new Point(19, 249);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(14, 21);
            lblDatosCliente.TabIndex = 18;
            lblDatosCliente.Text = " ";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(24, 43, 62);
            label5.Location = new Point(104, 340);
            label5.Name = "label5";
            label5.Size = new Size(227, 25);
            label5.TabIndex = 24;
            label5.Text = "Datos del Dispositivo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoDispositivo
            // 
            lblTipoDispositivo.AutoSize = true;
            lblTipoDispositivo.BackColor = Color.Transparent;
            lblTipoDispositivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDispositivo.ForeColor = Color.FromArgb(24, 43, 62);
            lblTipoDispositivo.Location = new Point(19, 376);
            lblTipoDispositivo.Name = "lblTipoDispositivo";
            lblTipoDispositivo.Size = new Size(155, 21);
            lblTipoDispositivo.TabIndex = 25;
            lblTipoDispositivo.Text = "Tipo de dispositivo";
            // 
            // Tecnico
            // 
            Tecnico.AutoSize = true;
            Tecnico.BackColor = Color.Transparent;
            Tecnico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tecnico.ForeColor = Color.FromArgb(24, 43, 62);
            Tecnico.Location = new Point(19, 406);
            Tecnico.Name = "Tecnico";
            Tecnico.Size = new Size(142, 21);
            Tecnico.TabIndex = 28;
            Tecnico.Text = "Técnico asignado";
            // 
            // lblDetalle
            // 
            lblDetalle.BackColor = Color.Transparent;
            lblDetalle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.ForeColor = Color.FromArgb(24, 43, 62);
            lblDetalle.Location = new Point(104, 452);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(227, 25);
            lblDetalle.TabIndex = 29;
            lblDetalle.Text = "Detalles";
            lblDetalle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDetalleFactura
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvDetalleFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleFactura.BackgroundColor = Color.FromArgb(235, 239, 240);
            dgvDetalleFactura.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetalleFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleFactura.ColumnHeadersHeight = 32;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalleFactura.ColumnHeadersVisible = false;
            dgvDetalleFactura.Columns.AddRange(new DataGridViewColumn[] { colDescripcion, colCosto });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalleFactura.EnableHeadersVisualStyles = false;
            dgvDetalleFactura.Font = new Font("Microsoft Sans Serif", 12F);
            dgvDetalleFactura.GridColor = Color.FromArgb(80, 160, 255);
            dgvDetalleFactura.Location = new Point(19, 526);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.RectColor = Color.FromArgb(41, 53, 72);
            dgvDetalleFactura.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalleFactura.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F);
            dgvDetalleFactura.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalleFactura.SelectedIndex = -1;
            dgvDetalleFactura.Size = new Size(385, 154);
            dgvDetalleFactura.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvDetalleFactura.TabIndex = 33;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCosto.DefaultCellStyle = dataGridViewCellStyle3;
            colCosto.HeaderText = "";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            colCosto.Width = 20;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(24, 43, 62);
            lblTotal.Location = new Point(24, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(124, 21);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "Forma de pago";
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.AutoSize = true;
            lblNumeroFactura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumeroFactura.ForeColor = Color.FromArgb(24, 43, 62);
            lblNumeroFactura.Location = new Point(220, 60);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(19, 21);
            lblNumeroFactura.TabIndex = 40;
            lblNumeroFactura.Text = "x";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(24, 43, 62);
            lblFecha.Location = new Point(220, 92);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(19, 21);
            lblFecha.TabIndex = 41;
            lblFecha.Text = "x";
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOrden.ForeColor = Color.FromArgb(24, 43, 62);
            lblOrden.Location = new Point(220, 126);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(19, 21);
            lblOrden.TabIndex = 42;
            lblOrden.Text = "x";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCedula.ForeColor = Color.FromArgb(24, 43, 62);
            lblCedula.Location = new Point(220, 216);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(19, 21);
            lblCedula.TabIndex = 43;
            lblCedula.Text = "x";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(24, 43, 62);
            lblNombre.Location = new Point(220, 249);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(19, 21);
            lblNombre.TabIndex = 44;
            lblNombre.Text = "x";
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.BackColor = Color.Transparent;
            lblDispositivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDispositivo.ForeColor = Color.FromArgb(24, 43, 62);
            lblDispositivo.Location = new Point(220, 376);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(19, 21);
            lblDispositivo.TabIndex = 45;
            lblDispositivo.Text = "x";
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.BackColor = Color.Transparent;
            lblTecnico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTecnico.ForeColor = Color.FromArgb(24, 43, 62);
            lblTecnico.Location = new Point(220, 406);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(19, 21);
            lblTecnico.TabIndex = 46;
            lblTecnico.Text = "x";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.BackColor = Color.Transparent;
            lblFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPago.ForeColor = Color.FromArgb(24, 43, 62);
            lblFormaPago.Location = new Point(220, 490);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(19, 21);
            lblFormaPago.TabIndex = 47;
            lblFormaPago.Text = "x";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telefono.ForeColor = Color.FromArgb(24, 43, 62);
            Telefono.Location = new Point(19, 284);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(146, 21);
            Telefono.TabIndex = 48;
            Telefono.Text = "Teléfono / Celular";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FillColor = Color.White;
            btnCerrar.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(0, 145, 137);
            btnCerrar.Location = new Point(24, 702);
            btnCerrar.MinimumSize = new Size(1, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Radius = 12;
            btnCerrar.RectColor = Color.FromArgb(0, 165, 155);
            btnCerrar.Size = new Size(119, 30);
            btnCerrar.TabIndex = 65;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCerrar.Click += btnCancelar_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPDF.FillColor = Color.White;
            btnPDF.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.ForeColor = Color.FromArgb(0, 145, 137);
            btnPDF.Location = new Point(151, 702);
            btnPDF.MinimumSize = new Size(1, 1);
            btnPDF.Name = "btnPDF";
            btnPDF.Radius = 12;
            btnPDF.RectColor = Color.FromArgb(0, 165, 155);
            btnPDF.Size = new Size(119, 30);
            btnPDF.TabIndex = 66;
            btnPDF.Text = "Guardar PDF";
            btnPDF.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnPDF.Click += btnPDF_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.FillColor = Color.White;
            btnImprimir.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.FromArgb(0, 145, 137);
            btnImprimir.Location = new Point(289, 702);
            btnImprimir.MinimumSize = new Size(1, 1);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Radius = 12;
            btnImprimir.RectColor = Color.FromArgb(0, 165, 155);
            btnImprimir.Size = new Size(119, 30);
            btnImprimir.TabIndex = 67;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlFactura
            // 
            pnlFactura.Controls.Add(Orden);
            pnlFactura.Controls.Add(dgvDetalleFactura);
            pnlFactura.Controls.Add(Fecha);
            pnlFactura.Controls.Add(lblFactuaranumero);
            pnlFactura.Controls.Add(lblNumeroFactura);
            pnlFactura.Controls.Add(lblFecha);
            pnlFactura.Controls.Add(lblOrden);
            pnlFactura.Controls.Add(lblCliente);
            pnlFactura.Controls.Add(airSeparator4);
            pnlFactura.Controls.Add(airSeparator3);
            pnlFactura.Controls.Add(airSeparator1);
            pnlFactura.Controls.Add(airSeparator2);
            pnlFactura.Controls.Add(lblNombreNegocio);
            pnlFactura.Controls.Add(lblCedula);
            pnlFactura.Controls.Add(lblNombre);
            pnlFactura.Controls.Add(lblFormaPago);
            pnlFactura.Controls.Add(Telefono);
            pnlFactura.Controls.Add(lblFacturaComprobante);
            pnlFactura.Controls.Add(lblDispositivo);
            pnlFactura.Controls.Add(lblTotal);
            pnlFactura.Controls.Add(lblDatosCliente);
            pnlFactura.Controls.Add(lblTecnico);
            pnlFactura.Controls.Add(lblDetalle);
            pnlFactura.Controls.Add(Tecnico);
            pnlFactura.Controls.Add(lblTipoDispositivo);
            pnlFactura.Controls.Add(Cedula);
            pnlFactura.Controls.Add(label5);
            pnlFactura.Controls.Add(lblTelefono);
            pnlFactura.FillColor = Color.White;
            pnlFactura.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFactura.Location = new Point(0, 0);
            pnlFactura.Margin = new Padding(4, 5, 4, 5);
            pnlFactura.MinimumSize = new Size(1, 1);
            pnlFactura.Name = "pnlFactura";
            pnlFactura.Radius = 12;
            pnlFactura.RectColor = Color.FromArgb(225, 230, 235);
            pnlFactura.Size = new Size(430, 694);
            pnlFactura.TabIndex = 68;
            pnlFactura.Text = null;
            pnlFactura.TextAlignment = ContentAlignment.MiddleCenter;
            pnlFactura.Click += pnlTrabajoRealizado_Click;
            // 
            // airSeparator4
            // 
            airSeparator4.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator4.Customization = "";
            airSeparator4.Font = new Font("Verdana", 8F);
            airSeparator4.Image = null;
            airSeparator4.Location = new Point(12, 448);
            airSeparator4.Name = "airSeparator4";
            airSeparator4.NoRounding = false;
            airSeparator4.Size = new Size(391, 1);
            airSeparator4.TabIndex = 50;
            airSeparator4.Text = "airSeparator4";
            airSeparator4.Transparent = false;
            // 
            // airSeparator3
            // 
            airSeparator3.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator3.Customization = "";
            airSeparator3.Font = new Font("Verdana", 8F);
            airSeparator3.Image = null;
            airSeparator3.Location = new Point(12, 324);
            airSeparator3.Name = "airSeparator3";
            airSeparator3.NoRounding = false;
            airSeparator3.Size = new Size(391, 1);
            airSeparator3.TabIndex = 49;
            airSeparator3.Text = "airSeparator3";
            airSeparator3.Transparent = false;
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(12, 153);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(391, 1);
            airSeparator1.TabIndex = 7;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // airSeparator2
            // 
            airSeparator2.BackColor = Color.FromArgb(75, 92, 108);
            airSeparator2.Customization = "";
            airSeparator2.Font = new Font("Verdana", 8F);
            airSeparator2.Image = null;
            airSeparator2.Location = new Point(12, 42);
            airSeparator2.Name = "airSeparator2";
            airSeparator2.NoRounding = false;
            airSeparator2.Size = new Size(391, 1);
            airSeparator2.TabIndex = 1;
            airSeparator2.Text = "airSeparator2";
            airSeparator2.Transparent = false;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(428, 744);
            Controls.Add(btnImprimir);
            Controls.Add(btnPDF);
            Controls.Add(btnCerrar);
            Controls.Add(pnlFactura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFactura";
            Text = "frmFactura";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            pnlFactura.ResumeLayout(false);
            pnlFactura.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreNegocio;
        private Label lblFacturaComprobante;
        private Label Fecha;
        private Label lblFactuaranumero;
        private Label Orden;
        private Label lblCliente;
        private Label Cedula;
        private Label lblTelefono;
        private Label lblDatosCliente;
        private Label label5;
        private Label lblTipoDispositivo;
        private Label Tecnico;
        private Label lblDetalle;
        private Sunny.UI.UIDataGridView dgvDetalleFactura;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCosto;
        private Label lblTotal;
        private Sunny.UI.UIButton btnCerrar;
        private Sunny.UI.UIButton uiButton1;
        private Label lblNumeroFactura;
        private Label lblFecha;
        private Label lblOrden;
        private Label lblCedula;
        private Label lblNombre;
        private Label lblDispositivo;
        private Label lblTecnico;
        private Label lblFormaPago;
        private Label Telefono;
        private Sunny.UI.UIButton btnPDF;
        private Sunny.UI.UIButton btnImprimir;
        private Sunny.UI.UIPanel pnlFactura;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
        private ReaLTaiizor.Controls.AirSeparator airSeparator4;
        private ReaLTaiizor.Controls.AirSeparator airSeparator3;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
    }
}