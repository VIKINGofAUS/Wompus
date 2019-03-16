using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wumpos_060219
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }

        DataHandler data_handler = new DataHandler();


        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            Button_5.Select();
            label1.Select();
        }

        private void Button_1_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "1";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_2_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "2";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_3_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "3";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_4_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "4";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_5_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "5";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_6_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "6";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_7_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "7";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_8_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "8";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_9_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "9";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_10_Click_1(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            string name = "john";
            string score = "10";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Button_1.ClientRectangle,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
