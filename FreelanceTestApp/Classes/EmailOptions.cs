using FreelanceTestApp.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FreelanceTestApp.Classes
{
    public class EmailOptions : IOptions
    {
        private readonly IConfiguration _configuration;

        public string? SendEndpoint { get; }
        public string? ApiToken { get; }
        public string? BaseAdress { get; }

        public EmailOptions()
        {
            var dir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.ToString();
            _configuration = new ConfigurationBuilder().AddJsonFile(dir + "/appsettings.json").Build();

            BaseAdress = _configuration["ApiSettings:baseAdress"];
            SendEndpoint = _configuration["ApiSettings:sendEndpoint"];
            ApiToken = _configuration["ApiSettings:apiToken"];
        }

    }
}
