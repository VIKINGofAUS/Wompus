using RestSharp;

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

            var client = new RestClient(URL);

            var request = new RestRequest("/api/login_validation.php", Method.POST);
            request.AddParameter("username", Username); // adds to POST or URL querystring based on Method
            request.AddParameter("password", Password);
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            return content;
        }

    }
}
