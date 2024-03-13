using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        private static int UsuarioID { get; set; }
        private static string Nombres { get; set; }
        private static string Apellidos { get; set; }
        private static string Email { get; set; }
        private static string Usuario { get; set; }
        private static string Contraseña { get; set; }
        private static int RolID { get; set; }
        public static bool IsLoggedIn { get; private set; }


        //METODO PARA ESTABLECER LOS DATOS DE INICIO DE SESION.
        public static void SerUserLogin(int usuarioID, string nombres, string apellidos, string email, string usuario, int rolID)
        {
            UsuarioID = usuarioID;
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Usuario = usuario;
            RolID = rolID;

            IsLoggedIn = true;
        }

        // Método para limpiar la caché al cerrar sesión
        public static void ClearUserLogin()
        {
            UsuarioID = 0;
            Nombres = null;
            Apellidos = null;
            Email = null;
            Usuario = null;
            RolID = 0;
            IsLoggedIn = false;
        }

        // Método para validar si el usuario está logueado
        public static bool ValidateUserLogin()
        {
            return IsLoggedIn;
        }

        public static string lblUser()
        {
            string usuario = Usuario;
            return usuario;

        }
        public static string lblEmail()
        {
            string email = Email;
            return email;

        }
    }
}
