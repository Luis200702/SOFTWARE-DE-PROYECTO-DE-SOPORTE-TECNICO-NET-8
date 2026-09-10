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
            var db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                SELECT U.Id, U.Nombre
                FROM Usuarios U
                INNER JOIN Sucursales S
                    ON U.IdSucursal = S.IdSucursal
                INNER JOIN ordenes O
                    ON O.sucursal = S.NombreSucursal
                WHERE U.Perfil = 'Tecnico'
                  AND O.numero_orden = @orden
                ORDER BY U.Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@orden", ordenActual);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbTecnico.DataSource = dt;
                        cmbTecnico.DisplayMember = "Nombre";
                        cmbTecnico.ValueMember = "Id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar técnicos: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
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

            var db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                        SELECT
                            d.IdRepuesto,
                            r.NombreRepuesto,
                            SUM(d.Cantidad) AS Cantidad
                        FROM DetallesOrden d
                        INNER JOIN Repuestos r ON d.IdRepuesto = r.IdRepuesto
                        INNER JOIN ordenes o ON d.IdOrden = o.id
                        WHERE o.numero_orden = @orden
                        GROUP BY d.IdRepuesto, r.NombreRepuesto
                        ORDER BY r.NombreRepuesto";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@orden", ordenActual);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idRepuesto = Convert.ToInt32(reader["IdRepuesto"]);
                                int cantidad = Convert.ToInt32(reader["Cantidad"]);
                                string nombre = reader["NombreRepuesto"].ToString() ?? "Repuesto";

                                repuestosGuardadosCantidades[idRepuesto] = cantidad;
                                nombresRepuestos[idRepuesto] = nombre;
                            }
                        }
                    }

                    ActualizarListaRepuestos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar repuestos guardados: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void CargarRepuestosStock()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Unimos Repuestos, Inventario, Sucursales y la Orden actual para filtrar por la sucursal correcta
                    string query = @"
                    SELECT 
                        R.IdRepuesto,
                        R.NombreRepuesto,
                        I.StockActual,
                        R.NombreRepuesto + ' (Stock: ' + CAST(I.StockActual AS VARCHAR) + ')' AS Descripcion 
                    FROM Repuestos R
                    INNER JOIN InventarioSucursal I ON R.IdRepuesto = I.IdRepuesto
                    INNER JOIN Sucursales S ON I.IdSucursal = S.IdSucursal
                    INNER JOIN ordenes O ON S.NombreSucursal = O.sucursal
                    WHERE O.numero_orden = @orden AND I.StockActual > 0";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@orden", ordenActual);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbRepuestos.DataSource = dt;
                        cmbRepuestos.DisplayMember = "Descripcion";
                        cmbRepuestos.ValueMember = "IdRepuesto";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar repuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnMarcarListo_Click(object sender, EventArgs e)
        {
            int idOrdenReal = 0;
            string sucursalOrigen = "";

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Buscamos el ID numérico y la sucursal actual
                    string query = "SELECT id, sucursal FROM ordenes WHERE numero_orden = @orden";
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@orden", ordenActual);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idOrdenReal = Convert.ToInt32(reader["id"]);
                                sucursalOrigen = reader["sucursal"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar datos para la derivación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    db.cerrarConexion();
                }
            }

            // Si encontramos la orden, abrimos el modal de derivación
            if (idOrdenReal > 0)
            {
                frmSeguimientoDerivacion modalDerivacion = new frmSeguimientoDerivacion(idOrdenReal, sucursalOrigen);
                modalDerivacion.ShowDialog();

                // Cerramos los detalles automáticamente porque el equipo ya no está en esta sucursal
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo identificar la orden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListoEntrega_Click(object sender, EventArgs e)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Recopilamos todos los textos del ListBox en un solo bloque de texto (separados por un salto de línea)
                    string observacionesFinales = "";
                    foreach (var item in lstObservaciones.Items)
                    {
                        observacionesFinales += item.ToString() + Environment.NewLine;
                    }

                    // 1. Actualizamos el estado, el técnico Y LAS OBSERVACIONES
                    string query = @"
    UPDATE ordenes
    SET estado = @estado,
        tecnico_id = @tecnico,
        trabajo_realizado = @observaciones
    WHERE numero_orden = @orden";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@estado", estadoSeleccionado);
                        cmd.Parameters.AddWithValue("@tecnico", cmbTecnico.SelectedValue);
                        // Pasamos el bloque de texto limpio a la base de datos
                        cmd.Parameters.AddWithValue("@observaciones", observacionesFinales.Trim());
                        cmd.Parameters.AddWithValue("@orden", ordenActual);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // 2. Descontar del stock únicamente las cantidades nuevas
                            // que se agregaron durante esta edición.
                            foreach (var repuesto in repuestosNuevosCantidades)
                            {
                                int idRepuesto = repuesto.Key;
                                int cantidad = repuesto.Value;

                                string queryStock = @"
                                    UPDATE InventarioSucursal
                                    SET StockActual = StockActual - @cantidad
                                    WHERE IdRepuesto = @id
                                      AND IdSucursal = (
                                          SELECT S.IdSucursal
                                          FROM Sucursales S
                                          INNER JOIN ordenes O
                                              ON S.NombreSucursal = O.sucursal
                                          WHERE O.numero_orden = @numOrden
                                      )
                                      AND StockActual >= @cantidad";

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

                                string queryDetalle = @"
                                    DECLARE @idOrden INT =
                                        (SELECT id FROM ordenes WHERE numero_orden = @numOrden);

                                    IF EXISTS (
                                        SELECT 1
                                        FROM DetallesOrden
                                        WHERE IdOrden = @idOrden
                                          AND IdRepuesto = @idRepuesto
                                    )
                                    BEGIN
                                        UPDATE DetallesOrden
                                        SET Cantidad = Cantidad + @cantidad
                                        WHERE IdDetalle = (
                                            SELECT TOP 1 IdDetalle
                                            FROM DetallesOrden
                                            WHERE IdOrden = @idOrden
                                              AND IdRepuesto = @idRepuesto
                                            ORDER BY IdDetalle
                                        );
                                    END
                                    ELSE
                                    BEGIN
                                        INSERT INTO DetallesOrden
                                            (IdOrden, IdRepuesto, Cantidad, PrecioCobrado)
                                        VALUES
                                            (@idOrden,
                                             @idRepuesto,
                                             @cantidad,
                                             (SELECT PrecioVenta
                                              FROM Repuestos
                                              WHERE IdRepuesto = @idRepuesto));
                                    END";

                                using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, db.oCon))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@numOrden", ordenActual);
                                    cmdDetalle.Parameters.AddWithValue("@idRepuesto", idRepuesto);
                                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmdDetalle.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("¡Los cambios se guardaron correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Cargamos el trabajo realizado previamente guardado en la orden.
                    string query =
       "SELECT trabajo_realizado FROM ordenes WHERE numero_orden = @orden";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@orden", ordenActual);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            // Separamos el texto guardado por saltos de línea para meterlo a la lista
                            string[] obsGuardadas = resultado.ToString().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string obs in obsGuardadas)
                            {
                                lstObservaciones.Items.Add(obs);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las observaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void lblObservaciones_Click(object sender, EventArgs e)
        {

        }
    }
}