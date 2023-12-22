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
    public partial class VmWorkloadProtectionPolicy : IUtf8JsonSerializable, IJsonModel<VmWorkloadProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadProtectionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmWorkloadProtectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VmWorkloadProtectionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkLoadType))
            {
                writer.WritePropertyName("workLoadType"u8);
                writer.WriteStringValue(WorkLoadType.Value.ToString());
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings);
            }
            if (Optional.IsCollectionDefined(SubProtectionPolicy))
            {
                writer.WritePropertyName("subProtectionPolicy"u8);
                writer.WriteStartArray();
                foreach (var item in SubProtectionPolicy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DoesMakePolicyConsistent))
            {
                writer.WritePropertyName("makePolicyConsistent"u8);
                writer.WriteBooleanValue(DoesMakePolicyConsistent.Value);
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType"u8);
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        VmWorkloadProtectionPolicy IJsonModel<VmWorkloadProtectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VmWorkloadProtectionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadProtectionPolicy(document.RootElement, options);
        }

        internal static VmWorkloadProtectionPolicy DeserializeVmWorkloadProtectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupWorkloadType> workLoadType = default;
            Optional<BackupCommonSettings> settings = default;
            Optional<IList<SubProtectionPolicy>> subProtectionPolicy = default;
            Optional<bool> makePolicyConsistent = default;
            Optional<int> protectedItemsCount = default;
            string backupManagementType = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workLoadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workLoadType = new BackupWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = BackupCommonSettings.DeserializeBackupCommonSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("subProtectionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubProtectionPolicy> array = new List<SubProtectionPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.SubProtectionPolicy.DeserializeSubProtectionPolicy(item));
                    }
                    subProtectionPolicy = array;
                    continue;
                }
                if (property.NameEquals("makePolicyConsistent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    makePolicyConsistent = property.Value.GetBoolean();
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
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmWorkloadProtectionPolicy(Optional.ToNullable(protectedItemsCount), backupManagementType, Optional.ToList(resourceGuardOperationRequests), serializedAdditionalRawData, Optional.ToNullable(workLoadType), settings.Value, Optional.ToList(subProtectionPolicy), Optional.ToNullable(makePolicyConsistent));
        }

        BinaryData IPersistableModel<VmWorkloadProtectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VmWorkloadProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        VmWorkloadProtectionPolicy IPersistableModel<VmWorkloadProtectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmWorkloadProtectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VmWorkloadProtectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadProtectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
