// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    public partial class ApplianceClusterUserKeysResult : IUtf8JsonSerializable, IJsonModel<ApplianceClusterUserKeysResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplianceClusterUserKeysResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplianceClusterUserKeysResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceClusterUserKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceClusterUserKeysResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(ArtifactProfiles is ChangeTrackingDictionary<string, ApplianceArtifactProfile> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("artifactProfiles"u8);
                writer.WriteStartObject();
                foreach (var item in ArtifactProfiles)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && !(Kubeconfigs is ChangeTrackingList<ApplianceCredentialKubeconfig> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("kubeconfigs"u8);
                writer.WriteStartArray();
                foreach (var item in Kubeconfigs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SshKeys is ChangeTrackingDictionary<string, ApplianceSshKey> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sshKeys"u8);
                writer.WriteStartObject();
                foreach (var item in SshKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ApplianceClusterUserKeysResult IJsonModel<ApplianceClusterUserKeysResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceClusterUserKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceClusterUserKeysResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplianceClusterUserKeysResult(document.RootElement, options);
        }

        internal static ApplianceClusterUserKeysResult DeserializeApplianceClusterUserKeysResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, ApplianceArtifactProfile> artifactProfiles = default;
            IReadOnlyList<ApplianceCredentialKubeconfig> kubeconfigs = default;
            IReadOnlyDictionary<string, ApplianceSshKey> sshKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ApplianceArtifactProfile> dictionary = new Dictionary<string, ApplianceArtifactProfile>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ApplianceArtifactProfile.DeserializeApplianceArtifactProfile(property0.Value, options));
                    }
                    artifactProfiles = dictionary;
                    continue;
                }
                if (property.NameEquals("kubeconfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceCredentialKubeconfig> array = new List<ApplianceCredentialKubeconfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceCredentialKubeconfig.DeserializeApplianceCredentialKubeconfig(item, options));
                    }
                    kubeconfigs = array;
                    continue;
                }
                if (property.NameEquals("sshKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ApplianceSshKey> dictionary = new Dictionary<string, ApplianceSshKey>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ApplianceSshKey.DeserializeApplianceSshKey(property0.Value, options));
                    }
                    sshKeys = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplianceClusterUserKeysResult(artifactProfiles ?? new ChangeTrackingDictionary<string, ApplianceArtifactProfile>(), kubeconfigs ?? new ChangeTrackingList<ApplianceCredentialKubeconfig>(), sshKeys ?? new ChangeTrackingDictionary<string, ApplianceSshKey>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplianceClusterUserKeysResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceClusterUserKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplianceClusterUserKeysResult)} does not support '{options.Format}' format.");
            }
        }

        ApplianceClusterUserKeysResult IPersistableModel<ApplianceClusterUserKeysResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceClusterUserKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplianceClusterUserKeysResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplianceClusterUserKeysResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplianceClusterUserKeysResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
