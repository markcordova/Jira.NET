using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class FieldInfo
    {
        [JsonProperty("clauseNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClauseNames { get; set; }

        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Custom { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("navigable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Navigable { get; set; }

        [JsonProperty("orderable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Orderable { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public JsonType Schema { get; set; }

        [JsonProperty("searchable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchable { get; set; }
    }
}
