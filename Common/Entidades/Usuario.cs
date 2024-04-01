using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Usuario
    {
        private int UsuarioID { get; set; }
        private string Nombres { get; set; }
        private string Apellidos { get; set; }
        private string Email { get; set; }
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private int RolID { get; set; }

        // Métodos para establecer los valores de las propiedades.

        public void SetUsuarioID(int id)
        {
            UsuarioID = id;
        }

        public void SetNombres(string Nombre)
        {
            Nombres = Nombre;
        }

        public void SetApellidos(string apellido)
        {
            Apellidos = apellido;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetUsuario(string Usuario)
        {
            NombreUsuario = Usuario;
        }

        public void SetContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }

        public void SetRolID(int rolid)
        {
            RolID = rolid;
        }

        // Métodos para obtener los valores de las propiedades
        public int GetUsuarioID()
        {
            return UsuarioID;
        }

        public string GetNombres()
        {
            return Nombres;
        }

        public string GetApellidos()
        {
            return Apellidos;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetUsuario()
        {
            return NombreUsuario;
        }

        public string GetContraseña()
        {
            return Contraseña;
        }

        public int GetRolID()
        {
            return RolID;
        }
    }
}
