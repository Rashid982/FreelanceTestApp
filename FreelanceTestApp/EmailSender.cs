using Org.BouncyCastle.Tls;
using RestSharp;
using static System.Net.Mime.MediaTypeNames;

namespace FreelanceTestApp
{
    public class EmailSender : IEmailSender
    {
        private readonly RestClient restClient;

        private readonly MyRestClient myRestClient;
        private readonly IOptions options;

        public EmailSender(EmailOptions emailOptions) // public EmailSender(EmailOptions emailOptions)
        {
            //restClient = new RestClient("https://send.api.mailtrap.io/api");  //must create constructor
            //restClient.AddDefaultHeader("Api-Token", "6c3c24289024661017339035acafb343");

            options = new EmailOptions();
            myRestClient = new MyRestClient(options.BaseAdress);
            myRestClient.AddDefaultHeader("Api-Token", options.ApiToken);
        }

        public async Task<MyRestResponse> Send(EmailRequest emailRequest)
        {
            var args_ = new
            {
                from = new { email = emailRequest.SenderMail, name = emailRequest.SenderName },  //it must be created class for this
                to = new[] { new { email = emailRequest.RecipientMail, name = emailRequest.RecipientName } },
                subject = emailRequest.Subject,
                text = emailRequest.Text,
            };

            var request = new MyRestRequest("/send", RestSharp.Method.Post);

            request.AddJsonBody(args_);

            var response = await myRestClient.ExecuteAsync(request);

        }

        public async Task<RestResponse> Send(string senderName, string senderEmail, string recipientName, string recipientEmail, string text) // send method must receive object, iEmailmessage , it can be interface
        {                    
            var args_ = new
            {
                from = new { email = senderEmail, name = senderName },  //it must be created class for this
                to = new[] { new { email = recipientEmail, name = recipientName } },
                subject = "Awesome",
                text = text,
            };

            var request = new RestRequest("/send", RestSharp.Method.Post);
            
            request.AddJsonBody(args_);                        

            RestResponse response = await restClient.ExecuteAsync(request);
            
            Console.WriteLine(response.Content);

            return response;
        }        

    }       
}
