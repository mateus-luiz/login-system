using login_system.Config;
using login_system.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login_system
{
    public partial class LoginSystem : Form
    {
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void OpenSignup(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            string user = textB_login.Text;
            string password = textB_pass.Text;

            Home homeForm = new Home();

            LoginAccount loginAccount = new LoginAccount(user, password);

            if(loginAccount.login == true)
            {
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Failed to login, please try again. Verify user or password!");
            }
        }
    }
}
