using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace Login.DataAccess.DataAccess
{
    public class UserData:ConnectionToSql
    {
        public bool Login (string user, string pass)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ValidarLogin";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);


                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLoginCache.SerUserLogin(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetInt32(6)
                                    ) ;
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }catch(SqlException ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                return false;
            }
            
        }
        public void LogOut()
        {
            UserLoginCache.ClearUserLogin();
        }
    }
}
