using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucReportes : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        public ucReportes()
        {
            InitializeComponent();
            CargarTiposReporte();
            CargarSucursales();
            CargarTecnicos();
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
            cmbTiposReporte.Items.Add("Historial de reparaciones por dispositivo");

            if (cmbTiposReporte.Items.Count > 0)
            {
                cmbTiposReporte.SelectedIndex = 0;
                ConfigurarFiltrosPorReporte();
            }
        }
        private void ucReportes_Load(object sender, EventArgs e)
        {
            DataTable EquiposRecibidos = oCon.retornarRegistrosUsuarios("select count(fecha_ingreso) as Numero  from Ordenes\r\nwhere month(fecha_ingreso) = month(getdate())\r\nand year(fecha_ingreso) = year(getdate())");
            lblEquiposRecibidos.Text = EquiposRecibidos.Rows[0]["Numero"].ToString();

            DataTable NumeroReparaciones = oCon.retornarRegistrosUsuarios("select count(fecha_ingreso) as Numero_Reparaciones from Ordenes\r\nwhere month(fecha_ingreso) = month(getdate())\r\nand year(fecha_ingreso) = year(getdate()) and estado = 'Entregado'");
            lblReparaciones.Text = NumeroReparaciones.Rows[0]["Numero_Reparaciones"].ToString();

            DataTable TotalIngresos = oCon.retornarRegistrosUsuarios("select sum(D.PrecioCobrado) as Total\r\nfrom DetallesOrden D inner join ordenes O on D.IdDetalle = O.Id\r\nwhere month(O.fecha_ingreso) = month(getdate())");
            lblIngresos.Text = "$ " + TotalIngresos.Rows[0]["Total"].ToString();

            DataTable Pendientes = oCon.retornarRegistrosUsuarios("select count(fecha_ingreso) as Numero_Reparaciones from Ordenes\r\nwhere month(fecha_ingreso) = month(getdate())\r\nand year(fecha_ingreso) = year(getdate()) and not estado = 'Entregado'");
            lblPendientes.Text = Pendientes.Rows[0]["Numero_Reparaciones"].ToString();

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
                    MessageBox.Show("Reporte de ingresos pendiente de implementar.");
                    break;

                case "Consumo de repuestos":
                    GenerarReporteConsumoRepuestos();
                    break;

                case "Inventario de repuestos":
                    MessageBox.Show("Reporte de inventario pendiente de implementar.");
                    break;

                case "Stock bajo":
                    MessageBox.Show("Reporte de stock bajo pendiente de implementar.");
                    break;

                case "Órdenes por técnico":
                    MessageBox.Show("Reporte de órdenes por técnico pendiente de implementar.");
                    break;

                case "Derivaciones entre sucursales":
                    MessageBox.Show("Reporte de derivaciones pendiente de implementar.");
                    break;

                case "Historial de reparaciones por dispositivo":
                    MessageBox.Show("Reporte de historial por dispositivo pendiente de implementar.");
                    break;
            }

        }




        private void GenerarReporteConsumoRepuestos()
        {
            if (!ValidarRangoFechas())
                return;
            QuestPDF.Settings.License = LicenseType.Community;
            string sucursal = cmbSucursal.SelectedValue?.ToString() ?? "0";
            string nombreSucursal = cmbSucursal.Text == "" ? "Todas" : cmbSucursal.Text;
            DataTable tabla = oCon.retornarRegistrosUsuarios(@"
         SELECT 
        R.idRepuesto AS Codigo,
        R.NombreRepuesto,
        R.Categoria,
        R.Compatibilidad AS Marca,
        SUM(D.Cantidad) AS TotalUsado,
        R.PrecioCosto,
        SUM(D.Cantidad * R.PrecioCosto) AS TotalCosto
    FROM DetallesOrden D
    INNER JOIN Repuestos R ON D.IdRepuesto = R.idRepuesto
    INNER JOIN ordenes O ON D.IdOrden = O.id
    INNER JOIN Sucursales S ON O.sucursal = S.IdSucursal
    WHERE MONTH(O.fecha_ingreso) = MONTH(GETDATE())
    AND YEAR(O.fecha_ingreso) = YEAR(GETDATE())
    AND (O.sucursal = '" + sucursal + @"' OR '" + sucursal + @"' = '0')    
    GROUP BY R.idRepuesto, R.NombreRepuesto, R.Categoria, R.Compatibilidad, R.PrecioCosto
    ORDER BY TotalUsado DESC");

            int totalItems = 0;
            int tiposRepuestos = tabla.Rows.Count;
            decimal totalCosto = 0;


            foreach (DataRow fila in tabla.Rows)
            {
                totalItems += Convert.ToInt32(fila["TotalUsado"]);
                totalCosto += Convert.ToDecimal(fila["TotalCosto"]);
            }

            decimal promedioDiario = totalCosto / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReporteRepuestos.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(9));

                    // ENCABEZADO
                    page.Header().Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            // Logo texto
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("⚙ TECH SERVICE").Bold().FontSize(20).FontColor("#1a73e8");
                                c.Item().Text("SERVICIO TÉCNICO ESPECIALIZADO").FontSize(8).FontColor("#555555");
                            });

                            // Info empresa
                            row.ConstantItem(200).Column(c =>
                            {
                                c.Item().AlignRight().Text("📍 Sucursal Centro").FontSize(8);
                                c.Item().AlignRight().Text("📞 098 765 4321").FontSize(8);
                                c.Item().AlignRight().Text("✉ contacto@techservice.com").FontSize(8);
                            });
                        });

                        col.Item().Height(8);
                        col.Item().LineHorizontal(2).LineColor("#1a73e8");
                        col.Item().Height(8);

                        col.Item().AlignCenter().Text("REPORTE DE CONSUMO DE REPUESTOS").Bold().FontSize(14);
                        col.Item().AlignCenter().Text($"Período: 01/{DateTime.Now.Month:D2}/{DateTime.Now.Year} al {DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)}/{DateTime.Now.Month:D2}/{DateTime.Now.Year}").FontSize(9).FontColor("#555555");
                        col.Item().Height(8);
                    });

                    page.Content().Column(col =>
                    {
                        // FILTROS APLICADOS
                        col.Item().Border(1).BorderColor("#1a73e8").Padding(8).Column(f =>
                        {
                            f.Item().Text("FILTROS APLICADOS").Bold().FontSize(9).FontColor("#1a73e8");
                            f.Item().Height(5);
                            f.Item().Row(row =>
                            {
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("Período:").Bold();
                                    c.Item().Text($"01/{DateTime.Now.Month:D2}/{DateTime.Now.Year} al {DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)}/{DateTime.Now.Month:D2}/{DateTime.Now.Year}");
                                });
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("Categoría:").Bold();
                                    c.Item().Text("Todas");
                                });
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("Sucursal:").Bold();
                                    c.Item().Text(nombreSucursal);  // <-- así queda
                                });
                                row.RelativeItem().Column(c =>
                                {
                                    c.Item().Text("Técnico:").Bold();
                                    c.Item().Text("Todos");
                                });
                            });
                        });

                        col.Item().Height(10);

                        // TARJETAS RESUMEN
                        col.Item().Row(row =>
                        {
                            void Tarjeta(RowDescriptor r, string titulo, string valor)
                            {
                                r.RelativeItem().Border(1).BorderColor("#dddddd").Padding(8).Column(c =>
                                {
                                    c.Item().Text(titulo).FontSize(8).FontColor("#555555").Bold();
                                    c.Item().Text(valor).FontSize(16).Bold().FontColor("#1a73e8");
                                });
                            }

                            Tarjeta(row, "TOTAL DE ÍTEMS", totalItems.ToString());
                            row.ConstantItem(5);
                            Tarjeta(row, "TIPOS DE REPUESTOS", tiposRepuestos.ToString());
                            row.ConstantItem(5);
                            Tarjeta(row, "COSTO TOTAL", $"${totalCosto:F2}");
                            row.ConstantItem(5);
                            Tarjeta(row, "PROMEDIO DIARIO", $"${promedioDiario:F2}");
                        });

                        col.Item().Height(10);

                        // TABLA
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(55);
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.ConstantColumn(50);
                                columns.ConstantColumn(60);
                                columns.ConstantColumn(60);
                            });

                            table.Header(header =>
                            {
                                string bg = "#1a4f8a";
                                header.Cell().Background(bg).Padding(4).Text("CÓDIGO").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).Text("REPUESTO").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).Text("CATEGORÍA").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).Text("MARCA").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).AlignCenter().Text("CANT.").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).AlignRight().Text("C. UNIT.").FontColor("#ffffff").Bold().FontSize(8);
                                header.Cell().Background(bg).Padding(4).AlignRight().Text("C. TOTAL").FontColor("#ffffff").Bold().FontSize(8);
                            });

                            bool par = false;
                            foreach (DataRow fila in tabla.Rows)
                            {
                                string bg = par ? "#f0f4ff" : "#ffffff";
                                table.Cell().Background(bg).Padding(4).Text($"REP-{fila["Codigo"]:D4}").FontSize(8);
                                table.Cell().Background(bg).Padding(4).Text(fila["NombreRepuesto"].ToString()).FontSize(8);
                                table.Cell().Background(bg).Padding(4).Text(fila["Categoria"].ToString()).FontSize(8);
                                table.Cell().Background(bg).Padding(4).Text(fila["Marca"].ToString()).FontSize(8);
                                table.Cell().Background(bg).Padding(4).AlignCenter().Text(fila["TotalUsado"].ToString()).FontSize(8);
                                table.Cell().Background(bg).Padding(4).AlignRight().Text($"${fila["PrecioCosto"]:F2}").FontSize(8);
                                table.Cell().Background(bg).Padding(4).AlignRight().Text($"${fila["TotalCosto"]:F2}").FontSize(8);
                                par = !par;
                            }
                        });

                        col.Item().Height(10);

                        // TOP 5
                        col.Item().Text("TOP 5 REPUESTOS MÁS CONSUMIDOS").Bold().FontSize(10).FontColor("#1a73e8");
                        col.Item().Height(5);

                        int top = 1;
                        foreach (DataRow fila in tabla.AsEnumerable().Take(5))
                        {
                            col.Item().Row(row =>
                            {
                                row.ConstantItem(20).Background("#1a4f8a").AlignCenter().AlignMiddle().Text(top.ToString()).FontColor("#ffffff").Bold().FontSize(9);
                                row.ConstantItem(5);
                                row.RelativeItem().BorderBottom(1).BorderColor("#dddddd").Padding(4).Text(fila["NombreRepuesto"].ToString()).FontSize(9);
                                row.ConstantItem(60).BorderBottom(1).BorderColor("#dddddd").Padding(4).AlignRight().Text($"{fila["TotalUsado"]} und").FontSize(9);
                            });
                            col.Item().Height(3);
                            top++;
                        }

                        col.Item().Height(10);

                        // OBSERVACIONES
                        col.Item().Text("Observaciones:").Bold().FontSize(8);
                        col.Item().Text("Reporte generado automáticamente desde el sistema.").FontSize(8).FontColor("#555555");
                    });

                    // PIE DE PÁGINA
                    page.Footer().Row(row =>
                    {
                        row.RelativeItem().Text($"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(8).FontColor("#555555");
                        row.RelativeItem().AlignCenter().Text(x =>
                        {
                            x.Span("Página ").FontSize(8);
                            x.CurrentPageNumber().FontSize(8);
                            x.Span(" de ").FontSize(8);
                            x.TotalPages().FontSize(8);
                        });
                    });
                });
            }).GeneratePdf(ruta);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(ruta) { UseShellExecute = true });
            MessageBox.Show("Reporte generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void GenerarReporteOrdenes()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

            string nombreSucursal = cmbSucursal.Text;
            int tecnicoId = Convert.ToInt32(cmbTecnicos.SelectedValue ?? 0);

            string consulta = @"
        SELECT
            O.numero_orden AS NumeroOrden,
            C.nombre AS Cliente,
            D.tipo AS Tipo,
            D.marca AS Marca,
            D.modelo AS Modelo,
            D.serie_imei AS SerieImei,
            ISNULL(U.Nombre, 'Sin asignar') AS Tecnico,
            O.sucursal AS Sucursal,
            O.estado AS Estado,
            O.fecha_ingreso AS FechaIngreso,
            O.fecha_estimada_entrega AS FechaEstimada,
            O.costo_estimado AS Costo
        FROM ordenes O
        INNER JOIN clientes C
            ON O.cliente_id = C.id
        INNER JOIN dispositivos D
            ON O.dispositivo_id = D.id
        LEFT JOIN Usuarios U
            ON O.tecnico_id = U.Id
        WHERE O.fecha_ingreso >= '" + fechaDesde.ToString("yyyy-MM-dd") + @"'
          AND O.fecha_ingreso < DATEADD(
                DAY,
                1,
                '" + fechaHasta.ToString("yyyy-MM-dd") + @"'
          )";

            // Filtrar por sucursal
            if (nombreSucursal != "Todas")
            {
                consulta += @"
          AND O.sucursal = '" + nombreSucursal + "'";
            }

            // Filtrar por técnico
            if (tecnicoId != 0)
            {
                consulta += @"
          AND O.tecnico_id = " + tecnicoId;
            }

            consulta += @"
        ORDER BY O.fecha_ingreso DESC";

            DataTable tabla =
                oCon.retornarRegistrosUsuarios(consulta);

            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron órdenes con los filtros seleccionados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            string ruta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "ReporteOrdenes.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());

                    page.Margin(
                        1.2f,
                        Unit.Centimetre);

                    page.DefaultTextStyle(
                        x => x.FontSize(8));

                    // ENCABEZADO
                    page.Header().Column(col =>
                    {
                        col.Item()
                            .Text("TECH SERVICE")
                            .Bold()
                            .FontSize(18)
                            .FontColor("#1a73e8");

                        col.Item()
                            .Text("REPORTE DE ÓRDENES DE REPARACIÓN")
                            .Bold()
                            .FontSize(14);

                        col.Item()
                            .Text(
                                $"Período: {fechaDesde:dd/MM/yyyy} al {fechaHasta:dd/MM/yyyy}")
                            .FontColor("#555555");

                        col.Item().Height(5);

                        col.Item()
                            .Text(
                                $"Sucursal: {nombreSucursal}   |   Técnico: {cmbTecnicos.Text}")
                            .FontSize(9);

                        col.Item().Height(8);

                        col.Item()
                            .LineHorizontal(2)
                            .LineColor("#1a73e8");
                    });

                    // CONTENIDO
                    page.Content().PaddingVertical(10).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(80);  // Orden
                            columns.RelativeColumn(2);   // Cliente
                            columns.RelativeColumn(2);   // Dispositivo
                            columns.RelativeColumn(2);   // IMEI
                            columns.RelativeColumn(2);   // Técnico
                            columns.RelativeColumn(1.5f);// Sucursal
                            columns.RelativeColumn(1.5f);// Estado
                            columns.ConstantColumn(70);  // Fecha
                            columns.ConstantColumn(60);  // Costo
                        });

                        table.Header(header =>
                        {
                            string fondo = "#1a4f8a";

                            header.Cell().Background(fondo).Padding(4)
                                .Text("ORDEN").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("CLIENTE").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("DISPOSITIVO").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("IMEI / SERIE").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("TÉCNICO").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("SUCURSAL").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("ESTADO").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .Text("INGRESO").FontColor("#ffffff").Bold();

                            header.Cell().Background(fondo).Padding(4)
                                .AlignRight()
                                .Text("COSTO").FontColor("#ffffff").Bold();
                        });

                        bool filaPar = false;

                        foreach (DataRow fila in tabla.Rows)
                        {
                            string fondo =
                                filaPar ? "#f0f4ff" : "#ffffff";

                            string dispositivo =
                                fila["Marca"].ToString() + " " +
                                fila["Modelo"].ToString();

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["NumeroOrden"].ToString());

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["Cliente"].ToString());

                            table.Cell().Background(fondo).Padding(4)
                                .Text(dispositivo);

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["SerieImei"].ToString());

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["Tecnico"].ToString());

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["Sucursal"].ToString());

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fila["Estado"].ToString());

                            DateTime fecha =
                                Convert.ToDateTime(fila["FechaIngreso"]);

                            table.Cell().Background(fondo).Padding(4)
                                .Text(fecha.ToString("dd/MM/yyyy"));

                            decimal costo = fila["Costo"] == DBNull.Value
    ? 0
    : Convert.ToDecimal(fila["Costo"]);

                            table.Cell().Background(fondo).Padding(4)
                                .AlignRight()
                                .Text($"${costo:F2}");

                            filaPar = !filaPar;
                        }
                    });

                    // PIE
                    page.Footer().Row(row =>
                    {
                        row.RelativeItem()
                            .Text(
                                $"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}")
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

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                });

            MessageBox.Show(
                "Reporte de órdenes generado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void ConfigurarFiltrosPorReporte()
        {
            string tipoReporte = cmbTiposReporte.Text;

            // Primero habilitamos todos los filtros
            cmbSucursal.Enabled = true;
            cmbTecnicos.Enabled = true;
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;

            switch (tipoReporte)
            {
                case "Órdenes de reparación":
                    // Sucursal + técnico + fechas
                    break;

                case "Ingresos por servicios":
                    // Sucursal + técnico + fechas
                    break;

                case "Consumo de repuestos":
                    // Sucursal + técnico + fechas
                    break;

                case "Inventario de repuestos":
                    // Solo sucursal
                    cmbTecnicos.Enabled = false;
                    dtpDesde.Enabled = false;
                    dtpHasta.Enabled = false;
                    break;

                case "Stock bajo":
                    // Solo sucursal
                    cmbTecnicos.Enabled = false;
                    dtpDesde.Enabled = false;
                    dtpHasta.Enabled = false;
                    break;

                case "Órdenes por técnico":
                    // Sucursal + técnico + fechas
                    break;

                case "Derivaciones entre sucursales":
                    // Sucursal + fechas
                    cmbTecnicos.Enabled = false;
                    break;

                case "Historial de reparaciones por dispositivo":
                    // Necesitará IMEI/Serie + fechas
                    cmbTecnicos.Enabled = false;

                    // Por ahora podemos mantener sucursal y fechas.
                    break;
            }
        }
    }

}
