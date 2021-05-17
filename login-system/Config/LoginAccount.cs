using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace login_system.Config
{
    class LoginAccount
    {
        string _connectionstring = "server=localhost;user id=root;database=loginsystem";

        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public bool login = false;

        public LoginAccount(string user, string password) 
        {
            con.ConnectionString = _connectionstring;
            cmd.CommandText = "select user, password from cadastros where user = @user and password = @password";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = con;

            con.Open();

            var result = cmd.ExecuteScalar();

            if (result != null)
            {
                login = true;
            }
            else
            {
                login = false;
            }

            con.Close();
            
        }
    }
}
