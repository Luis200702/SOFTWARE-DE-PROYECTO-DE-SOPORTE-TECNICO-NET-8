using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucGestionUsuarios : UserControl
    {
        Conexion_Base_de_Datos conSQL = new Conexion_Base_de_Datos();
        public ucGestionUsuarios()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
        }

        //DIseño tabla
        private void AplicarDiseñoGrid()
        {
            dgvNuevo.BackgroundColor = Color.White;
            dgvNuevo.BorderStyle = BorderStyle.None;
            dgvNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevo.GridColor = Color.FromArgb(240, 240, 240);
            dgvNuevo.RowHeadersVisible = false;

            dgvNuevo.AllowUserToAddRows = false;
            dgvNuevo.AllowUserToDeleteRows = false;
            dgvNuevo.AllowUserToResizeRows = false;
            dgvNuevo.AllowUserToResizeColumns = false;
            dgvNuevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNuevo.ColumnHeadersHeight = 50;
            dgvNuevo.RowTemplate.Height = 60; // Fila alta para los avatares

            dgvNuevo.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle estiloEncabezado = new DataGridViewCellStyle();
            estiloEncabezado.BackColor = Color.White;
            estiloEncabezado.ForeColor = Color.FromArgb(100, 100, 100);
            estiloEncabezado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            estiloEncabezado.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloEncabezado.SelectionBackColor = Color.White;
            estiloEncabezado.SelectionForeColor = Color.FromArgb(100, 100, 100);

            dgvNuevo.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            dgvNuevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle estiloFila = new DataGridViewCellStyle();
            estiloFila.BackColor = Color.White;
            estiloFila.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFila.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloFila.SelectionBackColor = Color.FromArgb(248, 250, 252); // Selección muy suave
            estiloFila.SelectionForeColor = Color.FromArgb(60, 60, 60);

            dgvNuevo.RowsDefaultCellStyle = estiloFila;
            dgvNuevo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ucGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {
            DataTable dt = conSQL.retornarRegistrosUsuarios("select U.Nombre, U.Usuario, U.Perfil, S.NombreSucursal as Sucursal\r\nfrom Usuarios U inner join Sucursales S on U.IdSucursal = S.IdSucursal\r\ngroup by U.Nombre, U.Usuario, U.Perfil, S.NombreSucursal");


            if (dt.Columns.Contains("Nombre")) dt.Columns["Nombre"].ColumnName = "NOMBRE";
            if (dt.Columns.Contains("Usuario")) dt.Columns["Usuario"].ColumnName = "USUARIO";
            if (dt.Columns.Contains("Perfil")) dt.Columns["Perfil"].ColumnName = "PERFIL";
            if (dt.Columns.Contains("Sucursal")) dt.Columns["Sucursal"].ColumnName = "SUCURSAL";

            dgvNuevo.AutoGenerateColumns = true;
            dgvNuevo.DataSource = dt;

            // Ocultamos el ID si es que tu método lo trae
            if (dgvNuevo.Columns.Contains("Id")) dgvNuevo.Columns["Id"].Visible = false;

            // Creamos el botón de EDITAR al final
            if (!dgvNuevo.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "EDITAR";
                btnEditar.Width = 100;
                btnEditar.FlatStyle = FlatStyle.Flat;
                dgvNuevo.Columns.Add(btnEditar);
            }


            if (dgvNuevo.Columns.Count > 0)
            {
                if (dgvNuevo.Columns.Contains("NOMBRE"))
                {
                    dgvNuevo.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvNuevo.Columns["NOMBRE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Nombre a la izquierda
                }
                if (dgvNuevo.Columns.Contains("USUARIO")) dgvNuevo.Columns["USUARIO"].Width = 150;
                if (dgvNuevo.Columns.Contains("PERFIL")) dgvNuevo.Columns["PERFIL"].Width = 160;
                if (dgvNuevo.Columns.Contains("SUCURSAL")) dgvNuevo.Columns["SUCURSAL"].Width = 120;
            }

            dgvNuevo.ClearSelection();
        }


        private void dgvNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvNuevo.Columns[e.ColumnIndex].Name == "Editar")
            {

                string nombre = dgvNuevo.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                string usuario = dgvNuevo.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString();
                string perfil = dgvNuevo.Rows[e.RowIndex].Cells["PERFIL"].Value.ToString();
                string sucursal = dgvNuevo.Rows[e.RowIndex].Cells["SUCURSAL"].Value.ToString();


                frmEditarUsuarios frmEditar = new frmEditarUsuarios(nombre, usuario, perfil, sucursal);
                frmEditar.ShowDialog();


                CargarDatos();
            }
        }

        private void btnNuevoTecnico_Click(object sender, EventArgs e)
        {

            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.ShowDialog();


            CargarDatos();
        }

        private void dgvNuevo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;


            if (nombreColumna == "NOMBRE")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                string nombreCompleto = e.Value?.ToString() ?? "Desconocido";


                string iniciales = "";
                string[] palabras = nombreCompleto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (palabras.Length >= 2)
                    iniciales = (palabras[0].Substring(0, 1) + palabras[1].Substring(0, 1)).ToUpper();
                else if (nombreCompleto.Length >= 2)
                    iniciales = nombreCompleto.Substring(0, 2).ToUpper();
                else if (nombreCompleto.Length > 0)
                    iniciales = nombreCompleto.Substring(0, 1).ToUpper();


                Color[] paleta = {
                    Color.FromArgb(40, 180, 90),
                    Color.FromArgb(20, 140, 220),
                    Color.FromArgb(240, 140, 0),
                    Color.FromArgb(140, 80, 220),
                    Color.FromArgb(0, 160, 160)
                };
                int colorIndex = Math.Abs(nombreCompleto.GetHashCode()) % paleta.Length;
                Color colorAvatar = paleta[colorIndex];

                int size = 32;
                int xCiculo = e.CellBounds.Left + 15;
                int yCirculo = e.CellBounds.Top + (e.CellBounds.Height - size) / 2;

                using (SolidBrush brush = new SolidBrush(colorAvatar))
                {
                    e.Graphics.FillEllipse(brush, xCiculo, yCirculo, size, size);
                }


                using (Font fontIniciales = new Font("Segoe UI", 9F, FontStyle.Bold))
                using (SolidBrush brushTexto = new SolidBrush(Color.White))
                {
                    SizeF sizeTexto = e.Graphics.MeasureString(iniciales, fontIniciales);
                    float xTexto = xCiculo + (size - sizeTexto.Width) / 2;
                    float yTexto = yCirculo + (size - sizeTexto.Height) / 2 + 1;
                    e.Graphics.DrawString(iniciales, fontIniciales, brushTexto, xTexto, yTexto);
                }


                int xNombre = xCiculo + size + 15;
                int yNombre = e.CellBounds.Top + (e.CellBounds.Height - e.CellStyle.Font.Height) / 2;
                using (SolidBrush brushNombre = new SolidBrush(e.CellStyle.ForeColor))
                {
                    e.Graphics.DrawString(nombreCompleto, e.CellStyle.Font, brushNombre, xNombre, yNombre);
                }

                e.Handled = true;
            }

            if (nombreColumna == "PERFIL")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                string perfil = e.Value?.ToString() ?? "";
                Color colorBase, colorFondo;
                string icono = "";

                if (perfil.ToLower().Contains("admin") || perfil.ToLower().Contains("gerente"))
                {
                    colorBase = Color.FromArgb(140, 80, 220);
                    colorFondo = Color.FromArgb(245, 240, 255);
                    icono = "👑 ";
                }
                else
                {
                    colorBase = Color.FromArgb(40, 140, 220);
                    colorFondo = Color.FromArgb(240, 245, 255);
                    icono = "👤 ";
                }

                string textoFinal = icono + perfil;
                int altoBadge = 28;
                using (Font f = new Font("Segoe UI", 9F, FontStyle.Regular))
                {
                    int anchoTexto = (int)e.Graphics.MeasureString(textoFinal, f).Width;
                    int anchoBadge = anchoTexto + 20;

                    int x = e.CellBounds.Left + (e.CellBounds.Width - anchoBadge) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - altoBadge) / 2;

                    using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int radio = 10;
                        path.AddArc(x, y, radio, radio, 180, 90);
                        path.AddArc(x + anchoBadge - radio, y, radio, radio, 270, 90);
                        path.AddArc(x + anchoBadge - radio, y + altoBadge - radio, radio, radio, 0, 90);
                        path.AddArc(x, y + altoBadge - radio, radio, radio, 90, 90);
                        path.CloseFigure();

                        using (SolidBrush bgBrush = new SolidBrush(colorFondo))
                        {
                            e.Graphics.FillPath(bgBrush, path);
                        }
                    }

                    using (SolidBrush textBrush = new SolidBrush(colorBase))
                    {
                        float textX = x + 10;
                        float textY = y + (altoBadge - f.Height) / 2 + 1;
                        e.Graphics.DrawString(textoFinal, f, textBrush, textX, textY);
                    }
                }
                e.Handled = true;
            }


            if (nombreColumna == "Editar")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Color verdeElegante = Color.FromArgb(0, 180, 140);
                string textoBtn = "✎ Editar";

                int btnAncho = 80;
                int btnAlto = 32;
                int x = e.CellBounds.Left + (e.CellBounds.Width - btnAncho) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - btnAlto) / 2;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 8;
                    path.AddArc(x, y, radio, radio, 180, 90);
                    path.AddArc(x + btnAncho - radio, y, radio, radio, 270, 90);
                    path.AddArc(x + btnAncho - radio, y + btnAlto - radio, radio, radio, 0, 90);
                    path.AddArc(x, y + btnAlto - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush brush = new SolidBrush(Color.White))
                        e.Graphics.FillPath(brush, path);

                    using (Pen pen = new Pen(verdeElegante, 1.5f))
                        e.Graphics.DrawPath(pen, path);
                }

                using (Font fontBtn = new Font("Segoe UI", 9F, FontStyle.Regular))
                using (SolidBrush textBrush = new SolidBrush(verdeElegante))
                {
                    SizeF textSize = e.Graphics.MeasureString(textoBtn, fontBtn);
                    float textX = x + (btnAncho - textSize.Width) / 2;
                    float textY = y + (btnAlto - textSize.Height) / 2 + 1;
                    e.Graphics.DrawString(textoBtn, fontBtn, textBrush, textX, textY);
                }

                e.Handled = true;
            }
        }

        private void txtBuscarTecnico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}