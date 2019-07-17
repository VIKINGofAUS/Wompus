using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace New_Perspectives
{
    public partial class LoginForm : Form
    {
        bool register = false;
        DataHandler data_handler = new DataHandler();
        public LoginForm()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public LoginForm(string version)
        {
            InitializeComponent();
            if (version == "Register") {
                aKeyBox.Visible = true;
                aKeyLable.Visible = true;
                register = true;
            }
        }

        private void aSubmitButton_Click(object sender, EventArgs e)
        {
            if (register) {
                RegisterUser();
            }
            else {
                SignInUser();
            }

            /*
            string authenticatedStatus = data_handler.Authenticate(aUsernameTextbox.Text, aPasswordTexbox.Text);
            if (authenticatedStatus == "Not Authenticated")
            {
                aincorrectLoginLable.Visible = true;

            }
            else {
                this.Hide();
            }

            */
        }


        private void RegisterUser() {
            if (IsValidEmail(aEmailTextbox.Text) == false) {
                aincorrectLoginLable.Visible = true;
                aincorrectLoginLable.Text = "Invalid Email format";
                return;
            }
            if (aPasswordTexbox.Text.Length < 8)
            {
                aincorrectLoginLable.Visible = true;
                aincorrectLoginLable.Text = "Password Must be at least 8 long";
                return;
            }
            if (aKeyBox.Text.Length < 1)
            {
                aincorrectLoginLable.Visible = true;
                aincorrectLoginLable.Text = "A key must be entered";
                return;
            }
            string response = data_handler.RegisterApi(aEmailTextbox.Text,aPasswordTexbox.Text,aKeyBox.Text);
            if (response == "Registration Complete") {
                this.Close();
            }
            aincorrectLoginLable.Visible = true;
            aincorrectLoginLable.Text = response;
        }
        private void SignInUser() {
            if (IsValidEmail(aEmailTextbox.Text) == false)
            {
                aincorrectLoginLable.Visible = true;
                aincorrectLoginLable.Text = "Invalid Email format";
                return;
            }
            if (aPasswordTexbox.Text.Length < 8)
            {
                aincorrectLoginLable.Visible = true;
                aincorrectLoginLable.Text = "Password Must be at least 8 long";
                return;
            }
            string response = data_handler.SignInApi(aEmailTextbox.Text, aPasswordTexbox.Text);
            if (response == "Sign In Successfull")
            {
                this.Close();
            }
            else {
                aincorrectLoginLable.Visible = true;
            }

        }


    }
}
