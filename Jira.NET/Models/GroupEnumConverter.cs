using System;
using Newtonsoft.Json;

namespace Jira.NET.Models
{
    internal class GroupEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GroupEnum) || t == typeof(GroupEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "group":
                    return GroupEnum.Group;
                case "role":
                    return GroupEnum.Role;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GroupEnum)untypedValue;
            switch (value)
            {
                case GroupEnum.Group:
                    serializer.Serialize(writer, "group");
                    return;
                case GroupEnum.Role:
                    serializer.Serialize(writer, "role");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly GroupEnumConverter Singleton = new GroupEnumConverter();
    }
}
