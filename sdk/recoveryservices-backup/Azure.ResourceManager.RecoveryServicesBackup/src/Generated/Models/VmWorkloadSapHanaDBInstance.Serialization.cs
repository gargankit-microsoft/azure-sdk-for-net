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
    public partial class VmWorkloadSapHanaDBInstance : IUtf8JsonSerializable, IJsonModel<VmWorkloadSapHanaDBInstance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadSapHanaDBInstance>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmWorkloadSapHanaDBInstance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ParentUniqueName))
            {
                writer.WritePropertyName("parentUniqueName"u8);
                writer.WriteStringValue(ParentUniqueName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(IsAutoProtected))
            {
                writer.WritePropertyName("isAutoProtected"u8);
                writer.WriteBooleanValue(IsAutoProtected.Value);
            }
            if (Optional.IsDefined(SubInquiredItemCount))
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (Optional.IsDefined(SubProtectableItemCount))
            {
                writer.WritePropertyName("subprotectableitemcount"u8);
                writer.WriteNumberValue(SubProtectableItemCount.Value);
            }
            if (Optional.IsDefined(PreBackupValidation))
            {
                writer.WritePropertyName("prebackupvalidation"u8);
                writer.WriteObjectValue(PreBackupValidation);
            }
            if (Optional.IsDefined(IsProtectable))
            {
                writer.WritePropertyName("isProtectable"u8);
                writer.WriteBooleanValue(IsProtectable.Value);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        VmWorkloadSapHanaDBInstance IJsonModel<VmWorkloadSapHanaDBInstance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSapHanaDBInstance(document.RootElement, options);
        }

        internal static VmWorkloadSapHanaDBInstance DeserializeVmWorkloadSapHanaDBInstance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentName = default;
            Optional<string> parentUniqueName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<bool> isAutoProtected = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subprotectableitemcount = default;
            Optional<PreBackupValidation> prebackupvalidation = default;
            Optional<bool> isProtectable = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentUniqueName"u8))
                {
                    parentUniqueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoProtected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtected = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subprotectableitemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subprotectableitemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("prebackupvalidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prebackupvalidation = PreBackupValidation.DeserializePreBackupValidation(property.Value);
                    continue;
                }
                if (property.NameEquals("isProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmWorkloadSapHanaDBInstance(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), serializedAdditionalRawData, parentName.Value, parentUniqueName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(isAutoProtected), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subprotectableitemcount), prebackupvalidation.Value, Optional.ToNullable(isProtectable));
        }

        BinaryData IPersistableModel<VmWorkloadSapHanaDBInstance>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{options.Format}' format.");
            }
        }

        VmWorkloadSapHanaDBInstance IPersistableModel<VmWorkloadSapHanaDBInstance>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmWorkloadSapHanaDBInstance(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadSapHanaDBInstance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
