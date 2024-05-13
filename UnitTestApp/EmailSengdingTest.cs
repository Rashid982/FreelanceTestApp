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

            var client = new MailTrapClient(options);

            var emailSender = new EmailSender(client);

            var request = new MessageRequest()
            {
                SenderName = "Mailtrap",
                SenderMail = "mailtrap@demomailtrap.com",
                RecipientName = "Receiver",
                RecipientMail = "rashid.aliyev96@gmail.com",
                Subject = "Awesome",
                Text = "Hi there ! I'm testing my Rest Email !"
            };

            var response = await emailSender.SendEmail(request);

            //Act
            var result = response.StatusCode;


            //Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result);
        }
    }
}