// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class RestoreProperties : IUtf8JsonSerializable, IJsonModel<RestoreProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Foldername))
            {
                writer.WritePropertyName("foldername"u8);
                writer.WriteStringValue(Foldername);
            }
            if (Optional.IsDefined(AzureStorageResourceUri))
            {
                writer.WritePropertyName("azureStorageResourceUri"u8);
                writer.WriteStringValue(AzureStorageResourceUri.AbsoluteUri);
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

        RestoreProperties IJsonModel<RestoreProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreProperties(document.RootElement, options);
        }

        internal static RestoreProperties DeserializeRestoreProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> foldername = default;
            Optional<Uri> azureStorageResourceUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foldername"u8))
                {
                    foldername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageResourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStorageResourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestoreProperties(foldername.Value, azureStorageResourceUri.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestoreProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreProperties)} does not support '{options.Format}' format.");
            }
        }

        RestoreProperties IPersistableModel<RestoreProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
