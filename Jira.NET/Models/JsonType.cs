using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class JsonType
    {
        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public string Custom { get; set; }

        [JsonProperty("customId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CustomId { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public string Items { get; set; }

        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
