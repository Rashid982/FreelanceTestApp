namespace FreelanceTestApp.Interfaces
{
    public interface IEmailSender
    {
        public Task<IResponse> Send(IRequest request);
    }
}
