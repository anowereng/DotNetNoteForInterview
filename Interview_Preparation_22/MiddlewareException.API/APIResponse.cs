using Newtonsoft.Json;

namespace MiddlewareException.API
{
    public class APIResponse
    {
        public object Data { get; set; }
        public string Message { get; set; }
        public string MessageType { get; set; }
        public int StatusCode { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
    public enum MessageType
    {
        Success =  1 ,
        Error = 2 
    }
}
