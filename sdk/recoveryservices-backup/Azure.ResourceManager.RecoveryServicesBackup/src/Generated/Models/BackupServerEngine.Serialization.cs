// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupServerEngine : IUtf8JsonSerializable, IJsonModel<BackupServerEngine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupServerEngine>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupServerEngine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupServerEngine)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(BackupEngineState))
            {
                writer.WritePropertyName("backupEngineState"u8);
                writer.WriteStringValue(BackupEngineState);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("backupEngineType"u8);
            writer.WriteStringValue(BackupEngineType.ToString());
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(BackupEngineId))
            {
                writer.WritePropertyName("backupEngineId"u8);
                writer.WriteStringValue(BackupEngineId);
            }
            if (Optional.IsDefined(DpmVersion))
            {
                writer.WritePropertyName("dpmVersion"u8);
                writer.WriteStringValue(DpmVersion);
            }
            if (Optional.IsDefined(AzureBackupAgentVersion))
            {
                writer.WritePropertyName("azureBackupAgentVersion"u8);
                writer.WriteStringValue(AzureBackupAgentVersion);
            }
            if (Optional.IsDefined(IsAzureBackupAgentUpgradeAvailable))
            {
                writer.WritePropertyName("isAzureBackupAgentUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsAzureBackupAgentUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(IsDpmUpgradeAvailable))
            {
                writer.WritePropertyName("isDpmUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsDpmUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
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

        BackupServerEngine IJsonModel<BackupServerEngine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupServerEngine)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupServerEngine(document.RootElement, options);
        }

        internal static BackupServerEngine DeserializeBackupServerEngine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> backupEngineState = default;
            Optional<string> healthStatus = default;
            BackupEngineType backupEngineType = default;
            Optional<bool> canReRegister = default;
            Optional<string> backupEngineId = default;
            Optional<string> dpmVersion = default;
            Optional<string> azureBackupAgentVersion = default;
            Optional<bool> isAzureBackupAgentUpgradeAvailable = default;
            Optional<bool> isDpmUpgradeAvailable = default;
            Optional<BackupEngineExtendedInfo> extendedInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineState"u8))
                {
                    backupEngineState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineType"u8))
                {
                    backupEngineType = new BackupEngineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupEngineId"u8))
                {
                    backupEngineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmVersion"u8))
                {
                    dpmVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureBackupAgentVersion"u8))
                {
                    azureBackupAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAzureBackupAgentUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAzureBackupAgentUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDpmUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDpmUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = BackupEngineExtendedInfo.DeserializeBackupEngineExtendedInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupServerEngine(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, backupEngineState.Value, healthStatus.Value, backupEngineType, Optional.ToNullable(canReRegister), backupEngineId.Value, dpmVersion.Value, azureBackupAgentVersion.Value, Optional.ToNullable(isAzureBackupAgentUpgradeAvailable), Optional.ToNullable(isDpmUpgradeAvailable), extendedInfo.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupServerEngine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupServerEngine)} does not support '{options.Format}' format.");
            }
        }

        BackupServerEngine IPersistableModel<BackupServerEngine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupServerEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupServerEngine(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupServerEngine)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupServerEngine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
