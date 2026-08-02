using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public static class TemaManager
    {
        // Método principal que se llamará desde cualquier parte del proyecto
        //public static void AplicarTema(Control contenedor, bool oscuro)
        //{
        //    // ==========================================
        //    // 1. PALETA DE COLORES GLOBAL (Modifica aquí tus tonos)
        //    // ==========================================
        //    Color colorFondoForm = oscuro ? Color.FromArgb(24, 35, 54) : Color.White;                     // Fondo de formularios
        //    Color colorFondoPanel = oscuro ? Color.FromArgb(17, 24, 39) : Color.FromArgb(240, 242, 245);    // Paneles y menús laterales
        //    Color colorTexto = oscuro ? Color.White : Color.FromArgb(30, 41, 59);                           // Texto general de Labels
        //    //Color colorBotonFondo = oscuro ? Color.FromArgb(45, 55, 72) : Color.FromArgb(226, 232, 240);    // Fondo de botones normales
        //    Color colorBotonTexto = oscuro ? Color.White : Color.FromArgb(30, 41, 59);                    // Texto de botones normales

        //    // Si el contenedor actual es un Formulario, le cambiamos el fondo
        //    if (contenedor is Form frm)
        //    {
        //        frm.BackColor = colorFondoForm;
        //    }

        //    // Recorremos todos los elementos internos del contenedor de forma recursiva
        //    foreach (Control control in contenedor.Controls)
        //    {
        //        // --------------------------------------------------
        //        // 2. EXCEPCIONES GLOBALES (AQUÍ PONES LO QUE NO DEBE CAMBIAR)
        //        // --------------------------------------------------
        //        // Si quieres exceptuar un botón específico por su nombre en TODO el sistema:

        //        /*
        //        if (control.Name == "btnLogoPrincipal" || control.Name == "btnLogoMenu" || control.Name == "btnRecepcionEquipos" || control.Name == "btnSeguimientoReparaciones"
        //            || control.Name == "btnDevoluciónEntrega" || control.Name == "btnGestionStock" || control.Name == "btnDerivacionOrdenes")
        //        {
        //            continue; // Salta este control y no le modifica los colores
        //        }
        //        */

        //        // Aseguramos que el control NUNCA se bloquee interactivamente
        //        control.Enabled = true;

        //        // Aplicamos estilos según el tipo de componente
        //        if (control is Panel || control is UserControl)
        //        {
        //            control.BackColor = colorFondoPanel;
        //        }
        //        else if (control is Label)
        //        {
        //            control.ForeColor = colorTexto;
        //        }
        //        else if (control is Button)
        //        {
        //            //control.BackColor = colorBotonFondo;
        //            control.ForeColor = colorBotonTexto;
        //        }

        //        // Si el control actual tiene elementos adentro (ej. un panel con botones o labels), 
        //        // entra recursivamente para aplicar el tema también a sus hijos.
        //        if (control.HasChildren)
        //        {
        //            AplicarTema(control, oscuro);
        //        }
        //    }
        //}
    }
}
