using RestSharp;

namespace FreelanceTestApp
{
    public class EmailSending
    {
        public async Task<RestResponse> Send(string senderName, string senderEmail, string recipientName, string recipientEmail, string text)
        {           
            var client = new RestClient("https://send.api.mailtrap.io/api");

            var args_ = new
            {
                from = new { email = senderEmail, name = senderName },
                to = new[] { new { email = recipientEmail, name = recipientName } },
                subject = "Awesome",
                text = text,
            };

            var request = new RestRequest("/send", RestSharp.Method.Post);

            request.AddHeader("Api-Token", "6c3c24289024661017339035acafb343");
            request.AddJsonBody(args_);

            RestResponse response = await client.ExecuteAsync(request);

            Console.WriteLine(response.Content);

            return response;
        }
    }
}
