using FreelanceTestApp.Interfaces;

namespace FreelanceTestApp.Classes
{
    public class MessageResponse : IResponse
    {
        public int StatusCode { get; set; }

        public string? Content { get; set; }

        public override string ToString()
        {
            return $"statusCode: {StatusCode}\r\ncontent: {Content}";
        }
    }
}
