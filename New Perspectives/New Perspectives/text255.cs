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
    public partial class text255 : Form
    {
        DataHandler data_handler = new DataHandler();
        List<string> Question = new List<string>();
        public text255(List<string> question)
        {
            InitializeComponent();
            Question = question;
            aQuestionLable.Text = Question[1];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aSubmitButton_Click(object sender, EventArgs e)
        {
            string response = data_handler.AnswerQuestion(aAnswerTextbox.Text, Question[0]);
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
