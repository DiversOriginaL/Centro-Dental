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

        Usuario usuario = new Usuario();
        public void InsertarUsuario(string nombre, string apellido, string mail, string nombreusuario, string contraseña, object rolid)
        {
            usuario.SetNombres(nombre);
            usuario.SetApellidos(apellido);
            usuario.SetEmail(mail);
            usuario.SetUsuario(nombreusuario);
            usuario.SetContraseña(contraseña);
            usuario.SetRolID(Convert.ToInt32(rolid));

            cdUsuario.InsertarUsuario(usuario);
        }

        public void EditarUsuario(string nombre, string apellido, string mail, string nombreusuario, string contraseña, object rolid, string id)
        {
            usuario.SetUsuarioID(Convert.ToInt32(id));
            usuario.SetNombres(nombre);
            usuario.SetApellidos(apellido);
            usuario.SetEmail(mail);
            usuario.SetUsuario(nombreusuario);
            usuario.SetContraseña(contraseña);
            usuario.SetRolID(Convert.ToInt32(rolid));

            cdUsuario.editarUsuario(usuario);
        }
        public void EliminarUsuario(string id)
        {
            cdUsuario.eliminarUsuario(Convert.ToInt32(id));
        }
    }
}
