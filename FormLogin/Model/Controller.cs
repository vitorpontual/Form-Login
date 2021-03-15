using FormLogin.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.Model
{
    public class Controller
    {
        public bool have;
        public string message = "";
        public bool Access(string login, string password)
        {
            Login loginUser = new Login();
            have = loginUser.VerifyPassword(login, password);
            if (!loginUser.message.Equals(""))
            {
                this.message = loginUser.message;
            }
            return have;
        }

        public string SignUpUser(string email, string password, string repassword)
        {
            Login login = new Login();
            this.message = login.SingUp(email, password, repassword);
            if (login.have)
            {
                this.have = true;
            }

            return message;
        }
    }
}
