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
        DataHandler data_handler = new DataHandler();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void aSubmitButton_Click(object sender, EventArgs e)
        {
            string authenticatedStatus = data_handler.Authenticate(aUsernameTextbox.Text, aPasswordTexbox.Text);
            if (authenticatedStatus == "Not Authenticated")
            {
                aincorrectLoginLable.Visible = true;

            }
            else {
                this.Hide();
            }

        }
    }
}
