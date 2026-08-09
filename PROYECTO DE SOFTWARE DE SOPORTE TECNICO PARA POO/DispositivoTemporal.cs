using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public class DispositivoTemporal
    {
        public string Tipo { get; set; } = "";
        public string Marca { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string Serie { get; set; } = "";
        public string Color { get; set; } = "";
        public int IndiceEstado { get; set; } = 0; // 0 para que seleccione el primer elemento por defecto
        public string Problema { get; set; } = "";
        public string Observaciones { get; set; } = "";
    }

}
