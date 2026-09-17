using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucSeguimientoReparaciones : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        public ucSeguimientoReparaciones()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
        }

        private void AplicarDiseñoGrid()
        {
            dgvSeguimiento.BackgroundColor = Color.White;
            dgvSeguimiento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSeguimiento.GridColor = Color.FromArgb(240, 242, 245);
            dgvSeguimiento.RowHeadersVisible = false;

            dgvSeguimiento.AllowUserToAddRows = false;
            dgvSeguimiento.AllowUserToDeleteRows = false;
            dgvSeguimiento.AllowUserToResizeRows = false;
            dgvSeguimiento.AllowUserToResizeColumns = false;
            dgvSeguimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSeguimiento.ColumnHeadersHeight = 50;
            dgvSeguimiento.RowTemplate.Height = 45;

            dgvSeguimiento.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle estiloEncabezado = new DataGridViewCellStyle();
            estiloEncabezado.BackColor = Color.White;
            estiloEncabezado.ForeColor = Color.FromArgb(120, 120, 120);
            estiloEncabezado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            estiloEncabezado.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado.Padding = new Padding(15, 0, 0, 0);

            estiloEncabezado.SelectionBackColor = Color.White;
            estiloEncabezado.SelectionForeColor = Color.FromArgb(120, 120, 120);

            dgvSeguimiento.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            dgvSeguimiento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle estiloFila = new DataGridViewCellStyle();
            estiloFila.BackColor = Color.White;
            estiloFila.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFila.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloFila.Padding = new Padding(15, 0, 0, 0);

            estiloFila.SelectionBackColor = Color.FromArgb(245, 248, 255);
            estiloFila.SelectionForeColor = Color.FromArgb(60, 60, 60);

            dgvSeguimiento.RowsDefaultCellStyle = estiloFila;
            dgvSeguimiento.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ucSeguimientoReparaciones_Load(object sender, EventArgs e)
        {
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            CargarSeguimiento();
            dgvSeguimiento.ClearSelection();
        }

        private void CargarSeguimiento(string filtroBusqueda = "", string filtroEstado = "Todos")
        {
            string sucursal = Sesion.SucursalActual.Replace("'", "''");
            string busqueda = filtroBusqueda.Replace("'", "''");
            string estado = filtroEstado.Replace("'", "''");

            string consulta = @"
        select
            o.numero_orden as ORDEN,
            c.nombre + ' - ' + d.marca + ' ' + d.modelo as [CLIENTE \ DISPOSITIVO],
            u.nombre as TÉCNICO,
            o.estado as ESTADO,
            o.fecha_ingreso as INGRESO,
            o.fecha_estimada_entrega as [ENTREGA ESTIMADA],
            case
                when o.fecha_entrega is not null
                    then datediff(day, o.fecha_ingreso, o.fecha_entrega)
                else
                    datediff(day, o.fecha_ingreso, getdate())
            end as TIEMPO
        from ordenes o
        inner join clientes c
            on o.cliente_id = c.id
        inner join dispositivos d
            on o.dispositivo_id = d.id
        inner join usuarios u
            on o.tecnico_id = u.id
        where o.sucursal = '" + sucursal + @"'
          and (
                '" + busqueda + @"' = ''
                or o.numero_orden like '%" + busqueda + @"%'
                or c.nombre like '%" + busqueda + @"%'
              )
          and (
                '" + estado + @"' = 'Todos'
                or o.estado = '" + estado + @"'
              )";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            dgvSeguimiento.AutoGenerateColumns = true;
            dgvSeguimiento.DataSource = dt;

            if (dgvSeguimiento.Columns.Count > 0)
            {
                dgvSeguimiento.Columns["ORDEN"].Width = 130;

                dgvSeguimiento.Columns["CLIENTE \\ DISPOSITIVO"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

                dgvSeguimiento.Columns["TÉCNICO"].Width = 140;
                dgvSeguimiento.Columns["ESTADO"].Width = 140;
                dgvSeguimiento.Columns["INGRESO"].Width = 140;
                dgvSeguimiento.Columns["ENTREGA ESTIMADA"].Width = 140;
                dgvSeguimiento.Columns["TIEMPO"].Width = 90;
            }

            dgvSeguimiento.ClearSelection();
        }

        private void txtBuscarOrden_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void dgvNuevo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataRowView filaSeleccionada =
                        (DataRowView)dgvSeguimiento.Rows[e.RowIndex].DataBoundItem;

                    if (filaSeleccionada != null)
                    {
                        string numeroOrden =
                            filaSeleccionada["ORDEN"].ToString();

                        string clienteDispositivo =
                            filaSeleccionada["CLIENTE \\ DISPOSITIVO"].ToString();

                        string estado =
                            filaSeleccionada["ESTADO"].ToString();

                        string tecnico =
                            filaSeleccionada["TÉCNICO"].ToString();

                        // SI YA FUE ENTREGADO, NO SE PUEDE MODIFICAR
                        if (estado.Equals(
                            "Entregado",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "Esta orden ya fue entregada.",
                                "Orden entregada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            return;
                        }

                        frmDetallesOrden frm =
                            new frmDetallesOrden(
                                numeroOrden,
                                clienteDispositivo,
                                estado,
                                tecnico
                            );

                        frm.ShowDialog();

                        string estadoFiltro =
                            cmbEstado.Text == "Todos los estados"
                                ? "Todos"
                                : cmbEstado.Text;

                        CargarSeguimiento(
                            txtBuscarOrden.Text.Trim(),
                            estadoFiltro
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al abrir la orden: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvNuevo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSeguimiento.Columns[e.ColumnIndex].Name == "TIEMPO" && e.Value != null)
            {
                e.Value = e.Value.ToString() + " días";
                e.CellStyle.ForeColor = Color.FromArgb(0, 100, 220);
                e.CellStyle.Font = new Font(dgvSeguimiento.Font, FontStyle.Bold);
                e.FormattingApplied = true;
            }
        }

        private void dgvNuevo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string estado = dgvSeguimiento.Rows[e.RowIndex].Cells["ESTADO"].Value?.ToString() ?? "";
            Color colorPrincipal = Color.Gray;
            Color colorFondo = Color.White;

            switch (estado)
            {
                case "En reparación":
                    colorPrincipal = Color.FromArgb(0, 100, 220);
                    colorFondo = Color.FromArgb(235, 245, 255);
                    break;
                case "En diagnóstico":
                    colorPrincipal = Color.FromArgb(240, 140, 0);
                    colorFondo = Color.FromArgb(255, 245, 235);
                    break;
                case "Listo":
                    colorPrincipal = Color.FromArgb(40, 180, 90);
                    colorFondo = Color.FromArgb(235, 250, 240);
                    break;
                case "Recibido":
                    colorPrincipal = Color.FromArgb(140, 40, 200);
                    colorFondo = Color.FromArgb(245, 235, 255);
                    break;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                using (SolidBrush brush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds.Left, e.CellBounds.Top, 4, e.CellBounds.Height);
                }
                e.Handled = true;
            }

            if (dgvSeguimiento.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int altoBadge = 24;
                int anchoTexto = (int)e.Graphics.MeasureString(estado, e.CellStyle.Font).Width;
                int anchoBadge = anchoTexto + 25;

                int x = e.CellBounds.Left + 15;
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

                int dotSize = 6;
                int dotX = x + 8;
                int dotY = y + (altoBadge - dotSize) / 2;
                using (SolidBrush dotBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
                }

                int textX = dotX + dotSize + 4;
                int textY = y + (altoBadge - e.CellStyle.Font.Height) / 2 + 1;
                using (SolidBrush textBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.DrawString(estado, e.CellStyle.Font, textBrush, textX, textY);
                }

                e.Handled = true;
            }
        }

        private void dgvSeguimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}