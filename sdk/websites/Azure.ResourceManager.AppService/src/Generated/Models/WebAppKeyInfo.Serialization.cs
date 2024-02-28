// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppKeyInfo : IUtf8JsonSerializable, IJsonModel<WebAppKeyInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppKeyInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppKeyInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppKeyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppKeyInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
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

        WebAppKeyInfo IJsonModel<WebAppKeyInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppKeyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppKeyInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppKeyInfo(document.RootElement, options);
        }

        internal static WebAppKeyInfo DeserializeWebAppKeyInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebAppKeyInfoProperties properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = WebAppKeyInfoProperties.DeserializeWebAppKeyInfoProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppKeyInfo(properties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppKeyInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppKeyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppKeyInfo)} does not support '{options.Format}' format.");
            }
        }

        WebAppKeyInfo IPersistableModel<WebAppKeyInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppKeyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppKeyInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppKeyInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppKeyInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
