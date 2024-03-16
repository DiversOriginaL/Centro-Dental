using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    internal class Roles
    {
        private int RolID;
        private string Rol;

        protected void SetRol(int rolid, string rol)
        {
            RolID = rolid;
            Rol = rol;
        }
    }
}
