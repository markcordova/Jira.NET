using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class EntityProperty
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
