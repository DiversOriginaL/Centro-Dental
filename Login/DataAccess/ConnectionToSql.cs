using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Login.DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string ConnectionString;

        //CONSTRUCTOR.
        public ConnectionToSql()
        {
            ConnectionString = "Server=WINDOWS-5BBQ7QJ; DataBase=MyCompany; integrated security=true";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
