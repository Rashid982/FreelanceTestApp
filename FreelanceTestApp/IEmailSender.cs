using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public interface IEmailSender
    {
        public Task<MyRestResponse> Send(EmailRequest emailRequest);
    }
}
