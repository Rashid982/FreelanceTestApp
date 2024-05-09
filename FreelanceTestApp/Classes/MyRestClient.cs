using FreelanceTestApp.Interfaces;
using RestSharp;

namespace FreelanceTestApp.Classes
{
    public class MyRestClient : IClient
    {
        private readonly RestClient restClient;

        public MyRestClient(string baseUrl)
        {
            restClient = new RestClient(baseUrl);
        }

        public void AddDefaultHeader(string name, string value)
        {
            restClient.AddDefaultHeader(name, value);
        }

        public async Task<object> ExecuteAsync(object request)
        {
            var request_ = request as RestRequest;

            if (request_ != null)
            {
                var response = await restClient.ExecuteAsync(request_);
                return response;
            }

            return null;
        }

    }
}
