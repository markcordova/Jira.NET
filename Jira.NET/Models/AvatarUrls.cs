using Newtonsoft.Json;
using System;

namespace Jira.NET.Models
{
    public partial class AvatarUrls
    {
		[JsonProperty("48x48")]
		public Uri Avatar48x48 { get; set; }

		[JsonProperty("32x32")]
		public Uri Avatar32x32 { get; set; }

		[JsonProperty("24x24")]
		public Uri Avatar24x24 { get; set; }

		[JsonProperty("16x16")]
		public Uri Avatar16x16 { get; set; }

	}
}
