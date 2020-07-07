using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public partial class Status
    {
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

        [JsonProperty("statusCategory", NullValueHandling = NullValueHandling.Ignore)]
        public StatusCategory StatusCategory { get; set; }

        [JsonProperty("statusColor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusColor { get; set; }
    }
}
