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
    internal partial class UnknownMonitoringInputDataBase : IUtf8JsonSerializable, IJsonModel<MonitoringInputDataBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringInputDataBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringInputDataBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringInputDataBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringInputDataBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Columns is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Columns != null)
                {
                    writer.WritePropertyName("columns"u8);
                    writer.WriteStartObject();
                    foreach (var item in Columns)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("columns");
                }
            }
            if (DataContext != null)
            {
                if (DataContext != null)
                {
                    writer.WritePropertyName("dataContext"u8);
                    writer.WriteStringValue(DataContext);
                }
                else
                {
                    writer.WriteNull("dataContext");
                }
            }
            writer.WritePropertyName("inputDataType"u8);
            writer.WriteStringValue(InputDataType.ToString());
            writer.WritePropertyName("jobInputType"u8);
            writer.WriteStringValue(JobInputType.ToString());
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
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

        MonitoringInputDataBase IJsonModel<MonitoringInputDataBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringInputDataBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringInputDataBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoringInputDataBase(document.RootElement, options);
        }

        internal static UnknownMonitoringInputDataBase DeserializeUnknownMonitoringInputDataBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> columns = default;
            Optional<string> dataContext = default;
            MonitoringInputDataType inputDataType = "Unknown";
            JobInputType jobInputType = default;
            Uri uri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        columns = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    columns = dictionary;
                    continue;
                }
                if (property.NameEquals("dataContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataContext = null;
                        continue;
                    }
                    dataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDataType"u8))
                {
                    inputDataType = new MonitoringInputDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobInputType"u8))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownMonitoringInputDataBase(columns ?? new ChangeTrackingDictionary<string, string>(), dataContext.Value, inputDataType, jobInputType, uri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoringInputDataBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringInputDataBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringInputDataBase)} does not support '{options.Format}' format.");
            }
        }

        MonitoringInputDataBase IPersistableModel<MonitoringInputDataBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringInputDataBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitoringInputDataBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoringInputDataBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringInputDataBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
