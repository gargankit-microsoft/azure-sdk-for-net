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

namespace Azure.AI.Translation.Text
{
    public partial class GetLanguagesResult : IUtf8JsonSerializable, IJsonModel<GetLanguagesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetLanguagesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetLanguagesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetLanguagesResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Translation))
            {
                writer.WritePropertyName("translation"u8);
                writer.WriteStartObject();
                foreach (var item in Translation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Transliteration))
            {
                writer.WritePropertyName("transliteration"u8);
                writer.WriteStartObject();
                foreach (var item in Transliteration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Dictionary))
            {
                writer.WritePropertyName("dictionary"u8);
                writer.WriteStartObject();
                foreach (var item in Dictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
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

        GetLanguagesResult IJsonModel<GetLanguagesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetLanguagesResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetLanguagesResult(document.RootElement, options);
        }

        internal static GetLanguagesResult DeserializeGetLanguagesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, TranslationLanguage>> translation = default;
            Optional<IReadOnlyDictionary<string, TransliterationLanguage>> transliteration = default;
            Optional<IReadOnlyDictionary<string, SourceDictionaryLanguage>> dictionary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("translation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TranslationLanguage> dictionary0 = new Dictionary<string, TranslationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TranslationLanguage.DeserializeTranslationLanguage(property0.Value));
                    }
                    translation = dictionary0;
                    continue;
                }
                if (property.NameEquals("transliteration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TransliterationLanguage> dictionary0 = new Dictionary<string, TransliterationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TransliterationLanguage.DeserializeTransliterationLanguage(property0.Value));
                    }
                    transliteration = dictionary0;
                    continue;
                }
                if (property.NameEquals("dictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SourceDictionaryLanguage> dictionary0 = new Dictionary<string, SourceDictionaryLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, SourceDictionaryLanguage.DeserializeSourceDictionaryLanguage(property0.Value));
                    }
                    dictionary = dictionary0;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetLanguagesResult(Optional.ToDictionary(translation), Optional.ToDictionary(transliteration), Optional.ToDictionary(dictionary), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetLanguagesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetLanguagesResult)} does not support '{options.Format}' format.");
            }
        }

        GetLanguagesResult IPersistableModel<GetLanguagesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetLanguagesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetLanguagesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetLanguagesResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetLanguagesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GetLanguagesResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGetLanguagesResult(document.RootElement);
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
