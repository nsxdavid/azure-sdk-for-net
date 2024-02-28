// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudStorageApplianceData : IUtf8JsonSerializable, IJsonModel<NetworkCloudStorageApplianceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudStorageApplianceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudStorageApplianceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudStorageApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudStorageApplianceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("administratorCredentials"u8);
            writer.WriteObjectValue(AdministratorCredentials);
            if (options.Format != "W" && Capacity.HasValue)
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            if (options.Format != "W" && CapacityUsed.HasValue)
            {
                writer.WritePropertyName("capacityUsed"u8);
                writer.WriteNumberValue(CapacityUsed.Value);
            }
            if (options.Format != "W" && ClusterId != null)
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            if (options.Format != "W" && DetailedStatus.HasValue)
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && DetailedStatusMessage != null)
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (options.Format != "W" && ManagementIPv4Address != null)
            {
                writer.WritePropertyName("managementIpv4Address"u8);
                writer.WriteStringValue(ManagementIPv4Address.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("rackId"u8);
            writer.WriteStringValue(RackId);
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            if (options.Format != "W" && RemoteVendorManagementFeature.HasValue)
            {
                writer.WritePropertyName("remoteVendorManagementFeature"u8);
                writer.WriteStringValue(RemoteVendorManagementFeature.Value.ToString());
            }
            if (options.Format != "W" && RemoteVendorManagementStatus.HasValue)
            {
                writer.WritePropertyName("remoteVendorManagementStatus"u8);
                writer.WriteStringValue(RemoteVendorManagementStatus.Value.ToString());
            }
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            writer.WritePropertyName("storageApplianceSkuId"u8);
            writer.WriteStringValue(StorageApplianceSkuId);
            writer.WriteEndObject();
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

        NetworkCloudStorageApplianceData IJsonModel<NetworkCloudStorageApplianceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudStorageApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudStorageApplianceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudStorageApplianceData(document.RootElement, options);
        }

        internal static NetworkCloudStorageApplianceData DeserializeNetworkCloudStorageApplianceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            AdministrativeCredentials administratorCredentials = default;
            long? capacity = default;
            long? capacityUsed = default;
            ResourceIdentifier clusterId = default;
            StorageApplianceDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            IPAddress managementIPv4Address = default;
            StorageApplianceProvisioningState? provisioningState = default;
            ResourceIdentifier rackId = default;
            long rackSlot = default;
            RemoteVendorManagementFeature? remoteVendorManagementFeature = default;
            RemoteVendorManagementStatus? remoteVendorManagementStatus = default;
            string serialNumber = default;
            string storageApplianceSkuId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorCredentials"u8))
                        {
                            administratorCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("capacityUsed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityUsed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new StorageApplianceDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managementIpv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementIPv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageApplianceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackId"u8))
                        {
                            rackId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackSlot"u8))
                        {
                            rackSlot = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("remoteVendorManagementFeature"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVendorManagementFeature = new RemoteVendorManagementFeature(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("remoteVendorManagementStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVendorManagementStatus = new RemoteVendorManagementStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageApplianceSkuId"u8))
                        {
                            storageApplianceSkuId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudStorageApplianceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                administratorCredentials,
                capacity,
                capacityUsed,
                clusterId,
                detailedStatus,
                detailedStatusMessage,
                managementIPv4Address,
                provisioningState,
                rackId,
                rackSlot,
                remoteVendorManagementFeature,
                remoteVendorManagementStatus,
                serialNumber,
                storageApplianceSkuId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudStorageApplianceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudStorageApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudStorageApplianceData)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudStorageApplianceData IPersistableModel<NetworkCloudStorageApplianceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudStorageApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudStorageApplianceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudStorageApplianceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudStorageApplianceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
