using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Worklog
    {
        [JsonProperty("maxResults", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxResults { get; set; }

        [JsonProperty("startAt", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartAt { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("worklogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorklogElement> Worklogs { get; set; }
    }
}
