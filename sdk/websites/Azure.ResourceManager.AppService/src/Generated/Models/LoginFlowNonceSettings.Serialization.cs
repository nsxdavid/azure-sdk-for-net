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
    public partial class LoginFlowNonceSettings : IUtf8JsonSerializable, IJsonModel<LoginFlowNonceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoginFlowNonceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoginFlowNonceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoginFlowNonceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoginFlowNonceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ValidateNonce.HasValue)
            {
                writer.WritePropertyName("validateNonce"u8);
                writer.WriteBooleanValue(ValidateNonce.Value);
            }
            if (NonceExpirationInterval != null)
            {
                writer.WritePropertyName("nonceExpirationInterval"u8);
                writer.WriteStringValue(NonceExpirationInterval);
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

        LoginFlowNonceSettings IJsonModel<LoginFlowNonceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoginFlowNonceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoginFlowNonceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoginFlowNonceSettings(document.RootElement, options);
        }

        internal static LoginFlowNonceSettings DeserializeLoginFlowNonceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? validateNonce = default;
            string nonceExpirationInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateNonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateNonce = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nonceExpirationInterval"u8))
                {
                    nonceExpirationInterval = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoginFlowNonceSettings(validateNonce, nonceExpirationInterval, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoginFlowNonceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoginFlowNonceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoginFlowNonceSettings)} does not support '{options.Format}' format.");
            }
        }

        LoginFlowNonceSettings IPersistableModel<LoginFlowNonceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoginFlowNonceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoginFlowNonceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoginFlowNonceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoginFlowNonceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
