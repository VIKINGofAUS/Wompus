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
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 0, timeStamp);
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 1, timeStamp);
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 2, timeStamp);
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 3, timeStamp);
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 4, timeStamp);
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 5, timeStamp);
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 6, timeStamp);
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 7, timeStamp);
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 8, timeStamp);
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 9, timeStamp);
        }

        private void Button_10_Click(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 10, timeStamp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String timeStamp = GetTimestamp(DateTime.Now);
            file_handler.openFileAndWriteNumber(path, 0, timeStamp);
        }
    }
}
