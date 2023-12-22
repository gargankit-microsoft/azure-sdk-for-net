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
    public partial class GenericContainerExtendedInfo : IUtf8JsonSerializable, IJsonModel<GenericContainerExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenericContainerExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GenericContainerExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GenericContainerExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RawCertData))
            {
                writer.WritePropertyName("rawCertData"u8);
                writer.WriteStringValue(RawCertData);
            }
            if (Optional.IsDefined(ContainerIdentityInfo))
            {
                writer.WritePropertyName("containerIdentityInfo"u8);
                writer.WriteObjectValue(ContainerIdentityInfo);
            }
            if (Optional.IsCollectionDefined(ServiceEndpoints))
            {
                writer.WritePropertyName("serviceEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in ServiceEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        GenericContainerExtendedInfo IJsonModel<GenericContainerExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GenericContainerExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenericContainerExtendedInfo(document.RootElement, options);
        }

        internal static GenericContainerExtendedInfo DeserializeGenericContainerExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rawCertData = default;
            Optional<ContainerIdentityInfo> containerIdentityInfo = default;
            Optional<IDictionary<string, string>> serviceEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawCertData"u8))
                {
                    rawCertData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerIdentityInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerIdentityInfo = ContainerIdentityInfo.DeserializeContainerIdentityInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    serviceEndpoints = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenericContainerExtendedInfo(rawCertData.Value, containerIdentityInfo.Value, Optional.ToDictionary(serviceEndpoints), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GenericContainerExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(GenericContainerExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        GenericContainerExtendedInfo IPersistableModel<GenericContainerExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGenericContainerExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(GenericContainerExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GenericContainerExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
