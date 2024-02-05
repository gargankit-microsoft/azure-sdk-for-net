// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class AnalyzeTextOptions : IUtf8JsonSerializable, IJsonModel<AnalyzeTextOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalyzeTextOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BlocklistNames))
            {
                writer.WritePropertyName("blocklistNames"u8);
                writer.WriteStartArray();
                foreach (var item in BlocklistNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HaltOnBlocklistHit))
            {
                writer.WritePropertyName("haltOnBlocklistHit"u8);
                writer.WriteBooleanValue(HaltOnBlocklistHit.Value);
            }
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("outputType"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
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

        AnalyzeTextOptions IJsonModel<AnalyzeTextOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextOptions(document.RootElement, options);
        }

        internal static AnalyzeTextOptions DeserializeAnalyzeTextOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            Optional<IList<TextCategory>> categories = default;
            Optional<IList<string>> blocklistNames = default;
            Optional<bool> haltOnBlocklistHit = default;
            Optional<AnalyzeTextOutputType> outputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextCategory> array = new List<TextCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new TextCategory(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("blocklistNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    blocklistNames = array;
                    continue;
                }
                if (property.NameEquals("haltOnBlocklistHit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    haltOnBlocklistHit = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("outputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputType = new AnalyzeTextOutputType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyzeTextOptions(text, Optional.ToList(categories), Optional.ToList(blocklistNames), Optional.ToNullable(haltOnBlocklistHit), Optional.ToNullable(outputType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeTextOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextOptions)} does not support '{options.Format}' format.");
            }
        }

        AnalyzeTextOptions IPersistableModel<AnalyzeTextOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeTextOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeTextOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeTextOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
