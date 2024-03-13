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


    }
}
