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
            btnDiagnostico = new Sunny.UI.UIButton();
            btnRecibido = new Sunny.UI.UIButton();
            lblNumeroOrden = new Label();
            lblEditar = new Label();
            lblCliente = new Label();
            lblDispositivo = new Label();
            btnListo = new Sunny.UI.UIButton();
            btnReparacion = new Sunny.UI.UIButton();
            btnEntregado = new Sunny.UI.UIButton();
            lblActualizarEstado = new Label();
            lblTecnicoAsignado = new Label();
            lstRepuestos = new Sunny.UI.UIListBox();
            label2 = new Label();
            btnAgregarRepuesto = new Sunny.UI.UIButton();
            cmbRepuestos = new Sunny.UI.UIComboBox();
            lblObservaciones = new Label();
            lstObservaciones = new Sunny.UI.UIListBox();
            btnAgregarObservacion = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // btnListoEntrega
            // 
            btnListoEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnListoEntrega.FillColor = Color.FromArgb(0, 150, 137);
            btnListoEntrega.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListoEntrega.Location = new Point(171, 548);
            btnListoEntrega.MinimumSize = new Size(1, 1);
            btnListoEntrega.Name = "btnListoEntrega";
            btnListoEntrega.Radius = 3;
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
            btnDerivar.FillColor = Color.FromArgb(0, 150, 137);
            btnDerivar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDerivar.Location = new Point(372, 548);
            btnDerivar.MinimumSize = new Size(1, 1);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.Radius = 3;
            btnDerivar.RectColor = Color.FromArgb(0, 150, 137);
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
            cmbTecnico.FillColor = Color.FromArgb(75, 92, 108);
            cmbTecnico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTecnico.ForeColor = Color.White;
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbTecnico.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbTecnico.Location = new Point(29, 271);
            cmbTecnico.Margin = new Padding(4, 5, 4, 5);
            cmbTecnico.MinimumSize = new Size(63, 0);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Padding = new Padding(0, 0, 30, 2);
            cmbTecnico.Radius = 12;
            cmbTecnico.RectColor = Color.FromArgb(148, 163, 184);
            cmbTecnico.Size = new Size(300, 46);
            cmbTecnico.SymbolSize = 24;
            cmbTecnico.TabIndex = 39;
            cmbTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTecnico.Watermark = "";
            // 
            // txtObservacion
            // 
            txtObservacion.FillColor = Color.FromArgb(75, 92, 108);
            txtObservacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacion.ForeColor = Color.White;
            txtObservacion.Location = new Point(361, 438);
            txtObservacion.Margin = new Padding(4, 5, 4, 5);
            txtObservacion.MaxLength = 255;
            txtObservacion.Minimum = 0D;
            txtObservacion.MinimumSize = new Size(1, 16);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Padding = new Padding(5);
            txtObservacion.Radius = 12;
            txtObservacion.RectColor = Color.FromArgb(39, 53, 72);
            txtObservacion.ShowText = false;
            txtObservacion.Size = new Size(300, 46);
            txtObservacion.TabIndex = 38;
            txtObservacion.TextAlignment = ContentAlignment.MiddleLeft;
            txtObservacion.Watermark = "Nueva observacion";
            txtObservacion.WatermarkActiveColor = Color.WhiteSmoke;
            txtObservacion.WatermarkColor = Color.WhiteSmoke;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.FillColor = Color.FromArgb(75, 92, 108);
            btnDiagnostico.FillHoverColor = Color.Transparent;
            btnDiagnostico.FillPressColor = Color.FromArgb(0, 150, 137);
            btnDiagnostico.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnDiagnostico.Font = new Font("Microsoft Sans Serif", 12F);
            btnDiagnostico.Location = new Point(171, 191);
            btnDiagnostico.MinimumSize = new Size(1, 1);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Radius = 12;
            btnDiagnostico.RectColor = Color.FromArgb(39, 53, 72);
            btnDiagnostico.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnDiagnostico.RectPressColor = Color.FromArgb(0, 150, 137);
            btnDiagnostico.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnDiagnostico.Size = new Size(132, 46);
            btnDiagnostico.TabIndex = 36;
            btnDiagnostico.Text = "Diagnóstico";
            btnDiagnostico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDiagnostico.TipsForeColor = Color.Transparent;
            btnDiagnostico.Click += btnDiagnostico_Click;
            // 
            // btnRecibido
            // 
            btnRecibido.FillColor = Color.FromArgb(75, 92, 108);
            btnRecibido.FillHoverColor = Color.Transparent;
            btnRecibido.FillPressColor = Color.FromArgb(0, 150, 137);
            btnRecibido.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnRecibido.Font = new Font("Microsoft Sans Serif", 12F);
            btnRecibido.Location = new Point(29, 191);
            btnRecibido.MinimumSize = new Size(1, 1);
            btnRecibido.Name = "btnRecibido";
            btnRecibido.Radius = 12;
            btnRecibido.RectColor = Color.FromArgb(39, 53, 72);
            btnRecibido.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnRecibido.RectPressColor = Color.FromArgb(0, 150, 137);
            btnRecibido.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnRecibido.Size = new Size(136, 46);
            btnRecibido.TabIndex = 35;
            btnRecibido.Text = "Recibido";
            btnRecibido.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRecibido.TipsForeColor = Color.Transparent;
            btnRecibido.Click += btnRecibido_Click;
            // 
            // lblNumeroOrden
            // 
            lblNumeroOrden.AutoSize = true;
            lblNumeroOrden.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblNumeroOrden.Location = new Point(41, 93);
            lblNumeroOrden.Name = "lblNumeroOrden";
            lblNumeroOrden.Size = new Size(15, 17);
            lblNumeroOrden.TabIndex = 31;
            lblNumeroOrden.Text = "x";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(277, 29);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(187, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Detalle de orden";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCliente.Location = new Point(41, 118);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(15, 17);
            lblCliente.TabIndex = 44;
            lblCliente.Text = "x";
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblDispositivo.Location = new Point(41, 142);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(15, 17);
            lblDispositivo.TabIndex = 45;
            lblDispositivo.Text = "x";
            // 
            // btnListo
            // 
            btnListo.FillColor = Color.FromArgb(75, 92, 108);
            btnListo.FillHoverColor = Color.Transparent;
            btnListo.FillPressColor = Color.FromArgb(0, 150, 137);
            btnListo.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnListo.Font = new Font("Microsoft Sans Serif", 12F);
            btnListo.Location = new Point(451, 191);
            btnListo.MinimumSize = new Size(1, 1);
            btnListo.Name = "btnListo";
            btnListo.Radius = 12;
            btnListo.RectColor = Color.FromArgb(39, 53, 72);
            btnListo.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnListo.RectPressColor = Color.FromArgb(0, 150, 137);
            btnListo.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnListo.Size = new Size(136, 46);
            btnListo.TabIndex = 47;
            btnListo.Text = "Listo";
            btnListo.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnListo.TipsForeColor = Color.Transparent;
            btnListo.Click += btnListo_Click;
            // 
            // btnReparacion
            // 
            btnReparacion.FillColor = Color.FromArgb(75, 92, 108);
            btnReparacion.FillHoverColor = Color.Transparent;
            btnReparacion.FillPressColor = Color.FromArgb(0, 150, 137);
            btnReparacion.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparacion.Font = new Font("Microsoft Sans Serif", 12F);
            btnReparacion.Location = new Point(309, 191);
            btnReparacion.MinimumSize = new Size(1, 1);
            btnReparacion.Name = "btnReparacion";
            btnReparacion.Radius = 12;
            btnReparacion.RectColor = Color.FromArgb(39, 53, 72);
            btnReparacion.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnReparacion.RectPressColor = Color.FromArgb(0, 150, 137);
            btnReparacion.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnReparacion.Size = new Size(136, 46);
            btnReparacion.TabIndex = 46;
            btnReparacion.Text = "Reparación";
            btnReparacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReparacion.TipsForeColor = Color.Transparent;
            btnReparacion.Click += btnReparacion_Click;
            // 
            // btnEntregado
            // 
            btnEntregado.FillColor = Color.FromArgb(75, 92, 108);
            btnEntregado.FillHoverColor = Color.Transparent;
            btnEntregado.FillPressColor = Color.FromArgb(0, 150, 137);
            btnEntregado.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnEntregado.Font = new Font("Microsoft Sans Serif", 12F);
            btnEntregado.Location = new Point(593, 191);
            btnEntregado.MinimumSize = new Size(1, 1);
            btnEntregado.Name = "btnEntregado";
            btnEntregado.Radius = 12;
            btnEntregado.RectColor = Color.FromArgb(39, 53, 72);
            btnEntregado.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnEntregado.RectPressColor = Color.FromArgb(0, 150, 137);
            btnEntregado.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnEntregado.Size = new Size(136, 46);
            btnEntregado.TabIndex = 48;
            btnEntregado.Text = "Entregado";
            btnEntregado.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEntregado.TipsForeColor = Color.Transparent;
            btnEntregado.Click += btnEntregado_Click;
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
            lstRepuestos.Font = new Font("Microsoft Sans Serif", 12F);
            lstRepuestos.HoverColor = Color.FromArgb(155, 200, 255);
            lstRepuestos.ItemSelectForeColor = Color.White;
            lstRepuestos.Location = new Point(29, 349);
            lstRepuestos.Margin = new Padding(4, 5, 4, 5);
            lstRepuestos.MinimumSize = new Size(1, 1);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Padding = new Padding(6);
            lstRepuestos.Radius = 12;
            lstRepuestos.RectColor = Color.FromArgb(39, 53, 72);
            lstRepuestos.ShowText = false;
            lstRepuestos.Size = new Size(300, 79);
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
            btnAgregarRepuesto.FillColor = Color.FromArgb(75, 92, 108);
            btnAgregarRepuesto.FillHoverColor = Color.Transparent;
            btnAgregarRepuesto.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.Font = new Font("Microsoft Sans Serif", 12F);
            btnAgregarRepuesto.Location = new Point(257, 438);
            btnAgregarRepuesto.MinimumSize = new Size(1, 1);
            btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            btnAgregarRepuesto.Radius = 12;
            btnAgregarRepuesto.RectColor = Color.FromArgb(39, 53, 72);
            btnAgregarRepuesto.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAgregarRepuesto.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarRepuesto.Size = new Size(72, 46);
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
            cmbRepuestos.FillColor = Color.FromArgb(75, 92, 108);
            cmbRepuestos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRepuestos.ForeColor = Color.White;
            cmbRepuestos.FormattingEnabled = true;
            cmbRepuestos.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbRepuestos.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbRepuestos.Location = new Point(29, 438);
            cmbRepuestos.Margin = new Padding(4, 5, 4, 5);
            cmbRepuestos.MinimumSize = new Size(63, 0);
            cmbRepuestos.Name = "cmbRepuestos";
            cmbRepuestos.Padding = new Padding(0, 0, 30, 2);
            cmbRepuestos.Radius = 12;
            cmbRepuestos.RectColor = Color.FromArgb(148, 163, 184);
            cmbRepuestos.Size = new Size(221, 46);
            cmbRepuestos.SymbolSize = 24;
            cmbRepuestos.TabIndex = 54;
            cmbRepuestos.TextAlignment = ContentAlignment.MiddleLeft;
            cmbRepuestos.Watermark = "";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(366, 327);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(98, 17);
            lblObservaciones.TabIndex = 55;
            lblObservaciones.Text = "Observaciones";
            lblObservaciones.Click += lblObservaciones_Click;
            // 
            // lstObservaciones
            // 
            lstObservaciones.Font = new Font("Microsoft Sans Serif", 12F);
            lstObservaciones.HoverColor = Color.FromArgb(155, 200, 255);
            lstObservaciones.ItemSelectForeColor = Color.White;
            lstObservaciones.Location = new Point(361, 349);
            lstObservaciones.Margin = new Padding(4, 5, 4, 5);
            lstObservaciones.MinimumSize = new Size(1, 1);
            lstObservaciones.Name = "lstObservaciones";
            lstObservaciones.Padding = new Padding(6);
            lstObservaciones.Radius = 12;
            lstObservaciones.RectColor = Color.FromArgb(39, 53, 72);
            lstObservaciones.ShowText = false;
            lstObservaciones.Size = new Size(300, 79);
            lstObservaciones.TabIndex = 56;
            lstObservaciones.Text = null;
            // 
            // btnAgregarObservacion
            // 
            btnAgregarObservacion.FillColor = Color.FromArgb(75, 92, 108);
            btnAgregarObservacion.FillHoverColor = Color.Transparent;
            btnAgregarObservacion.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.Font = new Font("Microsoft Sans Serif", 12F);
            btnAgregarObservacion.Location = new Point(668, 438);
            btnAgregarObservacion.MinimumSize = new Size(1, 1);
            btnAgregarObservacion.Name = "btnAgregarObservacion";
            btnAgregarObservacion.Radius = 12;
            btnAgregarObservacion.RectColor = Color.FromArgb(39, 53, 72);
            btnAgregarObservacion.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAgregarObservacion.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgregarObservacion.Size = new Size(72, 46);
            btnAgregarObservacion.TabIndex = 57;
            btnAgregarObservacion.Text = "+";
            btnAgregarObservacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgregarObservacion.TipsForeColor = Color.Transparent;
            btnAgregarObservacion.Click += btnAgregarObservacion_Click;
            // 
            // frmDetallesOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 199, 189);
            ClientSize = new Size(752, 607);
            Controls.Add(btnAgregarObservacion);
            Controls.Add(lstObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(cmbRepuestos);
            Controls.Add(btnAgregarRepuesto);
            Controls.Add(label2);
            Controls.Add(lstRepuestos);
            Controls.Add(lblTecnicoAsignado);
            Controls.Add(lblActualizarEstado);
            Controls.Add(btnEntregado);
            Controls.Add(btnListo);
            Controls.Add(btnReparacion);
            Controls.Add(lblDispositivo);
            Controls.Add(lblCliente);
            Controls.Add(btnListoEntrega);
            Controls.Add(btnDerivar);
            Controls.Add(cmbTecnico);
            Controls.Add(txtObservacion);
            Controls.Add(btnDiagnostico);
            Controls.Add(btnRecibido);
            Controls.Add(lblNumeroOrden);
            Controls.Add(lblEditar);
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
        private Sunny.UI.UIButton btnDiagnostico;
        private Sunny.UI.UIButton btnRecibido;
        private Label lblNumeroOrden;
        private Label lblEditar;
        private Label lblCliente;
        private Label lblDispositivo;
        private Sunny.UI.UIButton btnListo;
        private Sunny.UI.UIButton btnReparacion;
        private Sunny.UI.UIButton btnEntregado;
        private Label lblActualizarEstado;
        private Label lblTecnicoAsignado;
        private Sunny.UI.UIListBox lstRepuestos;
        private Label label2;
        private Sunny.UI.UIButton btnAgregarRepuesto;
        private Sunny.UI.UIComboBox cmbRepuestos;
        private Label lblObservaciones;
        private Sunny.UI.UIListBox lstObservaciones;
        private Sunny.UI.UIButton btnAgregarObservacion;
    }
}