using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public partial class StatusCategory
    {
        [JsonProperty("colorName", NullValueHandling = NullValueHandling.Ignore)]
        public string ColorName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }
    }
}
