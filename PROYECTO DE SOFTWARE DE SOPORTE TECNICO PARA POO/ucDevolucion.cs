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
    public partial class ucDevolucion : UserControl
    {
        public ucDevolucion()
        {
            InitializeComponent();
        }

        ucRecepcion UnSoloBoton = new ucRecepcion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlResumen.Visible = true;
            pnlTrabajoRealizado.Visible = true;
            pnlDesgloseCosto.Visible = true;
            pnlFormaDePago.Visible = true;
            btnRegistraEntrega.Visible = true;
            btnComprobante.Visible = true;
        }

        private void ucDevolucion_Load(object sender, EventArgs e)
        {
            cmbFormaPago.SelectedIndex = 0;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnReparado);
        }

        private void btnParcial_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnParcial);
        }

        private void btnSinReparar_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnSinReparar);
        }
    }
}
