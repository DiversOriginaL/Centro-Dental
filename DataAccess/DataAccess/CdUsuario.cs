using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.DataAccess.DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.DataAccess
{
    public class CdUsuario:ConnectionToSql
    {
        public DataTable mostrarUsuario()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("mostrarUsuarios", conexion))
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

        public DataTable cargarRoles()
        {
            DataTable dt = new DataTable();

            using(SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter("select RolID, Rol from Roles", conexion))
                {
                    try
                    {
                        adapter.Fill(dt);

                    }
                     catch(SqlException ex)
                    {
                        Console.WriteLine("SQLEXCEPTION: " + ex.Message);
                    }
                
                }
            }

            return dt;

        }

        public void Insertar(string nombre, string apellido, string mail, string usuario, string contraseña, int rolid)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("insertarUsuarios", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@rolid", rolid);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
