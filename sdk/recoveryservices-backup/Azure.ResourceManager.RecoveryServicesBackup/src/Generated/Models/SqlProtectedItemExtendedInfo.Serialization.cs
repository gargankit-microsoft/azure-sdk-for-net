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
    public partial class SqlProtectedItemExtendedInfo : IUtf8JsonSerializable, IJsonModel<SqlProtectedItemExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlProtectedItemExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlProtectedItemExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlProtectedItemExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OldestRecoverOn))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(PolicyState))
            {
                writer.WritePropertyName("policyState"u8);
                writer.WriteStringValue(PolicyState);
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

        SqlProtectedItemExtendedInfo IJsonModel<SqlProtectedItemExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlProtectedItemExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlProtectedItemExtendedInfo(document.RootElement, options);
        }

        internal static SqlProtectedItemExtendedInfo DeserializeSqlProtectedItemExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> oldestRecoveryPoint = default;
            Optional<int> recoveryPointCount = default;
            Optional<string> policyState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyState"u8))
                {
                    policyState = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlProtectedItemExtendedInfo(Optional.ToNullable(oldestRecoveryPoint), Optional.ToNullable(recoveryPointCount), policyState.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlProtectedItemExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlProtectedItemExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        SqlProtectedItemExtendedInfo IPersistableModel<SqlProtectedItemExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlProtectedItemExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlProtectedItemExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlProtectedItemExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
