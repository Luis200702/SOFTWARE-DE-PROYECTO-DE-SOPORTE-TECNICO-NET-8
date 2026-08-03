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

         
        }

        private void ucRecepcionEquipos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            cmbEstadoDispositvo.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTecnicos.SelectedIndex = 0;



        }


        public void SeleccionarBoton(UIButton boton)
        {

            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
            }


            boton.FillColor = Color.FromArgb(0, 150, 137);
            boton.RectColor = Color.FromArgb(0, 150, 137);
            boton.ForeColor = Color.FromArgb(22, 35, 52);

            botonSeleccionado = boton;
        }

        private void pnlCentral_Resize(object sender, EventArgs e)
        {

        
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void lblReparacion_Click(object sender, EventArgs e)
        {

        }
    }
}
