// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PrivateStorePlan : IUtf8JsonSerializable, IJsonModel<PrivateStorePlan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStorePlan>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateStorePlan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStorePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && SkuId != null)
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (options.Format != "W" && PlanId != null)
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (options.Format != "W" && PlanDisplayName != null)
            {
                writer.WritePropertyName("planDisplayName"u8);
                writer.WriteStringValue(PlanDisplayName);
            }
            if (Accessibility.HasValue)
            {
                writer.WritePropertyName("accessibility"u8);
                writer.WriteStringValue(Accessibility.Value.ToString());
            }
            if (options.Format != "W" && AltStackReference != null)
            {
                writer.WritePropertyName("altStackReference"u8);
                writer.WriteStringValue(AltStackReference);
            }
            if (options.Format != "W" && StackType != null)
            {
                writer.WritePropertyName("stackType"u8);
                writer.WriteStringValue(StackType);
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

        PrivateStorePlan IJsonModel<PrivateStorePlan>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStorePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStorePlan(document.RootElement, options);
        }

        internal static PrivateStorePlan DeserializePrivateStorePlan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string skuId = default;
            string planId = default;
            string planDisplayName = default;
            PrivateStorePlanAccessibility? accessibility = default;
            string altStackReference = default;
            string stackType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessibility = new PrivateStorePlanAccessibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("altStackReference"u8))
                {
                    altStackReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackType"u8))
                {
                    stackType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateStorePlan(
                skuId,
                planId,
                planDisplayName,
                accessibility,
                altStackReference,
                stackType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStorePlan>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStorePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{options.Format}' format.");
            }
        }

        PrivateStorePlan IPersistableModel<PrivateStorePlan>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStorePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateStorePlan(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateStorePlan>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
