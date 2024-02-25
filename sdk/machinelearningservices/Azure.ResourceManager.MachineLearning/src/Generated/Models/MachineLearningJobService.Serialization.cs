// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningJobService : IUtf8JsonSerializable, IJsonModel<MachineLearningJobService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Endpoint != null)
            {
                if (Endpoint != null)
                {
                    writer.WritePropertyName("endpoint"u8);
                    writer.WriteStringValue(Endpoint);
                }
                else
                {
                    writer.WriteNull("endpoint");
                }
            }
            if (options.Format != "W" && ErrorMessage != null)
            {
                if (ErrorMessage != null)
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
                }
                else
                {
                    writer.WriteNull("errorMessage");
                }
            }
            if (JobServiceType != null)
            {
                if (JobServiceType != null)
                {
                    writer.WritePropertyName("jobServiceType"u8);
                    writer.WriteStringValue(JobServiceType);
                }
                else
                {
                    writer.WriteNull("jobServiceType");
                }
            }
            if (Nodes != null)
            {
                if (Nodes != null)
                {
                    writer.WritePropertyName("nodes"u8);
                    writer.WriteObjectValue(Nodes);
                }
                else
                {
                    writer.WriteNull("nodes");
                }
            }
            if (Port.HasValue)
            {
                if (Port != null)
                {
                    writer.WritePropertyName("port"u8);
                    writer.WriteNumberValue(Port.Value);
                }
                else
                {
                    writer.WriteNull("port");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (options.Format != "W" && Status != null)
            {
                if (Status != null)
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
                else
                {
                    writer.WriteNull("status");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningJobService IJsonModel<MachineLearningJobService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobService(document.RootElement, options);
        }

        internal static MachineLearningJobService DeserializeMachineLearningJobService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> endpoint = default;
            Optional<string> errorMessage = default;
            Optional<string> jobServiceType = default;
            Optional<JobNodes> nodes = default;
            Optional<int?> port = default;
            IDictionary<string, string> properties = default;
            Optional<string> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorMessage = null;
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobServiceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobServiceType = null;
                        continue;
                    }
                    jobServiceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodes = null;
                        continue;
                    }
                    nodes = JobNodes.DeserializeJobNodes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        port = null;
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningJobService(endpoint.Value, errorMessage.Value, jobServiceType.Value, nodes.Value, Optional.ToNullable(port), properties ?? new ChangeTrackingDictionary<string, string>(), status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningJobService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobService)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningJobService IPersistableModel<MachineLearningJobService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
