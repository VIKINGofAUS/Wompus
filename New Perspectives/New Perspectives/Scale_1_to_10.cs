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
    public partial class Scale_1_to_10 : Form
    {
        List<string> Question = new List<string>();
        int SelectedButton = 0;
        DataHandler data_handler = new DataHandler();
        public Scale_1_to_10(List<string> question)
        {
            InitializeComponent();
            Question = question;
            aQuestionLable.Text = Question[1];
            aQuestionLable.Select();
        }

        private void setSelected(int number) {
            SelectedButton = number;
            aSubmitButton.Enabled = true;
        }

        private void aSubmitButton_Click(object sender, EventArgs e)
        {
            string response = data_handler.AnswerQuestion(SelectedButton.ToString(), Question[0]);
            if (response == "Answered SuccessFully")
            {
                this.Close();
            }
            else {
                MessageBox.Show(response);
            }

        }

        private void aRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(6);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(7);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(8);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(9);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            setSelected(10);
        }
    }
}
