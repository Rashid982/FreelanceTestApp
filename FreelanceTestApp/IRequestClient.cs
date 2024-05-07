using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public interface IRequestClient
    {
        public void AddDefaultHeader(string name, string value);
        Task<object> ExecuteAsync(object request);
    }
}
