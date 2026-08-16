using Microsoft.Data.SqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    internal class CatalogoMarcas
    {
        public static void CargarMarcasEnComboBox(UIComboBox cmbMarca, string tipoDispositivo = "")
        {
            cmbMarca.Items.Clear();
            HashSet<string> marcasUnicas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Lista base general de marcas de ambas categorías por si la BD está vacía
            var marcasGenerales = new[] {
                "Samsung", "Apple", "Xiaomi", "Motorola", "Huawei", "Honor", "Oppo", "Realme",
                "HP", "Dell", "Lenovo", "Asus", "Acer", "MSI", "Toshiba", "Sony", "LG", "ZTE", "Microsoft"
            };
            foreach (var m in marcasGenerales) marcasUnicas.Add(m);

            // Consultar la base de datos
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = string.IsNullOrEmpty(tipoDispositivo)
                        ? "SELECT DISTINCT marca FROM dispositivos WHERE marca IS NOT NULL AND marca <> ''"
                        : "SELECT DISTINCT marca FROM dispositivos WHERE tipo = @tipo AND marca IS NOT NULL AND marca <> ''";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        if (!string.IsNullOrEmpty(tipoDispositivo))
                        {
                            cmd.Parameters.AddWithValue("@tipo", tipoDispositivo);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string marcaDb = reader["marca"].ToString().Trim();
                                if (!string.IsNullOrEmpty(marcaDb))
                                {
                                    marcasUnicas.Add(marcaDb);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al consultar marcas: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }

            // Ordenar y añadir al ComboBox
            List<string> listaFinal = new List<string>(marcasUnicas);
            listaFinal.Sort();

            foreach (var marca in listaFinal)
            {
                cmbMarca.Items.Add(marca);
            }
        }
    }
}
