using Newtonsoft.Json;

namespace Jira.NET.Models
{
    public partial class Properties
    {
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public PropertiesProperties PropertiesProperties { get; set; }
    }
}
