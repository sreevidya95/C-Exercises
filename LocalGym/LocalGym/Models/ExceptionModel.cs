using Newtonsoft.Json;
using System.Net;

namespace LocalGym.Models
{
    public  class ExceptionModel : Exception, IException
    {
        public  HttpStatusCode? statusCode { get; set; }
        public string? message { get; set; }

        public  string toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
