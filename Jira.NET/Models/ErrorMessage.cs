using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public class ErrorMessage
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("status-code", NullValueHandling = NullValueHandling.Ignore)]
        public int StatusCode { get; set; }

    }
}
