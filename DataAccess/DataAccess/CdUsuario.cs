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

        public void InsertarUsuario(string nombre, string apellido, string mail, string usuario, string contraseña, int rolid)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("insertarUsuarios", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre.Trim());
                    command.Parameters.AddWithValue("@apellido", apellido.Trim());
                    command.Parameters.AddWithValue("@mail", mail.Trim());
                    command.Parameters.AddWithValue("@usuario", usuario.Trim());
                    command.Parameters.AddWithValue("@contraseña", contraseña.Trim());
                    command.Parameters.AddWithValue("@rolid", rolid);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void editarUsuario(string nombre, string apellido, string mail, string usuario, string contraseña, int rolid, int id)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("editarUsuarios", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre.Trim());
                    command.Parameters.AddWithValue("@apellido", apellido.Trim());
                    command.Parameters.AddWithValue("@mail", mail.Trim());
                    command.Parameters.AddWithValue("@usuario", usuario.Trim());
                    command.Parameters.AddWithValue("@contraseña", contraseña.Trim());
                    command.Parameters.AddWithValue("@rolid", rolid);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void eliminarUsuario(int id)
        {
            using(SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("eliminarUsuario", conexion))
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
