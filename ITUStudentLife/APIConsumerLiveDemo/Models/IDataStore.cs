using System.Net.Http;

namespace APIConsumerLiveDemo.Models
{
    public interface IDataStore
    {
        HttpClient GetHTTPClient();
    }
}