// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class VirtualMachineInstancePropertiesOSProfileLinuxConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesOSProfileLinuxConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisablePasswordAuthentication.HasValue)
            {
                writer.WritePropertyName("disablePasswordAuthentication"u8);
                writer.WriteBooleanValue(DisablePasswordAuthentication.Value);
            }
            if (Ssh != null)
            {
                writer.WritePropertyName("ssh"u8);
                writer.WriteObjectValue(Ssh);
            }
            if (ProvisionVmAgent.HasValue)
            {
                writer.WritePropertyName("provisionVMAgent"u8);
                writer.WriteBooleanValue(ProvisionVmAgent.Value);
            }
            if (ProvisionVmConfigAgent.HasValue)
            {
                writer.WritePropertyName("provisionVMConfigAgent"u8);
                writer.WriteBooleanValue(ProvisionVmConfigAgent.Value);
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

        VirtualMachineInstancePropertiesOSProfileLinuxConfiguration IJsonModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesOSProfileLinuxConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesOSProfileLinuxConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesOSProfileLinuxConfiguration DeserializeVirtualMachineInstancePropertiesOSProfileLinuxConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? disablePasswordAuthentication = default;
            SshConfiguration ssh = default;
            bool? provisionVmAgent = default;
            bool? provisionVmConfigAgent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disablePasswordAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePasswordAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ssh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssh = SshConfiguration.DeserializeSshConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisionVMAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVmAgent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisionVMConfigAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVmConfigAgent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesOSProfileLinuxConfiguration(disablePasswordAuthentication, ssh, provisionVmAgent, provisionVmConfigAgent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesOSProfileLinuxConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesOSProfileLinuxConfiguration IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesOSProfileLinuxConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesOSProfileLinuxConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesOSProfileLinuxConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
