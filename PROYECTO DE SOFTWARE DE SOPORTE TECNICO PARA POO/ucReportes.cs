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

            DataTable Pendientes = oCon.retornarRegistrosUsuarios("select count(fecha_ingreso) as Numero_Reparaciones from Ordenes\r\nwhere month(fecha_ingreso) = month(getdate())\r\nand year(fecha_ingreso) = year(getdate()) and not estado = 'listo'");
            lblPendientes.Text = Pendientes.Rows[0]["Numero_Reparaciones"].ToString();
        }

        private void pnlDatosCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
