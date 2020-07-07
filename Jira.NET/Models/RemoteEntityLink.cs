using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class RemoteEntityLink
    {
        [JsonProperty("link")]
        public object Link { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }
    }
}
