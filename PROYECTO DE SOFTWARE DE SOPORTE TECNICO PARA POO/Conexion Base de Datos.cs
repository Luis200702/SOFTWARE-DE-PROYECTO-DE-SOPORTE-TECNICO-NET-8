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
                    // Traemos el Perfil y la Sucursal de la base de datos
                    string consulta = @"SELECT Perfil, Sucursal 
                                FROM Usuarios 
                                WHERE Usuario = @Usuario 
                                AND Contrasena = @Contrasena";

                    oCom = new SqlCommand(consulta, oCon);
                    oCom.Parameters.AddWithValue("@Usuario", usuario);
                    oCom.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader reader = oCom.ExecuteReader())
                    {
                        if (reader.Read()) // Si el usuario y contraseña son correctos
                        {
                            string perfil = reader["Perfil"].ToString();
                            string sucursal = reader["Sucursal"].ToString();
                            cerrarConexion();

                            // Retornamos los dos valores en un arreglo
                            return new string[] { perfil, sucursal };
                        }
                    }
                    cerrarConexion();
                    return null; // Si no encontró el usuario
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public DataTable obtenerUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                if (abrirConexion())
                {
                    string consulta = @"SELECT Nombre, Usuario, Perfil, Sucursal 
                                FROM Usuarios";

                    oDA = new SqlDataAdapter(consulta, oCon);
                    oDA.Fill(dt);
                    cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
            return dt;
        }

        public bool actualizarUsuario(string usuarioOriginal, string nombre, string usuario, string contraseña, string perfil, string sucursal)
        {
            try
            {
                if (abrirConexion())
                {
                    string consulta;

                    if (string.IsNullOrWhiteSpace(contraseña))
                    {
               
                        consulta = @"UPDATE Usuarios SET 
                                Nombre = @Nombre,
                                Usuario = @Usuario,
                                Perfil = @Perfil,
                                Sucursal = @Sucursal
                              WHERE Usuario = @UsuarioOriginal";
                    }
                    else
                    {
                 
                        consulta = @"UPDATE Usuarios SET 
                                Nombre = @Nombre,
                                Usuario = @Usuario,
                                Contrasena = @Contrasena,
                                Perfil = @Perfil,
                                Sucursal = @Sucursal
                              WHERE Usuario = @UsuarioOriginal";
                    }

                    oCom = new SqlCommand(consulta, oCon);
                    oCom.Parameters.AddWithValue("@Nombre", nombre);
                    oCom.Parameters.AddWithValue("@Usuario", usuario);
                    oCom.Parameters.AddWithValue("@Perfil", perfil);
                    oCom.Parameters.AddWithValue("@Sucursal", sucursal);
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

        public bool insertarUsuario(string nombre, string usuario, string contraseña, string perfil, string sucursal)
        {
            try
            {
                if (abrirConexion())
                {
                    string consulta = @"INSERT INTO Usuarios (Nombre, Usuario, Contrasena, Perfil, Sucursal)
                                VALUES (@Nombre, @Usuario, @Contrasena, @Perfil, @Sucursal)";

                    oCom = new SqlCommand(consulta, oCon);
                    oCom.Parameters.AddWithValue("@Nombre", nombre);
                    oCom.Parameters.AddWithValue("@Usuario", usuario);
                    oCom.Parameters.AddWithValue("@Contrasena", contraseña);
                    oCom.Parameters.AddWithValue("@Perfil", perfil);
                    oCom.Parameters.AddWithValue("@Sucursal", sucursal);

                    int filas = oCom.ExecuteNonQuery();
                    cerrarConexion();

                    return filas > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
                return false;
            }
        }

        public DataTable obtenerSucursales()
        {
            DataTable dt = new DataTable();
            try
            {
                if (abrirConexion())
                {
                    string consulta = "SELECT DISTINCT Sucursal FROM Usuarios ORDER BY Sucursal";
                    // Si tienes una tabla separada de Sucursales, cambia la consulta por:
                    // string consulta = "SELECT Nombre FROM Sucursales ORDER BY Nombre";

                    oDA = new SqlDataAdapter(consulta, oCon);
                    oDA.Fill(dt);
                    cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
            }
            return dt;
        }


    }
}

