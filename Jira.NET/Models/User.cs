using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Jira.NET.Models
{
    public partial class User
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("avatarUrls", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("timeZone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        [JsonProperty("applicationRoles", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleItemsListWrapper<Group> ApplicationRoles { get; set; }

        [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
        public string Expand { get; set; }

        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleItemsListWrapper<Group> Groups { get; set; }

        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   EmailAddress == user.EmailAddress;
        }

        public override int GetHashCode()
        {
            int hashCode = -2094331574;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmailAddress);            
            return hashCode;
        }
    }
}
