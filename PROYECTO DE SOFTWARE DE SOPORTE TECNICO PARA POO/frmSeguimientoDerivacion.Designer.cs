namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmSeguimientoDerivacion
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
            txtMotivo = new Sunny.UI.UITextBox();
            btnCancelar = new Sunny.UI.UIButton();
            btnConfirmarDerivacion = new Sunny.UI.UIButton();
            cmbSucursalDestino = new Sunny.UI.UIComboBox();
            label4 = new Label();
            label3 = new Label();
            lblNombre = new Label();
            lblEditar = new Label();
            txtDetalle = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // txtMotivo
            // 
            txtMotivo.FillColor = Color.FromArgb(41, 53, 72);
            txtMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.ForeColor = Color.White;
            txtMotivo.Location = new Point(97, 173);
            txtMotivo.Margin = new Padding(4, 5, 4, 5);
            txtMotivo.MaxLength = 255;
            txtMotivo.Minimum = 0D;
            txtMotivo.MinimumSize = new Size(1, 16);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Padding = new Padding(5);
            txtMotivo.Radius = 12;
            txtMotivo.RectColor = Color.FromArgb(39, 53, 72);
            txtMotivo.ShowText = false;
            txtMotivo.Size = new Size(300, 73);
            txtMotivo.TabIndex = 42;
            txtMotivo.TextAlignment = ContentAlignment.MiddleLeft;
            txtMotivo.Watermark = "...";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(108, 378);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 3;
            btnCancelar.RectColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(117, 30);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarDerivacion
            // 
            btnConfirmarDerivacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmarDerivacion.FillColor = Color.FromArgb(0, 150, 137);
            btnConfirmarDerivacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarDerivacion.Location = new Point(243, 378);
            btnConfirmarDerivacion.MinimumSize = new Size(1, 1);
            btnConfirmarDerivacion.Name = "btnConfirmarDerivacion";
            btnConfirmarDerivacion.Radius = 3;
            btnConfirmarDerivacion.RectColor = Color.FromArgb(0, 150, 137);
            btnConfirmarDerivacion.Size = new Size(151, 30);
            btnConfirmarDerivacion.TabIndex = 40;
            btnConfirmarDerivacion.Text = "Confirmar derivación";
            btnConfirmarDerivacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnConfirmarDerivacion.Click += btnConfirmarDerivacion_Click;
            // 
            // cmbSucursalDestino
            // 
            cmbSucursalDestino.BackColor = Color.Transparent;
            cmbSucursalDestino.DataSource = null;
            cmbSucursalDestino.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbSucursalDestino.FillColor = Color.FromArgb(41, 53, 72);
            cmbSucursalDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursalDestino.ForeColor = Color.White;
            cmbSucursalDestino.FormattingEnabled = true;
            cmbSucursalDestino.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbSucursalDestino.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbSucursalDestino.Location = new Point(97, 102);
            cmbSucursalDestino.Margin = new Padding(4, 5, 4, 5);
            cmbSucursalDestino.MinimumSize = new Size(63, 0);
            cmbSucursalDestino.Name = "cmbSucursalDestino";
            cmbSucursalDestino.Padding = new Padding(0, 0, 30, 2);
            cmbSucursalDestino.Radius = 12;
            cmbSucursalDestino.RectColor = Color.FromArgb(148, 163, 184);
            cmbSucursalDestino.Size = new Size(300, 46);
            cmbSucursalDestino.SymbolSize = 24;
            cmbSucursalDestino.TabIndex = 39;
            cmbSucursalDestino.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursalDestino.Watermark = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 251);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 33;
            label4.Text = "Observaciones adicionales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 153);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 32;
            label3.Text = "Motivo de derivación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(94, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Sucursal destino";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(92, 9);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(302, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Derivar orden a otra sucursal";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetalle
            // 
            txtDetalle.FillColor = Color.FromArgb(41, 53, 72);
            txtDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalle.ForeColor = Color.White;
            txtDetalle.Location = new Point(94, 271);
            txtDetalle.Margin = new Padding(4, 5, 4, 5);
            txtDetalle.MaxLength = 255;
            txtDetalle.Minimum = 0D;
            txtDetalle.MinimumSize = new Size(1, 16);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Padding = new Padding(5);
            txtDetalle.Radius = 12;
            txtDetalle.RectColor = Color.FromArgb(39, 53, 72);
            txtDetalle.ShowText = false;
            txtDetalle.Size = new Size(300, 73);
            txtDetalle.TabIndex = 43;
            txtDetalle.TextAlignment = ContentAlignment.MiddleLeft;
            txtDetalle.Watermark = "...";
            // 
            // frmSeguimientoDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 429);
            Controls.Add(txtDetalle);
            Controls.Add(txtMotivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarDerivacion);
            Controls.Add(cmbSucursalDestino);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(lblEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSeguimientoDerivacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeguimientoDerivacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Sunny.UI.UITextBox txtMotivo;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnConfirmarDerivacion;
        private Sunny.UI.UIComboBox cmbSucursalDestino;
        private Sunny.UI.UIButton btnAdministrador;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblNombre;
        private Label lblEditar;
        private Sunny.UI.UITextBox txtDetalle;
    }
}