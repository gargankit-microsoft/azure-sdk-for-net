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
    public partial class BackupResourceConfigProperties : IUtf8JsonSerializable, IJsonModel<BackupResourceConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceConfigProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupResourceConfigProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupResourceConfigProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageModelType))
            {
                writer.WritePropertyName("storageModelType"u8);
                writer.WriteStringValue(StorageModelType.Value.ToString());
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageTypeState))
            {
                writer.WritePropertyName("storageTypeState"u8);
                writer.WriteStringValue(StorageTypeState.Value.ToString());
            }
            if (Optional.IsDefined(EnableCrossRegionRestore))
            {
                writer.WritePropertyName("crossRegionRestoreFlag"u8);
                writer.WriteBooleanValue(EnableCrossRegionRestore.Value);
            }
            if (Optional.IsDefined(DedupState))
            {
                writer.WritePropertyName("dedupState"u8);
                writer.WriteStringValue(DedupState.Value.ToString());
            }
            if (Optional.IsDefined(XcoolState))
            {
                writer.WritePropertyName("xcoolState"u8);
                writer.WriteStringValue(XcoolState.Value.ToString());
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

        BackupResourceConfigProperties IJsonModel<BackupResourceConfigProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupResourceConfigProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceConfigProperties(document.RootElement, options);
        }

        internal static BackupResourceConfigProperties DeserializeBackupResourceConfigProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupStorageType> storageModelType = default;
            Optional<BackupStorageType> storageType = default;
            Optional<BackupStorageTypeState> storageTypeState = default;
            Optional<bool> crossRegionRestoreFlag = default;
            Optional<VaultDedupState> dedupState = default;
            Optional<VaultXcoolState> xcoolState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageModelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageModelType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageTypeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageTypeState = new BackupStorageTypeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("crossRegionRestoreFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossRegionRestoreFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dedupState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dedupState = new VaultDedupState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("xcoolState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xcoolState = new VaultXcoolState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupResourceConfigProperties(Optional.ToNullable(storageModelType), Optional.ToNullable(storageType), Optional.ToNullable(storageTypeState), Optional.ToNullable(crossRegionRestoreFlag), Optional.ToNullable(dedupState), Optional.ToNullable(xcoolState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupResourceConfigProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupResourceConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        BackupResourceConfigProperties IPersistableModel<BackupResourceConfigProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupResourceConfigProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupResourceConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceConfigProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
