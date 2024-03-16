using Login.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace Login.Domain.Domain
{
    public class UserModel
    {
        UserData userData = new UserData();

        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

        public static void AnyMethod()
        {
            if (UserLoginCache.RolId() == Positions.Administrador && RolesCache.RoL() == "Administrador")
            {

            }
            if (UserLoginCache.RolId() == Positions.DoctoraGeneral && RolesCache.RoL() == "Doctora General" ||
                UserLoginCache.RolId() == Positions.Recepcionista && RolesCache.RoL() == "Recepcionista" ||
                UserLoginCache.RolId() == Positions.Secretaria && RolesCache.RoL() == "Secretaria" ||
                UserLoginCache.RolId() == Positions.Empleado && RolesCache.RoL() == "Empleado")
            {

            }
        }
    }
}
