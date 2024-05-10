using FreelanceTestApp.Interfaces;

namespace FreelanceTestApp.Classes
{
    public class EmailSender : IEmailSender
    {
        private readonly IClient client;        
        private readonly IResponse response;
        

        public EmailSender(IClient client, IResponse response, IOptions options)
        {            
            this.client = client;
            this.client.AddDefaultHeader("Api-Token", options.ApiToken ?? "");
            this.response = response;
        }

        public async Task<IResponse> Send(IRequest request)
        {
            var args_ = new
            {
                from = new { email = request.SenderMail, name = request.SenderName },
                to = new[] { new { email = request.RecipientMail, name = request.RecipientName } },
                subject = request.Subject,
                text = request.Text,
            };

            var req = request.AddJsonBody(args_);

            response.Content = await client.ExecuteAsync(req);
            await Console.Out.WriteLineAsync(response.SerializeContent());

            return response;
        }
                
    }
}
