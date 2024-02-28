// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds : IUtf8JsonSerializable, IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Min.HasValue)
            {
                writer.WritePropertyName("min"u8);
                writer.WriteNumberValue(Min.Value);
            }
            if (Max.HasValue)
            {
                writer.WritePropertyName("max"u8);
                writer.WriteNumberValue(Max.Value);
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

        ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds IJsonModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(document.RootElement, options);
        }

        internal static ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? min = default;
            int? max = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("min"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    min = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("max"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    max = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(min, max, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds)} does not support '{options.Format}' format.");
            }
        }

        ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
