using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Visibility
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public GroupEnum? Type { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
