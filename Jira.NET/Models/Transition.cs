using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Transition
    {
        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public TransitionFields Fields { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public Status To { get; set; }
    }
}
