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
    public partial class ucGestionUsuarios : UserControl
    {
        public ucGestionUsuarios()
        {
            InitializeComponent();

            // Se llama a la función para redondear todos los botones del formulario
            this.RedondearBotones(20);

        }
    }
}
