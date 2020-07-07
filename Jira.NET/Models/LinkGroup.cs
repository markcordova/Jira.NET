using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class LinkGroup
    {
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinkGroup> Groups { get; set; }

        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleLink Header { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<SimpleLink> Links { get; set; }

        [JsonProperty("styleClass", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleClass { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }
    }
}
