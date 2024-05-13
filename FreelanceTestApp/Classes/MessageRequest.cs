using FreelanceTestApp.Interfaces;

namespace FreelanceTestApp.Classes
{
    public class MessageRequest : IRequest
    {
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? RecipientName { get; set; }
        public string? RecipientMail { get; set; }
        public string? Text { get; set; }
        public string? Subject { get; set; }
    }
}
