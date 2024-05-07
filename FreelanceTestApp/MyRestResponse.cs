using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public class MyRestResponse
    {
        public bool Success { get; set; }
        public Guid[] Message_Id { get; set; }
    }
}
