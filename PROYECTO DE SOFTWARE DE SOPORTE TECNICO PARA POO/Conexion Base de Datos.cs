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

        public string[] validarUsuario(string usuario, string contrasena)
        {
            try
            {
                if (abrirConexion())
                {
                    string consulta = @"SELECT U.Perfil, S.NombreSucursal 
                                FROM Usuarios U
                                INNER JOIN Sucursales S ON U.IdSucursal = S.IdSucursal
                                WHERE U.Usuario = @Usuario 
                                AND U.Contrasena = @Contrasena";

                    oCom = new SqlCommand(consulta, oCon);
                    oCom.Parameters.AddWithValue("@Usuario", usuario);
                    oCom.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader reader = oCom.ExecuteReader())
                    {
                        if (reader.Read()) // Si el usuario y contraseña son correctos
                        {
                            string perfil = reader["Perfil"].ToString();
                            string sucursal = reader["NombreSucursal"].ToString();
                            cerrarConexion();

                            return new string[] { perfil, sucursal };
                        }
                    }
                    cerrarConexion();
                    return null; 
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public bool actualizarUsuario(string usuarioOriginal, string nombre, string usuario, string contraseña, string perfil, int idSucursal)
        {
            try
            {
                if (abrirConexion())
                {
                    string consulta;

                    if (string.IsNullOrWhiteSpace(contraseña))
                    {
                        // 🔥 MODIFICADO: Usamos IdSucursal en lugar de Sucursal (texto)
                        consulta = @"UPDATE Usuarios SET 
                                Nombre = @Nombre,
                                Usuario = @Usuario,
                                Perfil = @Perfil,
                                IdSucursal = @IdSucursal
                              WHERE Usuario = @UsuarioOriginal";
                    }
                    else
                    {
                        consulta = @"UPDATE Usuarios SET 
                                Nombre = @Nombre,
                                Usuario = @Usuario,
                                Contrasena = @Contrasena,
                                Perfil = @Perfil,
                                IdSucursal = @IdSucursal
                              WHERE Usuario = @UsuarioOriginal";
                    }

                    oCom = new SqlCommand(consulta, oCon);
                    oCom.Parameters.AddWithValue("@Nombre", nombre);
                    oCom.Parameters.AddWithValue("@Usuario", usuario);
                    oCom.Parameters.AddWithValue("@Perfil", perfil);
                    oCom.Parameters.AddWithValue("@IdSucursal", idSucursal); // Recibe el ID numérico
                    oCom.Parameters.AddWithValue("@UsuarioOriginal", usuarioOriginal);

                    if (!string.IsNullOrWhiteSpace(contraseña))
                    {
                        oCom.Parameters.AddWithValue("@Contrasena", contraseña);
                    }

                    int filasAfectadas = oCom.ExecuteNonQuery();
                    cerrarConexion();

                    return filasAfectadas > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
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
       

    }
}