// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetAzureDBForMySqlTaskOutput : IUtf8JsonSerializable, IJsonModel<ConnectToTargetAzureDBForMySqlTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToTargetAzureDBForMySqlTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToTargetAzureDBForMySqlTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetAzureDBForMySqlTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerBrandVersion))
            {
                writer.WritePropertyName("targetServerBrandVersion"u8);
                writer.WriteStringValue(TargetServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ConnectToTargetAzureDBForMySqlTaskOutput IJsonModel<ConnectToTargetAzureDBForMySqlTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetAzureDBForMySqlTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetAzureDBForMySqlTaskOutput(document.RootElement, options);
        }

        internal static ConnectToTargetAzureDBForMySqlTaskOutput DeserializeConnectToTargetAzureDBForMySqlTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> serverVersion = default;
            Optional<IReadOnlyList<string>> databases = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverVersion"u8))
                {
                    serverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databases"u8))
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
                    databases = array;
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToTargetAzureDBForMySqlTaskOutput(id.Value, serverVersion.Value, Optional.ToList(databases), targetServerBrandVersion.Value, Optional.ToList(validationErrors), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetAzureDBForMySqlTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToTargetAzureDBForMySqlTaskOutput IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToTargetAzureDBForMySqlTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetAzureDBForMySqlTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToTargetAzureDBForMySqlTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
