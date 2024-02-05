// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownAzureCoreNetworkFunctionApplication : IUtf8JsonSerializable, IJsonModel<AzureCoreNetworkFunctionApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCoreNetworkFunctionApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureCoreNetworkFunctionApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
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

        AzureCoreNetworkFunctionApplication IJsonModel<AzureCoreNetworkFunctionApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownAzureCoreNetworkFunctionApplication(document.RootElement, options);
        }

        internal static UnknownAzureCoreNetworkFunctionApplication DeserializeUnknownAzureCoreNetworkFunctionApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureCoreArtifactType artifactType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            Optional<string> name = default;
            Optional<DependsOnProfile> dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureCoreArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownAzureCoreNetworkFunctionApplication(name.Value, dependsOnProfile.Value, serializedAdditionalRawData, artifactType);
        }

        BinaryData IPersistableModel<AzureCoreNetworkFunctionApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        AzureCoreNetworkFunctionApplication IPersistableModel<AzureCoreNetworkFunctionApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownAzureCoreNetworkFunctionApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCoreNetworkFunctionApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
