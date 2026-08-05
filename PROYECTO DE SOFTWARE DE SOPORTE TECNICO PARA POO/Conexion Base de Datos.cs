using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    internal class Conexion_Base_de_Datos
    {
        private string cadena = @"Server=ASUSVIVOBOOK15\SQLEXPRESS;
                              Database=taller_tecnico;
                              Trusted_Connection=True;
                              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }

    }
}
