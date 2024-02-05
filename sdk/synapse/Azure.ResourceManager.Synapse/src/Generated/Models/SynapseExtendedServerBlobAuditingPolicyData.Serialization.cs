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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseExtendedServerBlobAuditingPolicyData : IUtf8JsonSerializable, IJsonModel<SynapseExtendedServerBlobAuditingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseExtendedServerBlobAuditingPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseExtendedServerBlobAuditingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseExtendedServerBlobAuditingPolicyData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PredicateExpression))
            {
                writer.WritePropertyName("predicateExpression"u8);
                writer.WriteStringValue(PredicateExpression);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Optional.IsCollectionDefined(AuditActionsAndGroups))
            {
                writer.WritePropertyName("auditActionsAndGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AuditActionsAndGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAccountSubscriptionId))
            {
                writer.WritePropertyName("storageAccountSubscriptionId"u8);
                writer.WriteStringValue(StorageAccountSubscriptionId.Value);
            }
            if (Optional.IsDefined(IsStorageSecondaryKeyInUse))
            {
                writer.WritePropertyName("isStorageSecondaryKeyInUse"u8);
                writer.WriteBooleanValue(IsStorageSecondaryKeyInUse.Value);
            }
            if (Optional.IsDefined(IsAzureMonitorTargetEnabled))
            {
                writer.WritePropertyName("isAzureMonitorTargetEnabled"u8);
                writer.WriteBooleanValue(IsAzureMonitorTargetEnabled.Value);
            }
            if (Optional.IsDefined(QueueDelayMs))
            {
                writer.WritePropertyName("queueDelayMs"u8);
                writer.WriteNumberValue(QueueDelayMs.Value);
            }
            if (Optional.IsDefined(IsDevopsAuditEnabled))
            {
                writer.WritePropertyName("isDevopsAuditEnabled"u8);
                writer.WriteBooleanValue(IsDevopsAuditEnabled.Value);
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

        SynapseExtendedServerBlobAuditingPolicyData IJsonModel<SynapseExtendedServerBlobAuditingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseExtendedServerBlobAuditingPolicyData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseExtendedServerBlobAuditingPolicyData(document.RootElement, options);
        }

        internal static SynapseExtendedServerBlobAuditingPolicyData DeserializeSynapseExtendedServerBlobAuditingPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> predicateExpression = default;
            Optional<SynapseBlobAuditingPolicyState> state = default;
            Optional<string> storageEndpoint = default;
            Optional<string> storageAccountAccessKey = default;
            Optional<int> retentionDays = default;
            Optional<IList<string>> auditActionsAndGroups = default;
            Optional<Guid> storageAccountSubscriptionId = default;
            Optional<bool> isStorageSecondaryKeyInUse = default;
            Optional<bool> isAzureMonitorTargetEnabled = default;
            Optional<int> queueDelayMs = default;
            Optional<bool> isDevopsAuditEnabled = default;
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
                        if (property0.NameEquals("predicateExpression"u8))
                        {
                            predicateExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSynapseBlobAuditingPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("auditActionsAndGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            auditActionsAndGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSubscriptionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isStorageSecondaryKeyInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isStorageSecondaryKeyInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAzureMonitorTargetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureMonitorTargetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queueDelayMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queueDelayMs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isDevopsAuditEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDevopsAuditEnabled = property0.Value.GetBoolean();
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
            return new SynapseExtendedServerBlobAuditingPolicyData(id, name, type, systemData.Value, predicateExpression.Value, Optional.ToNullable(state), storageEndpoint.Value, storageAccountAccessKey.Value, Optional.ToNullable(retentionDays), Optional.ToList(auditActionsAndGroups), Optional.ToNullable(storageAccountSubscriptionId), Optional.ToNullable(isStorageSecondaryKeyInUse), Optional.ToNullable(isAzureMonitorTargetEnabled), Optional.ToNullable(queueDelayMs), Optional.ToNullable(isDevopsAuditEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseExtendedServerBlobAuditingPolicyData)} does not support '{options.Format}' format.");
            }
        }

        SynapseExtendedServerBlobAuditingPolicyData IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseExtendedServerBlobAuditingPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseExtendedServerBlobAuditingPolicyData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseExtendedServerBlobAuditingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
