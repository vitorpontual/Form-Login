using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.Config
{
    public class Connection
    {

        SqlConnection con = new SqlConnection();

        public Connection()
        {
            con.ConnectionString = @"Data Source=AVELL-A52;Initial Catalog=LoginForm;Integrated Security=True";
        }
        
        public SqlConnection connect()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void disconnect()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

       
    }
}
