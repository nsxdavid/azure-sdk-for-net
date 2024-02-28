// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterUpdateIdentityCertificateContent : IUtf8JsonSerializable, IJsonModel<HDInsightClusterUpdateIdentityCertificateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterUpdateIdentityCertificateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightClusterUpdateIdentityCertificateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterUpdateIdentityCertificateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ApplicationId != null)
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Certificate != null)
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteStringValue(Certificate);
            }
            if (CertificatePassword != null)
            {
                writer.WritePropertyName("certificatePassword"u8);
                writer.WriteStringValue(CertificatePassword);
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

        HDInsightClusterUpdateIdentityCertificateContent IJsonModel<HDInsightClusterUpdateIdentityCertificateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterUpdateIdentityCertificateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterUpdateIdentityCertificateContent(document.RootElement, options);
        }

        internal static HDInsightClusterUpdateIdentityCertificateContent DeserializeHDInsightClusterUpdateIdentityCertificateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string applicationId = default;
            string certificate = default;
            string certificatePassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"u8))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightClusterUpdateIdentityCertificateContent(applicationId, certificate, certificatePassword, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterUpdateIdentityCertificateContent)} does not support '{options.Format}' format.");
            }
        }

        HDInsightClusterUpdateIdentityCertificateContent IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterUpdateIdentityCertificateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterUpdateIdentityCertificateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterUpdateIdentityCertificateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
