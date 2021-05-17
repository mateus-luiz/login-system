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
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public Account(string user, string email, string password) {
            con.ConnectionString = "server=localhost;user id=root;database=teste";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into cadastro (user, password, email) values(@user, @password, @email)";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
