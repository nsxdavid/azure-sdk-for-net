// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ImageGenerationOptions : IUtf8JsonSerializable, IJsonModel<ImageGenerationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageGenerationOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageGenerationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DeploymentName != null)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(DeploymentName);
            }
            writer.WritePropertyName("prompt"u8);
            writer.WriteStringValue(Prompt);
            if (ImageCount.HasValue)
            {
                writer.WritePropertyName("n"u8);
                writer.WriteNumberValue(ImageCount.Value);
            }
            if (Size.HasValue)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size.Value.ToString());
            }
            if (ResponseFormat.HasValue)
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (Quality.HasValue)
            {
                writer.WritePropertyName("quality"u8);
                writer.WriteStringValue(Quality.Value.ToString());
            }
            if (Style.HasValue)
            {
                writer.WritePropertyName("style"u8);
                writer.WriteStringValue(Style.Value.ToString());
            }
            if (User != null)
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
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

        ImageGenerationOptions IJsonModel<ImageGenerationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageGenerationOptions(document.RootElement, options);
        }

        internal static ImageGenerationOptions DeserializeImageGenerationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string model = default;
            string prompt = default;
            int? n = default;
            ImageSize? size = default;
            ImageGenerationResponseFormat? responseFormat = default;
            ImageGenerationQuality? quality = default;
            ImageGenerationStyle? style = default;
            string user = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prompt"u8))
                {
                    prompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    n = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = new ImageSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseFormat = new ImageGenerationResponseFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("quality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quality = new ImageGenerationQuality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("style"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    style = new ImageGenerationStyle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageGenerationOptions(
                model,
                prompt,
                n,
                size,
                responseFormat,
                quality,
                style,
                user,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageGenerationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support '{options.Format}' format.");
            }
        }

        ImageGenerationOptions IPersistableModel<ImageGenerationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageGenerationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageGenerationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageGenerationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageGenerationOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
