using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace New_Perspectives


{
    class DataHandler
    {
        //private const string URL = "http://www.wumpos.com";
        private const string URL = "https://businesssurvey.com.au";
        private static string GetConfigPath()
        {
            return "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming" + "\\BusinessSurveys" + "\\Config.txt";
        }


        public class QuestionClass
        {
            public string QuestionID { get; set; }
            public string Frequency { get; set; }
            public string Question { get; set; }
            public string QuestionType { get; set; }
        }




        private static List<String> ReadConfig()
        {
            List<string> ReturnValues = new List<string>();
            using (StreamReader sr = new StreamReader(GetConfigPath()))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ReturnValues.Add(line);
                }
            }
            return ReturnValues;
        }

        public bool sendUserMoodToApi(string UserKey, string score, string timeStamp)
        {

            var client = new RestClient(URL);

            var request = new RestRequest("/api/saveData.php", Method.POST);
            request.AddParameter("UserKey", UserKey); // adds to POST or URL querystring based on Method
            request.AddParameter("score", score);
            request.AddParameter("timestamp", timeStamp);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return true;
        }

        //un finished
        public string AnswerQuestion(string Answer, string QuestionID)
        {
            string results = AnswerQuestionApi(Answer, QuestionID);
            if (results == "Answered SuccessFully") {
                SetLastAnsweredQuestionDate();
                SetLastAnsweredDateForQuestionID(QuestionID);
            }
            return results;
        }

        public string AnswerQuestionApi(string Answer, string QuestionID)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/api/AnswerApplicationQuestion.php", Method.POST);
            request.AddParameter("Answer", Answer); // adds to POST or URL querystring based on Method
            request.AddParameter("QuestionID", QuestionID);
            request.AddParameter("Token", GetInputKey());
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            //check and removed
            return content;
        }

        public string RegisterApi(string Email, string Password, string Key)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/api/ApplicationRegisterUser.php", Method.POST);
            request.AddParameter("Email", Email); // adds to POST or URL querystring based on Method
            request.AddParameter("Password", Password);
            request.AddParameter("Key", Key);
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            if (content.Contains("Registration Complete; Token|"))
            {
                string inputKey = content.Split('|')[1];
                content = content.Split(';')[0];
                SetInputKey(inputKey);
            }
            return content;
        }

        public void FetchGroupQuestionsApi()
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/api/fetchGroupQuestions.php", Method.POST);
            request.AddParameter("token", GetInputKey()); // adds to POST or URL querystring based on Method
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            if (!ValidJSON(content)) {
                //Error handling section
                return;
            }
            var questions = JsonConvert.DeserializeObject<List<QuestionClass>>(content);
            ClearQuestions();
            foreach (QuestionClass question in questions)
            {
                string line = "Question|" + question.QuestionID + "," + question.Question + "," + question.QuestionType + "," + question.Frequency + "," + DateTime.Today.AddDays(-365).ToString("d");

                string a = GetConfigPath();

                using (StreamWriter sw = File.AppendText(GetConfigPath()))
                {
                    sw.WriteLine(line);
                }
            }
            //re-add Questions
            //string inputKey = content.Split('|')[1];
        }


        public string SignInApi(string Email, string Password)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/api/ApplicationSignIn.php", Method.POST);
            request.AddParameter("Email", Email); // adds to POST or URL querystring based on Method
            request.AddParameter("Password", Password);
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            if (content.Contains("Sign In Successfull; Token|"))
            {
                string inputKey = content.Split('|')[1];
                content = content.Split(';')[0];
                SetInputKey(inputKey);
            }
            return content;
        }

        public class InputKey
        {
            public int Pk { get; set; }
            public string Key { get; set; }
        }

        public static string GetInputKey()
        {
            foreach (string line in ReadConfig())
            {
                if (line.Contains("InputKey|"))
                {
                    return line.Split('|')[1];
                }
            }
            return "No InputKey Found";
        }

        //untested
        public static void SetLastAnsweredQuestionDate()
        {
            List<string> NewConfig = new List<string>();
            foreach (string line in ReadConfig())
            {
                string LineToReWrite = line;
                if (line.Contains("LastAnswered|"))
                {
                    LineToReWrite = "LastAnswered|" + DateTime.Today.ToString("d");
                }
                NewConfig.Add(LineToReWrite);
            }
            File.WriteAllLines(GetConfigPath(), NewConfig);
        }


        public static string GetLastAnsweredQuestionDate()
        {
            foreach (string line in ReadConfig())
            {
                if (line.Contains("LastAnswered|"))
                {
                    return line.Split('|')[1];
                }
            }
            return "Last Answered Question Date";
        }

        public static List<string> ReturnQuestionsFromInternalTable()
        {
            List<string> ReturnValues = new List<string>();
            foreach (string line in ReadConfig())
            {
                if (line.Contains("Question|"))
                {
                    ReturnValues.Add(line.Split('|')[1]);
                }
            }
            return ReturnValues;
        }

        public static List<string> ReturnAnswersFromInternalTable()
        {
            List<string> ReturnValues = new List<string>();
            foreach (string line in ReadConfig())
            {
                if (line.Contains("Answers|"))
                {
                    ReturnValues.Add(line.Split('|')[1]);
                }
            }
            return ReturnValues;
        }

        //untested
        public static void SetLastAnsweredDateForQuestionID(string questionID)
        {
            List<string> NewConfig = new List<string>();
            List<string> lineBits = new List<string>();
            //string NewConfig = "";
            foreach (string line in ReadConfig())
            {
                string LineToReWrite = line;
                if (line.Contains("Question|" + questionID))
                {
                    //bit [4] is the questions last answered index
                    lineBits = line.Split(',').ToList();
                    //set last answered to todays date
                    lineBits[4] = DateTime.Today.ToString("d");
                    LineToReWrite = String.Join(",", lineBits.ToArray());
                }
                NewConfig.Add(LineToReWrite);
            }
            File.WriteAllLines(GetConfigPath(), NewConfig);
        }

        public static void SetInputKey(string inputKey)
        {
            List<string> NewConfig = new List<string>();
            //string NewConfig = "";
            foreach (string line in ReadConfig())
            {
                string LineToReWrite = line;
                if (line.Contains("InputKey|"))
                {
                    LineToReWrite = "InputKey|" + inputKey;
                }
                NewConfig.Add(LineToReWrite);
            }
            File.WriteAllLines(GetConfigPath(), NewConfig);
        }

        public static void ClearQuestions()
        {
            List<string> NewConfig = new List<string>();
            //string NewConfig = "";
            foreach (string line in ReadConfig())
            {
                string LineToReWrite = line;
                if (!line.Contains("Question|"))
                {
                    NewConfig.Add(LineToReWrite);
                }
            }
            File.WriteAllLines(GetConfigPath(), NewConfig);
        }



        public void CheckAndCreateConfig()
        {
            if (!IsConfig())
            {
                CreateConfig();
            }
        }

        private static bool IsConfig()
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Config.txt";
            return File.Exists(path);
        }

        private static void CreateConfig()
        {
            string AppRoamingPath = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming";
            if (!Directory.Exists(AppRoamingPath))
            {
                //Error time
            }
            else
            {
                string BusinessSurveysPath = AppRoamingPath + "\\BusinessSurveys";
                if (!Directory.Exists(BusinessSurveysPath))
                {
                    Directory.CreateDirectory(BusinessSurveysPath);
                }
                string configtxtPath = BusinessSurveysPath + "\\Config.txt";
                if (!File.Exists(configtxtPath))
                {
                    File.WriteAllText(configtxtPath, "InputKey|Default\r\nLastAnswered|" + DateTime.Today.AddDays(-1).ToString("d"));
                }
            }
        }

        public static bool ValidJSON(string s)
        {
            try
            {
                JToken.Parse(s);
                return true;
            }
            catch (JsonReaderException ex)
            {
                Trace.WriteLine(ex);
                return false;
            }
        }

    }
}
