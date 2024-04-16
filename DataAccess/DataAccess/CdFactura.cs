using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Login.DataAccess.DataAccess;

namespace DataAccess.DataAccess
{
    public class CdFactura : ConnectionToSql
    {
        public DataTable mostrarFacturas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("mostrarFacturas", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader leer = command.ExecuteReader())
                    {
                        dt.Load(leer);
                    }
                }
            }
            return dt;
        }

        public DataTable cargarServicios()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT ServicioID, Servicio FROM Servicios", conexion))
                {
                    try
                    {
                        adapter.Fill(dt);

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQLEXCEPTION: " + ex.Message);
                    }

                }
            }
            return dt;
        }

        public string ObtenerPrecio(string servicio)
        {
            string precio = "";

            using(SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("ObtenerPrecio", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@servicio", servicio);

                    object result = command.ExecuteScalar();
                    if(result != null)
                    {
                        precio = result.ToString();
                    }
                }
            }

            return precio;
        }
        
    }
}
