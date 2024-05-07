using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace FreelanceTestApp
{
    public class EmailOptions : IOptions
    {
        private readonly IConfiguration _configuration;            

        public string? BaseAdress { get; }
        public string? ApiToken { get; }

        public EmailOptions()
        {
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            BaseAdress = _configuration.GetSection("ApiSettings:baseAdress").Value;
            ApiToken = _configuration.GetSection("ApiSettings:apiToken").Value;
        }

        public string GetApiSettings(string settingsName)
        {            
            throw new NotImplementedException();
        }
    }
}
