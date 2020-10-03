using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ProgramaMascotas
{
    public class AccesoDatos
    {
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private static readonly string cadenaConexion = ObtenerCadenaConexion("VacunasMascotas");

        public static List<string> ObtenerMascotas()
        {
            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var mascota = cxnDB.Query<string>("SELECT id_mascota FROM v_A_ListaNombresMacota", new DynamicParameters());
                return mascota.ToList();
            }
        }

        public static List<string> ObtenerVacunasPorEspecies(string id_mascota)
        {
            using (IDbConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                var id_especie = "";
                try
                {
                    id_especie = cxnDB.QuerySingle<string>($"SELECT id_especie FROM v_A_ListaNombresMacota  where id_mascota='{id_mascota}';");
                }
                catch (Exception)
                {
                    MessageBox.Show("Especie equivocada");
                }

                var vacunas = cxnDB.Query<string>($"SELECT nombre FROM Vacunas where id_especie = \"{id_especie}\";", new DynamicParameters());

                return vacunas.ToList();
            }
        }

        public static DataTable ObtenerInfoMascotas()
        {
            DataTable tablaResultado = new DataTable();

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter infoMascotas = new SQLiteDataAdapter("SELECT * FROM v_Consulta1", cxnDB);
                infoMascotas.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtenerInfoVacunasRazaEspecie()
        {
            DataTable tablaResultado = new DataTable();
            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter infoMascotas = new SQLiteDataAdapter("SELECT * FROM v_Consulta2", cxnDB);
                infoMascotas.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static DataTable ObtenerInfoMascotasPorVacunaEspecie()
        {
            DataTable tablaResultado = new DataTable();

            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                SQLiteDataAdapter infoMascotas = new SQLiteDataAdapter("SELECT * FROM v_Consulta3", cxnDB);
                infoMascotas.Fill(tablaResultado);
                return tablaResultado;
            }
        }

        public static bool InsertarRegistroVacunacion(string id_mascota, string vacunaMascota, string fechaVacuna)
        {
            using (SQLiteConnection cxnDB = new SQLiteConnection(cadenaConexion))
            {
                try
                {
                    var id_vacuna = cxnDB.QuerySingle<string>($"SELECT id FROM Vacunas where nombre ='{vacunaMascota}';");

                    cxnDB.Execute($"INSERT into fechas_Vacunacion (id_mascota, id_vacuna, fecha_vacunacion) values('{id_mascota}','{id_vacuna}','{fechaVacuna}')");
                    MessageBox.Show("Se ha registrado correctamente la vacuna.");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error verifique los datos.");
                    return false;
                }
            }
        }
    }
}