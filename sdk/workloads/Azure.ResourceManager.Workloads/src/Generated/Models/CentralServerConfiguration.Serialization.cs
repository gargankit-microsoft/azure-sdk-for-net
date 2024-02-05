// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CentralServerConfiguration : IUtf8JsonSerializable, IJsonModel<CentralServerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CentralServerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CentralServerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("virtualMachineConfiguration"u8);
            writer.WriteObjectValue(VirtualMachineConfiguration);
            writer.WritePropertyName("instanceCount"u8);
            writer.WriteNumberValue(InstanceCount);
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

        CentralServerConfiguration IJsonModel<CentralServerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCentralServerConfiguration(document.RootElement, options);
        }

        internal static CentralServerConfiguration DeserializeCentralServerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            SapVirtualMachineConfiguration virtualMachineConfiguration = default;
            long instanceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    virtualMachineConfiguration = SapVirtualMachineConfiguration.DeserializeSapVirtualMachineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    instanceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CentralServerConfiguration(subnetId, virtualMachineConfiguration, instanceCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CentralServerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CentralServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CentralServerConfiguration IPersistableModel<CentralServerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCentralServerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CentralServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CentralServerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
