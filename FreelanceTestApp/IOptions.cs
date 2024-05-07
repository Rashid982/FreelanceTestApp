using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public interface IOptions
    {
        public string? BaseAdress { get; }
        public string? ApiToken { get;  }
              

        string GetApiSettings(string settingsName);
    }
}
