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
            Server = "tcp:servidor-poo-luis.database.windows.net,1433";
            Database = "db_Soporte";
            Usuario = "Pudgy";
            Clave = "P@racaidas12";
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
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Initial Catalog=" + Database + "; User ID=" + Usuario.Trim() + "; Password=" + Clave + "; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
                oCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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





        //Codigo de clases modificado
        public DataTable retornarRegistrosUsuarios(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                abrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                cerrarConexion();
            }
            return oDT;
        }

        public bool insertDatosCliente(string tabla, string campos, string datos)
        {
            try
            {
                if (abrirConexion())
                {
                    Cadena = "Insert into " + tabla + "(" + campos + ") values(" + datos + ")";
                    oCom = new SqlCommand(Cadena, oCon);
                    oCom.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool actualizarDatos(string tabla, string campos, string condicion)
        {
            try
            {
                abrirConexion();

                Cadena = "Update " + tabla + " set " + campos + " where " + condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
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