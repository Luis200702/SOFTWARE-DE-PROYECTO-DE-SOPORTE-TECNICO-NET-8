using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public static class ExtensionesBotones
    {
        // Importar la función nativa de Windows para redondear regiones
        [DllImport("GDI32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // Coordenada X izquierda
            int nTopRect,      // Coordenada Y superior
            int nRightRect,    // Coordenada X derecha (Ancho)
            int nBottomRect,   // Coordenada Y inferior (Alto)
            int nWidthEllipse, // Ancho del óvalo de redondeo
            int nHeightEllipse // Alto del óvalo de redondeo
        );

        // Método individual para un botón
        public static void Redondear(this Button boton, int radio = 40)
        {
            boton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, boton.Width, boton.Height, radio, radio));
        }

        // Metodo recursivo que busca y redondea todos los botones de cualquier contenedor 
        public static void RedondearBotones(this Control contenedor, int radio = 40)
        {
            foreach (Control control in contenedor.Controls)
            {
                // Si el control actual es un botón, se lo redondea
                if (control is Button btn)
                {
                    btn.Redondear(radio);
                }

                // Si el control tiene hijos 
                if (control.HasChildren)
                {
                    RedondearBotones(control, radio);
                }
            }
        }
    }
}
