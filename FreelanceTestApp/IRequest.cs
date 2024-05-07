using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public interface IRequest
    {
        void AddJsonBody<T>(T obj);
    }
}
