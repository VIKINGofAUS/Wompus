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
            string response = data_handler.RegisterApi(aEmailTextbox.Text,aPasswordTexbox.Text,aKeyBox.Text);
            if (response == "Registration Complete") {
                this.Close();
            }
        }
        private void SignInUser() {
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
