using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Usuario
    {
        private int _id { get; set; }
        private string _nombre { get; set; }
        private string _apellido { get; set; }
        private string _email { get; set; }
        private string _usuario { get; set; }
        private string _contraseña { get; set; }
        private int _rolid { get; set; }

        // Métodos para establecer los valores de las propiedades
        public void SetID(int id)
        {
            _id = id;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            _apellido = apellido;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void SetNombreUsuario(string nombreUsuario)
        {
            _usuario = nombreUsuario;
        }

        public void SetContraseña(string contraseña)
        {
            _contraseña = contraseña;
        }

        public void SetRolID(int rolID)
        {
            _rolid = rolID;
        }

        // Métodos para obtener los valores de las propiedades
        public int GetID()
        {
            return _id;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public string GetApellido()
        {
            return _apellido;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetNombreUsuario()
        {
            return _usuario;
        }

        public string GetContraseña()
        {
            return _contraseña;
        }

        public int GetRolID()
        {
            return _rolid;
        }
    }
}
