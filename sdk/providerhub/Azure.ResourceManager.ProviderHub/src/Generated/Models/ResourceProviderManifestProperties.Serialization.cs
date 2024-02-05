// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceProviderManifestProperties : IUtf8JsonSerializable, IJsonModel<ResourceProviderManifestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceProviderManifestProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceProviderManifestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue(ProviderAuthentication);
            }
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue(Management);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TemplateDeploymentOptions))
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions);
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

        ResourceProviderManifestProperties IJsonModel<ResourceProviderManifestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderManifestProperties(document.RootElement, options);
        }

        internal static ResourceProviderManifestProperties DeserializeResourceProviderManifestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceProviderAuthentication> providerAuthentication = default;
            Optional<IList<ResourceProviderAuthorization>> providerAuthorizations = default;
            Optional<string> @namespace = default;
            Optional<string> providerVersion = default;
            Optional<ResourceProviderType> providerType = default;
            Optional<IList<string>> requiredFeatures = default;
            Optional<FeaturesRule> featuresRule = default;
            Optional<RequestHeaderOptions> requestHeaderOptions = default;
            Optional<ResourceProviderManagement> management = default;
            Optional<IList<ResourceProviderCapabilities>> capabilities = default;
            Optional<BinaryData> metadata = default;
            Optional<TemplateDeploymentOptions> templateDeploymentOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerType = new ResourceProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    management = ResourceProviderManagement.DeserializeResourceProviderManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderCapabilities> array = new List<ResourceProviderCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderCapabilities.DeserializeResourceProviderCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentOptions = TemplateDeploymentOptions.DeserializeTemplateDeploymentOptions(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceProviderManifestProperties(providerAuthentication.Value, Optional.ToList(providerAuthorizations), @namespace.Value, providerVersion.Value, Optional.ToNullable(providerType), Optional.ToList(requiredFeatures), featuresRule.Value, requestHeaderOptions.Value, management.Value, Optional.ToList(capabilities), metadata.Value, templateDeploymentOptions.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceProviderManifestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support '{options.Format}' format.");
            }
        }

        ResourceProviderManifestProperties IPersistableModel<ResourceProviderManifestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceProviderManifestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifestProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceProviderManifestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
