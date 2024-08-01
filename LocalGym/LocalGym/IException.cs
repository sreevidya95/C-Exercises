using System.Net;

namespace LocalGym
{
    public interface IException
    {
        public HttpStatusCode? statusCode { get; set; }
        public string? message { get; set; }
        public string toJson();
    }
}
