using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jira.NET.Models
{
    public partial class SimpleValuesListWrapper<T>
    {
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<T> Values { get; set; }

        [JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxResults { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("isLast")]
        public bool IsLast { get; set; }
    }
}
