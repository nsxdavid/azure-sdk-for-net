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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionModernReservationRecommendation : IUtf8JsonSerializable, IJsonModel<ConsumptionModernReservationRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionModernReservationRecommendation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionModernReservationRecommendation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && !(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
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
            if (options.Format != "W" && LocationPropertiesLocation != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(LocationPropertiesLocation);
            }
            if (options.Format != "W" && LookBackPeriod.HasValue)
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteNumberValue(LookBackPeriod.Value);
            }
            if (options.Format != "W" && InstanceFlexibilityRatio.HasValue)
            {
                writer.WritePropertyName("instanceFlexibilityRatio"u8);
                writer.WriteNumberValue(InstanceFlexibilityRatio.Value);
            }
            if (options.Format != "W" && InstanceFlexibilityGroup != null)
            {
                writer.WritePropertyName("instanceFlexibilityGroup"u8);
                writer.WriteStringValue(InstanceFlexibilityGroup);
            }
            if (options.Format != "W" && NormalizedSize != null)
            {
                writer.WritePropertyName("normalizedSize"u8);
                writer.WriteStringValue(NormalizedSize);
            }
            if (options.Format != "W" && RecommendedQuantityNormalized.HasValue)
            {
                writer.WritePropertyName("recommendedQuantityNormalized"u8);
                writer.WriteNumberValue(RecommendedQuantityNormalized.Value);
            }
            if (options.Format != "W" && MeterId.HasValue)
            {
                writer.WritePropertyName("meterId"u8);
                writer.WriteStringValue(MeterId.Value);
            }
            if (options.Format != "W" && Term != null)
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term);
            }
            if (options.Format != "W" && CostWithNoReservedInstances != null)
            {
                writer.WritePropertyName("costWithNoReservedInstances"u8);
                writer.WriteObjectValue(CostWithNoReservedInstances);
            }
            if (options.Format != "W" && RecommendedQuantity.HasValue)
            {
                writer.WritePropertyName("recommendedQuantity"u8);
                writer.WriteNumberValue(RecommendedQuantity.Value);
            }
            if (options.Format != "W" && TotalCostWithReservedInstances != null)
            {
                writer.WritePropertyName("totalCostWithReservedInstances"u8);
                writer.WriteObjectValue(TotalCostWithReservedInstances);
            }
            if (options.Format != "W" && NetSavings != null)
            {
                writer.WritePropertyName("netSavings"u8);
                writer.WriteObjectValue(NetSavings);
            }
            if (options.Format != "W" && FirstUsageOn.HasValue)
            {
                writer.WritePropertyName("firstUsageDate"u8);
                writer.WriteStringValue(FirstUsageOn.Value, "O");
            }
            if (options.Format != "W" && Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && !(SkuProperties is ChangeTrackingList<ConsumptionSkuProperty> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("skuProperties"u8);
                writer.WriteStartArray();
                foreach (var item in SkuProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && SkuName != null)
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
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

        ConsumptionModernReservationRecommendation IJsonModel<ConsumptionModernReservationRecommendation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionModernReservationRecommendation(document.RootElement, options);
        }

        internal static ConsumptionModernReservationRecommendation DeserializeConsumptionModernReservationRecommendation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReservationRecommendationKind kind = default;
            Optional<ETag> etag = default;
            IReadOnlyDictionary<string, string> tags = default;
            Optional<AzureLocation> location = default;
            Optional<string> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> location0 = default;
            Optional<int> lookBackPeriod = default;
            Optional<float> instanceFlexibilityRatio = default;
            Optional<string> instanceFlexibilityGroup = default;
            Optional<string> normalizedSize = default;
            Optional<float> recommendedQuantityNormalized = default;
            Optional<Guid> meterId = default;
            Optional<string> term = default;
            Optional<ConsumptionAmount> costWithNoReservedInstances = default;
            Optional<decimal> recommendedQuantity = default;
            Optional<ConsumptionAmount> totalCostWithReservedInstances = default;
            Optional<ConsumptionAmount> netSavings = default;
            Optional<DateTimeOffset> firstUsageDate = default;
            Optional<string> scope = default;
            IReadOnlyList<ConsumptionSkuProperty> skuProperties = default;
            Optional<string> skuName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ReservationRecommendationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
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
                        if (property0.NameEquals("location"u8))
                        {
                            location0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lookBackPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lookBackPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibilityRatio"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceFlexibilityRatio = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibilityGroup"u8))
                        {
                            instanceFlexibilityGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("normalizedSize"u8))
                        {
                            normalizedSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendedQuantityNormalized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendedQuantityNormalized = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("meterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costWithNoReservedInstances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costWithNoReservedInstances = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("recommendedQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalCostWithReservedInstances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalCostWithReservedInstances = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("netSavings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            netSavings = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("firstUsageDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            firstUsageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConsumptionSkuProperty> array = new List<ConsumptionSkuProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConsumptionSkuProperty.DeserializeConsumptionSkuProperty(item, options));
                            }
                            skuProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("skuName"u8))
                        {
                            skuName = property0.Value.GetString();
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
            return new ConsumptionModernReservationRecommendation(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), tags ?? new ChangeTrackingDictionary<string, string>(), Optional.ToNullable(location), sku.Value, serializedAdditionalRawData, location0.Value, Optional.ToNullable(lookBackPeriod), Optional.ToNullable(instanceFlexibilityRatio), instanceFlexibilityGroup.Value, normalizedSize.Value, Optional.ToNullable(recommendedQuantityNormalized), Optional.ToNullable(meterId), term.Value, costWithNoReservedInstances.Value, Optional.ToNullable(recommendedQuantity), totalCostWithReservedInstances.Value, netSavings.Value, Optional.ToNullable(firstUsageDate), scope.Value, skuProperties ?? new ChangeTrackingList<ConsumptionSkuProperty>(), skuName.Value);
        }

        BinaryData IPersistableModel<ConsumptionModernReservationRecommendation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionModernReservationRecommendation IPersistableModel<ConsumptionModernReservationRecommendation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionModernReservationRecommendation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionModernReservationRecommendation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
