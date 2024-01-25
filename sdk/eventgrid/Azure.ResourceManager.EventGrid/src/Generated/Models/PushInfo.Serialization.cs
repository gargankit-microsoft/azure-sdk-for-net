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
    public partial class PushInfo : IUtf8JsonSerializable, IJsonModel<PushInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PushInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PushInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PushInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(EventTimeToLive))
            {
                writer.WritePropertyName("eventTimeToLive"u8);
                writer.WriteStringValue(EventTimeToLive);
            }
            if (Optional.IsDefined(DeadLetterDestinationWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterDestinationWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterDestinationWithResourceIdentity);
            }
            if (Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity"u8);
                writer.WriteObjectValue(DeliveryWithResourceIdentity);
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

        PushInfo IJsonModel<PushInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PushInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePushInfo(document.RootElement, options);
        }

        internal static PushInfo DeserializePushInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxDeliveryCount = default;
            Optional<string> eventTimeToLive = default;
            Optional<DeadLetterWithResourceIdentity> deadLetterDestinationWithResourceIdentity = default;
            Optional<DeliveryWithResourceIdentity> deliveryWithResourceIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxDeliveryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventTimeToLive"u8))
                {
                    eventTimeToLive = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterDestinationWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterDestinationWithResourceIdentity = DeadLetterWithResourceIdentity.DeserializeDeadLetterWithResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryWithResourceIdentity = DeliveryWithResourceIdentity.DeserializeDeliveryWithResourceIdentity(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PushInfo(Optional.ToNullable(maxDeliveryCount), eventTimeToLive.Value, deadLetterDestinationWithResourceIdentity.Value, deliveryWithResourceIdentity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PushInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PushInfo)} does not support '{options.Format}' format.");
            }
        }

        PushInfo IPersistableModel<PushInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePushInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PushInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PushInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
