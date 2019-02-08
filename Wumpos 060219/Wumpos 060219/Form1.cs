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

        string path = "file.txt";
        FileHandler file_handler = new FileHandler();
        DataHandler data_handler = new DataHandler();


        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 0, timeStamp);
            string name = "john";
            string score = "0";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 1, timeStamp);
            string name = "john";
            string score = "1";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 2, timeStamp);
            string name = "john";
            string score = "2";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 3, timeStamp);
            string name = "john";
            string score = "3";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 4, timeStamp);
            string name = "john";
            string score = "4";
            data_handler.sendToApi(name, score, timeStamp);

        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 5, timeStamp);
            string name = "john";
            string score = "5";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 6, timeStamp);
            string name = "john";
            string score = "6";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 7, timeStamp);
            string name = "john";
            string score = "7";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 8, timeStamp);
            string name = "john";
            string score = "8";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 9, timeStamp);
            string name = "john";
            string score = "9";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Button_10_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 10, timeStamp);
            string name = "john";
            string score = "10";
            data_handler.sendToApi(name, score, timeStamp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 0, timeStamp);
        }
    }
}
