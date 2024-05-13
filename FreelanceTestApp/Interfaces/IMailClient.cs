namespace FreelanceTestApp.Interfaces
{
    public interface IMailClient
    {
        Task<IResponse> SendEmail(IRequest request);
    }
}
