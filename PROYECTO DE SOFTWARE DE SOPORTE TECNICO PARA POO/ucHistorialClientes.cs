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

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucHistorialClientes : UserControl
    {
        public ucHistorialClientes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            IconButton btnNuevaDerivacion = new IconButton();
            btnNuevaDerivacion.Text = "Nueva derivación";
            btnNuevaDerivacion.IconChar = IconChar.Plus;
            btnNuevaDerivacion.IconColor = Color.White;
            btnNuevaDerivacion.IconSize = 20;
            btnNuevaDerivacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaDerivacion.BackColor = ColorTranslator.FromHtml("#14B8A6");
            btnNuevaDerivacion.ForeColor = Color.White;
            btnNuevaDerivacion.FlatStyle = FlatStyle.Flat;
            btnNuevaDerivacion.FlatAppearance.BorderSize = 0;
        }
    }
}
