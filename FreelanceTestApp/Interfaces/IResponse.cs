namespace FreelanceTestApp.Interfaces
{
    public interface IResponse
    {
        int StatusCode { get; set; }
        string Content { get; set; }
    }
}
