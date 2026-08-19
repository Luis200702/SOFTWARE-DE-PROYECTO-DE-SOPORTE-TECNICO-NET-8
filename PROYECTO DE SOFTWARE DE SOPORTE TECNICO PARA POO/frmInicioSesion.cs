using Microsoft.Data.SqlClient;

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

            string[] datosUsuario = db.validarUsuario(txtUsuario.Text, txtContrasena.Text);

            if (datosUsuario != null)
            {
                // Guardamos los datos en nuestra clase Global
                Sesion.PerfilActual = datosUsuario[0];
                Sesion.SucursalActual = datosUsuario[1];

                // Instanciamos el menú principal


                // --- CONDICIÓN SEGÚN EL PERFIL ---
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
            // Verificamos si la contraseña está oculta actualmente
            if (txtContrasena.PasswordChar == '●' || txtContrasena.PasswordChar == '*')
            {
                // 🔓 MOSTRAR CONTRASEÑA
                // El caracter '\0' (nulo) le dice a C# que quite la máscara y muestre el texto real
                txtContrasena.PasswordChar = '\0';

                // Cambiamos el ícono al ojo abierto (fa-eye)
                btnVerContrasena.Symbol = 61550;
            }
            else
            {
                // 🔒 OCULTAR CONTRASEÑA
                // Volvemos a ponerle el punto o asterisco
                txtContrasena.PasswordChar = '●';

                // Cambiamos el ícono al ojo cerrado / tachado (fa-eye-slash)
                btnVerContrasena.Symbol = 61552;
            }
        }
    }
}
