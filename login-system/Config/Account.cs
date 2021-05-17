using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using login_system.Forms;
using MySql.Data.MySqlClient;

namespace login_system.Config
{
    public class Account
    {
        string _connectionstring = "server=localhost;user id=root;database=loginsystem";

        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        

        public string User { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Account(string user, string email, string password) {
            User = user;
            Email = email;
            Password = password;

            con.ConnectionString = _connectionstring;
            cmd.Parameters.AddWithValue("@user", User);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@email", Email);
        }


        public bool CheckAccount()
        {
            cmd.Connection = con;
            cmd.CommandText = "select user from cadastros where user = @user";
            con.Open();
            var result = cmd.ExecuteScalar();
            con.Close();

            if(result != null)
            {
                return true;
            }

            return false;

        }

        public void CreateAccount()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into cadastros (user, password, email) values(@user, @password, @email)";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
