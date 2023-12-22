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
    public partial class RestoreFileSpecs : IUtf8JsonSerializable, IJsonModel<RestoreFileSpecs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreFileSpecs>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreFileSpecs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFileSpecs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestoreFileSpecs)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(FileSpecType))
            {
                writer.WritePropertyName("fileSpecType"u8);
                writer.WriteStringValue(FileSpecType);
            }
            if (Optional.IsDefined(TargetFolderPath))
            {
                writer.WritePropertyName("targetFolderPath"u8);
                writer.WriteStringValue(TargetFolderPath);
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

        RestoreFileSpecs IJsonModel<RestoreFileSpecs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFileSpecs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RestoreFileSpecs)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreFileSpecs(document.RootElement, options);
        }

        internal static RestoreFileSpecs DeserializeRestoreFileSpecs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<string> fileSpecType = default;
            Optional<string> targetFolderPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileSpecType"u8))
                {
                    fileSpecType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFolderPath"u8))
                {
                    targetFolderPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestoreFileSpecs(path.Value, fileSpecType.Value, targetFolderPath.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestoreFileSpecs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFileSpecs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RestoreFileSpecs)} does not support '{options.Format}' format.");
            }
        }

        RestoreFileSpecs IPersistableModel<RestoreFileSpecs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFileSpecs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreFileSpecs(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RestoreFileSpecs)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreFileSpecs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
