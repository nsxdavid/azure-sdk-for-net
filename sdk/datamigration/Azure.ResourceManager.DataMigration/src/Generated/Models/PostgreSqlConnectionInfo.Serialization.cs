// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class PostgreSqlConnectionInfo : IUtf8JsonSerializable, IJsonModel<PostgreSqlConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlConnectionInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlConnectionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlConnectionInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                writer.WriteStringValue(DataSource);
            }
            if (Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            if (Optional.IsDefined(EncryptConnection))
            {
                writer.WritePropertyName("encryptConnection"u8);
                writer.WriteBooleanValue(EncryptConnection.Value);
            }
            if (Optional.IsDefined(TrustServerCertificate))
            {
                writer.WritePropertyName("trustServerCertificate"u8);
                writer.WriteBooleanValue(TrustServerCertificate.Value);
            }
            if (Optional.IsDefined(AdditionalSettings))
            {
                writer.WritePropertyName("additionalSettings"u8);
                writer.WriteStringValue(AdditionalSettings);
            }
            if (Optional.IsDefined(ServerBrandVersion))
            {
                writer.WritePropertyName("serverBrandVersion"u8);
                writer.WriteStringValue(ServerBrandVersion);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteStringValue(Authentication.Value.ToString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionInfoType);
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        PostgreSqlConnectionInfo IJsonModel<PostgreSqlConnectionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlConnectionInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlConnectionInfo(document.RootElement, options);
        }

        internal static PostgreSqlConnectionInfo DeserializePostgreSqlConnectionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serverName = default;
            Optional<string> dataSource = default;
            Optional<string> serverVersion = default;
            Optional<string> databaseName = default;
            int port = default;
            Optional<bool> encryptConnection = default;
            Optional<bool> trustServerCertificate = default;
            Optional<string> additionalSettings = default;
            Optional<string> serverBrandVersion = default;
            Optional<AuthenticationType> authentication = default;
            string type = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverVersion"u8))
                {
                    serverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("encryptConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptConnection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trustServerCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trustServerCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("additionalSettings"u8))
                {
                    additionalSettings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverBrandVersion"u8))
                {
                    serverBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = new AuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlConnectionInfo(type, userName.Value, password.Value, serializedAdditionalRawData, serverName, dataSource.Value, serverVersion.Value, databaseName.Value, port, Optional.ToNullable(encryptConnection), Optional.ToNullable(trustServerCertificate), additionalSettings.Value, serverBrandVersion.Value, Optional.ToNullable(authentication));
        }

        BinaryData IPersistableModel<PostgreSqlConnectionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlConnectionInfo)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlConnectionInfo IPersistableModel<PostgreSqlConnectionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlConnectionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlConnectionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlConnectionInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlConnectionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
