using System;
using System.Windows.Forms;

namespace New_Perspectives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aWelcomeLabel.Select();
        }


        public void RunButtonEvent(string buttonNumber) {
            MinimiseWindow();
            aWelcomeLabel.Select();
            String timeStamp = GetTimestamp(DateTime.Now);
            string score = buttonNumber;
            data_handler.sendToApi(name, score, timeStamp);
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
        string name = "john";

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
