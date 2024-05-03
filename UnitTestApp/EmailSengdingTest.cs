using FreelanceTestApp;
using System.Net;

namespace UnitTestApp
{
    public class EmailSengdingTest
    {
        [Fact]
        public async Task Send_FromCertainEmail_AnyText_To_ReceiverEmail_ShouldReturnOkResult()
        {
            //Arrange
            var emailSender = new EmailSending();
            
            var response = await emailSender.Send("Mailtrap", "mailtrap@demomailtrap.com",
                                                  "Receiver", "rashid.aliyev96@gmail.com",
                                                  "Hello to my freelance test app !");

            //Act
            var result = response.StatusCode;


            //Assert
            Assert.Equal(HttpStatusCode.OK, result);
        }
    }
}