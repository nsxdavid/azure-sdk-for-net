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
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBox
{
    public partial class DataBoxJobData : IUtf8JsonSerializable, IJsonModel<DataBoxJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxJobData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            if (options.Format != "W" && IsCancellable.HasValue)
            {
                writer.WritePropertyName("isCancellable"u8);
                writer.WriteBooleanValue(IsCancellable.Value);
            }
            if (options.Format != "W" && IsDeletable.HasValue)
            {
                writer.WritePropertyName("isDeletable"u8);
                writer.WriteBooleanValue(IsDeletable.Value);
            }
            if (options.Format != "W" && IsShippingAddressEditable.HasValue)
            {
                writer.WritePropertyName("isShippingAddressEditable"u8);
                writer.WriteBooleanValue(IsShippingAddressEditable.Value);
            }
            if (options.Format != "W" && ReverseShippingDetailsUpdate.HasValue)
            {
                writer.WritePropertyName("reverseShippingDetailsUpdate"u8);
                writer.WriteStringValue(ReverseShippingDetailsUpdate.Value.ToSerialString());
            }
            if (options.Format != "W" && ReverseTransportPreferenceUpdate.HasValue)
            {
                writer.WritePropertyName("reverseTransportPreferenceUpdate"u8);
                writer.WriteStringValue(ReverseTransportPreferenceUpdate.Value.ToSerialString());
            }
            if (options.Format != "W" && IsPrepareToShipEnabled.HasValue)
            {
                writer.WritePropertyName("isPrepareToShipEnabled"u8);
                writer.WriteBooleanValue(IsPrepareToShipEnabled.Value);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (Details != null)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details);
            }
            if (options.Format != "W" && CancellationReason != null)
            {
                writer.WritePropertyName("cancellationReason"u8);
                writer.WriteStringValue(CancellationReason);
            }
            if (DeliveryType.HasValue)
            {
                writer.WritePropertyName("deliveryType"u8);
                writer.WriteStringValue(DeliveryType.Value.ToSerialString());
            }
            if (DeliveryInfo != null)
            {
                writer.WritePropertyName("deliveryInfo"u8);
                writer.WriteObjectValue(DeliveryInfo);
            }
            if (options.Format != "W" && IsCancellableWithoutFee.HasValue)
            {
                writer.WritePropertyName("isCancellableWithoutFee"u8);
                writer.WriteBooleanValue(IsCancellableWithoutFee.Value);
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

        DataBoxJobData IJsonModel<DataBoxJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobData(document.RootElement, options);
        }

        internal static DataBoxJobData DeserializeDataBoxJobData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxSku sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            DataBoxJobTransferType transferType = default;
            Optional<bool> isCancellable = default;
            Optional<bool> isDeletable = default;
            Optional<bool> isShippingAddressEditable = default;
            Optional<ReverseShippingDetailsEditStatus> reverseShippingDetailsUpdate = default;
            Optional<ReverseTransportPreferenceEditStatus> reverseTransportPreferenceUpdate = default;
            Optional<bool> isPrepareToShipEnabled = default;
            Optional<DataBoxStageName> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<ResponseError> error = default;
            Optional<DataBoxBasicJobDetails> details = default;
            Optional<string> cancellationReason = default;
            Optional<JobDeliveryType> deliveryType = default;
            Optional<JobDeliveryInfo> deliveryInfo = default;
            Optional<bool> isCancellableWithoutFee = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DataBoxSku.DeserializeDataBoxSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("transferType"u8))
                        {
                            transferType = property0.Value.GetString().ToDataBoxJobTransferType();
                            continue;
                        }
                        if (property0.NameEquals("isCancellable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isDeletable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeletable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isShippingAddressEditable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isShippingAddressEditable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reverseShippingDetailsUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseShippingDetailsUpdate = property0.Value.GetString().ToReverseShippingDetailsEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("reverseTransportPreferenceUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseTransportPreferenceUpdate = property0.Value.GetString().ToReverseTransportPreferenceEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("isPrepareToShipEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrepareToShipEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DataBoxStageName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            details = DataBoxBasicJobDetails.DeserializeDataBoxBasicJobDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("cancellationReason"u8))
                        {
                            cancellationReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryType = property0.Value.GetString().ToJobDeliveryType();
                            continue;
                        }
                        if (property0.NameEquals("deliveryInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryInfo = JobDeliveryInfo.DeserializeJobDeliveryInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isCancellableWithoutFee"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellableWithoutFee = property0.Value.GetBoolean();
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
            return new DataBoxJobData(id, name, type, systemData.Value, tags ?? new ChangeTrackingDictionary<string, string>(), location, transferType, Optional.ToNullable(isCancellable), Optional.ToNullable(isDeletable), Optional.ToNullable(isShippingAddressEditable), Optional.ToNullable(reverseShippingDetailsUpdate), Optional.ToNullable(reverseTransportPreferenceUpdate), Optional.ToNullable(isPrepareToShipEnabled), Optional.ToNullable(status), Optional.ToNullable(startTime), error.Value, details.Value, cancellationReason.Value, Optional.ToNullable(deliveryType), deliveryInfo.Value, Optional.ToNullable(isCancellableWithoutFee), sku, identity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxJobData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobData)} does not support '{options.Format}' format.");
            }
        }

        DataBoxJobData IPersistableModel<DataBoxJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxJobData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
