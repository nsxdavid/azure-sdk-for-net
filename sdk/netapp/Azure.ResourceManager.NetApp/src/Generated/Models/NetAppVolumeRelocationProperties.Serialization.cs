// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeRelocationProperties : IUtf8JsonSerializable, IJsonModel<NetAppVolumeRelocationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeRelocationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumeRelocationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeRelocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeRelocationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsRelocationRequested.HasValue)
            {
                writer.WritePropertyName("relocationRequested"u8);
                writer.WriteBooleanValue(IsRelocationRequested.Value);
            }
            if (options.Format != "W" && IsReadyToBeFinalized.HasValue)
            {
                writer.WritePropertyName("readyToBeFinalized"u8);
                writer.WriteBooleanValue(IsReadyToBeFinalized.Value);
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

        NetAppVolumeRelocationProperties IJsonModel<NetAppVolumeRelocationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeRelocationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeRelocationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeRelocationProperties(document.RootElement, options);
        }

        internal static NetAppVolumeRelocationProperties DeserializeNetAppVolumeRelocationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? relocationRequested = default;
            bool? readyToBeFinalized = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relocationRequested"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relocationRequested = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readyToBeFinalized"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readyToBeFinalized = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeRelocationProperties(relocationRequested, readyToBeFinalized, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeRelocationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeRelocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeRelocationProperties)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumeRelocationProperties IPersistableModel<NetAppVolumeRelocationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeRelocationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumeRelocationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeRelocationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeRelocationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
