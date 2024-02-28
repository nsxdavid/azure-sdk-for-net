// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class ImportSourceProperties : IUtf8JsonSerializable, IJsonModel<ImportSourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportSourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportSourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportSourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportSourceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StorageType.HasValue)
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (StorageUri != null)
            {
                writer.WritePropertyName("storageUrl"u8);
                writer.WriteStringValue(StorageUri.AbsoluteUri);
            }
            if (SasToken != null)
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteStringValue(SasToken);
            }
            if (DataDirPath != null)
            {
                writer.WritePropertyName("dataDirPath"u8);
                writer.WriteStringValue(DataDirPath);
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

        ImportSourceProperties IJsonModel<ImportSourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportSourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportSourceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportSourceProperties(document.RootElement, options);
        }

        internal static ImportSourceProperties DeserializeImportSourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImportSourceStorageType? storageType = default;
            Uri storageUrl = default;
            string sasToken = default;
            string dataDirPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new ImportSourceStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDirPath"u8))
                {
                    dataDirPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportSourceProperties(storageType, storageUrl, sasToken, dataDirPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportSourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportSourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportSourceProperties)} does not support '{options.Format}' format.");
            }
        }

        ImportSourceProperties IPersistableModel<ImportSourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportSourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportSourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportSourceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportSourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
