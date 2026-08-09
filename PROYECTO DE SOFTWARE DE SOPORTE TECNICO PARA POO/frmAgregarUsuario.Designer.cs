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
            btnGuardarCambios = new Sunny.UI.UIButton();
            cmbSucursal = new Sunny.UI.UIComboBox();
            txtUsuario = new Sunny.UI.UITextBox();
            txtNombre = new Sunny.UI.UITextBox();
            btnTecnico = new Sunny.UI.UIButton();
            btnAdministrador = new Sunny.UI.UIButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblNombre = new Label();
            lblEditar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 224);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 43;
            label1.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.FillColor = Color.FromArgb(41, 53, 72);
            txtContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(94, 244);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.MaxLength = 255;
            txtContrasena.Minimum = 0D;
            txtContrasena.MinimumSize = new Size(1, 16);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(5);
            txtContrasena.Radius = 12;
            txtContrasena.RectColor = Color.FromArgb(39, 53, 72);
            txtContrasena.ShowText = false;
            txtContrasena.Size = new Size(300, 46);
            txtContrasena.TabIndex = 42;
            txtContrasena.TextAlignment = ContentAlignment.MiddleLeft;
            txtContrasena.Watermark = "Nueva Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(125, 529);
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
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarCambios.FillColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(248, 529);
            btnGuardarCambios.MinimumSize = new Size(1, 1);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Radius = 3;
            btnGuardarCambios.RectColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Size = new Size(117, 30);
            btnGuardarCambios.TabIndex = 40;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.BackColor = Color.Transparent;
            cmbSucursal.DataSource = null;
            cmbSucursal.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbSucursal.FillColor = Color.FromArgb(41, 53, 72);
            cmbSucursal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.ForeColor = Color.White;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbSucursal.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbSucursal.Location = new Point(94, 444);
            cmbSucursal.Margin = new Padding(4, 5, 4, 5);
            cmbSucursal.MinimumSize = new Size(63, 0);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Padding = new Padding(0, 0, 30, 2);
            cmbSucursal.Radius = 12;
            cmbSucursal.RectColor = Color.FromArgb(148, 163, 184);
            cmbSucursal.Size = new Size(300, 46);
            cmbSucursal.SymbolSize = 24;
            cmbSucursal.TabIndex = 39;
            cmbSucursal.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursal.Watermark = "";
            // 
            // txtUsuario
            // 
            txtUsuario.FillColor = Color.FromArgb(41, 53, 72);
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(94, 173);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 255;
            txtUsuario.Minimum = 0D;
            txtUsuario.MinimumSize = new Size(1, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5);
            txtUsuario.Radius = 12;
            txtUsuario.RectColor = Color.FromArgb(39, 53, 72);
            txtUsuario.ShowText = false;
            txtUsuario.Size = new Size(300, 46);
            txtUsuario.TabIndex = 38;
            txtUsuario.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuario.Watermark = "Usuario";
            // 
            // txtNombre
            // 
            txtNombre.FillColor = Color.FromArgb(41, 53, 72);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(94, 99);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 255;
            txtNombre.Minimum = 0D;
            txtNombre.MinimumSize = new Size(1, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(5);
            txtNombre.Radius = 12;
            txtNombre.RectColor = Color.FromArgb(39, 53, 72);
            txtNombre.ShowText = false;
            txtNombre.Size = new Size(300, 46);
            txtNombre.TabIndex = 37;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Nombre y apellidos";
            // 
            // btnTecnico
            // 
            btnTecnico.FillColor = Color.FromArgb(22, 35, 52);
            btnTecnico.FillHoverColor = Color.Transparent;
            btnTecnico.FillPressColor = Color.FromArgb(0, 150, 137);
            btnTecnico.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnTecnico.Font = new Font("Microsoft Sans Serif", 12F);
            btnTecnico.Location = new Point(94, 365);
            btnTecnico.MinimumSize = new Size(1, 1);
            btnTecnico.Name = "btnTecnico";
            btnTecnico.Radius = 12;
            btnTecnico.RectColor = Color.FromArgb(39, 53, 72);
            btnTecnico.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnTecnico.RectPressColor = Color.FromArgb(0, 150, 137);
            btnTecnico.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnTecnico.Size = new Size(300, 46);
            btnTecnico.TabIndex = 36;
            btnTecnico.Text = "Técnico";
            btnTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTecnico.TipsForeColor = Color.Transparent;
            btnTecnico.Click += btnTecnico_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.FillColor = Color.FromArgb(22, 35, 52);
            btnAdministrador.FillHoverColor = Color.Transparent;
            btnAdministrador.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdministrador.Location = new Point(94, 313);
            btnAdministrador.MinimumSize = new Size(1, 1);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Radius = 12;
            btnAdministrador.RectColor = Color.FromArgb(39, 53, 72);
            btnAdministrador.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAdministrador.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.Size = new Size(300, 46);
            btnAdministrador.TabIndex = 35;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdministrador.TipsForeColor = Color.Transparent;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 424);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 34;
            label5.Text = "Sucursal Asignada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 295);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 33;
            label4.Text = "Perfil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 153);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 32;
            label3.Text = "Nombre de usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(94, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre Completo";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(145, 10);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(187, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Agregar usuario";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 568);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(cmbSucursal);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(btnTecnico);
            Controls.Add(btnAdministrador);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(lblEditar);
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
        private Sunny.UI.UIButton btnGuardarCambios;
        private Sunny.UI.UIComboBox cmbSucursal;
        private Sunny.UI.UITextBox txtUsuario;
        private Sunny.UI.UITextBox txtNombre;
        private Sunny.UI.UIButton btnTecnico;
        private Sunny.UI.UIButton btnAdministrador;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblNombre;
        private Label lblEditar;
    }
}