using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    class csConectaSQL
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

        public csConectaSQL()
        {
            Server = "tcp:servidor-poo-luis.database.windows.net,1433";
            Database = "db_Soporte";
            Usuario = "Pudgy";
            Clave = "P@racaidas12";
        }

        public csConectaSQL(string Server, string Database, string Usuario, string Clave)
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

        public DataTable retornarRegistros(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                abrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT); //Pasar los registros a DataTable
                cerrarConexion();
            }
            return oDT;
        }
        public bool insertDatos(string tabla, string campos, string datos)
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
        public bool ActualizarDatos(string tabla, string campos, string conexion)
        {
            try
            {
                abrirConexion();
                Cadena = "Update " + tabla + " set " + campos + " where " + conexion;
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
        public bool EliminarDatos(string tabla, string conexion)
        {
            try
            {
                abrirConexion();
                Cadena = "Delete " + tabla + " where " + conexion;
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
        public bool ejecutaSentenciaSRD(string sentencia)
        {
            try
            {
                abrirConexion();
                oCom = new SqlCommand(sentencia, oCon);
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
