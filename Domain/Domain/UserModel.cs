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
        public string getBackPassword(string userRequesting, string pass)
        {
            return userData.recoverPassword(userRequesting, pass);
        }
        public static void AnyMethod()
        {
            if (UserLoginCache.RolId() == Positions.Administrador && RolesCache.RoL() == "Administrador" ||
                UserLoginCache.RolId() == Positions.DoctoraGeneral && RolesCache.RoL() == "Doctora General")
            {
                
            }
            if (UserLoginCache.RolId() == Positions.Recepcionista && RolesCache.RoL() == "Recepcionista" ||
                UserLoginCache.RolId() == Positions.DoctoraEncagada && RolesCache.RoL() == "Doctora Encargada" ||
                UserLoginCache.RolId() == Positions.Empleado && RolesCache.RoL() == "Empleado")
            {

            }
        }
    }
}
