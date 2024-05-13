using FreelanceTestApp.Interfaces;
using RestSharp;

namespace FreelanceTestApp.Classes
{
    public class MailTrapClient : IMailClient
    {
        private readonly RestClient _restClient;
        private readonly IOptions _options;
        const string ApiKeyHeader = "Api-Token";
        public MailTrapClient(IOptions options)
        {
            _restClient = new RestClient(options.BaseAdress ?? "");
            _restClient.AddDefaultHeader(ApiKeyHeader, options.ApiToken ?? "");
            _options = options;
        }

        public async Task<IResponse> SendEmail(IRequest request)
        {
            if (request != null)
            {
                var args_ = new
                {
                    from = new { email = request.SenderMail, name = request.SenderName },
                    to = new[] { new { email = request.RecipientMail, name = request.RecipientName } },
                    subject = request.Subject,
                    text = request.Text,
                };

                var restrequest = new RestRequest(_options.SendEndpoint, Method.Post);
                restrequest.AddJsonBody(args_);
                var response = await _restClient.ExecutePostAsync(restrequest);


                return new MessageResponse()
                {
                    StatusCode = (int)response.StatusCode,
                    Content = response.Content
                };                
            }

            return new MessageResponse()
            {
                StatusCode = 500,
                Content = string.Empty
            }; ;
        }

    }
}
