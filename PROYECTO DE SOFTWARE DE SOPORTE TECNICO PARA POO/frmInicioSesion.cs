using Microsoft.Data.SqlClient;
using System.Data;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{


    public partial class frmInicioSesion : Form
    {
        frmMenu menu = new frmMenu();
        Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var db = new Conexion_Base_de_Datos();

            string sentencia = @"select U.Usuario, U.Contrasena, U.Perfil, S.NombreSucursal as Sucursal
                     from Usuarios U 
                     inner join Sucursales S on U.IdSucursal = S.IdSucursal";

            DataTable tabla = db.retornarRegistrosUsuarios(sentencia);

            DataRow[] resultado = tabla.Select($"Usuario = '{txtUsuario.Text}' and Contrasena = '{txtContrasena.Text}'");

            if (resultado.Length > 0)
            {
                Sesion.PerfilActual = resultado[0]["Perfil"].ToString();
                Sesion.SucursalActual = resultado[0]["Sucursal"].ToString();

                if (Sesion.PerfilActual == "Administrador")
                {
                    MessageBox.Show($"¡Bienvenido Administrador! Ingresando a {Sesion.SucursalActual}...",
                                    "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.MostrarAdministrador();
                    menu.Show();
                }
                else if (Sesion.PerfilActual == "Tecnico")
                {
                    MessageBox.Show($"¡Bienvenido Técnico! Ingresando a {Sesion.SucursalActual}...",
                                    "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            btnVerContrasena.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '●' || txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';

                btnVerContrasena.Symbol = 61550;
            }
            else
            {

                txtContrasena.PasswordChar = '●';
                btnVerContrasena.Symbol = 61552;
            }
        }
    }
}
