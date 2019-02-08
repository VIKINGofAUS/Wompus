using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Wumpos_060219
{
    class DataHandler
    {

        private const string URL = "http://127.0.0.1/wumpus";

        
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
