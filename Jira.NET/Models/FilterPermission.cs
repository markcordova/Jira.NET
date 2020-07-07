using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class FilterPermission
    {
        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Group Group { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Project Project { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectRole Role { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("view")]
        public bool View { get; set; }
    }
}
