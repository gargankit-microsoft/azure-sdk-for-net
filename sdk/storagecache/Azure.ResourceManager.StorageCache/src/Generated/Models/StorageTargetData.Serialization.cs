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
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    public partial class StorageTargetData : IUtf8JsonSerializable, IJsonModel<StorageTargetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTargetData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageTargetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTargetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTargetData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (Optional.IsCollectionDefined(Junctions))
            {
                writer.WritePropertyName("junctions"u8);
                writer.WriteStartArray();
                foreach (var item in Junctions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetType))
            {
                writer.WritePropertyName("targetType"u8);
                writer.WriteStringValue(TargetType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Nfs3))
            {
                writer.WritePropertyName("nfs3"u8);
                writer.WriteObjectValue(Nfs3);
            }
            if (Optional.IsDefined(Clfs))
            {
                writer.WritePropertyName("clfs"u8);
                writer.WriteObjectValue(Clfs);
            }
            if (Optional.IsDefined(Unknown))
            {
                writer.WritePropertyName("unknown"u8);
                writer.WriteObjectValue(Unknown);
            }
            if (Optional.IsDefined(BlobNfs))
            {
                writer.WritePropertyName("blobNfs"u8);
                writer.WriteObjectValue(BlobNfs);
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationPercentage))
            {
                writer.WritePropertyName("allocationPercentage"u8);
                writer.WriteNumberValue(AllocationPercentage.Value);
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

        StorageTargetData IJsonModel<StorageTargetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTargetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTargetData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTargetData(document.RootElement, options);
        }

        internal static StorageTargetData DeserializeStorageTargetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<NamespaceJunction>> junctions = default;
            Optional<StorageTargetType> targetType = default;
            Optional<StorageCacheProvisioningStateType> provisioningState = default;
            Optional<StorageTargetOperationalStateType> state = default;
            Optional<Nfs3Target> nfs3 = default;
            Optional<ClfsTarget> clfs = default;
            Optional<UnknownTarget> unknown = default;
            Optional<BlobNfsTarget> blobNfs = default;
            Optional<int> allocationPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("junctions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NamespaceJunction> array = new List<NamespaceJunction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NamespaceJunction.DeserializeNamespaceJunction(item));
                            }
                            junctions = array;
                            continue;
                        }
                        if (property0.NameEquals("targetType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetType = new StorageTargetType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageCacheProvisioningStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new StorageTargetOperationalStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nfs3"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nfs3 = Nfs3Target.DeserializeNfs3Target(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clfs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clfs = Models.ClfsTarget.DeserializeClfsTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("unknown"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unknown = UnknownTarget.DeserializeUnknownTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("blobNfs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobNfs = BlobNfsTarget.DeserializeBlobNfsTarget(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allocationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationPercentage = property0.Value.GetInt32();
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
            return new StorageTargetData(id, name, type, systemData.Value, Optional.ToList(junctions), Optional.ToNullable(targetType), Optional.ToNullable(provisioningState), Optional.ToNullable(state), nfs3.Value, clfs.Value, unknown.Value, blobNfs.Value, Optional.ToNullable(allocationPercentage), Optional.ToNullable(location), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageTargetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTargetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageTargetData)} does not support '{options.Format}' format.");
            }
        }

        StorageTargetData IPersistableModel<StorageTargetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTargetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageTargetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageTargetData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageTargetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
