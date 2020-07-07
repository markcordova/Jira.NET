using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class ChangeHistory
    {
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public User Author { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("historyMetadata", NullValueHandling = NullValueHandling.Ignore)]
        public HistoryMetadata HistoryMetadata { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChangeItem> Items { get; set; }
    }
}
