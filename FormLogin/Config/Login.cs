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
                con.disconnect();
                dr.Close();
            }
            catch (SqlException)
            {
                this.message = "Database Internal Error!";
            }

            return have;
        }

        public string SingUp(string email, string password, string repassword)
        {
            have = false;
            if (password.Equals(repassword))
            {
                cmd.CommandText = "INSERT INTO _user values (@email, @password)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    cmd.Connection = con.connect();
                    cmd.ExecuteNonQuery();
                    con.disconnect();
                    this.message = "Succesful, SignUp complete";
                    have = true;
                }
                catch (SqlException)
                {
                    this.message = "Database Internal Error!!!";
                }
            }
            else
            {
                this.message = "Password Different!!!";
            }
            return message;

        }
    }
}
