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
    public partial class ucRecepcionEquipos : UserControl
    {
        public ucRecepcionEquipos()
        {
            InitializeComponent();
        }

        private void ucRecepcionEquipos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
        }
    }
}
