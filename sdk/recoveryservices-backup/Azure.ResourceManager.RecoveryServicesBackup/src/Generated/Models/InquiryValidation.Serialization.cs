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
    public partial class InquiryValidation : IUtf8JsonSerializable, IJsonModel<InquiryValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InquiryValidation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InquiryValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InquiryValidation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(ErrorDetail))
            {
                writer.WritePropertyName("errorDetail"u8);
                writer.WriteObjectValue(ErrorDetail);
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalDetail))
            {
                writer.WritePropertyName("additionalDetail"u8);
                writer.WriteStringValue(AdditionalDetail);
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectableItemCount))
            {
                writer.WritePropertyName("protectableItemCount"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectableItemCount);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectableItemCount))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        InquiryValidation IJsonModel<InquiryValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InquiryValidation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInquiryValidation(document.RootElement, options);
        }

        internal static InquiryValidation DeserializeInquiryValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            Optional<BackupErrorDetail> errorDetail = default;
            Optional<string> additionalDetail = default;
            Optional<BinaryData> protectableItemCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetail = BackupErrorDetail.DeserializeBackupErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalDetail"u8))
                {
                    additionalDetail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectableItemCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InquiryValidation(status.Value, errorDetail.Value, additionalDetail.Value, protectableItemCount.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InquiryValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InquiryValidation)} does not support '{options.Format}' format.");
            }
        }

        InquiryValidation IPersistableModel<InquiryValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InquiryValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInquiryValidation(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InquiryValidation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InquiryValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
