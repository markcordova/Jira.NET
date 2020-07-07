using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class SimpleLink
    {
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        [JsonProperty("iconClass", NullValueHandling = NullValueHandling.Ignore)]
        public string IconClass { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("styleClass", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleClass { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }
    }
}
