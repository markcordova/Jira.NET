using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class RoleActor
    {
        [JsonProperty("avatarUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
