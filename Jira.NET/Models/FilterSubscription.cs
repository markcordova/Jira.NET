using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class FilterSubscription
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Group Group { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }
    }
}
