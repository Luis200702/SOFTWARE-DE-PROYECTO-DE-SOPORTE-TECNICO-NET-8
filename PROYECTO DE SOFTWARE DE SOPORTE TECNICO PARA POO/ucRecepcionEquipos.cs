using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucRecepcionEquipos : UserControl
    {
        public ucRecepcionEquipos()
        {
            InitializeComponent();
        }

        private void ucRecepcionEquipos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            cmbEstado.SelectedIndex = 0;

        }

        private void pnlCentral_Resize(object sender, EventArgs e)
        {

            int margenIzquierdoDerecho = 30;
            int espacioEntrePaneles = 20;

            int espacioTotalParaPaneles = pnlCentral.Width - (margenIzquierdoDerecho * 2) - (espacioEntrePaneles * 2);

            int anchoPorPanel = espacioTotalParaPaneles / 3;

            mcCliente.Width = anchoPorPanel;
            mcCliente.Left = margenIzquierdoDerecho;

            mcDispositivo.Width = anchoPorPanel;
            mcDispositivo.Left = mcCliente.Right + espacioEntrePaneles;

            mcReparacion.Width = anchoPorPanel;
            mcReparacion.Left = mcDispositivo.Right + espacioEntrePaneles;

            int margenInferior = 30;
            int nuevaAltura = pnlCentral.Height - mcCliente.Top - margenInferior;
            mcCliente.Height = nuevaAltura;
            mcDispositivo.Height = nuevaAltura;
            mcReparacion.Height = nuevaAltura;
        }
    }
}
