// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GenerateExpressRoutePortsLoaResult : IUtf8JsonSerializable, IJsonModel<GenerateExpressRoutePortsLoaResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenerateExpressRoutePortsLoaResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GenerateExpressRoutePortsLoaResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateExpressRoutePortsLoaResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodedContent))
            {
                writer.WritePropertyName("encodedContent"u8);
                writer.WriteStringValue(EncodedContent);
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

        GenerateExpressRoutePortsLoaResult IJsonModel<GenerateExpressRoutePortsLoaResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateExpressRoutePortsLoaResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenerateExpressRoutePortsLoaResult(document.RootElement, options);
        }

        internal static GenerateExpressRoutePortsLoaResult DeserializeGenerateExpressRoutePortsLoaResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> encodedContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedContent"u8))
                {
                    encodedContent = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenerateExpressRoutePortsLoaResult(encodedContent.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GenerateExpressRoutePortsLoaResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateExpressRoutePortsLoaResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{options.Format}' format.");
            }
        }

        GenerateExpressRoutePortsLoaResult IPersistableModel<GenerateExpressRoutePortsLoaResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateExpressRoutePortsLoaResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGenerateExpressRoutePortsLoaResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GenerateExpressRoutePortsLoaResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GenerateExpressRoutePortsLoaResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
