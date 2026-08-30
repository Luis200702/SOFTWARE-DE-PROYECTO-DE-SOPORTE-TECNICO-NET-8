using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;
using System.IO;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucReportes : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        public ucReportes()
        {
            InitializeComponent();
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

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var oCon = new Conexion_Base_de_Datos();
            DataTable tabla = oCon.retornarRegistrosUsuarios(@"
        SELECT 
            R.NombreRepuesto,
            R.Categoria,
            SUM(D.Cantidad) AS TotalUsado,
            R.PrecioCosto,
            SUM(D.Cantidad * R.PrecioCosto) AS TotalCosto
        FROM DetallesOrden D
        INNER JOIN Repuestos R ON D.IdRepuesto = R.idRepuesto
        INNER JOIN ordenes O ON D.IdOrden = O.id
        WHERE MONTH(O.fecha_ingreso) = MONTH(GETDATE())
        AND YEAR(O.fecha_ingreso) = YEAR(GETDATE())
        GROUP BY R.NombreRepuesto, R.Categoria, R.PrecioCosto
        ORDER BY TotalUsado DESC");

            int totalItems = 0;
            decimal totalCosto = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                totalItems += Convert.ToInt32(fila["TotalUsado"]);
                totalCosto += Convert.ToDecimal(fila["TotalCosto"]);
            }

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReporteRepuestos.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    // ENCABEZADO
                    page.Header().Column(col =>
                    {
                        col.Item().AlignCenter().Text("TECH SERVICE").Bold().FontSize(20);
                        col.Item().AlignCenter().Text("Servicio Técnico Especializado").FontSize(11).FontColor("#555555");
                        col.Item().Height(10);
                        col.Item().AlignCenter().Text("REPORTE DE CONSUMO DE REPUESTOS").Bold().FontSize(14);
                        col.Item().AlignCenter().Text($"Período: {DateTime.Now:MMMM yyyy}").FontSize(10).FontColor("#555555");
                        col.Item().Height(10);
                        col.Item().LineHorizontal(1).LineColor("#1a73e8");
                        col.Item().Height(10);
                    });

                    // CONTENIDO
                    page.Content().Column(col =>
                    {
                        // TABLA
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(1);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                            });

                            table.Header(header =>
                            {
                                header.Cell().Background("#1a73e8").Padding(5).Text("Repuesto").FontColor("#ffffff").Bold();
                                header.Cell().Background("#1a73e8").Padding(5).Text("Categoría").FontColor("#ffffff").Bold();
                                header.Cell().Background("#1a73e8").Padding(5).Text("Cantidad").FontColor("#ffffff").Bold();
                                header.Cell().Background("#1a73e8").Padding(5).Text("Precio Costo").FontColor("#ffffff").Bold();
                                header.Cell().Background("#1a73e8").Padding(5).Text("Total").FontColor("#ffffff").Bold();
                            });

                            bool par = false;
                            foreach (DataRow fila in tabla.Rows)
                            {
                                string bg = par ? "#f0f0f0" : "#ffffff";
                                table.Cell().Background(bg).Padding(5).Text(fila["NombreRepuesto"].ToString());
                                table.Cell().Background(bg).Padding(5).Text(fila["Categoria"].ToString());
                                table.Cell().Background(bg).Padding(5).Text(fila["TotalUsado"].ToString());
                                table.Cell().Background(bg).Padding(5).Text($"${fila["PrecioCosto"]}");
                                table.Cell().Background(bg).Padding(5).Text($"${fila["TotalCosto"]}");
                                par = !par;
                            }
                        });

                        col.Item().Height(20);

                        // RESUMEN
                        col.Item().Border(1).BorderColor("#1a73e8").Padding(10).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("TOTAL DE ÍTEMS CONSUMIDOS").Bold().FontSize(9).FontColor("#555555");
                                c.Item().Text(totalItems.ToString()).Bold().FontSize(16);
                            });

                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("COSTO TOTAL DEL PERÍODO").Bold().FontSize(9).FontColor("#555555");
                                c.Item().Text($"${totalCosto:F2}").Bold().FontSize(16).FontColor("#1a73e8");
                            });
                        });
                    });

                    // PIE DE PÁGINA
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Generado el: ");
                        x.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        x.Span(" | Página ");
                        x.CurrentPageNumber();
                        x.Span(" de ");
                        x.TotalPages();
                    });
                });
            }).GeneratePdf(ruta);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(ruta) { UseShellExecute = true });

            MessageBox.Show("Reporte generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
