// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class AssignmentDeploymentJobResult : IUtf8JsonSerializable, IJsonModel<AssignmentDeploymentJobResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignmentDeploymentJobResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssignmentDeploymentJobResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJobResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentDeploymentJobResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
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

        AssignmentDeploymentJobResult IJsonModel<AssignmentDeploymentJobResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJobResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentDeploymentJobResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignmentDeploymentJobResult(document.RootElement, options);
        }

        internal static AssignmentDeploymentJobResult DeserializeAssignmentDeploymentJobResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureResourceManagerError> error = default;
            Optional<IList<AssignmentJobCreatedResult>> resources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = AzureResourceManagerError.DeserializeAzureResourceManagerError(property.Value);
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentJobCreatedResult> array = new List<AssignmentJobCreatedResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentJobCreatedResult.DeserializeAssignmentJobCreatedResult(item));
                    }
                    resources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssignmentDeploymentJobResult(error.Value, Optional.ToList(resources), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssignmentDeploymentJobResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJobResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssignmentDeploymentJobResult)} does not support '{options.Format}' format.");
            }
        }

        AssignmentDeploymentJobResult IPersistableModel<AssignmentDeploymentJobResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJobResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssignmentDeploymentJobResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignmentDeploymentJobResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignmentDeploymentJobResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
