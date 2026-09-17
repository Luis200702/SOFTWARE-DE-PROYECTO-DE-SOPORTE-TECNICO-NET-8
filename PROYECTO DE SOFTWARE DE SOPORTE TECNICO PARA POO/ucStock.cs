using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucStock : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        private bool mostrandoAlertas = false;
        private int cantidadAlertas = 0;

        public ucStock()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
        }

        private void AplicarDiseñoGrid()
        {
            dgvNuevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvNuevo.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle estiloEncabezado = new DataGridViewCellStyle();
            estiloEncabezado.BackColor = Color.White;
            estiloEncabezado.ForeColor = Color.FromArgb(100, 100, 100);
            estiloEncabezado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            estiloEncabezado.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado.Padding = new Padding(15, 0, 0, 0);
            estiloEncabezado.SelectionBackColor = Color.White;
            estiloEncabezado.SelectionForeColor = Color.FromArgb(100, 100, 100);

            dgvNuevo.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            dgvNuevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle estiloFila = new DataGridViewCellStyle();
            estiloFila.BackColor = Color.White;
            estiloFila.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFila.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloFila.Padding = new Padding(15, 0, 0, 0);
            estiloFila.SelectionBackColor = Color.FromArgb(248, 250, 252);
            estiloFila.SelectionForeColor = Color.FromArgb(60, 60, 60);

            dgvNuevo.RowsDefaultCellStyle = estiloFila;
            dgvNuevo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ucStock_Load(object sender, EventArgs e)
        {
            if (cmbCategorias.Items.Count > 0)
                cmbCategorias.SelectedIndex = 0;

            CargarDatos();
        }

        private void CargarDatos()
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            string categoriaSeleccionada = cmbCategorias.SelectedItem != null
                ? cmbCategorias.SelectedItem.ToString()
                : "Todas las categorías";

            string sucursal = Sesion.SucursalActual;

            // Evitar problemas si el texto contiene comillas simples
            textoBusqueda = textoBusqueda.Replace("'", "''");
            categoriaSeleccionada = categoriaSeleccionada.Replace("'", "''");
            sucursal = sucursal.Replace("'", "''");

            int soloAlertas = mostrandoAlertas ? 1 : 0;

            string consulta = @"
        select
            r.idrepuesto as IdRepuesto,
            i.idsucursal as IdSucursal,
            r.nombrerepuesto as NOMBRE,
            s.nombresucursal as SUCURSAL,
            isnull(r.categoria, '—') as CATEGORÍA,
            concat(i.stockactual, ' / ', i.stockminimo) as STOCK,
            r.preciocosto as COSTO,
            r.precioventa as VENTA,
            isnull(r.proveedor, '—') as PROVEEDOR,
            case
                when i.stockactual = 0 then 'Sin stock'
                when i.stockactual <= i.stockminimo then 'Stock bajo'
                else 'Normal'
            end as ESTADO
        from repuestos r
        inner join inventariosucursal i
            on r.idrepuesto = i.idrepuesto
        inner join sucursales s
            on i.idsucursal = s.idsucursal
        where s.nombresucursal = '" + sucursal + @"'
          and (
                " + soloAlertas + @" = 0
                or i.stockactual <= i.stockminimo
              )
          and (
                '" + textoBusqueda + @"' = ''
                or r.nombrerepuesto like '%" + textoBusqueda + @"%'
                or r.compatibilidad like '%" + textoBusqueda + @"%'
                or r.proveedor like '%" + textoBusqueda + @"%'
              )
          and (
                '" + categoriaSeleccionada + @"' = 'Todas las categorías'
                or '" + categoriaSeleccionada + @"' = ''
                or '" + categoriaSeleccionada + @"' = 'Todas'
                or r.categoria = '" + categoriaSeleccionada + @"'
              )";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            dgvNuevo.DataSource = dt;

            if (dgvNuevo.Columns.Contains("IdRepuesto"))
                dgvNuevo.Columns["IdRepuesto"].Visible = false;

            if (dgvNuevo.Columns.Contains("IdSucursal"))
                dgvNuevo.Columns["IdSucursal"].Visible = false;

            if (!dgvNuevo.Columns.Contains("Agregar"))
            {
                DataGridViewButtonColumn btnAgregar = new DataGridViewButtonColumn
                {
                    Name = "Agregar",
                    HeaderText = "",
                    Width = 45,
                    FlatStyle = FlatStyle.Flat
                };

                dgvNuevo.Columns.Add(btnAgregar);
            }
            if (dgvNuevo.Columns.Contains("NOMBRE"))
                dgvNuevo.Columns["NOMBRE"].Width = 160;

            if (dgvNuevo.Columns.Contains("SUCURSAL"))
                dgvNuevo.Columns["SUCURSAL"].Width = 120;

            if (dgvNuevo.Columns.Contains("CATEGORÍA"))
                dgvNuevo.Columns["CATEGORÍA"].Width = 120;

            if (dgvNuevo.Columns.Contains("STOCK"))
                dgvNuevo.Columns["STOCK"].Width = 110;

            if (dgvNuevo.Columns.Contains("COSTO"))
            {
                dgvNuevo.Columns["COSTO"].Width = 100;
                dgvNuevo.Columns["COSTO"].DefaultCellStyle.Format = "N2";
            }

            if (dgvNuevo.Columns.Contains("VENTA"))
            {
                dgvNuevo.Columns["VENTA"].Width = 100;
                dgvNuevo.Columns["VENTA"].DefaultCellStyle.Format = "N2";
            }

            if (dgvNuevo.Columns.Contains("PROVEEDOR"))
                dgvNuevo.Columns["PROVEEDOR"].Width = 160;

            if (dgvNuevo.Columns.Contains("ESTADO"))
                dgvNuevo.Columns["ESTADO"].Width = 140;

            dgvNuevo.ClearSelection();

            ActualizarContadorAlertas();
        }

        private void ActualizarContadorAlertas()
        {
            string sucursal = Sesion.SucursalActual.Replace("'", "''");

            string consulta = @"
        select count(*) as cantidad
        from inventariosucursal i
        inner join sucursales s
            on i.idsucursal = s.idsucursal
        where s.nombresucursal = '" + sucursal + @"'
          and i.stockactual <= i.stockminimo";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                cantidadAlertas = Convert.ToInt32(
                    dt.Rows[0]["cantidad"]);
            }
            else
            {
                cantidadAlertas = 0;
            }

            if (pnlInfo != null)
                pnlInfo.Invalidate();
        }

        private void dgvNuevo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "COSTO" || nombreColumna == "VENTA")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = $"${valor:N2}";
                        e.FormattingApplied = true;
                    }
                }

                if (nombreColumna == "VENTA")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 180, 110);
                    e.CellStyle.Font = new Font(dgvNuevo.Font, FontStyle.Bold);
                }

                if (nombreColumna == "COSTO")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.Font = new Font(dgvNuevo.Font, FontStyle.Bold);
                }
            }
        }

        private void dgvNuevo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ESTADO")
            {
                string estado = e.Value?.ToString() ?? "";
                Color colorPrincipal = Color.Gray;
                Color colorFondo = Color.White;

                switch (estado)
                {
                    case "Normal":
                        colorPrincipal = Color.FromArgb(0, 180, 110);
                        colorFondo = Color.FromArgb(235, 252, 240);
                        break;
                    case "Stock bajo":
                        colorPrincipal = Color.FromArgb(230, 160, 0);
                        colorFondo = Color.FromArgb(255, 250, 235);
                        break;
                    case "Sin stock":
                        colorPrincipal = Color.FromArgb(220, 50, 50);
                        colorFondo = Color.FromArgb(255, 235, 235);
                        break;
                }

                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int altoBadge = 26;
                int anchoTexto = (int)e.Graphics.MeasureString(estado, e.CellStyle.Font).Width;
                int anchoBadge = anchoTexto + 28;

                int x = e.CellBounds.Left + 15;
                int y = e.CellBounds.Top + (e.CellBounds.Height - altoBadge) / 2;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 12;
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
                int dotX = x + 10;
                int dotY = y + (altoBadge - dotSize) / 2;
                using (SolidBrush dotBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
                }

                int textX = dotX + dotSize + 5;
                int textY = y + (altoBadge - e.CellStyle.Font.Height) / 2 + 1;
                using (SolidBrush textBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.DrawString(estado, e.CellStyle.Font, textBrush, textX, textY);
                }

                e.Handled = true;
            }

            if (nombreColumna == "Agregar")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                bool esAgregar = true;

                Color bgColor = Color.FromArgb(235, 252, 242);
                Color borderColor = Color.FromArgb(170, 235, 190);
                Color textColor = Color.FromArgb(50, 170, 100);
                string text = "↓";

                int btnSize = 32;
                int x = e.CellBounds.Left + (e.CellBounds.Width - btnSize) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - btnSize) / 2;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 8;
                    path.AddArc(x, y, radio, radio, 180, 90);
                    path.AddArc(x + btnSize - radio, y, radio, radio, 270, 90);
                    path.AddArc(x + btnSize - radio, y + btnSize - radio, radio, radio, 0, 90);
                    path.AddArc(x, y + btnSize - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    using (Pen pen = new Pen(borderColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                using (Font iconFont = new Font("Segoe UI", 12F, FontStyle.Bold))
                {
                    SizeF textSize = e.Graphics.MeasureString(text, iconFont);
                    float textX = x + (btnSize - textSize.Width) / 2;
                    float textY = y + (btnSize - textSize.Height) / 2 + 1;

                    using (SolidBrush textBrush = new SolidBrush(textColor))
                    {
                        e.Graphics.DrawString(text, iconFont, textBrush, textX, textY);
                    }
                }

                e.Handled = true;
            }
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            mostrandoAlertas = !mostrandoAlertas;

            btnAlertas.Style = Sunny.UI.UIStyle.Custom;

            if (mostrandoAlertas)
            {
                btnAlertas.FillColor = Color.FromArgb(255, 245, 235);
                btnAlertas.RectColor = Color.FromArgb(255, 150, 0);
                btnAlertas.ForeColor = Color.FromArgb(255, 150, 0);
            }
            else
            {
                btnAlertas.FillColor = Color.White;
                btnAlertas.RectColor = Color.FromArgb(213, 218, 223);
                btnAlertas.ForeColor = Color.FromArgb(100, 100, 100);
            }

            CargarDatos();
        }

        private void btnAlertas_Paint(object sender, PaintEventArgs e)
        {
            if (cantidadAlertas > 0)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int size = 22;
                int x = btnAlertas.Width - size - 8;
                int y = (btnAlertas.Height - size) / 2;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 150, 0)))
                {
                    e.Graphics.FillEllipse(brush, x, y, size, size);
                }

                string texto = cantidadAlertas > 99 ? "+99" : cantidadAlertas.ToString();
                using (Font f = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    SizeF textSize = e.Graphics.MeasureString(texto, f);
                    float textX = x + (size - textSize.Width) / 2;
                    float textY = y + (size - textSize.Height) / 2 + 1;
                    e.Graphics.DrawString(texto, f, textBrush, textX, textY);
                }
            }
        }

        private void dgvNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idRepuestoActual = Convert.ToInt32(dgvNuevo.Rows[e.RowIndex].Cells["IdRepuesto"].Value);
            int idSucursalActual = Convert.ToInt32(dgvNuevo.Rows[e.RowIndex].Cells["IdSucursal"].Value);
            string nombreRepuestoActual = dgvNuevo.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            string nombreSucursalActual = dgvNuevo.Rows[e.RowIndex].Cells["SUCURSAL"].Value.ToString();

            if (dgvNuevo.Columns[e.ColumnIndex].Name == "Agregar")
            {
                frmAggStock frm = new frmAggStock(idRepuestoActual, idSucursalActual, nombreRepuestoActual, nombreSucursalActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            else if (dgvNuevo.Columns[e.ColumnIndex].Name == "Delete")
            {
                frmDeleteStock frm = new frmDeleteStock(idRepuestoActual, idSucursalActual, nombreRepuestoActual, nombreSucursalActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            frmRegistrarEntrega frm = new frmRegistrarEntrega();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}