namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmDetallesOrden
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
            btnListoEntrega = new Sunny.UI.UIButton();
            btnDerivar = new Sunny.UI.UIButton();
            cmbTecnico = new Sunny.UI.UIComboBox();
            txtObservacion = new Sunny.UI.UITextBox();
            lblNumeroOrden = new Label();
            lblEditar = new Label();
            lblCliente = new Label();
            lblDispositivo = new Label();
            lblActualizarEstado = new Label();
            lblTecnicoAsignado = new Label();
            lstRepuestos = new Sunny.UI.UIListBox();
            label2 = new Label();
            btnAgregarRepuesto = new Sunny.UI.UIButton();
            cmbRepuestos = new Sunny.UI.UIComboBox();
            lblObservaciones = new Label();
            lstObservaciones = new Sunny.UI.UIListBox();
            btnAgregarObservacion = new Sunny.UI.UIButton();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            btnRecibido = new Sunny.UI.UISymbolButton();
            btnDiagnostico = new Sunny.UI.UISymbolButton();
            btnEntregado = new Sunny.UI.UISymbolButton();
            btnReparacion = new Sunny.UI.UISymbolButton();
            btnListo = new Sunny.UI.UISymbolButton();
            SuspendLayout();
            // 
            // btnListoEntrega
            // 
            btnListoEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnListoEntrega.FillColor = Color.FromArgb(0, 165, 155);
            btnListoEntrega.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnListoEntrega.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListoEntrega.Location = new Point(171, 548);
            btnListoEntrega.MinimumSize = new Size(1, 1);
            btnListoEntrega.Name = "btnListoEntrega";
            btnListoEntrega.Radius = 12;
            btnListoEntrega.RectColor = Color.FromArgb(0, 150, 137);
            btnListoEntrega.Size = new Size(175, 30);
            btnListoEntrega.TabIndex = 41;
            btnListoEntrega.Text = "Actualizar estado";
            btnListoEntrega.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnListoEntrega.Click += btnListoEntrega_Click;
            // 
            // btnDerivar
            // 
            btnDerivar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDerivar.FillColor = Color.White;
            btnDerivar.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnDerivar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDerivar.ForeColor = Color.FromArgb(0, 145, 137);
            btnDerivar.Location = new Point(372, 548);
            btnDerivar.MinimumSize = new Size(1, 1);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.Radius = 12;
            btnDerivar.RectColor = Color.FromArgb(0, 165, 155);
            btnDerivar.Size = new Size(181, 30);
            btnDerivar.TabIndex = 40;
            btnDerivar.Text = "Derivar a otro sucursal";
            btnDerivar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDerivar.Click += btnMarcarListo_Click;
            // 
            // cmbTecnico
            // 
            cmbTecnico.BackColor = Color.Transparent;
            cmbTecnico.DataSource = null;
            cmbTecnico.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbTecnico.FillColor = Color.White;
            cmbTecnico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTecnico.ForeColor = Color.FromArgb(24, 43, 62);
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbTecnico.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbTecnico.Location = new Point(29, 271);
            cmbTecnico.Margin = new Padding(4, 5, 4, 5);
            cmbTecnico.MinimumSize = new Size(63, 0);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Padding = new Padding(0, 0, 30, 2);
            cmbTecnico.Radius = 12;
            cmbTecnico.RectColor = Color.FromArgb(220, 226, 232);
            cmbTecnico.RectDisableColor = Color.FromArgb(0, 165, 155);
            cmbTecnico.Size = new Size(300, 46);
            cmbTecnico.SymbolSize = 24;
            cmbTecnico.TabIndex = 39;
            cmbTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTecnico.Watermark = "";
            cmbTecnico.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // txtObservacion
            // 
            txtObservacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacion.ForeColor = Color.FromArgb(24, 43, 62);
            txtObservacion.Location = new Point(372, 438);
            txtObservacion.Margin = new Padding(4, 5, 4, 5);
            txtObservacion.MaxLength = 255;
            txtObservacion.Minimum = 0D;
            txtObservacion.MinimumSize = new Size(1, 16);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Padding = new Padding(5);
            txtObservacion.Radius = 12;
            txtObservacion.RectColor = Color.FromArgb(220, 226, 232);
            txtObservacion.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtObservacion.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtObservacion.ShowText = false;
            txtObservacion.Size = new Size(300, 46);
            txtObservacion.TabIndex = 38;
            txtObservacion.TextAlignment = ContentAlignment.MiddleLeft;
            txtObservacion.Watermark = "Nueva observacion";
            txtObservacion.WatermarkActiveColor = Color.WhiteSmoke;
            txtObservacion.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // lblNumeroOrden
            // 
            lblNumeroOrden.AutoSize = true;
            lblNumeroOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumeroOrden.ForeColor = Color.FromArgb(0, 165, 155);
            lblNumeroOrden.Location = new Point(29, 85);
            lblNumeroOrden.Name = "lblNumeroOrden";
            lblNumeroOrden.Size = new Size(19, 21);
            lblNumeroOrden.TabIndex = 31;
            lblNumeroOrden.Text = "x";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.ForeColor = Color.FromArgb(24, 43, 62);
            lblEditar.Location = new Point(80, 24);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(187, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Detalle de orden";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(24, 43, 62);
            lblCliente.Location = new Point(29, 114);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(19, 21);
            lblCliente.TabIndex = 44;
            lblCliente.Text = "x";
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDispositivo.ForeColor = Color.FromArgb(70, 86, 103);
            lblDispositivo.Location = new Point(29, 140);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(19, 21);
            lblDispositivo.TabIndex = 45;
            lblDispositivo.Text = "x";
            // 
            // lblActualizarEstado
            // 
            lblActualizarEstado.AutoSize = true;
            lblActualizarEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActualizarEstado.Location = new Point(29, 169);
            lblActualizarEstado.Name = "lblActualizarEstado";
            lblActualizarEstado.Size = new Size(141, 17);
            lblActualizarEstado.TabIndex = 49;
            lblActualizarEstado.Text = "ACTUALIZAR ESTADO";
            // 
            // lblTecnicoAsignado
            // 
            lblTecnicoAsignado.AutoSize = true;
            lblTecnicoAsignado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTecnicoAsignado.Location = new Point(29, 248);
            lblTecnicoAsignado.Name = "lblTecnicoAsignado";
            lblTecnicoAsignado.Size = new Size(135, 17);
            lblTecnicoAsignado.TabIndex = 50;
            lblTecnicoAsignado.Text = "TECNICO ASIGNADO";
            // 
            // lstRepuestos
            // 
            lstRepuestos.FillColor = Color.White;
            lstRepuestos.Font = new Font("Microsoft Sans Serif", 12F);
            lstRepuestos.ForeColor = Color.FromArgb(24, 43, 62);
            lstRepuestos.HoverColor = Color.FromArgb(155, 200, 255);
            lstRepuestos.ItemSelectForeColor = Color.White;
            lstRepuestos.Location = new Point(29, 349);
            lstRepuestos.Margin = new Padding(4, 5, 4, 5);
            lstRepuestos.MinimumSize = new Size(1, 1);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Padding = new Padding(6);
            lstRepuestos.Radius = 12;
            lstRepuestos.RectColor = Color.FromArgb(220, 226, 232);
            lstRepuestos.ScrollBarBackColor = Color.FromArgb(232, 248, 247);
            lstRepuestos.ScrollBarColor = Color.FromArgb(0, 165, 155);
            lstRepuestos.ScrollBarStyleInherited = false;
            lstRepuestos.ShowText = false;
            lstRepuestos.Size = new Size(329, 79);
            lstRepuestos.TabIndex = 51;
            lstRepuestos.Text = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 327);
            label2.Name = "label2";
            label2.Size = new Size(159, 17);
            label2.TabIndex = 52;
            label2.Text = "REPUESTOS UTILIZADOS";
            // 
            // btnAgregarRepuesto
            // 
            btnAgregarRepuesto.FillColor = Color.White;
            btnAgregarRepuesto.FillColor2 = Color.FromArgb(232, 248, 247);
            btnAgregarRepuesto.FillHoverColor = Color.Transparent;
            btnAgregarRepuesto.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.Font = new Font("Microsoft Sans Serif", 12F);
            btnAgregarRepuesto.ForeColor = Color.FromArgb(0, 165, 155);
            btnAgregarRepuesto.Location = new Point(306, 438);
            btnAgregarRepuesto.MinimumSize = new Size(1, 1);
            btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            btnAgregarRepuesto.Radius = 12;
            btnAgregarRepuesto.RectColor = Color.FromArgb(0, 165, 155);
            btnAgregarRepuesto.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAgregarRepuesto.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.Size = new Size(52, 46);
            btnAgregarRepuesto.TabIndex = 53;
            btnAgregarRepuesto.Text = "+";
            btnAgregarRepuesto.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgregarRepuesto.TipsForeColor = Color.Transparent;
            btnAgregarRepuesto.Click += btnAgregarRepuesto_Click;
            // 
            // cmbRepuestos
            // 
            cmbRepuestos.BackColor = Color.Transparent;
            cmbRepuestos.DataSource = null;
            cmbRepuestos.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbRepuestos.FillColor = Color.White;
            cmbRepuestos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRepuestos.ForeColor = Color.FromArgb(24, 43, 62);
            cmbRepuestos.FormattingEnabled = true;
            cmbRepuestos.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbRepuestos.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbRepuestos.Location = new Point(29, 438);
            cmbRepuestos.Margin = new Padding(4, 5, 4, 5);
            cmbRepuestos.MinimumSize = new Size(63, 0);
            cmbRepuestos.Name = "cmbRepuestos";
            cmbRepuestos.Padding = new Padding(0, 0, 30, 2);
            cmbRepuestos.Radius = 12;
            cmbRepuestos.RectColor = Color.FromArgb(220, 226, 232);
            cmbRepuestos.Size = new Size(270, 46);
            cmbRepuestos.SymbolSize = 24;
            cmbRepuestos.TabIndex = 54;
            cmbRepuestos.TextAlignment = ContentAlignment.MiddleLeft;
            cmbRepuestos.Watermark = "";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(372, 327);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(111, 17);
            lblObservaciones.TabIndex = 55;
            lblObservaciones.Text = "OBSERVACIONES";
            // 
            // lstObservaciones
            // 
            lstObservaciones.FillColor = Color.White;
            lstObservaciones.Font = new Font("Microsoft Sans Serif", 12F);
            lstObservaciones.ForeColor = Color.FromArgb(24, 43, 62);
            lstObservaciones.HoverColor = Color.FromArgb(155, 200, 255);
            lstObservaciones.ItemSelectForeColor = Color.White;
            lstObservaciones.Location = new Point(372, 349);
            lstObservaciones.Margin = new Padding(4, 5, 4, 5);
            lstObservaciones.MinimumSize = new Size(1, 1);
            lstObservaciones.Name = "lstObservaciones";
            lstObservaciones.Padding = new Padding(6);
            lstObservaciones.Radius = 12;
            lstObservaciones.RectColor = Color.FromArgb(220, 226, 232);
            lstObservaciones.ScrollBarBackColor = Color.FromArgb(232, 248, 247);
            lstObservaciones.ScrollBarColor = Color.FromArgb(0, 165, 155);
            lstObservaciones.ScrollBarStyleInherited = false;
            lstObservaciones.ShowText = false;
            lstObservaciones.Size = new Size(357, 79);
            lstObservaciones.TabIndex = 56;
            lstObservaciones.Text = null;
            // 
            // btnAgregarObservacion
            // 
            btnAgregarObservacion.FillColor = Color.White;
            btnAgregarObservacion.FillColor2 = Color.FromArgb(232, 248, 247);
            btnAgregarObservacion.FillHoverColor = Color.Transparent;
            btnAgregarObservacion.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.Font = new Font("Microsoft Sans Serif", 12F);
            btnAgregarObservacion.ForeColor = Color.FromArgb(0, 165, 155);
            btnAgregarObservacion.Location = new Point(677, 438);
            btnAgregarObservacion.MinimumSize = new Size(1, 1);
            btnAgregarObservacion.Name = "btnAgregarObservacion";
            btnAgregarObservacion.Radius = 12;
            btnAgregarObservacion.RectColor = Color.FromArgb(0, 165, 155);
            btnAgregarObservacion.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAgregarObservacion.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.Size = new Size(52, 46);
            btnAgregarObservacion.TabIndex = 57;
            btnAgregarObservacion.Text = "+";
            btnAgregarObservacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgregarObservacion.TipsForeColor = Color.Transparent;
            btnAgregarObservacion.Click += btnAgregarObservacion_Click;
            // 
            // uiAvatar1
            // 
            uiAvatar1.FillColor = Color.FromArgb(232, 248, 247);
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.ForeColor = Color.FromArgb(0, 165, 155);
            uiAvatar1.Location = new Point(29, 12);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(60, 60);
            uiAvatar1.Symbol = 61564;
            uiAvatar1.TabIndex = 58;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // btnRecibido
            // 
            btnRecibido.FillColor = Color.White;
            btnRecibido.FillPressColor = Color.FromArgb(0, 165, 155);
            btnRecibido.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnRecibido.Font = new Font("Microsoft Sans Serif", 12F);
            btnRecibido.ForeColor = Color.FromArgb(24, 43, 62);
            btnRecibido.Location = new Point(29, 191);
            btnRecibido.MinimumSize = new Size(1, 1);
            btnRecibido.Name = "btnRecibido";
            btnRecibido.Radius = 12;
            btnRecibido.RectColor = Color.FromArgb(220, 226, 232);
            btnRecibido.Size = new Size(136, 46);
            btnRecibido.Symbol = 61468;
            btnRecibido.SymbolColor = Color.FromArgb(70, 86, 103);
            btnRecibido.TabIndex = 59;
            btnRecibido.Text = "Recibido";
            btnRecibido.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRecibido.Click += btnRecibido_Click;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.FillColor = Color.White;
            btnDiagnostico.FillPressColor = Color.FromArgb(0, 165, 155);
            btnDiagnostico.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnDiagnostico.Font = new Font("Microsoft Sans Serif", 12F);
            btnDiagnostico.ForeColor = Color.FromArgb(24, 43, 62);
            btnDiagnostico.Location = new Point(169, 191);
            btnDiagnostico.MinimumSize = new Size(1, 1);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Radius = 12;
            btnDiagnostico.RectColor = Color.FromArgb(220, 226, 232);
            btnDiagnostico.Size = new Size(136, 46);
            btnDiagnostico.Symbol = 61442;
            btnDiagnostico.SymbolColor = Color.FromArgb(70, 86, 103);
            btnDiagnostico.TabIndex = 60;
            btnDiagnostico.Text = "Diagnóstico";
            btnDiagnostico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDiagnostico.Click += btnDiagnostico_Click;
            // 
            // btnEntregado
            // 
            btnEntregado.FillColor = Color.White;
            btnEntregado.FillPressColor = Color.FromArgb(0, 165, 155);
            btnEntregado.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnEntregado.Font = new Font("Microsoft Sans Serif", 12F);
            btnEntregado.ForeColor = Color.FromArgb(24, 43, 62);
            btnEntregado.Location = new Point(593, 191);
            btnEntregado.MinimumSize = new Size(1, 1);
            btnEntregado.Name = "btnEntregado";
            btnEntregado.Radius = 12;
            btnEntregado.RectColor = Color.FromArgb(220, 226, 232);
            btnEntregado.Size = new Size(136, 46);
            btnEntregado.Symbol = 61649;
            btnEntregado.SymbolColor = Color.FromArgb(70, 86, 103);
            btnEntregado.TabIndex = 61;
            btnEntregado.Text = "Entregado";
            btnEntregado.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEntregado.Click += btnEntregado_Click;
            // 
            // btnReparacion
            // 
            btnReparacion.FillColor = Color.White;
            btnReparacion.FillPressColor = Color.FromArgb(0, 165, 155);
            btnReparacion.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnReparacion.Font = new Font("Microsoft Sans Serif", 12F);
            btnReparacion.ForeColor = Color.FromArgb(24, 43, 62);
            btnReparacion.Location = new Point(309, 191);
            btnReparacion.MinimumSize = new Size(1, 1);
            btnReparacion.Name = "btnReparacion";
            btnReparacion.Radius = 12;
            btnReparacion.RectColor = Color.FromArgb(220, 226, 232);
            btnReparacion.Size = new Size(136, 46);
            btnReparacion.Symbol = 61613;
            btnReparacion.SymbolColor = Color.FromArgb(70, 86, 103);
            btnReparacion.TabIndex = 62;
            btnReparacion.Text = "Reparación";
            btnReparacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReparacion.Click += btnReparacion_Click;
            // 
            // btnListo
            // 
            btnListo.FillColor = Color.White;
            btnListo.FillPressColor = Color.FromArgb(0, 165, 155);
            btnListo.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnListo.Font = new Font("Microsoft Sans Serif", 12F);
            btnListo.ForeColor = Color.FromArgb(24, 43, 62);
            btnListo.Location = new Point(451, 191);
            btnListo.MinimumSize = new Size(1, 1);
            btnListo.Name = "btnListo";
            btnListo.Radius = 12;
            btnListo.RectColor = Color.FromArgb(220, 226, 232);
            btnListo.Size = new Size(136, 46);
            btnListo.Symbol = 61533;
            btnListo.SymbolColor = Color.FromArgb(70, 86, 103);
            btnListo.TabIndex = 63;
            btnListo.Text = "Listo";
            btnListo.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnListo.Click += btnListo_Click;
            // 
            // frmDetallesOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(752, 607);
            Controls.Add(btnListo);
            Controls.Add(btnReparacion);
            Controls.Add(btnEntregado);
            Controls.Add(btnDiagnostico);
            Controls.Add(btnRecibido);
            Controls.Add(uiAvatar1);
            Controls.Add(btnAgregarObservacion);
            Controls.Add(lstObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(cmbRepuestos);
            Controls.Add(btnAgregarRepuesto);
            Controls.Add(label2);
            Controls.Add(lstRepuestos);
            Controls.Add(lblTecnicoAsignado);
            Controls.Add(lblActualizarEstado);
            Controls.Add(lblDispositivo);
            Controls.Add(lblCliente);
            Controls.Add(btnListoEntrega);
            Controls.Add(btnDerivar);
            Controls.Add(cmbTecnico);
            Controls.Add(txtObservacion);
            Controls.Add(lblNumeroOrden);
            Controls.Add(lblEditar);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "frmDetallesOrden";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalles de orden";
            Load += frmDetallesOrden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIButton btnListoEntrega;
        private Sunny.UI.UIButton btnDerivar;
        private Sunny.UI.UIComboBox cmbTecnico;
        private Sunny.UI.UITextBox txtObservacion;
        private Label lblNumeroOrden;
        private Label lblEditar;
        private Label lblCliente;
        private Label lblDispositivo;
        private Label lblActualizarEstado;
        private Label lblTecnicoAsignado;
        private Sunny.UI.UIListBox lstRepuestos;
        private Label label2;
        private Sunny.UI.UIButton btnAgregarRepuesto;
        private Sunny.UI.UIComboBox cmbRepuestos;
        private Label lblObservaciones;
        private Sunny.UI.UIListBox lstObservaciones;
        private Sunny.UI.UIButton btnAgregarObservacion;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UISymbolButton btnRecibido;
        private Sunny.UI.UISymbolButton btnDiagnostico;
        private Sunny.UI.UISymbolButton btnEntregado;
        private Sunny.UI.UISymbolButton btnReparacion;
        private Sunny.UI.UISymbolButton btnListo;
    }
}