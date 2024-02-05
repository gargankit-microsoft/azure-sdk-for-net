// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRUpstreamTemplate : IUtf8JsonSerializable, IJsonModel<SignalRUpstreamTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRUpstreamTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SignalRUpstreamTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRUpstreamTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HubPattern))
            {
                writer.WritePropertyName("hubPattern"u8);
                writer.WriteStringValue(HubPattern);
            }
            if (Optional.IsDefined(EventPattern))
            {
                writer.WritePropertyName("eventPattern"u8);
                writer.WriteStringValue(EventPattern);
            }
            if (Optional.IsDefined(CategoryPattern))
            {
                writer.WritePropertyName("categoryPattern"u8);
                writer.WriteStringValue(CategoryPattern);
            }
            writer.WritePropertyName("urlTemplate"u8);
            writer.WriteStringValue(UrlTemplate);
            if (Optional.IsDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteObjectValue(Auth);
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

        SignalRUpstreamTemplate IJsonModel<SignalRUpstreamTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRUpstreamTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRUpstreamTemplate(document.RootElement, options);
        }

        internal static SignalRUpstreamTemplate DeserializeSignalRUpstreamTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hubPattern = default;
            Optional<string> eventPattern = default;
            Optional<string> categoryPattern = default;
            string urlTemplate = default;
            Optional<SignalRUpstreamAuthSettings> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hubPattern"u8))
                {
                    hubPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventPattern"u8))
                {
                    eventPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categoryPattern"u8))
                {
                    categoryPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urlTemplate"u8))
                {
                    urlTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    auth = SignalRUpstreamAuthSettings.DeserializeSignalRUpstreamAuthSettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignalRUpstreamTemplate(hubPattern.Value, eventPattern.Value, categoryPattern.Value, urlTemplate, auth.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignalRUpstreamTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignalRUpstreamTemplate)} does not support '{options.Format}' format.");
            }
        }

        SignalRUpstreamTemplate IPersistableModel<SignalRUpstreamTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRUpstreamTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRUpstreamTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignalRUpstreamTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRUpstreamTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
