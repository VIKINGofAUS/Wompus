using Dapper;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace New_Perspectives
{
    class DataHandler
    {
        private const string URL = "http://www.wumpos.com";

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

        public string Authenticate(string Username, string Password)
        {
            string response = AuthenticateApi( Username, Password);
            if (response != "0 results") {
                SetInputKey(response);
                return response;
            }
            return "Not Authenticated";
        }

        public string AuthenticateApi(string Username, string Password)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/api/login_validation.php", Method.POST);
            request.AddParameter("username", Username); // adds to POST or URL querystring based on Method
            request.AddParameter("password", Password);
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            return content;
        }


        public class InputKey {
            public int Pk { get; set; }
            public string Key { get; set; }
        }

        public static InputKey GetInputKey() {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InputKey>("select * from InputKey", new DynamicParameters());
                return output.ToList().First();
             }
        }

        public static void SetInputKey(string inputKey)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string updateStatment = "UPDATE InputKey SET key ='" + inputKey+"'";
                cnn.Query<InputKey>(updateStatment, new DynamicParameters());
            }
        }

        private static string LoadConnectionString(string id = "Default") {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
