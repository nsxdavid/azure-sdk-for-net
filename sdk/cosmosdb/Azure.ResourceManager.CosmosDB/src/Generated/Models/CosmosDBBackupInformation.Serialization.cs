// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBBackupInformation : IUtf8JsonSerializable, IJsonModel<CosmosDBBackupInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBBackupInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBBackupInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBackupInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBBackupInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ContinuousBackupInformation != null)
            {
                writer.WritePropertyName("continuousBackupInformation"u8);
                writer.WriteObjectValue(ContinuousBackupInformation);
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

        CosmosDBBackupInformation IJsonModel<CosmosDBBackupInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBackupInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBBackupInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBBackupInformation(document.RootElement, options);
        }

        internal static CosmosDBBackupInformation DeserializeCosmosDBBackupInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContinuousBackupInformation continuousBackupInformation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuousBackupInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuousBackupInformation = ContinuousBackupInformation.DeserializeContinuousBackupInformation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBBackupInformation(continuousBackupInformation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBBackupInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBackupInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBBackupInformation)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBBackupInformation IPersistableModel<CosmosDBBackupInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBackupInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBBackupInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBBackupInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBBackupInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
