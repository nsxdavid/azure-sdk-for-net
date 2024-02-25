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
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    public partial class StorageCacheData : IUtf8JsonSerializable, IJsonModel<StorageCacheData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
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
            if (CacheSizeGB.HasValue)
            {
                writer.WritePropertyName("cacheSizeGB"u8);
                writer.WriteNumberValue(CacheSizeGB.Value);
            }
            if (options.Format != "W" && Health != null)
            {
                writer.WritePropertyName("health"u8);
                writer.WriteObjectValue(Health);
            }
            if (options.Format != "W" && !(MountAddresses is ChangeTrackingList<IPAddress> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("mountAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in MountAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
            }
            if (options.Format != "W" && UpgradeStatus != null)
            {
                writer.WritePropertyName("upgradeStatus"u8);
                writer.WriteObjectValue(UpgradeStatus);
            }
            if (UpgradeSettings != null)
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (NetworkSettings != null)
            {
                writer.WritePropertyName("networkSettings"u8);
                writer.WriteObjectValue(NetworkSettings);
            }
            if (EncryptionSettings != null)
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteObjectValue(EncryptionSettings);
            }
            if (SecuritySettings != null)
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
            }
            if (DirectoryServicesSettings != null)
            {
                writer.WritePropertyName("directoryServicesSettings"u8);
                writer.WriteObjectValue(DirectoryServicesSettings);
            }
            if (!(Zones is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(PrimingJobs is ChangeTrackingList<PrimingJob> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("primingJobs"u8);
                writer.WriteStartArray();
                foreach (var item in PrimingJobs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SpaceAllocation is ChangeTrackingList<StorageTargetSpaceAllocation> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("spaceAllocation"u8);
                writer.WriteStartArray();
                foreach (var item in SpaceAllocation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        StorageCacheData IJsonModel<StorageCacheData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheData(document.RootElement, options);
        }

        internal static StorageCacheData DeserializeStorageCacheData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<StorageCacheSkuInfo> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> cacheSizeGB = default;
            Optional<StorageCacheHealth> health = default;
            IReadOnlyList<IPAddress> mountAddresses = default;
            Optional<StorageCacheProvisioningStateType> provisioningState = default;
            Optional<ResourceIdentifier> subnet = default;
            Optional<StorageCacheUpgradeStatus> upgradeStatus = default;
            Optional<StorageCacheUpgradeSettings> upgradeSettings = default;
            Optional<StorageCacheNetworkSettings> networkSettings = default;
            Optional<StorageCacheEncryptionSettings> encryptionSettings = default;
            Optional<StorageCacheSecuritySettings> securitySettings = default;
            Optional<StorageCacheDirectorySettings> directoryServicesSettings = default;
            IList<string> zones = default;
            IReadOnlyList<PrimingJob> primingJobs = default;
            IReadOnlyList<StorageTargetSpaceAllocation> spaceAllocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuInfo.DeserializeStorageCacheSkuInfo(property.Value, options);
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
                        if (property0.NameEquals("cacheSizeGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cacheSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("health"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            health = StorageCacheHealth.DeserializeStorageCacheHealth(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("mountAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            mountAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageCacheProvisioningStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgradeStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeStatus = StorageCacheUpgradeStatus.DeserializeStorageCacheUpgradeStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeSettings = StorageCacheUpgradeSettings.DeserializeStorageCacheUpgradeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSettings = StorageCacheNetworkSettings.DeserializeStorageCacheNetworkSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionSettings = StorageCacheEncryptionSettings.DeserializeStorageCacheEncryptionSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securitySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securitySettings = StorageCacheSecuritySettings.DeserializeStorageCacheSecuritySettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("directoryServicesSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            directoryServicesSettings = StorageCacheDirectorySettings.DeserializeStorageCacheDirectorySettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("zones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            zones = array;
                            continue;
                        }
                        if (property0.NameEquals("primingJobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrimingJob> array = new List<PrimingJob>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrimingJob.DeserializePrimingJob(item, options));
                            }
                            primingJobs = array;
                            continue;
                        }
                        if (property0.NameEquals("spaceAllocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StorageTargetSpaceAllocation> array = new List<StorageTargetSpaceAllocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageTargetSpaceAllocation.DeserializeStorageTargetSpaceAllocation(item, options));
                            }
                            spaceAllocation = array;
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
            return new StorageCacheData(id, name, type, systemData.Value, tags ?? new ChangeTrackingDictionary<string, string>(), location, identity, sku.Value, Optional.ToNullable(cacheSizeGB), health.Value, mountAddresses ?? new ChangeTrackingList<IPAddress>(), Optional.ToNullable(provisioningState), subnet.Value, upgradeStatus.Value, upgradeSettings.Value, networkSettings.Value, encryptionSettings.Value, securitySettings.Value, directoryServicesSettings.Value, zones ?? new ChangeTrackingList<string>(), primingJobs ?? new ChangeTrackingList<PrimingJob>(), spaceAllocation ?? new ChangeTrackingList<StorageTargetSpaceAllocation>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheData)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheData IPersistableModel<StorageCacheData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
