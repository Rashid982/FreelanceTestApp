using FreelanceTestApp.Interfaces;
using RestSharp;
using System.Net;

namespace FreelanceTestApp.Classes
{
    public class MyRestResponse : IResponse
    {
        private readonly RestResponse _response;
        public HttpStatusCode StatusCode { get; set; }

        public object Content { get; set; }

        public MyRestResponse()
        {
            _response = new RestResponse();
            StatusCode = _response.StatusCode;
        }

        public string SerializeContent()
        {
            var responseContent = Content as RestResponse;
            if (responseContent != null)
            {
                StatusCode = responseContent.StatusCode;
            }

            var serializeContent = responseContent?.Content;

            if (serializeContent != null)
            {
                return serializeContent;
            }

            return string.Empty;
        }
    }
}
