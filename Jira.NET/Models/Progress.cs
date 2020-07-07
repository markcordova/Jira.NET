using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public class Progress
    {
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public decimal CurrentValue { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Total { get; set; }

    }

}
