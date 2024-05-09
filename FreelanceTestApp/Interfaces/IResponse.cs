using System.Net;

namespace FreelanceTestApp.Interfaces
{
    public interface IResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Content { get; set; }
        string SerializeContent();
    }
}
