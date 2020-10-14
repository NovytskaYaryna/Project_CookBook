using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public partial class UserLogin
    {
        private static UserLogin instance;

        private UserLogin(){ }

        private UserLogin(int id, string login)
        {
            userId = id;
            userLogin = login;
        }

        public static UserLogin getInstance()
        {
            if (instance == null)
                instance = new UserLogin();
            return instance;
        }

        public static UserLogin setInstance(int id, string login)
        {
            if (instance == null)
                instance = new UserLogin(id, login);
            else
            {
                instance.userId = id;
                instance.userLogin = login;
            }

            return instance;
        }

        public int userId { get; set; }
        public string userLogin { get; set; }
    }
}
