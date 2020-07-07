using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Opsbar
    {
        [JsonProperty("linkGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinkGroup> LinkGroups { get; set; }
    }
}
