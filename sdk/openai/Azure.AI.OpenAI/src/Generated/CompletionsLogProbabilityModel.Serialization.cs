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

namespace Azure.AI.OpenAI
{
    public partial class CompletionsLogProbabilityModel : IUtf8JsonSerializable, IJsonModel<CompletionsLogProbabilityModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CompletionsLogProbabilityModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CompletionsLogProbabilityModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompletionsLogProbabilityModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CompletionsLogProbabilityModel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("tokens"u8);
            writer.WriteStartArray();
            foreach (var item in Tokens)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("token_logprobs"u8);
            writer.WriteStartArray();
            foreach (var item in TokenLogProbabilities)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteNumberValue(item.Value);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("top_logprobs"u8);
            writer.WriteStartArray();
            foreach (var item in TopLogProbabilities)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartObject();
                foreach (var item0 in item)
                {
                    writer.WritePropertyName(item0.Key);
                    if (item0.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteNumberValue(item0.Value.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("text_offset"u8);
            writer.WriteStartArray();
            foreach (var item in TextOffsets)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
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

        CompletionsLogProbabilityModel IJsonModel<CompletionsLogProbabilityModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompletionsLogProbabilityModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CompletionsLogProbabilityModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCompletionsLogProbabilityModel(document.RootElement, options);
        }

        internal static CompletionsLogProbabilityModel DeserializeCompletionsLogProbabilityModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> tokens = default;
            IReadOnlyList<float?> tokenLogprobs = default;
            IReadOnlyList<IDictionary<string, float?>> topLogprobs = default;
            IReadOnlyList<int> textOffset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokens"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tokens = array;
                    continue;
                }
                if (property.NameEquals("token_logprobs"u8))
                {
                    List<float?> array = new List<float?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetSingle());
                        }
                    }
                    tokenLogprobs = array;
                    continue;
                }
                if (property.NameEquals("top_logprobs"u8))
                {
                    List<IDictionary<string, float?>> array = new List<IDictionary<string, float?>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, float?> dictionary = new Dictionary<string, float?>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                if (property0.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property0.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property0.Name, property0.Value.GetSingle());
                                }
                            }
                            array.Add(dictionary);
                        }
                    }
                    topLogprobs = array;
                    continue;
                }
                if (property.NameEquals("text_offset"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    textOffset = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CompletionsLogProbabilityModel(tokens, tokenLogprobs, topLogprobs, textOffset, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CompletionsLogProbabilityModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompletionsLogProbabilityModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CompletionsLogProbabilityModel)} does not support '{options.Format}' format.");
            }
        }

        CompletionsLogProbabilityModel IPersistableModel<CompletionsLogProbabilityModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompletionsLogProbabilityModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCompletionsLogProbabilityModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CompletionsLogProbabilityModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CompletionsLogProbabilityModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CompletionsLogProbabilityModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCompletionsLogProbabilityModel(document.RootElement);
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
