using FreelanceTestApp.Classes;
using System.Net;

namespace UnitTestApp
{
    public class EmailSengdingTest
    {
        [Fact]
        public async Task Send_FromCertainEmail_AnyText_To_ReceiverEmail_ShouldReturnOkResult()
        {
            //Arrange
            var options = new EmailOptions();

            var emailSender = new EmailSender(new MyRestClient(options.BaseAdress ?? ""), new MyRestResponse(), options);

            var request = new MyRestRequest("/send", RestSharp.Method.Post);

            request.SenderName = "Mailtrap";
            request.SenderMail = "mailtrap@demomailtrap.com";
            request.RecipientName = "Receiver";
            request.RecipientMail = "rashid.aliyev96@gmail.com";
            request.Subject = "Awesome";
            request.Text = "Hi there ! I'm testing my Rest Email !";

            var response = await emailSender.Send(request);

            //Act
            var result = response.StatusCode;


            //Assert
            Assert.Equal(HttpStatusCode.OK, result);
        }
    }
}