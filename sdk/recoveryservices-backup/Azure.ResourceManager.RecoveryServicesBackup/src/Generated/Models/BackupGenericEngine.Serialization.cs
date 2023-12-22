// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownBackupEngineBase))]
    public partial class BackupGenericEngine : IUtf8JsonSerializable, IJsonModel<BackupGenericEngine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericEngine>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupGenericEngine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupGenericEngine)} does not support '{format}' format.");
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

        BackupGenericEngine IJsonModel<BackupGenericEngine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupGenericEngine)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericEngine(document.RootElement, options);
        }

        internal static BackupGenericEngine DeserializeBackupGenericEngine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("backupEngineType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupServerEngine": return BackupServerEngine.DeserializeBackupServerEngine(element);
                    case "DpmBackupEngine": return DpmBackupEngine.DeserializeDpmBackupEngine(element);
                }
            }
            return UnknownBackupEngineBase.DeserializeUnknownBackupEngineBase(element);
        }

        BinaryData IPersistableModel<BackupGenericEngine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupGenericEngine)} does not support '{options.Format}' format.");
            }
        }

        BackupGenericEngine IPersistableModel<BackupGenericEngine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericEngine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupGenericEngine(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupGenericEngine)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericEngine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
