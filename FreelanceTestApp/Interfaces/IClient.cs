namespace FreelanceTestApp.Interfaces
{
    public interface IClient
    {
        public void AddDefaultHeader(string name, string value);
        Task<object> ExecuteAsync(object request);
    }
}
