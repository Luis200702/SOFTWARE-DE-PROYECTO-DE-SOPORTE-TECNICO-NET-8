using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
     class Conexion_Base_de_Datos
    {
        public SqlConnection oCon;
        DataTable oDT;
        SqlDataAdapter oDA;
        SqlCommand oCom;

        string Server;
        string Database;
        string Usuario;
        string Clave;
        string Cadena;

        public Conexion_Base_de_Datos()
        {
            Server = "ASUSVIVOBOOK15\\SQLEXPRESS";
            Database = "Proyecto_Software";
            Usuario = "Pinguino2";
            Clave = "admin";
        }

        public Conexion_Base_de_Datos(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();
            try
            {
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                oCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
