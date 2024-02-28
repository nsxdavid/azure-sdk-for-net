// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArmResourceDefinitionResourceElementTemplateDetails : IUtf8JsonSerializable, IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Configuration != null)
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceElementType.ToString());
            if (DependsOnProfile != null)
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
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

        ArmResourceDefinitionResourceElementTemplateDetails IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmResourceDefinitionResourceElementTemplateDetails(document.RootElement, options);
        }

        internal static ArmResourceDefinitionResourceElementTemplateDetails DeserializeArmResourceDefinitionResourceElementTemplateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmResourceDefinitionResourceElementTemplate configuration = default;
            string name = default;
            Type type = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ArmResourceDefinitionResourceElementTemplate.DeserializeArmResourceDefinitionResourceElementTemplate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Type(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmResourceDefinitionResourceElementTemplateDetails(name, type, dependsOnProfile, serializedAdditionalRawData, configuration);
        }

        BinaryData IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support '{options.Format}' format.");
            }
        }

        ArmResourceDefinitionResourceElementTemplateDetails IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmResourceDefinitionResourceElementTemplateDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
