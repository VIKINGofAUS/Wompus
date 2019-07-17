using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace New_Perspectives
{
    public partial class Form1 : Form
    {
        DataHandler data_handler = new DataHandler();
        List<string> Questions = new List<string>();
        public string getdata;
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowLoginForm(string version) {
            LoginForm loginForm = new LoginForm(version);
            loginForm.ShowDialog();
        }


        private void SetButtonVisiblity(bool abool) {
            aRegisterButton.Visible = abool;
            aSignUpButton.Visible = abool;
        }

        private bool LoadQuestions() {
            Questions = DataHandler.ReturnQuestionsFromInternalTable();
            if (Questions.Count < 1) {
                data_handler.FetchGroupQuestionsApi();
                Questions = DataHandler.ReturnQuestionsFromInternalTable();
                if (Questions.Count < 1) {
                    return false;
                }
            }
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            data_handler.CheckAndCreateConfig();
            aWelcomeLabel.Select();
            text255 text255From = new text255();
            text255From.ShowDialog();
            if (DataHandler.GetInputKey() == "Default")
            {
                //aWelcomeLabel.Text = "";
                //keeping code for future use
                //this.Size = new Size(420, 200);
                SetButtonVisiblity(true);
                aWelcomeLabel.Select();
            }
            else {
                aWelcomeLabel.Text = "Welcome!";
                aWelcomeLabel.Left = 4;
                LoadQuestions();
                timer1_Tick(sender, e);
            }


        }

        public bool hasInputKey() {
            if (DataHandler.GetInputKey() == "Default")
            {
                return false;
            }
            return true;
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

        private int GetMostUrgentQuestion() {
            int MostFrequentQuestion=0;
            double Urgency=0;
            for (int i = 0; i < Questions.Count; i++)
            {
                List<string> Question = Questions[i].Split(',').ToList<string>();
                int Frequency = Int32.Parse(Question[3]);
                DateTime date = DateTime.ParseExact(Question[4], "d", null);
                double daysBetween = (DateTime.Today.Date - date).TotalDays;
                double thisUrgency = daysBetween / Frequency;
                if (thisUrgency> Urgency) {
                    MostFrequentQuestion = i;
                }
            }
            return MostFrequentQuestion;
        }
    
        private bool QuestionNeedsToBeAsked() {

            for (int i = 0; i < Questions.Count; i++)
            {
                List<string> Question = Questions[i].Split(',').ToList<string>();
                int Frequency = Int32.Parse(Question[3]);
                DateTime date = DateTime.ParseExact(Question[4], "d", null);
                double daysBetween = (DateTime.Today.Date - date).TotalDays;
                if (daysBetween/Frequency >1) {
                    return true;
                }
                /*
                 ID
                 Question
                 Type
                 Frequency
                 Last answered
                 */
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoadQuestions())
            {
                string LAQD = DataHandler.GetLastAnsweredQuestionDate();
                DateTime LastAnsweredQuestionDate = DateTime.ParseExact(LAQD, "d", null);
                if (LastAnsweredQuestionDate.Date < DateTime.Today.Date && QuestionNeedsToBeAsked())
                {
                    int MostUrgentQuestionNumber = GetMostUrgentQuestion();
                    AskQuestion(Questions[MostUrgentQuestionNumber]);
                }
            }
            //if any questions need answering
            //  Show question window
            //  MaximizeWindow();
            //MaximizeWindow();
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void aWelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowYesNoQuestion(List<string> Question) {
            DialogResult dialogResult = MessageBox.Show(Question[1], "Questionaire", MessageBoxButtons.YesNo);
            string answer = dialogResult.ToString();
            data_handler.AnswerQuestionApi(answer, Question[0]);
        }

        private void AskQuestion(string InputQuestion) {
            List<string> Question = InputQuestion.Split(',').ToList<string>();
            string type = Question[2];
            if (type =="y/n") {
                ShowYesNoQuestion(Question);
            }

            else if (type =="text255") {
                text255 text255From = new text255();
                text255From.ShowDialog();

            }

            else if (type == "Scale_1_to_10")
            {

            }

            var a = "";
            a = "";
        }

        private void AskFirstQuestion() {
            if (LoadQuestions()) {
                int QuestionToAsk = 0;
                int HighestFrequency =0;
                for (int i = 0; i < Questions.Count;i++)
                {
                    /*
                     [0]ID
                     [1]Question
                     [2]Type
                     [3]Frequency
                     [4]Last answered
                     */
                    List<string> Question = Questions[i].Split(',').ToList<string>();
                    if (Int32.Parse(Question[3])> HighestFrequency) {
                        QuestionToAsk = i;
                        HighestFrequency = Int32.Parse(Question[3]);
                    }
                }
                AskQuestion(Questions[QuestionToAsk]);

            }
        }

        private void aSignUpButton_Click(object sender, EventArgs e)
        {
            ShowLoginForm("Sign In");
            if (hasInputKey()) {
                aWelcomeLabel.Text = "SignedIn Successfully";
                aWelcomeLabel.Left = 4;
                SetButtonVisiblity(false);
                AskFirstQuestion();
            }
        }

        private void aRegisterButton_Click(object sender, EventArgs e)
        {
            ShowLoginForm("Register");
            if (hasInputKey())
            {
                aWelcomeLabel.Text = "Successfully Registered :)";
                aWelcomeLabel.Left = 4;
                SetButtonVisiblity(false);
                AskFirstQuestion();
            }
        }
    }
}
