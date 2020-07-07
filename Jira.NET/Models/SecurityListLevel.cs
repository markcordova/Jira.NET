using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class SecurityListLevel
    {
        [JsonProperty("levels", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityLevel> Levels { get; set; }
    }
}
