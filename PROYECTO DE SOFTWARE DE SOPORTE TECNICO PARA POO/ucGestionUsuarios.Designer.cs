namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucGestionUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            btnNuevoTecnico = new Sunny.UI.UIButton();
            txtBuscarTecnico = new Sunny.UI.UITextBox();
            dgvUsuarios = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Perfil = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            pnlSuperior.Size = new Size(1037, 59);
            pnlSuperior.TabIndex = 2;
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
            lblTitulo.Text = "Gestión de Usuarios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(btnNuevoTecnico);
            pnlInformacion.Controls.Add(txtBuscarTecnico);
            pnlInformacion.ForeColor = Color.Coral;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1031, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // btnNuevoTecnico
            // 
            btnNuevoTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoTecnico.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevoTecnico.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoTecnico.Location = new Point(874, 16);
            btnNuevoTecnico.MinimumSize = new Size(1, 1);
            btnNuevoTecnico.Name = "btnNuevoTecnico";
            btnNuevoTecnico.Radius = 3;
            btnNuevoTecnico.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevoTecnico.Size = new Size(117, 30);
            btnNuevoTecnico.TabIndex = 20;
            btnNuevoTecnico.Text = "Nuevo Técnico";
            btnNuevoTecnico.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevoTecnico.Click += btnNuevoTecnico_Click;
            // 
            // txtBuscarTecnico
            // 
            txtBuscarTecnico.BackColor = Color.Transparent;
            txtBuscarTecnico.FillColor = Color.LightGray;
            txtBuscarTecnico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTecnico.ForeColor = Color.Black;
            txtBuscarTecnico.Icon = Properties.Resources.TablerSearch;
            txtBuscarTecnico.Location = new Point(29, 16);
            txtBuscarTecnico.Margin = new Padding(4, 5, 4, 5);
            txtBuscarTecnico.MinimumSize = new Size(1, 16);
            txtBuscarTecnico.Name = "txtBuscarTecnico";
            txtBuscarTecnico.Padding = new Padding(5);
            txtBuscarTecnico.Radius = 12;
            txtBuscarTecnico.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscarTecnico.ShowText = false;
            txtBuscarTecnico.Size = new Size(295, 30);
            txtBuscarTecnico.TabIndex = 3;
            txtBuscarTecnico.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarTecnico.Watermark = "Buscar usuario...";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 50;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Nombre, Usuario, Perfil, Sucursal, Editar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = SystemColors.InactiveCaptionText;
            dgvUsuarios.Location = new Point(0, 120);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 12, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowTemplate.Height = 40;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvUsuarios.Size = new Size(1024, 661);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.RowPostPaint += dgvUsuarios_RowPostPaint;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "USUARIO";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Perfil
            // 
            Perfil.HeaderText = "PERFIL";
            Perfil.MinimumWidth = 6;
            Perfil.Name = "Perfil";
            Perfil.ReadOnly = true;
            // 
            // Sucursal
            // 
            Sucursal.HeaderText = "SUCURSAL";
            Sucursal.MinimumWidth = 6;
            Sucursal.Name = "Sucursal";
            Sucursal.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "EDITAR";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.True;
            Editar.SortMode = DataGridViewColumnSortMode.Automatic;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // ucGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucGestionUsuarios";
            Size = new Size(1025, 752);
            Load += ucGestionUsuarios_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UIButton btnNuevoTecnico;
        private Sunny.UI.UITextBox txtBuscarTecnico;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Perfil;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewButtonColumn Editar;
    }
}
