using FreelanceTestApp.Interfaces;

namespace FreelanceTestApp.Classes
{
    public class EmailSender : IEmailSender
    {
        private readonly IMailClient client;

        public EmailSender(IMailClient client)
        {            
            this.client = client;
        }

        public async Task<IResponse> SendEmail(IRequest request)
        {
            return await client.SendEmail(request);
        }
                
    }
}
