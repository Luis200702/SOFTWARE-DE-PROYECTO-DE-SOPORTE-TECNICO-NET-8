using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO.Reportes
{
    public static class FacturaPdf
    {
        public static byte[] Generar(FacturaModel factura)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            using MemoryStream stream = new MemoryStream();

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);

                    page.MarginVertical(30);
                    page.MarginHorizontal(35);

                    page.DefaultTextStyle(x =>
                        x.FontSize(10)
                         .FontColor("#182B3E"));

                    page.Header()
                        .Element(c => CrearEncabezado(c, factura));

                    page.Content()
                        .PaddingTop(15)
                        .Element(c => CrearContenido(c, factura));

                    page.Footer()
                        .AlignCenter()
                        .Text("Gracias por su preferencia")
                        .FontSize(10)
                        .FontColor("#465667");
                });
            })
            .GeneratePdf(stream);

            return stream.ToArray();
        }

        private static void CrearEncabezado(
            IContainer container,
            FacturaModel factura)
        {
            container.Row(row =>
            {
                row.RelativeItem(2)
                    .Column(col =>
                    {
                        col.Spacing(3);

                        col.Item()
                            .Text("TECH_DKV")
                            .Bold()
                            .FontSize(24)
                            .FontColor("#00A59B");

                        col.Item()
                            .Text("Servicio técnico especializado")
                            .FontSize(10)
                            .FontColor("#465667");
                    });

                row.RelativeItem()
                    .Border(1)
                    .BorderColor("#DCE2E8")
                    .Padding(10)
                    .Column(col =>
                    {
                        col.Spacing(5);

                        col.Item()
                            .AlignCenter()
                            .Text("FACTURA / COMPROBANTE")
                            .Bold()
                            .FontSize(16)
                            .FontColor("#182B3E");

                        col.Item()
                            .LineHorizontal(1)
                            .LineColor("#00A59B");

                        col.Item()
                            .Text($"N.º Factura: {factura.NumeroFactura}")
                            .Bold();

                        col.Item()
                            .Text($"Fecha: {factura.Fecha:dd/MM/yyyy HH:mm}");

                        col.Item()
                            .Text($"Orden: {factura.NumeroOrden}");
                    });
            });
        }

        private static void CrearContenido(
            IContainer container,
            FacturaModel factura)
        {
            container.Column(col =>
            {
                col.Spacing(14);

                col.Item()
                    .Element(c => CrearSeccionCliente(c, factura));

                col.Item()
                    .Element(c => CrearSeccionDispositivo(c, factura));

                col.Item()
                    .Element(c => CrearTablaDetalles(c, factura));

                col.Item()
                    .Element(c => CrearResumenPago(c, factura));
            });
        }

        private static void CrearSeccionCliente(
            IContainer container,
            FacturaModel factura)
        {
            container
                .Border(1)
                .BorderColor("#E1E6EB")
                .Column(col =>
                {
                    col.Item()
                        .Background("#00A59B")
                        .PaddingVertical(6)
                        .PaddingHorizontal(10)
                        .Text("DATOS DEL CLIENTE")
                        .Bold()
                        .FontColor(Colors.White);

                    col.Item()
                        .Padding(10)
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Cédula")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(factura.Cedula);
                                });

                            row.RelativeItem()
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Nombre")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(factura.NombreCliente);
                                });

                            row.RelativeItem()
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Teléfono")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(factura.Telefono);
                                });

                            row.RelativeItem()
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Correo")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(
                                            string.IsNullOrWhiteSpace(factura.Correo)
                                                ? "No registrado"
                                                : factura.Correo
                                        );
                                });
                        });
                });
        }

        private static void CrearSeccionDispositivo(
            IContainer container,
            FacturaModel factura)
        {
            container
                .Border(1)
                .BorderColor("#E1E6EB")
                .Column(col =>
                {
                    col.Item()
                        .Background("#00A59B")
                        .PaddingVertical(6)
                        .PaddingHorizontal(10)
                        .Text("DATOS DEL DISPOSITIVO")
                        .Bold()
                        .FontColor(Colors.White);

                    col.Item()
                        .Padding(10)
                        .Row(row =>
                        {
                            row.RelativeItem(2)
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Dispositivo")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(factura.Dispositivo);
                                });

                            row.RelativeItem()
                                .Column(c =>
                                {
                                    c.Item()
                                        .Text("Técnico")
                                        .Bold()
                                        .FontSize(9)
                                        .FontColor("#465667");

                                    c.Item()
                                        .Text(factura.Tecnico);
                                });
                        });

                    if (!string.IsNullOrWhiteSpace(factura.TrabajoRealizado))
                    {
                        col.Item()
                            .PaddingHorizontal(10)
                            .PaddingBottom(10)
                            .Column(c =>
                            {
                                c.Item()
                                    .Text("Trabajo realizado")
                                    .Bold()
                                    .FontSize(9)
                                    .FontColor("#465667");

                                c.Item()
                                    .Text(factura.TrabajoRealizado);
                            });
                    }
                });
        }

        private static void CrearTablaDetalles(
            IContainer container,
            FacturaModel factura)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(4);
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(1.5f);
                    columns.RelativeColumn(1.5f);
                });

                table.Header(header =>
                {
                    header.Cell()
                        .Background("#00A59B")
                        .Padding(6)
                        .Text("DESCRIPCIÓN")
                        .Bold()
                        .FontColor(Colors.White);

                    header.Cell()
                        .Background("#00A59B")
                        .Padding(6)
                        .AlignCenter()
                        .Text("CANT.")
                        .Bold()
                        .FontColor(Colors.White);

                    header.Cell()
                        .Background("#00A59B")
                        .Padding(6)
                        .AlignRight()
                        .Text("PRECIO")
                        .Bold()
                        .FontColor(Colors.White);

                    header.Cell()
                        .Background("#00A59B")
                        .Padding(6)
                        .AlignRight()
                        .Text("SUBTOTAL")
                        .Bold()
                        .FontColor(Colors.White);
                });

                foreach (var detalle in factura.Detalles)
                {
                    table.Cell()
                        .BorderBottom(1)
                        .BorderColor("#E1E6EB")
                        .Padding(6)
                        .Text(detalle.Descripcion);

                    table.Cell()
                        .BorderBottom(1)
                        .BorderColor("#E1E6EB")
                        .Padding(6)
                        .AlignCenter()
                        .Text(detalle.Cantidad.ToString());

                    table.Cell()
                        .BorderBottom(1)
                        .BorderColor("#E1E6EB")
                        .Padding(6)
                        .AlignRight()
                        .Text($"${detalle.PrecioUnitario:F2}");

                    table.Cell()
                        .BorderBottom(1)
                        .BorderColor("#E1E6EB")
                        .Padding(6)
                        .AlignRight()
                        .Text($"${detalle.Subtotal:F2}");
                }
            });
        }

        private static void CrearResumenPago(
            IContainer container,
            FacturaModel factura)
        {
            container.Row(row =>
            {
                row.RelativeItem(2)
                    .Border(1)
                    .BorderColor("#E1E6EB")
                    .Padding(10)
                    .Column(col =>
                    {
                        col.Spacing(6);

                        col.Item()
                            .Text("Forma de pago")
                            .Bold()
                            .FontColor("#465667");

                        col.Item()
                            .Text(factura.FormaPago);

                        if (!string.IsNullOrWhiteSpace(factura.Observaciones))
                        {
                            col.Item()
                                .PaddingTop(8)
                                .Text("Observaciones")
                                .Bold()
                                .FontColor("#465667");

                            col.Item()
                                .Text(factura.Observaciones);
                        }
                    });

                row.ConstantItem(180)
                    .Border(1)
                    .BorderColor("#E1E6EB")
                    .Padding(10)
                    .Column(col =>
                    {
                        col.Spacing(6);

                        col.Item()
                            .Row(r =>
                            {
                                r.RelativeItem()
                                    .Text("SUBTOTAL");

                                r.ConstantItem(80)
                                    .AlignRight()
                                    .Text($"${factura.Total:F2}");
                            });

                        col.Item()
                            .LineHorizontal(1)
                            .LineColor("#DCE2E8");

                        col.Item()
                            .Row(r =>
                            {
                                r.RelativeItem()
                                    .Text("TOTAL")
                                    .Bold()
                                    .FontSize(12);

                                r.ConstantItem(80)
                                    .AlignRight()
                                    .Text($"${factura.Total:F2}")
                                    .Bold()
                                    .FontSize(13)
                                    .FontColor("#00A59B");
                            });
                    });
            });
        }
    }
}