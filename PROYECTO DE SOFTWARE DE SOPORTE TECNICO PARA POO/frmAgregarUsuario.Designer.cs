namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmAgregarUsuario
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
            label1 = new Label();
            txtContrasena = new Sunny.UI.UITextBox();
            btnCancelar = new Sunny.UI.UIButton();
            cmbSucursal = new Sunny.UI.UIComboBox();
            txtUsuario = new Sunny.UI.UITextBox();
            txtNombre = new Sunny.UI.UITextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNombre = new Label();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            lblEditar = new Label();
            btnAdministrador = new Sunny.UI.UISymbolButton();
            btnTecnico = new Sunny.UI.UISymbolButton();
            btnGuardarCambios = new Sunny.UI.UISymbolButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 43, 62);
            label1.Location = new Point(29, 224);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 43;
            label1.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.FromArgb(24, 43, 62);
            txtContrasena.Location = new Point(29, 244);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.MaxLength = 255;
            txtContrasena.Minimum = 0D;
            txtContrasena.MinimumSize = new Size(1, 16);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(5);
            txtContrasena.Radius = 12;
            txtContrasena.RectColor = Color.FromArgb(220, 226, 232);
            txtContrasena.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtContrasena.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtContrasena.ShowText = false;
            txtContrasena.Size = new Size(424, 46);
            txtContrasena.Symbol = 61475;
            txtContrasena.SymbolColor = Color.FromArgb(0, 165, 155);
            txtContrasena.TabIndex = 42;
            txtContrasena.TextAlignment = ContentAlignment.MiddleLeft;
            txtContrasena.Watermark = "Nueva Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.White;
            btnCancelar.FillHoverColor = Color.FromArgb(243, 246, 250);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(24, 43, 62);
            btnCancelar.Location = new Point(92, 458);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectColor = Color.FromArgb(220, 226, 232);
            btnCancelar.Size = new Size(123, 40);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.BackColor = Color.Transparent;
            cmbSucursal.DataSource = null;
            cmbSucursal.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbSucursal.FillColor = Color.White;
            cmbSucursal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.ForeColor = Color.FromArgb(24, 43, 62);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbSucursal.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbSucursal.Location = new Point(29, 393);
            cmbSucursal.Margin = new Padding(4, 5, 4, 5);
            cmbSucursal.MinimumSize = new Size(63, 0);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Padding = new Padding(0, 0, 30, 2);
            cmbSucursal.Radius = 12;
            cmbSucursal.RectColor = Color.FromArgb(220, 226, 232);
            cmbSucursal.RectDisableColor = Color.FromArgb(0, 165, 155);
            cmbSucursal.Size = new Size(424, 46);
            cmbSucursal.SymbolDropDown = 61841;
            cmbSucursal.SymbolNormal = 61841;
            cmbSucursal.SymbolSize = 24;
            cmbSucursal.TabIndex = 39;
            cmbSucursal.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursal.Watermark = "";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(24, 43, 62);
            txtUsuario.Location = new Point(29, 173);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 255;
            txtUsuario.Minimum = 0D;
            txtUsuario.MinimumSize = new Size(1, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5);
            txtUsuario.Radius = 12;
            txtUsuario.RectColor = Color.FromArgb(220, 226, 232);
            txtUsuario.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtUsuario.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtUsuario.ShowText = false;
            txtUsuario.Size = new Size(424, 46);
            txtUsuario.Symbol = 62144;
            txtUsuario.SymbolColor = Color.FromArgb(0, 165, 155);
            txtUsuario.TabIndex = 38;
            txtUsuario.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuario.Watermark = "Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.FromArgb(24, 43, 62);
            txtNombre.Location = new Point(29, 102);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 255;
            txtNombre.Minimum = 0D;
            txtNombre.MinimumSize = new Size(1, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(5);
            txtNombre.Radius = 12;
            txtNombre.RectColor = Color.FromArgb(220, 226, 232);
            txtNombre.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtNombre.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtNombre.ShowText = false;
            txtNombre.Size = new Size(424, 46);
            txtNombre.Symbol = 62144;
            txtNombre.SymbolColor = Color.FromArgb(0, 165, 155);
            txtNombre.TabIndex = 37;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Nombre y apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(29, 371);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 34;
            label5.Text = "Sucursal Asignada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(24, 43, 62);
            label4.Location = new Point(29, 295);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 33;
            label4.Text = "Perfil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(24, 43, 62);
            label3.Location = new Point(29, 153);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 32;
            label3.Text = "Nombre de usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(24, 43, 62);
            lblNombre.Location = new Point(29, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(122, 17);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre Completo";
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
            uiAvatar1.Symbol = 62004;
            uiAvatar1.TabIndex = 59;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.ForeColor = Color.FromArgb(24, 43, 62);
            lblEditar.Location = new Point(98, 24);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(149, 36);
            lblEditar.TabIndex = 60;
            lblEditar.Text = "Agregar perfil";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdministrador
            // 
            btnAdministrador.FillColor = Color.White;
            btnAdministrador.FillPressColor = Color.FromArgb(0, 165, 155);
            btnAdministrador.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnAdministrador.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdministrador.ForeColor = Color.FromArgb(24, 43, 62);
            btnAdministrador.Location = new Point(29, 313);
            btnAdministrador.MinimumSize = new Size(1, 1);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Radius = 12;
            btnAdministrador.RectColor = Color.FromArgb(220, 226, 232);
            btnAdministrador.Size = new Size(198, 46);
            btnAdministrador.Symbol = 61612;
            btnAdministrador.SymbolColor = Color.FromArgb(70, 86, 103);
            btnAdministrador.TabIndex = 61;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // btnTecnico
            // 
            btnTecnico.FillColor = Color.White;
            btnTecnico.FillPressColor = Color.FromArgb(0, 165, 155);
            btnTecnico.FillSelectedColor = Color.FromArgb(0, 165, 155);
            btnTecnico.Font = new Font("Microsoft Sans Serif", 12F);
            btnTecnico.ForeColor = Color.FromArgb(24, 43, 62);
            btnTecnico.Location = new Point(248, 313);
            btnTecnico.MinimumSize = new Size(1, 1);
            btnTecnico.Name = "btnTecnico";
            btnTecnico.Radius = 12;
            btnTecnico.RectColor = Color.FromArgb(220, 226, 232);
            btnTecnico.Size = new Size(205, 46);
            btnTecnico.Symbol = 61613;
            btnTecnico.SymbolColor = Color.FromArgb(70, 86, 103);
            btnTecnico.TabIndex = 62;
            btnTecnico.Text = "Técnico";
            btnTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTecnico.Click += btnTecnico_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.FillColor = Color.FromArgb(0, 165, 155);
            btnGuardarCambios.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnGuardarCambios.FillPressColor = Color.FromArgb(0, 125, 117);
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardarCambios.Location = new Point(230, 458);
            btnGuardarCambios.MinimumSize = new Size(1, 1);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Radius = 12;
            btnGuardarCambios.RectColor = Color.FromArgb(0, 165, 155);
            btnGuardarCambios.Size = new Size(156, 40);
            btnGuardarCambios.Symbol = 61639;
            btnGuardarCambios.TabIndex = 64;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(488, 510);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnTecnico);
            Controls.Add(btnAdministrador);
            Controls.Add(lblEditar);
            Controls.Add(uiAvatar1);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(btnCancelar);
            Controls.Add(cmbSucursal);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Sunny.UI.UITextBox txtContrasena;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIComboBox cmbSucursal;
        private Sunny.UI.UITextBox txtUsuario;
        private Sunny.UI.UITextBox txtNombre;

        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblNombre;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Label lblEditar;
        private Sunny.UI.UISymbolButton btnRecibido;
        private Sunny.UI.UISymbolButton btnTecnico;
        private Sunny.UI.UISymbolButton btnAdministrador;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton btnGuardarCambios;
    }
}