
namespace login_system
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_user = new System.Windows.Forms.TextBox();
            this.textB_email = new System.Windows.Forms.TextBox();
            this.textB_password = new System.Windows.Forms.TextBox();
            this.textB_conPassword = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONFIRM PASSWORD";
            // 
            // textB_user
            // 
            this.textB_user.Location = new System.Drawing.Point(13, 46);
            this.textB_user.Name = "textB_user";
            this.textB_user.Size = new System.Drawing.Size(124, 23);
            this.textB_user.TabIndex = 4;
            // 
            // textB_email
            // 
            this.textB_email.Location = new System.Drawing.Point(13, 100);
            this.textB_email.Name = "textB_email";
            this.textB_email.Size = new System.Drawing.Size(124, 23);
            this.textB_email.TabIndex = 5;
            // 
            // textB_password
            // 
            this.textB_password.Location = new System.Drawing.Point(13, 163);
            this.textB_password.MaxLength = 8;
            this.textB_password.Name = "textB_password";
            this.textB_password.PasswordChar = '*';
            this.textB_password.Size = new System.Drawing.Size(124, 23);
            this.textB_password.TabIndex = 6;
            // 
            // textB_conPassword
            // 
            this.textB_conPassword.Location = new System.Drawing.Point(13, 223);
            this.textB_conPassword.MaxLength = 8;
            this.textB_conPassword.Name = "textB_conPassword";
            this.textB_conPassword.PasswordChar = '*';
            this.textB_conPassword.Size = new System.Drawing.Size(124, 23);
            this.textB_conPassword.TabIndex = 7;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(173, 223);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 8;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.SignupAccount);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.Red;
            this.lbl_email.Location = new System.Drawing.Point(143, 103);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(105, 15);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Insert a valid email";
            this.lbl_email.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.Red;
            this.lbl_password.Location = new System.Drawing.Point(30, 249);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(107, 15);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Incorrect password";
            this.lbl_password.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.textB_conPassword);
            this.Controls.Add(this.textB_password);
            this.Controls.Add(this.textB_email);
            this.Controls.Add(this.textB_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_user;
        private System.Windows.Forms.TextBox textB_email;
        private System.Windows.Forms.TextBox textB_password;
        private System.Windows.Forms.TextBox textB_conPassword;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
    }
}