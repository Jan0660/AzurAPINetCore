﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Newtonsoft.Json;

namespace Jan0660.AzurAPINet.Converters
{
    public class BossesConverter : JsonConverter<string[]>
    {
        public override string[] ReadJson(JsonReader reader, Type objectType, [AllowNull] string[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return new string[] { serializer.Deserialize<string>(reader) };
            }
            else
            {
                var a = serializer.Deserialize<string[]>(reader);
                return a;
            }
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] string[] value, JsonSerializer serializer)
        {
            throw new Exception("no");
        }

    }
}
