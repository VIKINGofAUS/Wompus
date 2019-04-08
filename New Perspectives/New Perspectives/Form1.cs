using System;
using System.Windows.Forms;

namespace New_Perspectives
{
    public partial class Form1 : Form
    {
        public string getdata;
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowLoginForm() {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            aWelcomeLabel.Select();
        }

        public bool hasInputKey() {
            DataHandler.InputKey InputKey = DataHandler.GetInputKey();
            if (InputKey.Key == "default")
            {
                return false;
            }
            return true;
        }

        public void SetEnabledAllButtons( bool setting) {
            aButton_1.Enabled = setting;
            aButton_2.Enabled = setting;
            aButton_3.Enabled = setting;
            aButton_4.Enabled = setting;
            aButton_5.Enabled = setting;
            aButton_6.Enabled = setting;
            aButton_7.Enabled = setting;
            aButton_8.Enabled = setting;
            aButton_9.Enabled = setting;
            aButton_10.Enabled = setting;
        }

        public void RunButtonEvent(string buttonNumber) {
            //DataHandler.SetInputKey("default");
            if (hasInputKey() == false)
            {
                ShowLoginForm();
            }
            else
            {
                aWelcomeLabel.Select();
                String timeStamp = GetTimestamp(DateTime.Now);
                string score = buttonNumber;
                String Key = DataHandler.GetInputKey().Key;
                data_handler.sendUserMoodToApi(Key, score, timeStamp);
                MinimiseWindow();
            }
        }


        public void MinimiseWindow()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void MaximizeWindow()
        {
            this.WindowState = FormWindowState.Normal;
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }


        DataHandler data_handler = new DataHandler();

        private void aButton_1_Click(object sender, EventArgs e)
        {
            RunButtonEvent("1");
        }

        private void aButton_2_Click(object sender, EventArgs e)
        {
            RunButtonEvent("2");
        }

        private void aButton_3_Click(object sender, EventArgs e)
        {
            RunButtonEvent("3");
        }

        private void aButton_4_Click(object sender, EventArgs e)
        {
            RunButtonEvent("4");
        }

        private void aButton_5_Click(object sender, EventArgs e)
        {
            RunButtonEvent("5");
        }

        private void aButton_6_Click(object sender, EventArgs e)
        {
            RunButtonEvent("6");
        }

        private void aButton_7_Click(object sender, EventArgs e)
        {
            RunButtonEvent("7");
        }

        private void aButton_8_Click(object sender, EventArgs e)
        {
            RunButtonEvent("8");
        }

        private void aButton_9_Click(object sender, EventArgs e)
        {
            RunButtonEvent("9");
        }

        private void aButton_10_Click(object sender, EventArgs e)
        {
            RunButtonEvent("10");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MaximizeWindow();
        }
    }
}
