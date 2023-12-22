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
    public partial class BackupEngineExtendedInfo : IUtf8JsonSerializable, IJsonModel<BackupEngineExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupEngineExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupEngineExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupEngineExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupEngineExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            if (Optional.IsDefined(ProtectedServersCount))
            {
                writer.WritePropertyName("protectedServersCount"u8);
                writer.WriteNumberValue(ProtectedServersCount.Value);
            }
            if (Optional.IsDefined(DiskCount))
            {
                writer.WritePropertyName("diskCount"u8);
                writer.WriteNumberValue(DiskCount.Value);
            }
            if (Optional.IsDefined(UsedDiskSpace))
            {
                writer.WritePropertyName("usedDiskSpace"u8);
                writer.WriteNumberValue(UsedDiskSpace.Value);
            }
            if (Optional.IsDefined(AvailableDiskSpace))
            {
                writer.WritePropertyName("availableDiskSpace"u8);
                writer.WriteNumberValue(AvailableDiskSpace.Value);
            }
            if (Optional.IsDefined(RefreshedOn))
            {
                writer.WritePropertyName("refreshedAt"u8);
                writer.WriteStringValue(RefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(AzureProtectedInstances))
            {
                writer.WritePropertyName("azureProtectedInstances"u8);
                writer.WriteNumberValue(AzureProtectedInstances.Value);
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

        BackupEngineExtendedInfo IJsonModel<BackupEngineExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupEngineExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupEngineExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupEngineExtendedInfo(document.RootElement, options);
        }

        internal static BackupEngineExtendedInfo DeserializeBackupEngineExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<int> protectedItemsCount = default;
            Optional<int> protectedServersCount = default;
            Optional<int> diskCount = default;
            Optional<double> usedDiskSpace = default;
            Optional<double> availableDiskSpace = default;
            Optional<DateTimeOffset> refreshedAt = default;
            Optional<int> azureProtectedInstances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protectedServersCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedServersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedDiskSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedDiskSpace = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("availableDiskSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableDiskSpace = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("refreshedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("azureProtectedInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureProtectedInstances = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupEngineExtendedInfo(databaseName.Value, Optional.ToNullable(protectedItemsCount), Optional.ToNullable(protectedServersCount), Optional.ToNullable(diskCount), Optional.ToNullable(usedDiskSpace), Optional.ToNullable(availableDiskSpace), Optional.ToNullable(refreshedAt), Optional.ToNullable(azureProtectedInstances), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupEngineExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupEngineExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupEngineExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        BackupEngineExtendedInfo IPersistableModel<BackupEngineExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupEngineExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupEngineExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupEngineExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupEngineExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
