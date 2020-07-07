using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public class Watches 
    {

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("watchCount", NullValueHandling = NullValueHandling.Ignore)]
        public int WatchCount { get; set; }

        [JsonProperty("isWatching", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsWatching { get; set; }

    }

}
