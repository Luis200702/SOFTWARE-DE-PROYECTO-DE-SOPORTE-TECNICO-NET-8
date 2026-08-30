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
            CargarSucursales();
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
        }

        private void pnlDatosCliente_Click(object sender, EventArgs e)
        {

        }
        public void CargarSucursales()
        {
            DataTable dt = oCon.retornarRegistrosUsuarios("select IdSucursal, NombreSucursal from Sucursales order by NombreSucursal");

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "NombreSucursal";
                cmbSucursal.ValueMember = "IdSucursal";
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
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
    }

}
