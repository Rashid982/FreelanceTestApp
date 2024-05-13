namespace FreelanceTestApp.Interfaces
{
    public interface IEmailSender
    {
        public Task<IResponse> SendEmail(IRequest request);
    }
}
