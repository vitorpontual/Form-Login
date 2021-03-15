using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.Config
{
    class Login
    {
        public bool have;
        public string message = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;
        public bool VerifyPassword(string login, string password)
        {
            cmd.CommandText = "SELECT * FROM _user WHERE email = @login AND password = @password";

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.Connection = con.connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    have = true;
                }
            }
            catch (SqlException)
            {
                this.message = "Database Internal Error!";
            }

            return have;
        }

        public string SingUpUser(string email, string password, string repassword)
        {
            return message;

        }
    }
}
