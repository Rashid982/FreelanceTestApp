namespace FreelanceTestApp.Interfaces
{
    public interface IOptions
    {
        public string? BaseAdress { get; }
        public string? SendEndpoint { get; }
        public string? ApiToken { get; }               
    }
}
