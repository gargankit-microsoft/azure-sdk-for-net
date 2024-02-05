// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class TableLevelSharingProperties : IUtf8JsonSerializable, IJsonModel<TableLevelSharingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TableLevelSharingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TableLevelSharingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableLevelSharingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExternalTablesToExclude))
            {
                writer.WritePropertyName("externalTablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToInclude))
            {
                writer.WritePropertyName("externalTablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToExclude))
            {
                writer.WritePropertyName("materializedViewsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToInclude))
            {
                writer.WritePropertyName("materializedViewsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToExclude))
            {
                writer.WritePropertyName("tablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToInclude))
            {
                writer.WritePropertyName("tablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToInclude)
                {
                    writer.WriteStringValue(item);
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

        TableLevelSharingProperties IJsonModel<TableLevelSharingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableLevelSharingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTableLevelSharingProperties(document.RootElement, options);
        }

        internal static TableLevelSharingProperties DeserializeTableLevelSharingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> externalTablesToExclude = default;
            Optional<IList<string>> externalTablesToInclude = default;
            Optional<IList<string>> materializedViewsToExclude = default;
            Optional<IList<string>> materializedViewsToInclude = default;
            Optional<IList<string>> tablesToExclude = default;
            Optional<IList<string>> tablesToInclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("externalTablesToExclude"u8))
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
                    externalTablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToInclude"u8))
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
                    externalTablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToExclude"u8))
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
                    materializedViewsToExclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToInclude"u8))
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
                    materializedViewsToInclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToExclude"u8))
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
                    tablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToInclude"u8))
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
                    tablesToInclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TableLevelSharingProperties(Optional.ToList(externalTablesToExclude), Optional.ToList(externalTablesToInclude), Optional.ToList(materializedViewsToExclude), Optional.ToList(materializedViewsToInclude), Optional.ToList(tablesToExclude), Optional.ToList(tablesToInclude), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TableLevelSharingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        TableLevelSharingProperties IPersistableModel<TableLevelSharingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTableLevelSharingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TableLevelSharingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TableLevelSharingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
