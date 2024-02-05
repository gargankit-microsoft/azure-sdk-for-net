// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ReportConfigTimePeriod : IUtf8JsonSerializable, IJsonModel<ReportConfigTimePeriod>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportConfigTimePeriod>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportConfigTimePeriod>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportConfigTimePeriod)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("from"u8);
            writer.WriteStringValue(From, "O");
            writer.WritePropertyName("to"u8);
            writer.WriteStringValue(To, "O");
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

        ReportConfigTimePeriod IJsonModel<ReportConfigTimePeriod>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportConfigTimePeriod)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportConfigTimePeriod(document.RootElement, options);
        }

        internal static ReportConfigTimePeriod DeserializeReportConfigTimePeriod(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset @from = default;
            DateTimeOffset to = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportConfigTimePeriod(@from, to, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportConfigTimePeriod>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportConfigTimePeriod)} does not support '{options.Format}' format.");
            }
        }

        ReportConfigTimePeriod IPersistableModel<ReportConfigTimePeriod>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportConfigTimePeriod(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportConfigTimePeriod)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportConfigTimePeriod>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
