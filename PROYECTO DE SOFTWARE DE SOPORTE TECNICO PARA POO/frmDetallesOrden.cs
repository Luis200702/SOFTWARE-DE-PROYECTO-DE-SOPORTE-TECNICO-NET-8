using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmDetallesOrden : Form
    {
        ucRecepcion Unsoloboton = new ucRecepcion();
        private string ordenActual;
        private string estadoSeleccionado;
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

        // Repuestos ya guardados y repuestos nuevos agregados durante esta edición.
        // Se separan para no volver a descontar del stock lo que ya estaba registrado.
        private Dictionary<int, int> repuestosGuardadosCantidades = new Dictionary<int, int>();
        private Dictionary<int, int> repuestosNuevosCantidades = new Dictionary<int, int>();
        private Dictionary<int, string> nombresRepuestos = new Dictionary<int, string>();

        // Actualizamos el constructor para recibir todos los datos de la grilla
        public frmDetallesOrden(string numeroOrden, string clienteDispositivo, string estadoActual, string tecnicoActual)
        {
            InitializeComponent();
            ordenActual = numeroOrden;

            // 1. Asignamos el número de orden
            lblNumeroOrden.Text = numeroOrden;

            // 2. Separamos el "Cliente - Dispositivo" usando el guion que pusiste en SQL
            string[] partes = clienteDispositivo.Split(new string[] { " - " }, StringSplitOptions.None);
            if (partes.Length >= 2)
            {
                lblCliente.Text = partes[0].Trim();
                lblDispositivo.Text = partes[1].Trim();
            }
            else
            {
                lblCliente.Text = clienteDispositivo;
                lblDispositivo.Text = "Dispositivo no especificado";
            }

            CargarTecnicos();
            cmbTecnico.Text = tecnicoActual;

            CargarRepuestosStock();
            CargarRepuestosGuardados();
            CargarObservacionesGuardadas();

            ActualizarDiseñoBotonesEstado(estadoActual);

            estadoSeleccionado = estadoActual;
        }

        // --- EVENTO LOAD: Se ejecuta al abrir el formulario ---
        private void frmDetallesOrden_Load(object sender, EventArgs e)
        {

        }

        // --- MÉTODOS DE CARGA DE BASE DE DATOS ---
        private void CargarTecnicos()
        {
            string orden = ordenActual.Replace("'", "''");
            string consulta = "select u.id as Id, u.nombre as Nombre from usuarios u inner join sucursales s on u.idsucursal = s.idsucursal inner join ordenes o on o.sucursal = s.nombresucursal where u.perfil = 'Tecnico' and o.numero_orden = '" + orden + "' order by u.nombre";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            cmbTecnico.DataSource = dt;
            cmbTecnico.DisplayMember = "Nombre";
            cmbTecnico.ValueMember = "Id";
        }

        // --- LÓGICA DE INTERFAZ Y EFECTOS VISUALES ---
        private void ActualizarDiseñoBotonesEstado(string estadoSeleccionado)
        {
            // Usamos tu función personalizada para "presionar" el botón correcto al abrir la ventana
            switch (estadoSeleccionado)
            {
                case "Recibido":
                    Unsoloboton.SeleccionarBoton(btnRecibido);
                    break;
                case "En diagnóstico":
                    Unsoloboton.SeleccionarBoton(btnDiagnostico);
                    break;
                case "En reparación":
                    Unsoloboton.SeleccionarBoton(btnReparacion);
                    break;
                case "Listo":
                    Unsoloboton.SeleccionarBoton(btnListo);
                    break;
            }
        }

        // --- EVENTO: BOTÓN DE AGREGAR REPUESTO ---
        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (cmbRepuestos.SelectedValue == null || cmbRepuestos.SelectedItem == null)
                return;

            int idSeleccionado = Convert.ToInt32(cmbRepuestos.SelectedValue);

            DataRowView filaSeleccionada = cmbRepuestos.SelectedItem as DataRowView;

            if (filaSeleccionada == null)
                return;

            int stockDisponible = Convert.ToInt32(filaSeleccionada["StockActual"]);
            string nombreRepuesto = filaSeleccionada["NombreRepuesto"].ToString() ?? "Repuesto";

            int cantidadNuevaActual = repuestosNuevosCantidades.ContainsKey(idSeleccionado)
                ? repuestosNuevosCantidades[idSeleccionado]
                : 0;

            if (cantidadNuevaActual + 1 > stockDisponible)
            {
                MessageBox.Show(
                    "No hay suficiente stock disponible para agregar otra unidad de este repuesto.",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (repuestosNuevosCantidades.ContainsKey(idSeleccionado))
                repuestosNuevosCantidades[idSeleccionado]++;
            else
                repuestosNuevosCantidades[idSeleccionado] = 1;

            nombresRepuestos[idSeleccionado] = nombreRepuesto;

            ActualizarListaRepuestos();
        }

        private void ActualizarListaRepuestos()
        {
            lstRepuestos.Items.Clear();

            foreach (var item in repuestosGuardadosCantidades)
            {
                int idRepuesto = item.Key;
                int cantidadGuardada = item.Value;
                int cantidadNueva = repuestosNuevosCantidades.ContainsKey(idRepuesto)
                    ? repuestosNuevosCantidades[idRepuesto]
                    : 0;

                int cantidadTotal = cantidadGuardada + cantidadNueva;
                string nombre = nombresRepuestos.ContainsKey(idRepuesto)
                    ? nombresRepuestos[idRepuesto]
                    : "Repuesto";

                lstRepuestos.Items.Add($"• {nombre} x{cantidadTotal}");
            }

            foreach (var item in repuestosNuevosCantidades)
            {
                if (repuestosGuardadosCantidades.ContainsKey(item.Key))
                    continue;

                string nombre = nombresRepuestos.ContainsKey(item.Key)
                    ? nombresRepuestos[item.Key]
                    : "Repuesto";

                lstRepuestos.Items.Add($"• {nombre} x{item.Value}");
            }
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnRecibido);
            estadoSeleccionado = "Recibido";
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnDiagnostico);
            estadoSeleccionado = "En diagnóstico";
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnReparacion);
            estadoSeleccionado = "En reparación";
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnListo);
            estadoSeleccionado = "Listo";
        }


        private void CargarRepuestosGuardados()
        {
            repuestosGuardadosCantidades.Clear();
            nombresRepuestos.Clear();

            string orden = ordenActual.Replace("'", "''");
            string consulta = "select d.idrepuesto as IdRepuesto, r.nombrerepuesto as NombreRepuesto, sum(d.cantidad) as Cantidad from detallesorden d inner join repuestos r on d.idrepuesto = r.idrepuesto inner join ordenes o on d.idorden = o.id where o.numero_orden = '" + orden + "' group by d.idrepuesto, r.nombrerepuesto order by r.nombrerepuesto";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    int idRepuesto = Convert.ToInt32(fila["IdRepuesto"]);
                    int cantidad = Convert.ToInt32(fila["Cantidad"]);
                    string nombre = fila["NombreRepuesto"].ToString() ?? "Repuesto";

                    repuestosGuardadosCantidades[idRepuesto] = cantidad;
                    nombresRepuestos[idRepuesto] = nombre;
                }
            }

            ActualizarListaRepuestos();
        }

        private void CargarRepuestosStock()
        {
            string orden = ordenActual.Replace("'", "''");
            string consulta = "select r.idrepuesto as IdRepuesto, r.nombrerepuesto as NombreRepuesto, i.stockactual as StockActual, r.nombrerepuesto + ' (Stock: ' + cast(i.stockactual as varchar) + ')' as Descripcion from repuestos r inner join inventariosucursal i on r.idrepuesto = i.idrepuesto inner join sucursales s on i.idsucursal = s.idsucursal inner join ordenes o on s.nombresucursal = o.sucursal where o.numero_orden = '" + orden + "' and i.stockactual > 0";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            cmbRepuestos.DataSource = dt;
            cmbRepuestos.DisplayMember = "Descripcion";
            cmbRepuestos.ValueMember = "IdRepuesto";
        }

        private void btnMarcarListo_Click(object sender, EventArgs e)
        {
            int idOrdenReal = 0;
            string sucursalOrigen = "";

            string orden = ordenActual.Replace("'", "''");
            string consulta = "select id, sucursal from ordenes where numero_orden = '" + orden + "'";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                idOrdenReal = Convert.ToInt32(dt.Rows[0]["id"]);
                sucursalOrigen = dt.Rows[0]["sucursal"].ToString();
            }

            if (idOrdenReal > 0)
            {
                frmSeguimientoDerivacion modalDerivacion =
                    new frmSeguimientoDerivacion(
                        idOrdenReal,
                        sucursalOrigen);

                modalDerivacion.ShowDialog();

                // Se mantiene la lógica original:
                // al terminar la derivación se cierra el detalle de la orden.
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo identificar la orden.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnListoEntrega_Click(object sender, EventArgs e)
        {
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    string observacionesFinales = "";

                    foreach (var item in lstObservaciones.Items)
                    {
                        observacionesFinales += item.ToString() + Environment.NewLine;
                    }

                    string query = "update ordenes set estado = @estado, tecnico_id = @tecnico, trabajo_realizado = @observaciones where numero_orden = @orden";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@estado", estadoSeleccionado);
                        cmd.Parameters.AddWithValue("@tecnico", cmbTecnico.SelectedValue);
                        cmd.Parameters.AddWithValue("@observaciones", observacionesFinales.Trim());
                        cmd.Parameters.AddWithValue("@orden", ordenActual);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            foreach (var repuesto in repuestosNuevosCantidades)
                            {
                                int idRepuesto = repuesto.Key;
                                int cantidad = repuesto.Value;

                                string queryStock = "update inventariosucursal set stockactual = stockactual - @cantidad where idrepuesto = @id and idsucursal = (select s.idsucursal from sucursales s inner join ordenes o on s.nombresucursal = o.sucursal where o.numero_orden = @numOrden) and stockactual >= @cantidad";

                                using (SqlCommand cmdStock = new SqlCommand(queryStock, db.oCon))
                                {
                                    cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmdStock.Parameters.AddWithValue("@id", idRepuesto);
                                    cmdStock.Parameters.AddWithValue("@numOrden", ordenActual);

                                    int filasStock = cmdStock.ExecuteNonQuery();

                                    if (filasStock == 0)
                                    {
                                        MessageBox.Show(
                                            "No hay suficiente stock para uno de los repuestos seleccionados.",
                                            "Stock insuficiente",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                        return;
                                    }
                                }

                                string queryDetalle = "declare @idOrden int = (select id from ordenes where numero_orden = @numOrden); if exists (select 1 from detallesorden where idorden = @idOrden and idrepuesto = @idRepuesto) begin update detallesorden set cantidad = cantidad + @cantidad where iddetalle = (select top 1 iddetalle from detallesorden where idorden = @idOrden and idrepuesto = @idRepuesto order by iddetalle); end else begin insert into detallesorden (idorden, idrepuesto, cantidad, preciocobrado) values (@idOrden, @idRepuesto, @cantidad, (select precioventa from repuestos where idrepuesto = @idRepuesto)); end";

                                using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, db.oCon))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@numOrden", ordenActual);
                                    cmdDetalle.Parameters.AddWithValue("@idRepuesto", idRepuesto);
                                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmdDetalle.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show(
                                "¡Los cambios se guardaron correctamente!",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al guardar los cambios: " + ex.Message,
                        "Error de BD",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnAgregarObservacion_Click(object sender, EventArgs e)
        {
            // Verificamos que no esté vacío el TextBox
            if (!string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                // Agregamos el texto a la lista con un puntito para que se vea ordenado
                lstObservaciones.Items.Add("• " + txtObservacion.Text.Trim());

                // Limpiamos el TextBox para escribir la siguiente
                txtObservacion.Clear();
                txtObservacion.Focus();
            }
        }

        private void CargarObservacionesGuardadas()
        {
            string orden = ordenActual.Replace("'", "''");
            string consulta = "select trabajo_realizado from ordenes where numero_orden = '" + orden + "'";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null &&
                dt.Rows.Count > 0 &&
                dt.Rows[0]["trabajo_realizado"] != DBNull.Value)
            {
                string[] obsGuardadas =
                    dt.Rows[0]["trabajo_realizado"]
                    .ToString()
                    .Split(
                        new[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (string obs in obsGuardadas)
                {
                    lstObservaciones.Items.Add(obs);
                }
            }
        }

        private void lblObservaciones_Click(object sender, EventArgs e)
        {

        }
    }
}