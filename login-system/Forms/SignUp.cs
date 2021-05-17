using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using login_system.Config;
using MySql.Data.MySqlClient;

namespace login_system
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignupAccount(object sender, EventArgs e)
        {
            string user = textB_user.Text;
            string email = textB_email.Text;
            string password = textB_password.Text;

            SignUpAccount verifyAccount = new SignUpAccount(user, email, password);

            //Verifica se informações inseridas estão vazias
            if(user == null || email == null || password == null)
            {
                return;
            }

            if (!verifyAccount.isValidEmail())
            {
                lbl_email.Visible = true;
                return;
            }

            if(!verifyAccount.confirmPassword(password, textB_conPassword.Text))
            {
                lbl_password.Visible = true;
                return;
            }

            //Cria e adiciona conta no banco de dados
            try
            {
                Account newAccount = new Account(user, email, password);

                if(newAccount.CheckAccount() == true)
                {
                    MessageBox.Show("Already exist!");
                    return;
                }

                newAccount.CreateAccount();
                MessageBox.Show("Sucessfull created!");
                ActiveForm.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            this.Close();
        }
    }
}
