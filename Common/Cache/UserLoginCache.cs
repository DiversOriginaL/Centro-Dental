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
        public static void SetUserLogin(int usuarioID, string nombres, string apellidos, string email, string usuario, string contraseña, int rolID)
        {
            UsuarioID = usuarioID;
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Usuario = usuario;
            RolID = rolID;
            Contraseña = contraseña;
            IsLoggedIn = true;
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

        public static int RolId()
        {
            return RolID;
        }

        public static string getUser()
        {
            return Nombres + " " + Apellidos;
        }

        public static int GetID() => UsuarioID;
     
    }
}
