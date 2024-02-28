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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class HubVirtualNetworkConnectionData : IUtf8JsonSerializable, IJsonModel<HubVirtualNetworkConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HubVirtualNetworkConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HubVirtualNetworkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubVirtualNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubVirtualNetworkConnectionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RemoteVirtualNetwork != null)
            {
                writer.WritePropertyName("remoteVirtualNetwork"u8);
                JsonSerializer.Serialize(writer, RemoteVirtualNetwork);
            }
            if (AllowHubToRemoteVnetTransit.HasValue)
            {
                writer.WritePropertyName("allowHubToRemoteVnetTransit"u8);
                writer.WriteBooleanValue(AllowHubToRemoteVnetTransit.Value);
            }
            if (AllowRemoteVnetToUseHubVnetGateways.HasValue)
            {
                writer.WritePropertyName("allowRemoteVnetToUseHubVnetGateways"u8);
                writer.WriteBooleanValue(AllowRemoteVnetToUseHubVnetGateways.Value);
            }
            if (EnableInternetSecurity.HasValue)
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (RoutingConfiguration != null)
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        HubVirtualNetworkConnectionData IJsonModel<HubVirtualNetworkConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubVirtualNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubVirtualNetworkConnectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHubVirtualNetworkConnectionData(document.RootElement, options);
        }

        internal static HubVirtualNetworkConnectionData DeserializeHubVirtualNetworkConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            WritableSubResource remoteVirtualNetwork = default;
            bool? allowHubToRemoteVnetTransit = default;
            bool? allowRemoteVnetToUseHubVnetGateways = default;
            bool? enableInternetSecurity = default;
            RoutingConfiguration routingConfiguration = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("remoteVirtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVirtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("allowHubToRemoteVnetTransit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowHubToRemoteVnetTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowRemoteVnetToUseHubVnetGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowRemoteVnetToUseHubVnetGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value, options);
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
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HubVirtualNetworkConnectionData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                remoteVirtualNetwork,
                allowHubToRemoteVnetTransit,
                allowRemoteVnetToUseHubVnetGateways,
                enableInternetSecurity,
                routingConfiguration,
                provisioningState);
        }

        BinaryData IPersistableModel<HubVirtualNetworkConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubVirtualNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HubVirtualNetworkConnectionData)} does not support '{options.Format}' format.");
            }
        }

        HubVirtualNetworkConnectionData IPersistableModel<HubVirtualNetworkConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubVirtualNetworkConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHubVirtualNetworkConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HubVirtualNetworkConnectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HubVirtualNetworkConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
