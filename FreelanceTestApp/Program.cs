using FreelanceTestApp.Classes;
using FreelanceTestApp.Validation;

var options = new EmailOptions();

OptionsValidator optValidator = new OptionsValidator();
var optValResult = optValidator.Validate(options);

if (optValResult.IsValid)
{
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

    RequestValidator reqValidator = new RequestValidator();
    var reqValResult = reqValidator.Validate(request);

    if (reqValResult.IsValid)
    {
        var messageResponse = await emailSender.SendEmail(request);

        Console.WriteLine($"statusCode: {messageResponse.StatusCode} \r\nbody : {messageResponse.Content}");
    }
    else
    {
        Console.WriteLine(reqValResult.ToString("~"));
    }
}
else
Console.WriteLine(optValResult.ToString("~"));







