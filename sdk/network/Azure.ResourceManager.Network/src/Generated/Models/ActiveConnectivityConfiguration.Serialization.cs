// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ActiveConnectivityConfiguration : IUtf8JsonSerializable, IJsonModel<ActiveConnectivityConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActiveConnectivityConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ActiveConnectivityConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveConnectivityConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CommittedOn.HasValue)
            {
                writer.WritePropertyName("commitTime"u8);
                writer.WriteStringValue(CommittedOn.Value, "O");
            }
            if (Region.HasValue)
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region.Value);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (!(ConfigurationGroups is ChangeTrackingList<NetworkConfigurationGroup> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("configurationGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (ConnectivityTopology.HasValue)
            {
                writer.WritePropertyName("connectivityTopology"u8);
                writer.WriteStringValue(ConnectivityTopology.Value.ToString());
            }
            if (!(Hubs is ChangeTrackingList<ConnectivityHub> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("hubs"u8);
                writer.WriteStartArray();
                foreach (var item in Hubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsGlobal.HasValue)
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteStringValue(IsGlobal.Value.ToString());
            }
            if (!(AppliesToGroups is ChangeTrackingList<ConnectivityGroupItem> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("appliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AppliesToGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (DeleteExistingPeering.HasValue)
            {
                writer.WritePropertyName("deleteExistingPeering"u8);
                writer.WriteStringValue(DeleteExistingPeering.Value.ToString());
            }
            if (options.Format != "W" && ResourceGuid.HasValue)
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
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

        ActiveConnectivityConfiguration IJsonModel<ActiveConnectivityConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveConnectivityConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActiveConnectivityConfiguration(document.RootElement, options);
        }

        internal static ActiveConnectivityConfiguration DeserializeActiveConnectivityConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? commitTime = default;
            AzureLocation? region = default;
            string id = default;
            IReadOnlyList<NetworkConfigurationGroup> configurationGroups = default;
            string description = default;
            ConnectivityTopology? connectivityTopology = default;
            IReadOnlyList<ConnectivityHub> hubs = default;
            GlobalMeshSupportFlag? isGlobal = default;
            IReadOnlyList<ConnectivityGroupItem> appliesToGroups = default;
            NetworkProvisioningState? provisioningState = default;
            DeleteExistingPeering? deleteExistingPeering = default;
            Guid? resourceGuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item, options));
                    }
                    configurationGroups = array;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectivityTopology"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityTopology = new ConnectivityTopology(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityHub> array = new List<ConnectivityHub>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityHub.DeserializeConnectivityHub(item, options));
                            }
                            hubs = array;
                            continue;
                        }
                        if (property0.NameEquals("isGlobal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGlobal = new GlobalMeshSupportFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliesToGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectivityGroupItem> array = new List<ConnectivityGroupItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectivityGroupItem.DeserializeConnectivityGroupItem(item, options));
                            }
                            appliesToGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deleteExistingPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteExistingPeering = new DeleteExistingPeering(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
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
            return new ActiveConnectivityConfiguration(
                id,
                configurationGroups ?? new ChangeTrackingList<NetworkConfigurationGroup>(),
                description,
                connectivityTopology,
                hubs ?? new ChangeTrackingList<ConnectivityHub>(),
                isGlobal,
                appliesToGroups ?? new ChangeTrackingList<ConnectivityGroupItem>(),
                provisioningState,
                deleteExistingPeering,
                resourceGuid,
                serializedAdditionalRawData,
                commitTime,
                region);
        }

        BinaryData IPersistableModel<ActiveConnectivityConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ActiveConnectivityConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ActiveConnectivityConfiguration IPersistableModel<ActiveConnectivityConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveConnectivityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActiveConnectivityConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActiveConnectivityConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActiveConnectivityConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
