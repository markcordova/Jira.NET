using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{

    public class SearchResults<T>
    {
        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<Issue<T>> Issues { get; set; }

        [JsonProperty("maxResults", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxResults { get; set; }

        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public SearchResultsNames Names { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public SearchResultsSchema Schema { get; set; }

        [JsonProperty("startAt", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartAt { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("warningMessages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WarningMessages { get; set; }
    }
}
