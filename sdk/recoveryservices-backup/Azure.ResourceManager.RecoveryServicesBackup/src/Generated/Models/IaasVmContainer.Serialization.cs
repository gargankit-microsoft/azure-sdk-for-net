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
    public partial class IaasVmContainer : IUtf8JsonSerializable, IJsonModel<IaasVmContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(VirtualMachineVersion))
            {
                writer.WritePropertyName("virtualMachineVersion"u8);
                writer.WriteStringValue(VirtualMachineVersion);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
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
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
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

        IaasVmContainer IJsonModel<IaasVmContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmContainer(document.RootElement, options);
        }

        internal static IaasVmContainer DeserializeIaasVmContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("containerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmContainer.DeserializeIaasClassicComputeVmContainer(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmContainer.DeserializeIaasComputeVmContainer(element);
                }
            }
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> virtualMachineVersion = default;
            Optional<string> resourceGroup = default;
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineVersion"u8))
                {
                    virtualMachineVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData, virtualMachineId.Value, virtualMachineVersion.Value, resourceGroup.Value);
        }

        BinaryData IPersistableModel<IaasVmContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmContainer)} does not support '{options.Format}' format.");
            }
        }

        IaasVmContainer IPersistableModel<IaasVmContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
