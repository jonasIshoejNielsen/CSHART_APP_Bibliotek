using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIConsumerLiveDemo.Models
{
    public class LocalhostDataStore : IDataStore
    {
        public HttpClient GetHTTPClient()
        {
            HttpClient httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:44382/") };
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }
    }
}
