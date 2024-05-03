using FreelanceTestApp;


var emailSending = new EmailSending();

await emailSending.Send("Mailtrap", "mailtrap@demomailtrap.com", 
                        "Receiver", "rashid.aliyev96@gmail.com", 
                        "Hello to my freelance test app !");