using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class UserBeanListWrapper
    {
        [JsonProperty("end-index")]
        public long EndIndex { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<User> Items { get; set; }

        [JsonProperty("max-results")]
        public long MaxResults { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("start-index")]
        public long StartIndex { get; set; }
    }
}
