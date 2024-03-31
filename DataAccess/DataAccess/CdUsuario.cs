using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.DataAccess.DataAccess;
using System.Data;
using System.Data.SqlClient;
using Common.Entidades;

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

        public void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("insertarUsuarios", conexion))
                {
                    if (usuario != null)
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Verificar si los valores no son nulos antes de usarlos
                            string nombre = usuario.GetNombres() ?? "";
                            string apellido = usuario.GetApellidos() ?? "";
                            string email = usuario.GetEmail() ?? "";
                            string nombreUsuario = usuario.GetUsuario() ?? "";
                            string contraseña = usuario.GetContraseña() ?? "";

                            command.Parameters.AddWithValue("@nombre", nombre.Trim());
                            command.Parameters.AddWithValue("@apellido", apellido.Trim());
                            command.Parameters.AddWithValue("@mail", email.Trim());
                            command.Parameters.AddWithValue("@usuario", nombreUsuario.Trim());
                            command.Parameters.AddWithValue("@contraseña", contraseña.Trim());
                            command.Parameters.AddWithValue("@rolid", usuario.GetRolID());
                            command.ExecuteNonQuery();

                        }catch(NullReferenceException ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error.");
                    }
                }
            }
        }
        public void editarUsuario(Usuario usuario)
        {
            if(usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario),  "El usuario proporcionado es nulo");
            }

            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("editarUsuarios", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", usuario.GetNombres().Trim());
                    command.Parameters.AddWithValue("@apellido", usuario.GetApellidos().Trim());
                    command.Parameters.AddWithValue("@mail", usuario.GetEmail().Trim());
                    command.Parameters.AddWithValue("@usuario", usuario.GetUsuario().Trim());
                    command.Parameters.AddWithValue("@contraseña", usuario.GetContraseña().Trim());
                    command.Parameters.AddWithValue("@rolid", usuario.GetRolID());
                    command.Parameters.AddWithValue("@id", usuario.GetUsuarioID());
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
