using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Listado_De_Productos : Form
    {
        string cadena;
        public Listado_De_Productos()
        {
            InitializeComponent();
        }

        private void Listado_De_Productos_Load(object sender, EventArgs e)
        {
            csConectaSQL oConSQL = new csConectaSQL();
            DataTable dt = new DataTable();
            ReportDataSource dataset = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Reportes.rptProductos.rdlc";
            cadena = "select P.ProductID, P.ProductName, C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock\r\nfrom Products P inner join Categories C on P.CategoryID = C.CategoryID";
            dt = oConSQL.retornarRegistros(cadena);
            dataset = new ReportDataSource("DS_Productos", dt);
            reportViewer1.LocalReport.DataSources.Add (dataset);
            dataset.Value = dt;
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
