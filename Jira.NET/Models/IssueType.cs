using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public partial class IssueType
    {
        [JsonProperty("avatarId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvatarId { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("subtask")]
        public bool Subtask { get; set; }
    }
}
