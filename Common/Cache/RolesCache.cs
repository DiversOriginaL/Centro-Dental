using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class RolesCache
    {
        private static int RolID { get; set; }
        private static string Rol { get; set; }

        public static void GetRol(int rolid, string rol)
        {
            RolID = rolid;
            Rol = rol;
        }

        public static string RoL()
        {
            return Rol;
        }
    }
}
