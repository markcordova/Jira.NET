using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jira.NET.Models
{
    public partial class RenderedFields
    {
        [JsonExtensionData]
        public JObject AdditionalData { get; set; }
    }
}
