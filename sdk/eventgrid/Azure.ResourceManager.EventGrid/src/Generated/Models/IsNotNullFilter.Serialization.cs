// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class IsNotNullFilter : IUtf8JsonSerializable, IJsonModel<IsNotNullFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IsNotNullFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IsNotNullFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IsNotNullFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IsNotNullFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        IsNotNullFilter IJsonModel<IsNotNullFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IsNotNullFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IsNotNullFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIsNotNullFilter(document.RootElement, options);
        }

        internal static IsNotNullFilter DeserializeIsNotNullFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FilterOperatorType operatorType = default;
            Optional<string> key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new FilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IsNotNullFilter(operatorType, key.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IsNotNullFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IsNotNullFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IsNotNullFilter)} does not support '{options.Format}' format.");
            }
        }

        IsNotNullFilter IPersistableModel<IsNotNullFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IsNotNullFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIsNotNullFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IsNotNullFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IsNotNullFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
