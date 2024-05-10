using FreelanceTestApp.Classes;
using FreelanceTestApp.Validation;


var options = new EmailOptions();

var emailSender = new EmailSender(new MyRestClient(options.BaseAdress ?? ""), new MyRestResponse(), options);

var request = new MyRestRequest("/send", RestSharp.Method.Post);

request.SenderName = "Mailtrap";
request.SenderMail = "mailtrap@demomailtrap.com";
request.RecipientName = "Receiver";
request.RecipientMail = "rashid.aliyev96@gmail.com";
request.Subject = "Awesome";
request.Text = "Hi there ! I'm testing my Rest Email !";

RequestValidator validator = new RequestValidator();
var validationResult = validator.Validate(request);

if(validationResult.IsValid)
{
    await emailSender.Send(request);
}
else
{
    Console.WriteLine(validationResult.ToString("~"));
}
