// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class ProximityPlacementGroupData : IUtf8JsonSerializable, IJsonModel<ProximityPlacementGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProximityPlacementGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProximityPlacementGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProximityPlacementGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProximityPlacementGroupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Zones is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
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
            if (ProximityPlacementGroupType.HasValue)
            {
                writer.WritePropertyName("proximityPlacementGroupType"u8);
                writer.WriteStringValue(ProximityPlacementGroupType.Value.ToString());
            }
            if (options.Format != "W" && !(VirtualMachines is ChangeTrackingList<ComputeSubResourceDataWithColocationStatus> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(VirtualMachineScaleSets is ChangeTrackingList<ComputeSubResourceDataWithColocationStatus> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("virtualMachineScaleSets"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachineScaleSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(AvailabilitySets is ChangeTrackingList<ComputeSubResourceDataWithColocationStatus> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("availabilitySets"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilitySets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ColocationStatus != null)
            {
                writer.WritePropertyName("colocationStatus"u8);
                writer.WriteObjectValue(ColocationStatus);
            }
            if (Intent != null)
            {
                writer.WritePropertyName("intent"u8);
                writer.WriteObjectValue(Intent);
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

        ProximityPlacementGroupData IJsonModel<ProximityPlacementGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProximityPlacementGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProximityPlacementGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProximityPlacementGroupData(document.RootElement, options);
        }

        internal static ProximityPlacementGroupData DeserializeProximityPlacementGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> zones = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ProximityPlacementGroupType? proximityPlacementGroupType = default;
            IReadOnlyList<ComputeSubResourceDataWithColocationStatus> virtualMachines = default;
            IReadOnlyList<ComputeSubResourceDataWithColocationStatus> virtualMachineScaleSets = default;
            IReadOnlyList<ComputeSubResourceDataWithColocationStatus> availabilitySets = default;
            InstanceViewStatus colocationStatus = default;
            ProximityPlacementGroupPropertiesIntent intent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                        if (property0.NameEquals("proximityPlacementGroupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroupType = new ProximityPlacementGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ComputeSubResourceDataWithColocationStatus> array = new List<ComputeSubResourceDataWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComputeSubResourceDataWithColocationStatus.DeserializeComputeSubResourceDataWithColocationStatus(item, options));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineScaleSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ComputeSubResourceDataWithColocationStatus> array = new List<ComputeSubResourceDataWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComputeSubResourceDataWithColocationStatus.DeserializeComputeSubResourceDataWithColocationStatus(item, options));
                            }
                            virtualMachineScaleSets = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilitySets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ComputeSubResourceDataWithColocationStatus> array = new List<ComputeSubResourceDataWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComputeSubResourceDataWithColocationStatus.DeserializeComputeSubResourceDataWithColocationStatus(item, options));
                            }
                            availabilitySets = array;
                            continue;
                        }
                        if (property0.NameEquals("colocationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            colocationStatus = InstanceViewStatus.DeserializeInstanceViewStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("intent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intent = ProximityPlacementGroupPropertiesIntent.DeserializeProximityPlacementGroupPropertiesIntent(property0.Value, options);
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
            return new ProximityPlacementGroupData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                zones ?? new ChangeTrackingList<string>(),
                proximityPlacementGroupType,
                virtualMachines ?? new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>(),
                virtualMachineScaleSets ?? new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>(),
                availabilitySets ?? new ChangeTrackingList<ComputeSubResourceDataWithColocationStatus>(),
                colocationStatus,
                intent,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProximityPlacementGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProximityPlacementGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProximityPlacementGroupData)} does not support '{options.Format}' format.");
            }
        }

        ProximityPlacementGroupData IPersistableModel<ProximityPlacementGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProximityPlacementGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProximityPlacementGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProximityPlacementGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProximityPlacementGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
