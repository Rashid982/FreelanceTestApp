using FreelanceTestApp.Interfaces;
using RestSharp;

namespace FreelanceTestApp.Classes
{
    public class MyRestRequest : IRequest
    {
        private readonly RestRequest restRequest;

        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? RecipientName { get; set; }
        public string? RecipientMail { get; set; }
        public string? Text { get; set; }
        public string? Subject { get; set; }

        public MyRestRequest(string endPoint, Method method)
        {
            restRequest = new RestRequest(endPoint, method);
        }

        public object AddJsonBody<T>(T obj)
        {
            return restRequest.AddJsonBody<object>(obj);
        }
    }
}
