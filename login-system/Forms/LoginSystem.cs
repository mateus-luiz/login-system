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
    }
}
