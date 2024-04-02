using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using DataAccess.MailServices;

namespace Login.DataAccess.DataAccess
{
    public class UserData:ConnectionToSql
    {
        public bool Login (string user, string password)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("ValidarLogin", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@user", user.Trim());
                        command.Parameters.AddWithValue("@pass", password.Trim());


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    UserLoginCache.SetUserLogin(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2),
                                        reader.GetString(3),
                                        reader.GetString(4),
                                        password,
                                        reader.GetInt32(6)
                                        );
                                }
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }catch(SqlException ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                return false;
            }
            
        }

        public bool GetRolUser()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var command = new SqlCommand("ObtenerRol", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.HasRows)
                                {
                                    RolesCache.GetRol(
                                        reader.GetInt32(0),
                                        reader.GetString(1)
                                        );
                                }
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Ha habido un fallo en la conexion: " + ex.Message);
                return false;
            }
        }

        public string recoverPassword(string userRequesting, string pass)
        {
            using(var conn = GetConnection())
            {
                conn.Open();
                using (var command = new SqlCommand("RecoverPassword", conn))
                {
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read() == true)
                        {
                            string userName = reader.GetString(1) + ", " + reader.GetString(2);
                            string userMail = reader.GetString(3);
                            string accountPassword = pass;

                            var mailService = new SystemSupportMail();
                            mailService.SendMail(
                                subject: "SYSTEM: Peticion de recuperacion de contraseña",
                                body: "Hola " + userName + "\nsolicitaste recuperar tu contraseña\n" +
                                      "tu contraseña actual es: " + accountPassword +
                                      " Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez entre al sistema",
                                recipientMail: new List<string> { userMail }
                                );

                            return "Hola " + userName + "\nsolicitaste recuperar tu contraseña\n" +
                                        "Porfavor revisa tu correo: " + userMail +
                                        "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez entre al sistema";
                        }
                        else
                        {
                            return "Lo siento, no tienes una cuenta con este nombre de usuario o correo electronico";
                        }
                    }
                    catch(SqlException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                        return "No se pudo extraer los datos.";
                    }
                }
            }
        }

    }
}
