using System;
using System.Collections.Generic;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO.Reportes
{
    public class FacturaModel
    {
        // Factura
        public string NumeroFactura { get; set; } = "";
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string NumeroOrden { get; set; } = "";

        // Cliente
        public string Cedula { get; set; } = "";
        public string NombreCliente { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Correo { get; set; } = "";

        // Dispositivo
        public string Dispositivo { get; set; } = "";
        public string Tecnico { get; set; } = "";

        // Reparación
        public string TrabajoRealizado { get; set; } = "";
        public string Observaciones { get; set; } = "";

        // Pago
        public string FormaPago { get; set; } = "";
        public decimal Total { get; set; }

        // Detalle
        public List<DetalleFacturaModel> Detalles { get; set; } = new();
    }

    public class DetalleFacturaModel
    {
        public string Descripcion { get; set; } = "";
        public int Cantidad { get; set; } = 1;
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
    }
}