using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

            SqlDataAdapter da = new SqlDataAdapter("SELECT email FROM _user WHERE email='"+email+"'", con.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count >= 1)
            {
                this.message = "Error Email Exists!";
            }
            else
            {

                if (password.Equals(repassword) && password != "")
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
          
            }
            return message;

        }
    }
}
