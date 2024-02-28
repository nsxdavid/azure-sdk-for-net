// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowSourceConverter))]
    public partial class DataFlowSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SchemaLinkedService != null)
            {
                writer.WritePropertyName("schemaLinkedService"u8);
                writer.WriteObjectValue(SchemaLinkedService);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Dataset != null)
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteObjectValue(Dataset);
            }
            if (LinkedService != null)
            {
                writer.WritePropertyName("linkedService"u8);
                writer.WriteObjectValue(LinkedService);
            }
            if (Flowlet != null)
            {
                writer.WritePropertyName("flowlet"u8);
                writer.WriteObjectValue(Flowlet);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowSource DeserializeDataFlowSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference schemaLinkedService = default;
            string name = default;
            string description = default;
            DatasetReference dataset = default;
            LinkedServiceReference linkedService = default;
            DataFlowReference flowlet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataset = DatasetReference.DeserializeDatasetReference(property.Value);
                    continue;
                }
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("flowlet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowlet = DataFlowReference.DeserializeDataFlowReference(property.Value);
                    continue;
                }
            }
            return new DataFlowSource(
                name,
                description,
                dataset,
                linkedService,
                flowlet,
                schemaLinkedService);
        }

        internal partial class DataFlowSourceConverter : JsonConverter<DataFlowSource>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowSource(document.RootElement);
            }
        }
    }
}
