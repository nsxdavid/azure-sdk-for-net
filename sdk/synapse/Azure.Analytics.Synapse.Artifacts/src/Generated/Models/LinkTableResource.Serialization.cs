// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableResourceConverter))]
    public partial class LinkTableResource
    {
        internal static LinkTableResource DeserializeLinkTableResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            LinkTableRequestSource source = default;
            LinkTableRequestTarget target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = LinkTableRequestSource.DeserializeLinkTableRequestSource(property.Value);
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = LinkTableRequestTarget.DeserializeLinkTableRequestTarget(property.Value);
                    continue;
                }
            }
            return new LinkTableResource(id, name, source, target);
        }

        internal partial class LinkTableResourceConverter : JsonConverter<LinkTableResource>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableResource model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LinkTableResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableResource(document.RootElement);
            }
        }
    }
}
