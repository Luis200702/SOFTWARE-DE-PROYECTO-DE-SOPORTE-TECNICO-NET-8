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
            cmbSucursalDestino = new Sunny.UI.UIComboBox();
            label4 = new Label();
            label3 = new Label();
            lblNombre = new Label();
            lblEditar = new Label();
            txtDetalle = new Sunny.UI.UITextBox();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            btnCancelar = new Sunny.UI.UISymbolButton();
            SuspendLayout();
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.ForeColor = Color.FromArgb(24, 43, 62);
            txtMotivo.Location = new Point(29, 177);
            txtMotivo.Margin = new Padding(4, 5, 4, 5);
            txtMotivo.MaxLength = 255;
            txtMotivo.Minimum = 0D;
            txtMotivo.MinimumSize = new Size(1, 16);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Padding = new Padding(5);
            txtMotivo.Radius = 12;
            txtMotivo.RectColor = Color.FromArgb(220, 226, 232);
            txtMotivo.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtMotivo.ShowText = false;
            txtMotivo.Size = new Size(685, 137);
            txtMotivo.Symbol = 61564;
            txtMotivo.TabIndex = 42;
            txtMotivo.TextAlignment = ContentAlignment.TopLeft;
            txtMotivo.Watermark = "Ingrese el motivo de la derivación...";
            txtMotivo.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // cmbSucursalDestino
            // 
            cmbSucursalDestino.BackColor = Color.Transparent;
            cmbSucursalDestino.DataSource = null;
            cmbSucursalDestino.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbSucursalDestino.FillColor = Color.White;
            cmbSucursalDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursalDestino.ForeColor = Color.FromArgb(70, 86, 103);
            cmbSucursalDestino.FormattingEnabled = true;
            cmbSucursalDestino.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbSucursalDestino.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbSucursalDestino.Location = new Point(29, 104);
            cmbSucursalDestino.Margin = new Padding(4, 5, 4, 5);
            cmbSucursalDestino.MinimumSize = new Size(63, 0);
            cmbSucursalDestino.Name = "cmbSucursalDestino";
            cmbSucursalDestino.Padding = new Padding(0, 0, 30, 2);
            cmbSucursalDestino.Radius = 12;
            cmbSucursalDestino.RectColor = Color.FromArgb(220, 226, 232);
            cmbSucursalDestino.RectDisableColor = Color.FromArgb(0, 165, 155);
            cmbSucursalDestino.Size = new Size(685, 46);
            cmbSucursalDestino.SymbolSize = 24;
            cmbSucursalDestino.TabIndex = 39;
            cmbSucursalDestino.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursalDestino.Watermark = "Selecione una sucursal";
            cmbSucursalDestino.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(24, 43, 62);
            label4.Location = new Point(29, 319);
            label4.Name = "label4";
            label4.Size = new Size(171, 17);
            label4.TabIndex = 33;
            label4.Text = "Observaciones adicionales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(24, 43, 62);
            label3.Location = new Point(29, 155);
            label3.Name = "label3";
            label3.Size = new Size(139, 17);
            label3.TabIndex = 32;
            label3.Text = "Motivo de derivación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(24, 43, 62);
            lblNombre.Location = new Point(29, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 17);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Sucursal destino";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.ForeColor = Color.FromArgb(24, 43, 62);
            lblEditar.Location = new Point(75, 27);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(302, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Derivar orden a otra sucursal";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetalle
            // 
            txtDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalle.ForeColor = Color.FromArgb(24, 43, 62);
            txtDetalle.Location = new Point(29, 341);
            txtDetalle.Margin = new Padding(4, 5, 4, 5);
            txtDetalle.MaxLength = 255;
            txtDetalle.Minimum = 0D;
            txtDetalle.MinimumSize = new Size(1, 16);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Padding = new Padding(5);
            txtDetalle.Radius = 12;
            txtDetalle.RectColor = Color.FromArgb(220, 226, 232);
            txtDetalle.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtDetalle.ShowText = false;
            txtDetalle.Size = new Size(685, 160);
            txtDetalle.Symbol = 61557;
            txtDetalle.TabIndex = 43;
            txtDetalle.TextAlignment = ContentAlignment.MiddleLeft;
            txtDetalle.Watermark = "Ingrese observaciones adicionales...";
            txtDetalle.WatermarkColor = Color.FromArgb(145, 158, 172);
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
            uiAvatar1.Symbol = 61734;
            uiAvatar1.TabIndex = 59;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.FillColor = Color.FromArgb(0, 165, 155);
            uiSymbolButton1.FillHoverColor = Color.FromArgb(0, 145, 137);
            uiSymbolButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            uiSymbolButton1.Location = new Point(337, 565);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 12;
            uiSymbolButton1.RectColor = Color.FromArgb(0, 165, 155);
            uiSymbolButton1.Size = new Size(182, 30);
            uiSymbolButton1.TabIndex = 60;
            uiSymbolButton1.Text = "Confirmar derivación";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiSymbolButton1.Click += btnConfirmarDerivacion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FillColor = Color.White;
            btnCancelar.FillHoverColor = Color.FromArgb(232, 248, 247);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(0, 145, 137);
            btnCancelar.Location = new Point(224, 565);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectColor = Color.FromArgb(0, 165, 155);
            btnCancelar.Size = new Size(107, 30);
            btnCancelar.Symbol = 61527;
            btnCancelar.SymbolColor = Color.FromArgb(0, 145, 137);
            btnCancelar.TabIndex = 61;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // frmSeguimientoDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(752, 607);
            Controls.Add(btnCancelar);
            Controls.Add(uiSymbolButton1);
            Controls.Add(uiAvatar1);
            Controls.Add(txtDetalle);
            Controls.Add(txtMotivo);
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
        private Sunny.UI.UIComboBox cmbSucursalDestino;
        private Sunny.UI.UIButton btnAdministrador;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblNombre;
        private Label lblEditar;
        private Sunny.UI.UITextBox txtDetalle;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton btnCancelar;
    }
}