// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ServicePrincipalProperties : IUtf8JsonSerializable, IJsonModel<ServicePrincipalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServicePrincipalProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServicePrincipalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePrincipalProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId.Value);
            }
            if (Optional.IsDefined(Secret))
            {
                writer.WritePropertyName("secret"u8);
                writer.WriteStringValue(Secret);
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

        ServicePrincipalProperties IJsonModel<ServicePrincipalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServicePrincipalProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalProperties(document.RootElement, options);
        }

        internal static ServicePrincipalProperties DeserializeServicePrincipalProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> applicationId = default;
            Optional<string> secret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("secret"u8))
                {
                    secret = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServicePrincipalProperties(Optional.ToNullable(applicationId), secret.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServicePrincipalProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServicePrincipalProperties)} does not support '{options.Format}' format.");
            }
        }

        ServicePrincipalProperties IPersistableModel<ServicePrincipalProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServicePrincipalProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServicePrincipalProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServicePrincipalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
