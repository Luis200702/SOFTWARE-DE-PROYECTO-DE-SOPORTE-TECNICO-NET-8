using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Color = System.Drawing.Color;
using Size = System.Drawing.Size;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucReportes : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

        private FlowLayoutPanel flpReportesGenerados;
        private Label lblSinReportes;
        public ucReportes()
        {
            InitializeComponent();
            InicializarHistorialReportes();
            CargarTiposReporte();
            CargarSucursales();
            CargarTecnicos();
            cmbTiposReporte.SelectedIndexChanged += (s, e) => ConfigurarFiltrosPorReporte();
            CargarReportesGuardados();
        }

        private void CargarTiposReporte()
        {
            cmbTiposReporte.Items.Clear();

            cmbTiposReporte.Items.Add("Órdenes de reparación");
            cmbTiposReporte.Items.Add("Ingresos por servicios");
            cmbTiposReporte.Items.Add("Consumo de repuestos");
            cmbTiposReporte.Items.Add("Inventario de repuestos");
            cmbTiposReporte.Items.Add("Stock bajo");
            cmbTiposReporte.Items.Add("Órdenes por técnico");
            cmbTiposReporte.Items.Add("Derivaciones entre sucursales");
            cmbTiposReporte.Items.Add("Historial de reparaciones por cliente");
            cmbTiposReporte.Items.Add("Facturas emitidas");

            if (cmbTiposReporte.Items.Count > 0)
            {
                cmbTiposReporte.SelectedIndex = 0;
                ConfigurarFiltrosPorReporte();
            }
        }
        private void CargarClientesEnCombo()
        {
            string consulta = "select id, nombre + ' - ' + isnull(cedula_pasaporte, 'Sin cédula') as Nombre from clientes order by nombre";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null)
            {
                cmbTecnicos.DataSource = null;
                cmbTecnicos.DataSource = dt;
                cmbTecnicos.DisplayMember = "Nombre";
                cmbTecnicos.ValueMember = "id";

                if (cmbTecnicos.Items.Count > 0)
                    cmbTecnicos.SelectedIndex = 0;
            }
        }
        private void ucReportes_Load(object sender, EventArgs e)
        {
            DataTable equiposRecibidos = oCon.retornarRegistrosUsuarios(@"
                SELECT COUNT(*) AS Numero
                FROM ordenes
                WHERE MONTH(fecha_ingreso) = MONTH(GETDATE())
                  AND YEAR(fecha_ingreso) = YEAR(GETDATE())");

            lblEquiposRecibidos.Text =
                equiposRecibidos.Rows[0]["Numero"].ToString();

            DataTable reparaciones = oCon.retornarRegistrosUsuarios(@"
                SELECT COUNT(*) AS Numero
                FROM ordenes
                WHERE estado = 'Entregado'
                  AND fecha_entrega IS NOT NULL
                  AND MONTH(fecha_entrega) = MONTH(GETDATE())
                  AND YEAR(fecha_entrega) = YEAR(GETDATE())");

            lblReparaciones.Text =
                reparaciones.Rows[0]["Numero"].ToString();

            DataTable ingresos = oCon.retornarRegistrosUsuarios(@"
                SELECT ISNULL(SUM(monto_pagado), 0) AS Total
                FROM ordenes
                WHERE estado = 'Entregado'
                  AND fecha_entrega IS NOT NULL
                  AND MONTH(fecha_entrega) = MONTH(GETDATE())
                  AND YEAR(fecha_entrega) = YEAR(GETDATE())");

            decimal totalIngresos =
                Convert.ToDecimal(ingresos.Rows[0]["Total"]);

            lblIngresos.Text = "$ " + totalIngresos.ToString("F2");

            DataTable pendientes = oCon.retornarRegistrosUsuarios(@"
                SELECT COUNT(*) AS Numero
                FROM ordenes
                WHERE estado = 'Listo'");

            lblPendientes.Text =
                pendientes.Rows[0]["Numero"].ToString();

            label9.Text = "Actualmente";

            dtpDesde.Value = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                1);

            dtpHasta.Value = DateTime.Now;
        }

        private bool ValidarRangoFechas()
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser mayor que la fecha final.",
                    "Rango de fechas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        private void pnlDatosCliente_Click(object sender, EventArgs e)
        {

        }
        public void CargarSucursales()
        {
            DataTable dt = oCon.retornarRegistrosUsuarios("select IdSucursal, NombreSucursal " + "from Sucursales " + "order by NombreSucursal");

            if (dt != null)
            {
                DataRow filaTodas = dt.NewRow();
                filaTodas["IdSucursal"] = 0;
                filaTodas["NombreSucursal"] = "Todas";

                dt.Rows.InsertAt(filaTodas, 0);

                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "NombreSucursal";
                cmbSucursal.ValueMember = "IdSucursal";
                cmbSucursal.SelectedIndex = 0;
            }
        }

        private void CargarTecnicos()
        {
            DataTable dt;

            if (cmbSucursal.Text == "Todas" ||
                string.IsNullOrWhiteSpace(cmbSucursal.Text))
            {
                dt = oCon.retornarRegistrosUsuarios(@"
            SELECT Id, Nombre
            FROM Usuarios
            WHERE Perfil = 'Tecnico'
            ORDER BY Nombre");
            }
            else
            {
                dt = oCon.retornarRegistrosUsuarios(@"
            SELECT U.Id, U.Nombre
            FROM Usuarios U
            INNER JOIN Sucursales S
                ON U.IdSucursal = S.IdSucursal
            WHERE U.Perfil = 'Tecnico'
              AND S.NombreSucursal = '" + cmbSucursal.Text + @"'
            ORDER BY U.Nombre");
            }

            if (dt != null)
            {
                DataRow filaTodos = dt.NewRow();
                filaTodos["Id"] = 0;
                filaTodos["Nombre"] = "Todos";

                dt.Rows.InsertAt(filaTodos, 0);

                cmbTecnicos.DataSource = dt;
                cmbTecnicos.DisplayMember = "Nombre";
                cmbTecnicos.ValueMember = "Id";
                cmbTecnicos.SelectedIndex = 0;
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string tipoReporte = cmbTiposReporte.Text;

            if (string.IsNullOrWhiteSpace(tipoReporte))
            {
                MessageBox.Show(
                    "Selecciona un tipo de reporte.",
                    "Reportes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpDesde.Enabled && dtpHasta.Enabled)
            {
                if (!ValidarRangoFechas())
                    return;
            }

            switch (tipoReporte)
            {
                case "Órdenes de reparación":
                    GenerarReporteOrdenes();
                    break;

                case "Ingresos por servicios":
                    GenerarReporteIngresos();
                    break;

                case "Facturas emitidas":
                    GenerarReporteFacturas();
                    break;

                case "Consumo de repuestos":
                    GenerarReporteConsumoRepuestos();
                    break;

                case "Inventario de repuestos":
                    GenerarReporteInventario();
                    break;

                case "Stock bajo":
                    GenerarReporteStockBajo();
                    break;

                case "Órdenes por técnico":
                    GenerarReporteOrdenesPorTecnico();
                    break;

                case "Derivaciones entre sucursales":
                    GenerarReporteDerivaciones();
                    break;

                case "Historial de reparaciones por cliente":
                    GenerarReporteHistorialCliente();
                    break;
            }

        }

        private void InicializarHistorialReportes()
        {
            flpReportesGenerados = new FlowLayoutPanel
            {
                Location = new Point(17, 52),
                Size = new Size(uiPanel5.Width - 34, uiPanel5.Height - 69),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.Transparent
            };

            lblSinReportes = new Label
            {
                Text = "Todavía no se han generado reportes.",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(120, 130, 140),
                Margin = new Padding(8, 10, 0, 0)
            };

            flpReportesGenerados.Controls.Add(lblSinReportes);
            uiPanel5.Controls.Add(flpReportesGenerados);
            flpReportesGenerados.BringToFront();
        }

        private void CargarReportesGuardados()
        {
            if (flpReportesGenerados == null)
                return;

            DataTable tabla = oCon.retornarRegistrosUsuarios(@"
                SELECT
                    TipoReporte,
                    RutaArchivo,
                    FechaGeneracion,
                    Sucursal,
                    Tecnico,
                    FechaDesde,
                    FechaHasta
                FROM ReportesGenerados
                ORDER BY FechaGeneracion DESC");

            flpReportesGenerados.Controls.Clear();

            if (tabla == null || tabla.Rows.Count == 0)
            {
                flpReportesGenerados.Controls.Add(lblSinReportes);
                return;
            }

            foreach (DataRow fila in tabla.Rows)
            {
                string titulo = fila["TipoReporte"].ToString();
                string ruta = fila["RutaArchivo"].ToString();

                DateTime fechaGeneracion =
                    Convert.ToDateTime(fila["FechaGeneracion"]);

                string sucursal =
                    fila["Sucursal"] == DBNull.Value
                        ? "Todas"
                        : fila["Sucursal"].ToString();

                string tecnico =
                    fila["Tecnico"] == DBNull.Value
                        ? ""
                        : fila["Tecnico"].ToString();

                DateTime? fechaDesde =
                    fila["FechaDesde"] == DBNull.Value
                        ? null
                        : Convert.ToDateTime(fila["FechaDesde"]);

                DateTime? fechaHasta =
                    fila["FechaHasta"] == DBNull.Value
                        ? null
                        : Convert.ToDateTime(fila["FechaHasta"]);

                CrearTarjetaReporte(
                    titulo,
                    ruta,
                    fechaGeneracion,
                    sucursal,
                    tecnico,
                    fechaDesde,
                    fechaHasta);
            }
        }

        private void RegistrarReporteGenerado(
            string titulo,
            string ruta,
            bool mostrarTecnico)
        {
            DateTime fechaGeneracion = DateTime.Now;

            string sucursal = string.IsNullOrWhiteSpace(cmbSucursal.Text)
                ? "Todas"
                : cmbSucursal.Text;

            string tecnico = mostrarTecnico
                ? cmbTecnicos.Text
                : "";

            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (dtpDesde.Enabled && dtpHasta.Enabled)
            {
                fechaDesde = FechaDesde();
                fechaHasta = FechaHasta();
            }

            GuardarReporteEnBD(
                titulo,
                ruta,
                fechaGeneracion,
                sucursal,
                tecnico,
                fechaDesde,
                fechaHasta);

            CrearTarjetaReporte(
                titulo,
                ruta,
                fechaGeneracion,
                sucursal,
                tecnico,
                fechaDesde,
                fechaHasta,
                true);
        }

        private void GuardarReporteEnBD(
            string titulo,
            string ruta,
            DateTime fechaGeneracion,
            string sucursal,
            string tecnico,
            DateTime? fechaDesde,
            DateTime? fechaHasta)
        {
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    string consulta = @"
                        INSERT INTO ReportesGenerados
                        (
                            TipoReporte,
                            RutaArchivo,
                            FechaGeneracion,
                            Sucursal,
                            Tecnico,
                            FechaDesde,
                            FechaHasta
                        )
                        VALUES
                        (
                            @TipoReporte,
                            @RutaArchivo,
                            @FechaGeneracion,
                            @Sucursal,
                            @Tecnico,
                            @FechaDesde,
                            @FechaHasta
                        )";

                    using (SqlCommand cmd =
                        new SqlCommand(consulta, db.oCon))
                    {
                        cmd.Parameters.AddWithValue(
                            "@TipoReporte",
                            titulo);

                        cmd.Parameters.AddWithValue(
                            "@RutaArchivo",
                            ruta);

                        cmd.Parameters.AddWithValue(
                            "@FechaGeneracion",
                            fechaGeneracion);

                        cmd.Parameters.AddWithValue(
                            "@Sucursal",
                            string.IsNullOrWhiteSpace(sucursal)
                                ? (object)DBNull.Value
                                : sucursal);

                        cmd.Parameters.AddWithValue(
                            "@Tecnico",
                            string.IsNullOrWhiteSpace(tecnico)
                                ? (object)DBNull.Value
                                : tecnico);

                        cmd.Parameters.AddWithValue(
                            "@FechaDesde",
                            fechaDesde.HasValue
                                ? (object)fechaDesde.Value
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue(
                            "@FechaHasta",
                            fechaHasta.HasValue
                                ? (object)fechaHasta.Value
                                : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "El PDF se generó, pero no se pudo guardar " +
                    "en el historial:\n" + ex.Message,
                    "Historial de reportes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                if (db.oCon != null &&
                    db.oCon.State == ConnectionState.Open)
                {
                    db.cerrarConexion();
                }
            }
        }

        private void CrearTarjetaReporte(
            string titulo,
            string ruta,
            DateTime fechaGeneracion,
            string sucursal,
            string tecnico,
            DateTime? fechaDesde,
            DateTime? fechaHasta,
            bool colocarPrimero = false)
        {
            if (flpReportesGenerados == null)
                return;

            if (lblSinReportes.Parent == flpReportesGenerados)
                flpReportesGenerados.Controls.Remove(lblSinReportes);

            Panel tarjeta = new Panel
            {
                Width = Math.Max(
                    650,
                    flpReportesGenerados.ClientSize.Width - 25),

                Height = 72,
                BackColor = Color.FromArgb(248, 249, 251),
                Margin = new Padding(4, 4, 4, 6),
                Tag = ruta
            };

            Label lblTituloReporte = new Label
            {
                Text = titulo,
                Location = new Point(14, 10),
                Size = new Size(tarjeta.Width - 125, 22),
                Font = new Font(
                    "Segoe UI Semibold",
                    10F,
                    FontStyle.Bold),
                ForeColor = Color.FromArgb(24, 43, 62),
                AutoEllipsis = true
            };

            string detalle =
                $"Generado: {fechaGeneracion:dd/MM/yyyy HH:mm} | " +
                $"Sucursal: {sucursal}";

            if (!string.IsNullOrWhiteSpace(tecnico))
            {
                bool esReporteCliente =
                    titulo.Contains("POR CLIENTE", StringComparison.OrdinalIgnoreCase);

                detalle += esReporteCliente
                    ? $" | Cliente: {tecnico}"
                    : $" | Técnico: {tecnico}";
            }

            if (fechaDesde.HasValue &&
                fechaHasta.HasValue)
            {
                detalle +=
                    $" | {fechaDesde.Value:dd/MM/yyyy} - " +
                    $"{fechaHasta.Value:dd/MM/yyyy}";
            }

            Label lblDetalleReporte = new Label
            {
                Text = detalle,
                Location = new Point(14, 38),
                Size = new Size(tarjeta.Width - 125, 20),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(100, 110, 120),
                AutoEllipsis = true
            };

            Button btnAbrir = new Button
            {
                Text = "Abrir",
                Size = new Size(82, 30),
                Location = new Point(
                    tarjeta.Width - 98,
                    21),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 165, 155),
                ForeColor = Color.White,
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold),
                Cursor = Cursors.Hand
            };

            btnAbrir.FlatAppearance.BorderSize = 0;

            btnAbrir.Click +=
                (s, e) => AbrirReporteGenerado(ruta);

            tarjeta.Controls.Add(lblTituloReporte);
            tarjeta.Controls.Add(lblDetalleReporte);
            tarjeta.Controls.Add(btnAbrir);

            flpReportesGenerados.Controls.Add(tarjeta);

            if (colocarPrimero)
            {
                flpReportesGenerados.Controls
                    .SetChildIndex(tarjeta, 0);
            }
        }

        private void AbrirReporteGenerado(string ruta)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show(
                    "El archivo del reporte ya no se encuentra " +
                    "en la ubicación guardada.",
                    "Archivo no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                });
        }

        private DateTime FechaDesde()
        {
            return dtpDesde.Value.Date;
        }

        private DateTime FechaHasta()
        {
            return dtpHasta.Value.Date;
        }

        private int TecnicoSeleccionado()
        {
            return Convert.ToInt32(cmbTecnicos.SelectedValue ?? 0);
        }

        private void AgregarFiltroSucursal(ref string consulta, string campoSucursal)
        {
            if (cmbSucursal.Text != "Todas")
                consulta += " AND " + campoSucursal + " = '" + cmbSucursal.Text + "'";
        }

        private void AgregarFiltroTecnico(ref string consulta, string campoTecnico)
        {
            int tecnicoId = TecnicoSeleccionado();

            if (tecnicoId != 0)
                consulta += " AND " + campoTecnico + " = " + tecnicoId;
        }

        private string FormatearValorReporte(object valor, string columna)
        {
            if (valor == null || valor == DBNull.Value)
                return "—";

            if (valor is DateTime fecha)
            {
                if (fecha.TimeOfDay.TotalSeconds > 0)
                    return fecha.ToString("dd/MM/yyyy HH:mm");

                return fecha.ToString("dd/MM/yyyy");
            }

            if (valor is decimal || valor is double || valor is float)
            {
                decimal numero = Convert.ToDecimal(valor);

                if (columna.Contains("Costo", StringComparison.OrdinalIgnoreCase) ||
                    columna.Contains("Monto", StringComparison.OrdinalIgnoreCase) ||
                    columna.Contains("Precio", StringComparison.OrdinalIgnoreCase) ||
                    columna.Contains("Ingreso", StringComparison.OrdinalIgnoreCase) ||
                    columna.Contains("Valor", StringComparison.OrdinalIgnoreCase) ||
                    columna.Contains("Promedio", StringComparison.OrdinalIgnoreCase))
                {
                    return $"${numero:F2}";
                }

                return numero.ToString("F2");
            }

            return valor.ToString();
        }

        private void GenerarPdfTabla(
            string titulo,
            DataTable datos,
            string nombreArchivo,
            string[] columnas,
            string[] encabezados,
            Dictionary<string, string> resumen = null,
            bool mostrarTecnico = false)
        {
            if (datos == null || datos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron datos con los filtros seleccionados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            QuestPDF.Settings.License = LicenseType.Community;

            string nombreBase =
                Path.GetFileNameWithoutExtension(nombreArchivo);

            string extension =
                Path.GetExtension(nombreArchivo);

            string nombreUnico =
                nombreBase + "_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                extension;

            string ruta = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.Desktop),
                nombreUnico);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(1.2f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(columnas.Length >= 8 ? 7 : 8));

                    page.Header().Column(col =>
                    {
                        col.Item()
                            .Text("TECH DKV")
                            .Bold()
                            .FontSize(18)
                            .FontColor("#1a73e8");

                        col.Item()
                            .Text(titulo)
                            .Bold()
                            .FontSize(14);

                        if (dtpDesde.Enabled && dtpHasta.Enabled)
                        {
                            col.Item()
                                .Text($"Período: {FechaDesde():dd/MM/yyyy} al {FechaHasta():dd/MM/yyyy}")
                                .FontColor("#555555");
                        }

                        string filtros = $"Sucursal: {cmbSucursal.Text}";

                        if (mostrarTecnico)
                        {
                            string nombreFiltro =
                                cmbTiposReporte.Text == "Historial de reparaciones por cliente"
                                    ? "Cliente"
                                    : "Técnico";

                            filtros += $"   |   {nombreFiltro}: {cmbTecnicos.Text}";
                        }

                        col.Item().Text(filtros).FontSize(9);
                        col.Item().Height(8);
                        col.Item().LineHorizontal(2).LineColor("#1a73e8");
                    });

                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        if (resumen != null && resumen.Count > 0)
                        {
                            col.Item().Row(row =>
                            {
                                foreach (KeyValuePair<string, string> dato in resumen)
                                {
                                    row.RelativeItem()
                                        .Border(1)
                                        .BorderColor("#dddddd")
                                        .Padding(7)
                                        .Column(c =>
                                        {
                                            c.Item()
                                                .Text(dato.Key)
                                                .FontSize(7)
                                                .FontColor("#555555")
                                                .Bold();

                                            c.Item()
                                                .Text(dato.Value)
                                                .FontSize(13)
                                                .Bold()
                                                .FontColor("#1a73e8");
                                        });

                                    row.ConstantItem(4);
                                }
                            });

                            col.Item().Height(12);
                        }

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columnsDefinition =>
                            {
                                foreach (string columna in columnas)
                                    columnsDefinition.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                foreach (string encabezado in encabezados)
                                {
                                    header.Cell()
                                        .Background("#1a4f8a")
                                        .Padding(4)
                                        .Text(encabezado)
                                        .FontColor("#ffffff")
                                        .Bold();
                                }
                            });

                            bool filaPar = false;

                            foreach (DataRow fila in datos.Rows)
                            {
                                string fondo = filaPar ? "#f0f4ff" : "#ffffff";

                                foreach (string columna in columnas)
                                {
                                    table.Cell()
                                        .Background(fondo)
                                        .Padding(4)
                                        .Text(FormatearValorReporte(fila[columna], columna));
                                }

                                filaPar = !filaPar;
                            }
                        });
                    });

                    page.Footer().Row(row =>
                    {
                        row.RelativeItem()
                            .Text($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}")
                            .FontSize(8)
                            .FontColor("#555555");

                        row.RelativeItem()
                            .AlignRight()
                            .Text(x =>
                            {
                                x.Span("Página ");
                                x.CurrentPageNumber();
                                x.Span(" de ");
                                x.TotalPages();
                            });
                    });
                });
            }).GeneratePdf(ruta);

            RegistrarReporteGenerado(titulo, ruta, mostrarTecnico);

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                });

            MessageBox.Show(
                "Reporte generado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void GenerarReporteOrdenes()
        {
            string consulta = @"
        SELECT
            O.numero_orden AS Orden,
            C.nombre AS Cliente,
            CONCAT(D.marca, ' ', D.modelo) AS Dispositivo,
            D.serie_imei AS SerieImei,
            ISNULL(U.Nombre, 'Sin asignar') AS Tecnico,
            O.sucursal AS Sucursal,
            O.estado AS Estado,
            O.fecha_ingreso AS FechaIngreso,
            ISNULL(O.costo_estimado, 0) AS Costo
        FROM ordenes O
        INNER JOIN clientes C ON O.cliente_id = C.id
        INNER JOIN dispositivos D ON O.dispositivo_id = D.id
        LEFT JOIN Usuarios U ON O.tecnico_id = U.Id
        WHERE O.fecha_ingreso >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND O.fecha_ingreso < DATEADD(DAY, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + "')";

            AgregarFiltroSucursal(ref consulta, "O.sucursal");
            AgregarFiltroTecnico(ref consulta, "O.tecnico_id");

            consulta += " ORDER BY O.fecha_ingreso DESC";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            GenerarPdfTabla(
                "REPORTE DE ÓRDENES DE REPARACIÓN",
                tabla,
                "ReporteOrdenes.pdf",
                new[] { "Orden", "Cliente", "Dispositivo", "SerieImei", "Tecnico", "Sucursal", "Estado", "FechaIngreso", "Costo" },
                new[] { "ORDEN", "CLIENTE", "DISPOSITIVO", "IMEI / SERIE", "TÉCNICO", "SUCURSAL", "ESTADO", "INGRESO", "COSTO" },
                null,
                true);
        }

        private void GenerarReporteIngresos()
        {
            string consulta = @"
        SELECT
            O.numero_orden AS Orden,
            C.nombre AS Cliente,
            ISNULL(U.Nombre, 'Sin asignar') AS Tecnico,
            O.sucursal AS Sucursal,
            ISNULL(O.forma_pago, 'No especificado') AS FormaPago,
            O.fecha_entrega AS FechaEntrega,
            ISNULL(O.monto_pagado, 0) AS MontoPagado
        FROM ordenes O
        INNER JOIN clientes C ON O.cliente_id = C.id
        LEFT JOIN Usuarios U ON O.tecnico_id = U.Id
        WHERE O.fecha_entrega >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND O.fecha_entrega < DATEADD(DAY, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + @"')
          AND O.estado = 'Entregado'
          AND O.monto_pagado IS NOT NULL";

            AgregarFiltroSucursal(ref consulta, "O.sucursal");
            AgregarFiltroTecnico(ref consulta, "O.tecnico_id");

            consulta += " ORDER BY O.fecha_entrega DESC";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            decimal total = 0;
            decimal efectivo = 0;
            decimal transferencia = 0;

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    decimal monto = Convert.ToDecimal(fila["MontoPagado"]);
                    total += monto;

                    string formaPago = fila["FormaPago"].ToString();

                    if (formaPago.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
                        efectivo += monto;
                    else if (formaPago.Equals("Transferencia", StringComparison.OrdinalIgnoreCase))
                        transferencia += monto;
                }
            }

            int cantidad = tabla?.Rows.Count ?? 0;
            decimal promedio = cantidad > 0 ? total / cantidad : 0;

            Dictionary<string, string> resumen = new Dictionary<string, string>
            {
                { "INGRESOS", $"${total:F2}" },
                { "SERVICIOS", cantidad.ToString() },
                { "EFECTIVO", $"${efectivo:F2}" },
                { "TRANSFERENCIAS", $"${transferencia:F2}" },
                { "PROMEDIO", $"${promedio:F2}" }
            };

            GenerarPdfTabla(
                "REPORTE DE INGRESOS POR SERVICIOS",
                tabla,
                "ReporteIngresos.pdf",
                new[] { "Orden", "Cliente", "Tecnico", "Sucursal", "FormaPago", "FechaEntrega", "MontoPagado" },
                new[] { "ORDEN", "CLIENTE", "TÉCNICO", "SUCURSAL", "FORMA DE PAGO", "FECHA", "MONTO" },
                resumen,
                true);
        }

        private void GenerarReporteConsumoRepuestos()
        {
            string consulta = @"
        SELECT
            R.idRepuesto AS Codigo,
            R.NombreRepuesto AS Repuesto,
            R.Categoria AS Categoria,
            R.Compatibilidad AS Compatibilidad,
            SUM(D.Cantidad) AS Cantidad,
            R.PrecioCosto,
            SUM(D.Cantidad * R.PrecioCosto) AS CostoTotal
        FROM DetallesOrden D
        INNER JOIN Repuestos R ON D.IdRepuesto = R.idRepuesto
        INNER JOIN ordenes O ON D.IdOrden = O.id
        WHERE O.fecha_ingreso >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND O.fecha_ingreso < DATEADD(DAY, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + "')";

            AgregarFiltroSucursal(ref consulta, "O.sucursal");
            AgregarFiltroTecnico(ref consulta, "O.tecnico_id");

            consulta += @"
        GROUP BY R.idRepuesto, R.NombreRepuesto, R.Categoria, R.Compatibilidad, R.PrecioCosto
        ORDER BY Cantidad DESC";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            int items = 0;
            decimal costo = 0;

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    items += Convert.ToInt32(fila["Cantidad"]);
                    costo += Convert.ToDecimal(fila["CostoTotal"]);
                }
            }

            int dias = (FechaHasta() - FechaDesde()).Days + 1;

            Dictionary<string, string> resumen = new Dictionary<string, string>
            {
                { "ÍTEMS USADOS", items.ToString() },
                { "TIPOS", (tabla?.Rows.Count ?? 0).ToString() },
                { "COSTO TOTAL", $"${costo:F2}" },
                { "PROMEDIO DIARIO", $"${(dias > 0 ? costo / dias : 0):F2}" }
            };

            GenerarPdfTabla(
                "REPORTE DE CONSUMO DE REPUESTOS",
                tabla,
                "ReporteRepuestos.pdf",
                new[] { "Codigo", "Repuesto", "Categoria", "Compatibilidad", "Cantidad", "PrecioCosto", "CostoTotal" },
                new[] { "CÓDIGO", "REPUESTO", "CATEGORÍA", "COMPATIBLE", "CANT.", "COSTO UNIT.", "COSTO TOTAL" },
                resumen,
                true);
        }

        private void GenerarReporteInventario()
        {
            string consulta = @"
        SELECT
            R.idRepuesto AS Codigo,
            R.NombreRepuesto AS Repuesto,
            S.NombreSucursal AS Sucursal,
            R.Categoria AS Categoria,
            R.Compatibilidad AS Compatibilidad,
            I.StockActual,
            I.StockMinimo,
            R.PrecioCosto,
            R.PrecioVenta,
            R.Proveedor
        FROM Repuestos R
        INNER JOIN InventarioSucursal I ON R.IdRepuesto = I.IdRepuesto
        INNER JOIN Sucursales S ON I.IdSucursal = S.IdSucursal
        WHERE 1 = 1";

            AgregarFiltroSucursal(ref consulta, "S.NombreSucursal");
            consulta += " ORDER BY S.NombreSucursal, R.NombreRepuesto";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            int unidades = 0;
            decimal valor = 0;

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    int stock = Convert.ToInt32(fila["StockActual"]);
                    decimal costo = fila["PrecioCosto"] == DBNull.Value ? 0 : Convert.ToDecimal(fila["PrecioCosto"]);

                    unidades += stock;
                    valor += stock * costo;
                }
            }

            Dictionary<string, string> resumen = new Dictionary<string, string>
            {
                { "TIPOS DE REPUESTOS", (tabla?.Rows.Count ?? 0).ToString() },
                { "UNIDADES", unidades.ToString() },
                { "VALOR INVENTARIO", $"${valor:F2}" }
            };

            GenerarPdfTabla(
                "REPORTE DE INVENTARIO DE REPUESTOS",
                tabla,
                "ReporteInventario.pdf",
                new[] { "Codigo", "Repuesto", "Sucursal", "Categoria", "Compatibilidad", "StockActual", "StockMinimo", "PrecioCosto", "PrecioVenta", "Proveedor" },
                new[] { "CÓDIGO", "REPUESTO", "SUCURSAL", "CATEGORÍA", "COMPATIBLE", "STOCK", "MÍN.", "COSTO", "VENTA", "PROVEEDOR" },
                resumen);
        }

        private void GenerarReporteStockBajo()
        {
            string consulta = @"
        SELECT
            R.idRepuesto AS Codigo,
            R.NombreRepuesto AS Repuesto,
            S.NombreSucursal AS Sucursal,
            R.Categoria AS Categoria,
            I.StockActual,
            I.StockMinimo,
            R.Proveedor,
            CASE
                WHEN I.StockActual = 0 THEN 'Sin stock'
                ELSE 'Stock bajo'
            END AS Estado
        FROM Repuestos R
        INNER JOIN InventarioSucursal I ON R.IdRepuesto = I.IdRepuesto
        INNER JOIN Sucursales S ON I.IdSucursal = S.IdSucursal
        WHERE I.StockActual <= I.StockMinimo";

            AgregarFiltroSucursal(ref consulta, "S.NombreSucursal");
            consulta += " ORDER BY I.StockActual, R.NombreRepuesto";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            int sinStock = 0;

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    if (Convert.ToInt32(fila["StockActual"]) == 0)
                        sinStock++;
                }
            }

            Dictionary<string, string> resumen = new Dictionary<string, string>
            {
                { "ALERTAS", (tabla?.Rows.Count ?? 0).ToString() },
                { "SIN STOCK", sinStock.ToString() }
            };

            GenerarPdfTabla(
                "REPORTE DE STOCK BAJO",
                tabla,
                "ReporteStockBajo.pdf",
                new[] { "Codigo", "Repuesto", "Sucursal", "Categoria", "StockActual", "StockMinimo", "Proveedor", "Estado" },
                new[] { "CÓDIGO", "REPUESTO", "SUCURSAL", "CATEGORÍA", "ACTUAL", "MÍNIMO", "PROVEEDOR", "ESTADO" },
                resumen);
        }

        private void GenerarReporteOrdenesPorTecnico()
        {
            string consulta = @"
        SELECT
            U.Nombre AS Tecnico,
            O.sucursal AS Sucursal,
            COUNT(*) AS TotalOrdenes,
            SUM(CASE WHEN O.estado = 'Entregado' THEN 1 ELSE 0 END) AS Entregadas,
            SUM(CASE WHEN O.estado = 'Listo' THEN 1 ELSE 0 END) AS Listas,
            SUM(CASE
                    WHEN O.estado IN ('Recibido', 'En diagnóstico', 'En reparación')
                    THEN 1 ELSE 0
                END) AS EnProceso
        FROM ordenes O
        INNER JOIN Usuarios U ON O.tecnico_id = U.Id
        WHERE O.fecha_ingreso >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND O.fecha_ingreso < DATEADD(DAY, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + "')";

            AgregarFiltroSucursal(ref consulta, "O.sucursal");
            AgregarFiltroTecnico(ref consulta, "O.tecnico_id");

            consulta += @"
        GROUP BY U.Nombre, O.sucursal
        ORDER BY TotalOrdenes DESC";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            GenerarPdfTabla(
                "REPORTE DE ÓRDENES POR TÉCNICO",
                tabla,
                "ReporteOrdenesTecnicos.pdf",
                new[] { "Tecnico", "Sucursal", "TotalOrdenes", "Entregadas", "Listas", "EnProceso" },
                new[] { "TÉCNICO", "SUCURSAL", "TOTAL", "ENTREGADAS", "LISTAS", "EN PROCESO" },
                null,
                true);
        }

        private void GenerarReporteDerivaciones()
        {
            string consulta = @"
        SELECT
            O.numero_orden AS Orden,
            C.nombre AS Cliente,
            D.SucursalOrigen AS Origen,
            D.SucursalDestino AS Destino,
            D.Estado,
            ISNULL(D.Motivo, '—') AS Motivo,
            ISNULL(D.Detalle, '—') AS Detalle,
            D.FechaDerivacion
        FROM DerivacionesSucursales D
        INNER JOIN ordenes O ON D.IdOrden = O.id
        INNER JOIN clientes C ON O.cliente_id = C.id
        WHERE D.FechaDerivacion >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND D.FechaDerivacion < DATEADD(DAY, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + "')";

            if (cmbSucursal.Text != "Todas")
            {
                consulta += " AND (D.SucursalOrigen = '" + cmbSucursal.Text +
                            "' OR D.SucursalDestino = '" + cmbSucursal.Text + "')";
            }

            consulta += " ORDER BY D.FechaDerivacion DESC";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            GenerarPdfTabla(
                "REPORTE DE DERIVACIONES ENTRE SUCURSALES",
                tabla,
                "ReporteDerivaciones.pdf",
                new[] { "Orden", "Cliente", "Origen", "Destino", "Estado", "Motivo", "Detalle", "FechaDerivacion" },
                new[] { "ORDEN", "CLIENTE", "ORIGEN", "DESTINO", "ESTADO", "MOTIVO", "DETALLE", "FECHA" });
        }

        private void GenerarReporteHistorialCliente()
        {
            if (cmbTecnicos.SelectedValue == null)
            {
                MessageBox.Show(
                    "Selecciona un cliente.",
                    "Reportes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(cmbTecnicos.SelectedValue);

            string consulta = "select concat(d.marca, ' ', d.modelo) as Dispositivo, d.serie_imei as SerieImei, o.numero_orden as Orden, o.fecha_ingreso as FechaIngreso, o.fecha_entrega as FechaEntrega, o.estado as Estado, isnull(u.nombre, 'Sin asignar') as Tecnico, isnull(o.trabajo_realizado, '—') as TrabajoRealizado, isnull(o.costo_estimado, 0) as Costo from ordenes o inner join clientes c on o.cliente_id = c.id inner join dispositivos d on o.dispositivo_id = d.id left join usuarios u on o.tecnico_id = u.id where c.id = " + idCliente + " and o.fecha_ingreso >= '" + FechaDesde().ToString("yyyy-MM-dd") + "' and o.fecha_ingreso < dateadd(day, 1, '" + FechaHasta().ToString("yyyy-MM-dd") + "')";

            AgregarFiltroSucursal(ref consulta, "o.sucursal");

            consulta += " order by o.fecha_ingreso desc";

            DataTable tabla = oCon.retornarRegistrosUsuarios(consulta);

            GenerarPdfTabla(
                "HISTORIAL DE REPARACIONES POR CLIENTE",
                tabla,
                "ReporteHistorialCliente.pdf",
                new[] { "Dispositivo", "SerieImei", "Orden", "FechaIngreso", "FechaEntrega", "Estado", "Tecnico", "TrabajoRealizado", "Costo" },
                new[] { "DISPOSITIVO", "IMEI / SERIE", "ORDEN", "INGRESO", "ENTREGA", "ESTADO", "TÉCNICO", "TRABAJO REALIZADO", "COSTO" },
                null,
                true);
        }

        private void ConfigurarFiltrosPorReporte()
        {
            string tipoReporte = cmbTiposReporte.Text;

            cmbSucursal.Enabled = true;
            cmbTecnicos.Enabled = true;
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;

            if (tipoReporte == "Historial de reparaciones por cliente")
            {
                label13.Text = "Cliente";
                CargarClientesEnCombo();
                return;
            }

            label13.Text = "Técnico";
            CargarTecnicos();

            switch (tipoReporte)
            {
                case "Órdenes de reparación":
                    break;

                case "Ingresos por servicios":
                    break;

                case "Consumo de repuestos":
                    break;

                case "Inventario de repuestos":
                    cmbTecnicos.Enabled = false;
                    dtpDesde.Enabled = false;
                    dtpHasta.Enabled = false;
                    break;

                case "Stock bajo":
                    cmbTecnicos.Enabled = false;
                    dtpDesde.Enabled = false;
                    dtpHasta.Enabled = false;
                    break;

                case "Órdenes por técnico":
                    break;

                case "Derivaciones entre sucursales":
                    cmbTecnicos.Enabled = false;
                    break;
            }
        }
        private void GenerarReporteFacturas()
        {
            string consulta = @"
        SELECT
            F.numero_factura AS NumeroFactura,
            F.fecha_emision AS FechaEmision,
            O.numero_orden AS Orden,
            C.nombre AS Cliente,
            C.cedula_pasaporte AS Cedula,
            CONCAT(D.marca, ' ', D.modelo) AS Dispositivo,
            ISNULL(U.nombre, 'Sin asignar') AS Tecnico,
            O.sucursal AS Sucursal,
            F.forma_pago AS FormaPago,
            F.total AS Total,
            F.estado AS Estado
        FROM facturas F
        INNER JOIN ordenes O
            ON F.orden_id = O.id
        INNER JOIN clientes C
            ON O.cliente_id = C.id
        INNER JOIN dispositivos D
            ON O.dispositivo_id = D.id
        LEFT JOIN usuarios U
            ON O.tecnico_id = U.id
        WHERE F.fecha_emision >= '" + FechaDesde().ToString("yyyy-MM-dd") + @"'
          AND F.fecha_emision < DATEADD(
                DAY,
                1,
                '" + FechaHasta().ToString("yyyy-MM-dd") + @"'
          )";

            AgregarFiltroSucursal(
                ref consulta,
                "O.sucursal"
            );

            AgregarFiltroTecnico(
                ref consulta,
                "O.tecnico_id"
            );

            consulta += " ORDER BY F.fecha_emision DESC";

            DataTable tabla =
                oCon.retornarRegistrosUsuarios(consulta);


            decimal totalFacturado = 0;
            decimal efectivo = 0;
            decimal transferencia = 0;

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    decimal total =
                        Convert.ToDecimal(fila["Total"]);

                    totalFacturado += total;

                    string formaPago =
                        fila["FormaPago"].ToString();

                    if (formaPago.Equals(
                        "Efectivo",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        efectivo += total;
                    }
                    else if (formaPago.Equals(
                        "Transferencia",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        transferencia += total;
                    }
                }
            }

            int cantidadFacturas =
                tabla?.Rows.Count ?? 0;

            Dictionary<string, string> resumen =
                new Dictionary<string, string>
            {
        {
            "FACTURAS",
            cantidadFacturas.ToString()
        },
        {
            "TOTAL FACTURADO",
            $"${totalFacturado:F2}"
        },
        {
            "EFECTIVO",
            $"${efectivo:F2}"
        },
        {
            "TRANSFERENCIA",
            $"${transferencia:F2}"
        }
            };


            GenerarPdfTabla(
                "REPORTE DE FACTURAS EMITIDAS",
                tabla,
                "ReporteFacturas.pdf",

                new[]
                {
            "NumeroFactura",
            "FechaEmision",
            "Orden",
            "Cliente",
            "Cedula",
            "Dispositivo",
            "Tecnico",
            "Sucursal",
            "FormaPago",
            "Total",
            "Estado"
                },

                new[]
                {
            "FACTURA",
            "FECHA",
            "ORDEN",
            "CLIENTE",
            "CÉDULA",
            "DISPOSITIVO",
            "TÉCNICO",
            "SUCURSAL",
            "PAGO",
            "TOTAL",
            "ESTADO"
                },

                resumen,
                true
            );
        }
    }

}