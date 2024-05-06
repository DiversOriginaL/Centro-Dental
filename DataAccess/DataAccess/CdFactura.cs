using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Login.DataAccess.DataAccess;
using Common.Entidades;
using Common.Cache;

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
        public DataTable mostrarDetalles(int FacturaID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("mostrarDetalles", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FacturaID", FacturaID);

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

        public void InsertarFacturaConDetalles
            (
                IEnumerable<DetallesFacturas> detalleList, List<int> servicioID, 
                decimal total, DateTime fecha, int pacienteID
            )
        {
            var table = new DataTable();
            table.Columns.Add("ServicioID", typeof(int));
            table.Columns.Add("Precio", typeof(decimal));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Importe", typeof(decimal));
            table.Columns.Add("SubTotal", typeof(decimal));
            table.Columns.Add("Descuento", typeof(decimal));
            
            // Verificar que las listas tengan la misma cantidad de elementos
            if (detalleList.Count() != servicioID.Count())
            {
                throw new ArgumentException("La cantidad de detalles de factura no coincide con la cantidad de IDs de servicios.");
            }

            var detalleEnumerator = detalleList.GetEnumerator();
            var servicioIDEnumerator = servicioID.GetEnumerator();

            while (detalleEnumerator.MoveNext() && servicioIDEnumerator.MoveNext())
            {
                // Obtener el detalle de factura y el ID del servicio actual
                DetallesFacturas detalle = detalleEnumerator.Current;
                int idServicio = servicioIDEnumerator.Current;

                // Agregar una fila a la tabla para este detalle de factura
                table.Rows.Add(new object[]
                {
                    idServicio, // Utilizar el ID del servicio actual
                    detalle.Precio,
                    detalle.Cantidad,
                    detalle.Importe,
                    detalle.SubTotal,
                    detalle.Descuento
                });
            }

            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("InsertarFacturaConDetalles", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameter = cmd.Parameters.AddWithValue("@DetalleTable", table);
                    parameter.SqlDbType = SqlDbType.Structured;

                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
                    cmd.Parameters.AddWithValue("@UsuarioID", UserLoginCache.GetID());

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("El error es: " + ex.Message);
                    }
                }
            }
        }

        public void EditarFacturaConDetalles
        (
            int facturaID, IEnumerable<DetallesFacturas> detalleList, List<int> servicioID,
            decimal total, DateTime fecha, int pacienteID
        )
        {
            var table = new DataTable();
            table.Columns.Add("ServicioID", typeof(int));
            table.Columns.Add("Precio", typeof(decimal));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Importe", typeof(decimal));
            table.Columns.Add("SubTotal", typeof(decimal));
            table.Columns.Add("Descuento", typeof(decimal));

            // Verificar que las listas tengan la misma cantidad de elementos
            if (detalleList.Count() != servicioID.Count())
            {
                throw new ArgumentException("La cantidad de detalles de factura no coincide con la cantidad de IDs de servicios.");
            }

            var detalleEnumerator = detalleList.GetEnumerator();
            var servicioIDEnumerator = servicioID.GetEnumerator();

            while (detalleEnumerator.MoveNext() && servicioIDEnumerator.MoveNext())
            {
                // Obtener el detalle de factura y el ID del servicio actual
                DetallesFacturas detalle = detalleEnumerator.Current;
                int idServicio = servicioIDEnumerator.Current;

                // Agregar una fila a la tabla para este detalle de factura
                table.Rows.Add(new object[]
                {
                    idServicio, // Utilizar el ID del servicio actual
                    detalle.Precio,
                    detalle.Cantidad,
                    detalle.Importe,
                    detalle.SubTotal,
                    detalle.Descuento
                });
            }

            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("EditarFacturaConDetalles", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    SqlParameter parameter = cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Direction = ParameterDirection.Input;

                    parameter = cmd.Parameters.AddWithValue("@DetalleTable", table);
                    parameter.SqlDbType = SqlDbType.Structured;

                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@PacienteID", pacienteID);
                    cmd.Parameters.AddWithValue("@UsuarioID", UserLoginCache.GetID());

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("El error es: " + ex.Message);
                        // Puedes lanzar una excepción personalizada o manejar el error de otra manera según tu aplicación
                    }
                }
            }
        }

    }
}
