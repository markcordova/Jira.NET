﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class FilterSubscriptionBeanListWrapper
    {
        [JsonProperty("end-index")]
        public long EndIndex { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<FilterSubscription> Items { get; set; }

        [JsonProperty("max-results")]
        public long MaxResults { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("start-index")]
        public long StartIndex { get; set; }
    }
}
