using FontAwesome.Sharp;
using ReaLTaiizor.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucRecepcionEquipos : UserControl
    {
        private UIButton botonSeleccionado = null;

        public ucRecepcionEquipos()
        {
            InitializeComponent();

            mcCliente.BackColor = Color.FromArgb(45, 45, 45);
  
            this.RedondearBotones(40);
        }

        private void ucRecepcionEquipos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            cmbEstado.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTecnicos.SelectedIndex = 0;

          

        }

      
        private void SeleccionarBoton(UIButton boton)
        {

            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.White;
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.Black;
            }


            boton.FillColor = Color.FromArgb(0, 150, 137);
            boton.RectColor = Color.FromArgb(0, 150, 137);
            boton.ForeColor = Color.White;

            botonSeleccionado = boton;
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

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
        }
    }
}
