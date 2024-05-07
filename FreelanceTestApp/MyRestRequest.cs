using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceTestApp
{
    public class MyRestRequest : IRequest
    {
        private readonly RestRequest restRequest;
                
        public MyRestRequest(string endPoint, Method method)
        {
            restRequest = new RestRequest(endPoint, method);            
        }

        public void AddJsonBody<T>(T obj)  
        {
            restRequest.AddJsonBody<object>(obj);
        }
    }
}
