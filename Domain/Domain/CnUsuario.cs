using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.DataAccess;

namespace Domain.Domain
{
    public class CnUsuario
    {
        CdUsuario cdUsuario = new CdUsuario();

        public DataTable mostrarUsuarios()
        {
            DataTable dt = new DataTable();
            dt = cdUsuario.mostrarUsuario();
            return dt;
        }

        public DataTable cargarRol()
        {
            DataTable dt = new DataTable();
            dt = cdUsuario.cargarRoles();
            return dt;
        }

        public void InsertarUsuario(string nombre, string apellido, string mail, string usuario, string contraseña, object rolid)
        {
            cdUsuario.Insertar(nombre, apellido, mail, usuario, contraseña, Convert.ToInt32(rolid));
        }


    }
}
