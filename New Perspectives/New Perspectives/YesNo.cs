using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace New_Perspectives
{
    public partial class YesNo : Form
    {
        List<string> Question = new List<string>();
        DataHandler data_handler = new DataHandler();
        public YesNo(List<string> question)
        {
            InitializeComponent();
            Question = question;
            AQuestionLable.Text = Question[1];
            AQuestionLable.Select();
        }
        private void aNoButton_Click(object sender, EventArgs e)
        {
            string response = data_handler.AnswerQuestion("No", Question[0]);
            if (response == "Answered SuccessFully")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(response);
            }
        }

        private void aYesButton_Click(object sender, EventArgs e)
        {
            string response = data_handler.AnswerQuestion("Yes", Question[0]);
            if (response == "Answered SuccessFully")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(response);
            }
        }
    }
}
