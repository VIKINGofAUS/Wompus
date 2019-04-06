using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Perspectives
{
    public partial class LoginForm : Form
    {
        DataHandler data_handler = new DataHandler();
        public string Score;
        public string TimeStamp;
        public string UserKey;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(string key, string SentText,String SentTimeStamp) : this()
        {
            Score = SentText;
            TimeStamp = SentTimeStamp;
            UserKey = key;
        }

        private void aSubmitButton_Click(object sender, EventArgs e)
        {
            string authenticatedStatus = data_handler.Authenticate(aUsernameTextbox.Text, aPasswordTexbox.Text);
            if (authenticatedStatus == "Successful Authentication")
            {
                data_handler.sendUserMoodToApi(UserKey, Score, TimeStamp);
                this.Hide();
            }
            else {
                aincorrectLoginLable.Visible = true;
            }

        }
    }
}
