using System;
using System.Collections.Generic;
using System.Text;

namespace login_system.Config
{
    public class SignUpAccount
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SignUpAccount(string user, string email, string password)
        {
            User = user;
            Email = email;
            Password = password;
        }

        public bool isValidEmail() 
        {
            try
            {
                //Compara o email recebido com o final para identificar se é valido
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch{

                return false;
            }
        }

        public bool confirmPassword(string password, string conPassword) {
            //Checa se senhas são iguais
            return password == conPassword;
        }
    }
}
