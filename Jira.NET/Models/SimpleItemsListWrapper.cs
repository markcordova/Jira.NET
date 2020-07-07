using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class SimpleItemsListWrapper<T>
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<T> Items { get; set; }

        [JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxResults { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }
}
