namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmEditarUsuarios
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
            lblEditar = new Label();
            lblNombre = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdministrador = new Sunny.UI.UIButton();
            btnTecnico = new Sunny.UI.UIButton();
            txtNombre = new Sunny.UI.UITextBox();
            txtUsuario = new Sunny.UI.UITextBox();
            cmbSucursal = new Sunny.UI.UIComboBox();
            btnGuardarCambios = new Sunny.UI.UIButton();
            btnCancelar = new Sunny.UI.UIButton();
            txtContrasena = new Sunny.UI.UITextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(150, 28);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(187, 36);
            lblEditar.TabIndex = 0;
            lblEditar.Text = "Editar Credenciales";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(99, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 171);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 313);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 442);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Sucursal Asignada";
            // 
            // btnAdministrador
            // 
            btnAdministrador.FillColor = Color.FromArgb(22, 35, 52);
            btnAdministrador.FillHoverColor = Color.Transparent;
            btnAdministrador.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdministrador.Location = new Point(99, 331);
            btnAdministrador.MinimumSize = new Size(1, 1);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Radius = 12;
            btnAdministrador.RectColor = Color.FromArgb(39, 53, 72);
            btnAdministrador.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnAdministrador.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAdministrador.Size = new Size(300, 46);
            btnAdministrador.TabIndex = 6;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdministrador.TipsForeColor = Color.Transparent;
            // 
            // btnTecnico
            // 
            btnTecnico.FillColor = Color.FromArgb(22, 35, 52);
            btnTecnico.FillHoverColor = Color.Transparent;
            btnTecnico.FillPressColor = Color.FromArgb(0, 150, 137);
            btnTecnico.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnTecnico.Font = new Font("Microsoft Sans Serif", 12F);
            btnTecnico.Location = new Point(99, 383);
            btnTecnico.MinimumSize = new Size(1, 1);
            btnTecnico.Name = "btnTecnico";
            btnTecnico.Radius = 12;
            btnTecnico.RectColor = Color.FromArgb(39, 53, 72);
            btnTecnico.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnTecnico.RectPressColor = Color.FromArgb(0, 150, 137);
            btnTecnico.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnTecnico.Size = new Size(300, 46);
            btnTecnico.TabIndex = 7;
            btnTecnico.Text = "Técnico";
            btnTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnTecnico.TipsForeColor = Color.Transparent;
            // 
            // txtNombre
            // 
            txtNombre.FillColor = Color.FromArgb(41, 53, 72);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(99, 117);
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
            txtNombre.TabIndex = 15;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Nombre y apellidos";
            // 
            // txtUsuario
            // 
            txtUsuario.FillColor = Color.FromArgb(41, 53, 72);
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(99, 191);
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
            txtUsuario.TabIndex = 16;
            txtUsuario.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuario.Watermark = "Usuario";
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
            cmbSucursal.Location = new Point(99, 462);
            cmbSucursal.Margin = new Padding(4, 5, 4, 5);
            cmbSucursal.MinimumSize = new Size(63, 0);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Padding = new Padding(0, 0, 30, 2);
            cmbSucursal.Radius = 12;
            cmbSucursal.RectColor = Color.FromArgb(148, 163, 184);
            cmbSucursal.Size = new Size(300, 46);
            cmbSucursal.SymbolSize = 24;
            cmbSucursal.TabIndex = 25;
            cmbSucursal.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSucursal.Watermark = "";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarCambios.FillColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(253, 547);
            btnGuardarCambios.MinimumSize = new Size(1, 1);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Radius = 3;
            btnGuardarCambios.RectColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Size = new Size(117, 30);
            btnGuardarCambios.TabIndex = 26;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(130, 547);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 3;
            btnCancelar.RectColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(117, 30);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.FillColor = Color.FromArgb(41, 53, 72);
            txtContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(99, 262);
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
            txtContrasena.TabIndex = 28;
            txtContrasena.TextAlignment = ContentAlignment.MiddleLeft;
            txtContrasena.Watermark = "Nueva Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 242);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 29;
            label1.Text = "Contraseña";
            // 
            // frmEditarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 607);
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
            Name = "frmEditarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditar;
        private Label lblNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Sunny.UI.UIButton btnAdministrador;
        private Sunny.UI.UIButton btnTecnico;
        private Sunny.UI.UITextBox txtNombre;
        private Sunny.UI.UITextBox txtUsuario;
        private Sunny.UI.UIComboBox cmbSucursal;
        private Sunny.UI.UIButton btnGuardarCambios;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UITextBox txtContrasena;
        private Label label1;
    }
}