// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    public partial class JobRunData : IUtf8JsonSerializable, IJsonModel<JobRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobRunData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && ScanStatus.HasValue)
            {
                writer.WritePropertyName("scanStatus"u8);
                writer.WriteStringValue(ScanStatus.Value.ToString());
            }
            if (options.Format != "W" && AgentName != null)
            {
                writer.WritePropertyName("agentName"u8);
                writer.WriteStringValue(AgentName);
            }
            if (options.Format != "W" && AgentResourceId != null)
            {
                writer.WritePropertyName("agentResourceId"u8);
                writer.WriteStringValue(AgentResourceId);
            }
            if (options.Format != "W" && ExecutionStartOn.HasValue)
            {
                writer.WritePropertyName("executionStartTime"u8);
                writer.WriteStringValue(ExecutionStartOn.Value, "O");
            }
            if (options.Format != "W" && ExecutionEndOn.HasValue)
            {
                writer.WritePropertyName("executionEndTime"u8);
                writer.WriteStringValue(ExecutionEndOn.Value, "O");
            }
            if (options.Format != "W" && LastStatusUpdate.HasValue)
            {
                writer.WritePropertyName("lastStatusUpdate"u8);
                writer.WriteStringValue(LastStatusUpdate.Value, "O");
            }
            if (options.Format != "W" && ItemsScanned.HasValue)
            {
                writer.WritePropertyName("itemsScanned"u8);
                writer.WriteNumberValue(ItemsScanned.Value);
            }
            if (options.Format != "W" && ItemsExcluded.HasValue)
            {
                writer.WritePropertyName("itemsExcluded"u8);
                writer.WriteNumberValue(ItemsExcluded.Value);
            }
            if (options.Format != "W" && ItemsUnsupported.HasValue)
            {
                writer.WritePropertyName("itemsUnsupported"u8);
                writer.WriteNumberValue(ItemsUnsupported.Value);
            }
            if (options.Format != "W" && ItemsNoTransferNeeded.HasValue)
            {
                writer.WritePropertyName("itemsNoTransferNeeded"u8);
                writer.WriteNumberValue(ItemsNoTransferNeeded.Value);
            }
            if (options.Format != "W" && ItemsFailed.HasValue)
            {
                writer.WritePropertyName("itemsFailed"u8);
                writer.WriteNumberValue(ItemsFailed.Value);
            }
            if (options.Format != "W" && ItemsTransferred.HasValue)
            {
                writer.WritePropertyName("itemsTransferred"u8);
                writer.WriteNumberValue(ItemsTransferred.Value);
            }
            if (options.Format != "W" && BytesScanned.HasValue)
            {
                writer.WritePropertyName("bytesScanned"u8);
                writer.WriteNumberValue(BytesScanned.Value);
            }
            if (options.Format != "W" && BytesExcluded.HasValue)
            {
                writer.WritePropertyName("bytesExcluded"u8);
                writer.WriteNumberValue(BytesExcluded.Value);
            }
            if (options.Format != "W" && BytesUnsupported.HasValue)
            {
                writer.WritePropertyName("bytesUnsupported"u8);
                writer.WriteNumberValue(BytesUnsupported.Value);
            }
            if (options.Format != "W" && BytesNoTransferNeeded.HasValue)
            {
                writer.WritePropertyName("bytesNoTransferNeeded"u8);
                writer.WriteNumberValue(BytesNoTransferNeeded.Value);
            }
            if (options.Format != "W" && BytesFailed.HasValue)
            {
                writer.WritePropertyName("bytesFailed"u8);
                writer.WriteNumberValue(BytesFailed.Value);
            }
            if (options.Format != "W" && BytesTransferred.HasValue)
            {
                writer.WritePropertyName("bytesTransferred"u8);
                writer.WriteNumberValue(BytesTransferred.Value);
            }
            if (options.Format != "W" && SourceName != null)
            {
                writer.WritePropertyName("sourceName"u8);
                writer.WriteStringValue(SourceName);
            }
            if (options.Format != "W" && SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (options.Format != "W" && SourceProperties != null)
            {
                writer.WritePropertyName("sourceProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(SourceProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && TargetName != null)
            {
                writer.WritePropertyName("targetName"u8);
                writer.WriteStringValue(TargetName);
            }
            if (options.Format != "W" && TargetResourceId != null)
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (options.Format != "W" && TargetProperties != null)
            {
                writer.WritePropertyName("targetProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TargetProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(TargetProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && JobDefinitionProperties != null)
            {
                writer.WritePropertyName("jobDefinitionProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(JobDefinitionProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(JobDefinitionProperties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        JobRunData IJsonModel<JobRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobRunData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobRunData(document.RootElement, options);
        }

        internal static JobRunData DeserializeJobRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            JobRunStatus? status = default;
            JobRunScanStatus? scanStatus = default;
            string agentName = default;
            ResourceIdentifier agentResourceId = default;
            DateTimeOffset? executionStartTime = default;
            DateTimeOffset? executionEndTime = default;
            DateTimeOffset? lastStatusUpdate = default;
            long? itemsScanned = default;
            long? itemsExcluded = default;
            long? itemsUnsupported = default;
            long? itemsNoTransferNeeded = default;
            long? itemsFailed = default;
            long? itemsTransferred = default;
            long? bytesScanned = default;
            long? bytesExcluded = default;
            long? bytesUnsupported = default;
            long? bytesNoTransferNeeded = default;
            long? bytesFailed = default;
            long? bytesTransferred = default;
            string sourceName = default;
            ResourceIdentifier sourceResourceId = default;
            BinaryData sourceProperties = default;
            string targetName = default;
            ResourceIdentifier targetResourceId = default;
            BinaryData targetProperties = default;
            BinaryData jobDefinitionProperties = default;
            JobRunError error = default;
            StorageMoverProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new JobRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scanStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scanStatus = new JobRunScanStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentName"u8))
                        {
                            agentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("executionStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("executionEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastStatusUpdate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("itemsScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sourceName"u8))
                        {
                            sourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("targetName"u8))
                        {
                            targetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jobDefinitionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobDefinitionProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JobRunError.DeserializeJobRunError(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageMoverProvisioningState(property0.Value.GetString());
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
            return new JobRunData(
                id,
                name,
                type,
                systemData,
                status,
                scanStatus,
                agentName,
                agentResourceId,
                executionStartTime,
                executionEndTime,
                lastStatusUpdate,
                itemsScanned,
                itemsExcluded,
                itemsUnsupported,
                itemsNoTransferNeeded,
                itemsFailed,
                itemsTransferred,
                bytesScanned,
                bytesExcluded,
                bytesUnsupported,
                bytesNoTransferNeeded,
                bytesFailed,
                bytesTransferred,
                sourceName,
                sourceResourceId,
                sourceProperties,
                targetName,
                targetResourceId,
                targetProperties,
                jobDefinitionProperties,
                error,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JobRunData)} does not support '{options.Format}' format.");
            }
        }

        JobRunData IPersistableModel<JobRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobRunData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
