// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class MetricsResponse : IUtf8JsonSerializable, IJsonModel<MetricsResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricsResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricsResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DateTimeBegin.HasValue)
            {
                writer.WritePropertyName("dateTimeBegin"u8);
                writer.WriteStringValue(DateTimeBegin.Value, "O");
            }
            if (DateTimeEnd.HasValue)
            {
                writer.WritePropertyName("dateTimeEnd"u8);
                writer.WriteStringValue(DateTimeEnd.Value, "O");
            }
            if (Granularity.HasValue)
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (!(Series is ChangeTrackingList<MetricsResponseSeriesItem> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("series"u8);
                writer.WriteStartArray();
                foreach (var item in Series)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MetricsResponse IJsonModel<MetricsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricsResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricsResponse(document.RootElement, options);
        }

        internal static MetricsResponse DeserializeMetricsResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dateTimeBegin = default;
            DateTimeOffset? dateTimeEnd = default;
            MetricsResponseGranularity? granularity = default;
            IReadOnlyList<MetricsResponseSeriesItem> series = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeBegin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dateTimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new MetricsResponseGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("series"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsResponseSeriesItem> array = new List<MetricsResponseSeriesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsResponseSeriesItem.DeserializeMetricsResponseSeriesItem(item, options));
                    }
                    series = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricsResponse(dateTimeBegin, dateTimeEnd, granularity, series ?? new ChangeTrackingList<MetricsResponseSeriesItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricsResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricsResponse)} does not support '{options.Format}' format.");
            }
        }

        MetricsResponse IPersistableModel<MetricsResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricsResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
