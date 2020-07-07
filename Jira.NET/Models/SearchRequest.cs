using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jira.NET.Models
{
    public class SearchRequest
    {
        [JsonProperty("jql")]
        public string Jql { get; set; }

        [JsonProperty("startAt", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartAt { get; set; } = null;

        [JsonProperty("maxResults", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxResults { get; set; } = null;

        [JsonProperty("validateQuery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateQuery { get; set; } = null;

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; } = new List<string>();

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Expand { get; set; } = new List<string>();

    }
}
