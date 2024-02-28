// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(HDInsightOnDemandLinkedServiceConverter))]
    public partial class HDInsightOnDemandLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<object> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("clusterSize"u8);
            writer.WriteObjectValue(ClusterSize);
            writer.WritePropertyName("timeToLive"u8);
            writer.WriteObjectValue(TimeToLive);
            writer.WritePropertyName("version"u8);
            writer.WriteObjectValue(Version);
            writer.WritePropertyName("linkedServiceName"u8);
            writer.WriteObjectValue(LinkedServiceName);
            writer.WritePropertyName("hostSubscriptionId"u8);
            writer.WriteObjectValue(HostSubscriptionId);
            if (ServicePrincipalId != null)
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (ServicePrincipalKey != null)
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            writer.WritePropertyName("tenant"u8);
            writer.WriteObjectValue(Tenant);
            writer.WritePropertyName("clusterResourceGroup"u8);
            writer.WriteObjectValue(ClusterResourceGroup);
            if (ClusterNamePrefix != null)
            {
                writer.WritePropertyName("clusterNamePrefix"u8);
                writer.WriteObjectValue(ClusterNamePrefix);
            }
            if (ClusterUserName != null)
            {
                writer.WritePropertyName("clusterUserName"u8);
                writer.WriteObjectValue(ClusterUserName);
            }
            if (ClusterPassword != null)
            {
                writer.WritePropertyName("clusterPassword"u8);
                writer.WriteObjectValue(ClusterPassword);
            }
            if (ClusterSshUserName != null)
            {
                writer.WritePropertyName("clusterSshUserName"u8);
                writer.WriteObjectValue(ClusterSshUserName);
            }
            if (ClusterSshPassword != null)
            {
                writer.WritePropertyName("clusterSshPassword"u8);
                writer.WriteObjectValue(ClusterSshPassword);
            }
            if (!(AdditionalLinkedServiceNames is ChangeTrackingList<LinkedServiceReference> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("additionalLinkedServiceNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalLinkedServiceNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (HcatalogLinkedServiceName != null)
            {
                writer.WritePropertyName("hcatalogLinkedServiceName"u8);
                writer.WriteObjectValue(HcatalogLinkedServiceName);
            }
            if (ClusterType != null)
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteObjectValue(ClusterType);
            }
            if (SparkVersion != null)
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteObjectValue(SparkVersion);
            }
            if (CoreConfiguration != null)
            {
                writer.WritePropertyName("coreConfiguration"u8);
                writer.WriteObjectValue(CoreConfiguration);
            }
            if (HBaseConfiguration != null)
            {
                writer.WritePropertyName("hBaseConfiguration"u8);
                writer.WriteObjectValue(HBaseConfiguration);
            }
            if (HdfsConfiguration != null)
            {
                writer.WritePropertyName("hdfsConfiguration"u8);
                writer.WriteObjectValue(HdfsConfiguration);
            }
            if (HiveConfiguration != null)
            {
                writer.WritePropertyName("hiveConfiguration"u8);
                writer.WriteObjectValue(HiveConfiguration);
            }
            if (MapReduceConfiguration != null)
            {
                writer.WritePropertyName("mapReduceConfiguration"u8);
                writer.WriteObjectValue(MapReduceConfiguration);
            }
            if (OozieConfiguration != null)
            {
                writer.WritePropertyName("oozieConfiguration"u8);
                writer.WriteObjectValue(OozieConfiguration);
            }
            if (StormConfiguration != null)
            {
                writer.WritePropertyName("stormConfiguration"u8);
                writer.WriteObjectValue(StormConfiguration);
            }
            if (YarnConfiguration != null)
            {
                writer.WritePropertyName("yarnConfiguration"u8);
                writer.WriteObjectValue(YarnConfiguration);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (HeadNodeSize != null)
            {
                writer.WritePropertyName("headNodeSize"u8);
                writer.WriteObjectValue(HeadNodeSize);
            }
            if (DataNodeSize != null)
            {
                writer.WritePropertyName("dataNodeSize"u8);
                writer.WriteObjectValue(DataNodeSize);
            }
            if (ZookeeperNodeSize != null)
            {
                writer.WritePropertyName("zookeeperNodeSize"u8);
                writer.WriteObjectValue(ZookeeperNodeSize);
            }
            if (!(ScriptActions is ChangeTrackingList<ScriptAction> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (VirtualNetworkId != null)
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteObjectValue(VirtualNetworkId);
            }
            if (SubnetName != null)
            {
                writer.WritePropertyName("subnetName"u8);
                writer.WriteObjectValue(SubnetName);
            }
            if (Credential != null)
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightOnDemandLinkedService DeserializeHDInsightOnDemandLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object clusterSize = default;
            object timeToLive = default;
            object version = default;
            LinkedServiceReference linkedServiceName = default;
            object hostSubscriptionId = default;
            object servicePrincipalId = default;
            SecretBase servicePrincipalKey = default;
            object tenant = default;
            object clusterResourceGroup = default;
            object clusterNamePrefix = default;
            object clusterUserName = default;
            SecretBase clusterPassword = default;
            object clusterSshUserName = default;
            SecretBase clusterSshPassword = default;
            IList<LinkedServiceReference> additionalLinkedServiceNames = default;
            LinkedServiceReference hcatalogLinkedServiceName = default;
            object clusterType = default;
            object sparkVersion = default;
            object coreConfiguration = default;
            object hBaseConfiguration = default;
            object hdfsConfiguration = default;
            object hiveConfiguration = default;
            object mapReduceConfiguration = default;
            object oozieConfiguration = default;
            object stormConfiguration = default;
            object yarnConfiguration = default;
            object encryptedCredential = default;
            object headNodeSize = default;
            object dataNodeSize = default;
            object zookeeperNodeSize = default;
            IList<ScriptAction> scriptActions = default;
            object virtualNetworkId = default;
            object subnetName = default;
            CredentialReference credential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterSize"u8))
                        {
                            clusterSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timeToLive"u8))
                        {
                            timeToLive = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"u8))
                        {
                            linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostSubscriptionId"u8))
                        {
                            hostSubscriptionId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceGroup"u8))
                        {
                            clusterResourceGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterNamePrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterNamePrefix = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterSshUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterSshPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalLinkedServiceNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                            }
                            additionalLinkedServiceNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hcatalogLinkedServiceName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hcatalogLinkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkVersion = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("coreConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hBaseConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hBaseConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hdfsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hdfsConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hiveConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hiveConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("mapReduceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mapReduceConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("oozieConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oozieConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("stormConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stormConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("yarnConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            yarnConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("headNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            headNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("dataNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("zookeeperNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zookeeperNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scriptActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ScriptAction> array = new List<ScriptAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptAction.DeserializeScriptAction(item));
                            }
                            scriptActions = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("subnetName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightOnDemandLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                clusterSize,
                timeToLive,
                version,
                linkedServiceName,
                hostSubscriptionId,
                servicePrincipalId,
                servicePrincipalKey,
                tenant,
                clusterResourceGroup,
                clusterNamePrefix,
                clusterUserName,
                clusterPassword,
                clusterSshUserName,
                clusterSshPassword,
                additionalLinkedServiceNames ?? new ChangeTrackingList<LinkedServiceReference>(),
                hcatalogLinkedServiceName,
                clusterType,
                sparkVersion,
                coreConfiguration,
                hBaseConfiguration,
                hdfsConfiguration,
                hiveConfiguration,
                mapReduceConfiguration,
                oozieConfiguration,
                stormConfiguration,
                yarnConfiguration,
                encryptedCredential,
                headNodeSize,
                dataNodeSize,
                zookeeperNodeSize,
                scriptActions ?? new ChangeTrackingList<ScriptAction>(),
                virtualNetworkId,
                subnetName,
                credential);
        }

        internal partial class HDInsightOnDemandLinkedServiceConverter : JsonConverter<HDInsightOnDemandLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, HDInsightOnDemandLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HDInsightOnDemandLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHDInsightOnDemandLinkedService(document.RootElement);
            }
        }
    }
}
