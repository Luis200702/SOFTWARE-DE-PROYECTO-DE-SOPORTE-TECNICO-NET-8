using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    internal class CatalogoMarcas
    {
        public static void CargarMarcasEnComboBox(
            UIComboBox cmbMarca,
            string tipoDispositivo = "")
        {
            cmbMarca.Items.Clear();

            Conexion_Base_de_Datos oCon =
                new Conexion_Base_de_Datos();

            HashSet<string> marcasUnicas =
                new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase);

            var marcasGenerales = new[]
            {
                "Samsung", "Apple", "Xiaomi", "Motorola",
                "Huawei", "Honor", "Oppo", "Realme",
                "HP", "Dell", "Lenovo", "Asus",
                "Acer", "MSI", "Toshiba", "Sony",
                "LG", "ZTE", "Microsoft"
            };

            foreach (var marca in marcasGenerales)
            {
                marcasUnicas.Add(marca);
            }

            try
            {
                string tipo =
                    tipoDispositivo.Replace("'", "''");

                string consulta;

                if (string.IsNullOrEmpty(tipoDispositivo))
                {
                    consulta = @"
                        select distinct marca
                        from dispositivos
                        where marca is not null
                          and marca <> ''";
                }
                else
                {
                    consulta = @"
                        select distinct marca
                        from dispositivos
                        where tipo = '" + tipo + @"'
                          and marca is not null
                          and marca <> ''";
                }

                DataTable dt =
                    oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        string marcaDb =
                            fila["marca"].ToString().Trim();

                        if (!string.IsNullOrEmpty(marcaDb))
                        {
                            marcasUnicas.Add(marcaDb);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Error al consultar marcas: " +
                    ex.Message);
            }

            foreach (string marca in marcasUnicas.OrderBy(m => m))
            {
                cmbMarca.Items.Add(marca);
            }
        }
    }
}

