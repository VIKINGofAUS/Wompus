using RestSharp;

namespace New_Perspectives
{
    class DataHandler
    {
        private const string URL = "http://www.wumpos.com";

        public bool sendToApi(string name, string score, string timeStamp)
        {

            var client = new RestClient(URL);

            var request = new RestRequest("/api/saveData.php", Method.POST);
            request.AddParameter("name", name); // adds to POST or URL querystring based on Method
            request.AddParameter("score", score);
            request.AddParameter("timestamp", timeStamp);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return true;
        }
    }
}
