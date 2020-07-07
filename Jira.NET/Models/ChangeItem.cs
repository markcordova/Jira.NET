using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class ChangeItem
    {
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("fieldtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Fieldtype { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        [JsonProperty("fromString", NullValueHandling = NullValueHandling.Ignore)]
        public string FromString { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        [JsonProperty("toString", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeItemToString { get; set; }
    }
}
