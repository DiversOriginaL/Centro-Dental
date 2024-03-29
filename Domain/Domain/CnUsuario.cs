using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.DataAccess;
using Common.Entidades;

namespace Domain.Domain
{
    public class CnUsuario
    {
        CdUsuario cdUsuario = new CdUsuario();
        DataTable dt = new DataTable();

        public DataTable mostrarUsuarios()
        {
            dt = cdUsuario.mostrarUsuario();
            return dt;
        }

        public DataTable cargarRol()
        {
            dt = cdUsuario.cargarRoles();
            return dt;
        }

        public void InsertarUsuario(string nombre, string apellido, string mail, string nombreusuario, string contraseña, object rolid)
        {
            Usuario usuario = new Usuario();
            usuario.SetNombre(nombre);
            usuario.SetApellido(apellido);
            usuario.SetEmail(mail);
            usuario.SetNombreUsuario(nombreusuario);
            usuario.SetContraseña(contraseña);
            usuario.SetRolID(Convert.ToInt32(rolid));

            cdUsuario.InsertarUsuario(usuario);
        }

        public void EditarUsuario(string nombre, string apellido, string mail, string usuario, string contraseña, object rolid, string id)
        {
            cdUsuario.editarUsuario(nombre, apellido, mail, usuario, contraseña, Convert.ToInt32(rolid), Convert.ToInt32(id));
        }
        public void EliminarUsuario(string id)
        {
            cdUsuario.eliminarUsuario(Convert.ToInt32(id));
        }
    }
}
