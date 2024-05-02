using FreelanceTestApp;


var emailSending = new EmailSending();

await emailSending.Send("Mailtrap", "mailtrap@demomailtrap.com", 
                        "Receiver", "rashid.aliyev96@gmail.com", 
                        "Hi there ! Hello to my freelance test app !");