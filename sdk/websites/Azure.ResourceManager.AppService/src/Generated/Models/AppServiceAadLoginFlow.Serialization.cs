// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAadLoginFlow : IUtf8JsonSerializable, IJsonModel<AppServiceAadLoginFlow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceAadLoginFlow>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceAadLoginFlow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadLoginFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadLoginFlow)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoginParameters))
            {
                writer.WritePropertyName("loginParameters"u8);
                writer.WriteStartArray();
                foreach (var item in LoginParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsWwwAuthenticateDisabled))
            {
                writer.WritePropertyName("disableWWWAuthenticate"u8);
                writer.WriteBooleanValue(IsWwwAuthenticateDisabled.Value);
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

        AppServiceAadLoginFlow IJsonModel<AppServiceAadLoginFlow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadLoginFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadLoginFlow)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceAadLoginFlow(document.RootElement, options);
        }

        internal static AppServiceAadLoginFlow DeserializeAppServiceAadLoginFlow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> loginParameters = default;
            Optional<bool> disableWWWAuthenticate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginParameters"u8))
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
                    loginParameters = array;
                    continue;
                }
                if (property.NameEquals("disableWWWAuthenticate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableWWWAuthenticate = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceAadLoginFlow(Optional.ToList(loginParameters), Optional.ToNullable(disableWWWAuthenticate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceAadLoginFlow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadLoginFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadLoginFlow)} does not support '{options.Format}' format.");
            }
        }

        AppServiceAadLoginFlow IPersistableModel<AppServiceAadLoginFlow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadLoginFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceAadLoginFlow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadLoginFlow)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceAadLoginFlow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
