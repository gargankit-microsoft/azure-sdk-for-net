// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AmazonS3LinkedService : IUtf8JsonSerializable, IJsonModel<AmazonS3LinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmazonS3LinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmazonS3LinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonS3LinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmazonS3LinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                JsonSerializer.Serialize(writer, AuthenticationType);
            }
            if (Optional.IsDefined(AccessKeyId))
            {
                writer.WritePropertyName("accessKeyId"u8);
                JsonSerializer.Serialize(writer, AccessKeyId);
            }
            if (Optional.IsDefined(SecretAccessKey))
            {
                writer.WritePropertyName("secretAccessKey"u8);
                JsonSerializer.Serialize(writer, SecretAccessKey);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl"u8);
                JsonSerializer.Serialize(writer, ServiceUri);
            }
            if (Optional.IsDefined(SessionToken))
            {
                writer.WritePropertyName("sessionToken"u8);
                JsonSerializer.Serialize(writer, SessionToken);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        AmazonS3LinkedService IJsonModel<AmazonS3LinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonS3LinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmazonS3LinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmazonS3LinkedService(document.RootElement, options);
        }

        internal static AmazonS3LinkedService DeserializeAmazonS3LinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DataFactoryElement<string>> authenticationType = default;
            Optional<DataFactoryElement<string>> accessKeyId = default;
            Optional<DataFactorySecretBaseDefinition> secretAccessKey = default;
            Optional<DataFactoryElement<string>> serviceUrl = default;
            Optional<DataFactorySecretBaseDefinition> sessionToken = default;
            Optional<string> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accessKeyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessKeyId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("secretAccessKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secretAccessKey = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceUrl = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sessionToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionToken = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonS3LinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, authenticationType.Value, accessKeyId.Value, secretAccessKey, serviceUrl.Value, sessionToken, encryptedCredential.Value);
        }

        BinaryData IPersistableModel<AmazonS3LinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonS3LinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmazonS3LinkedService)} does not support '{options.Format}' format.");
            }
        }

        AmazonS3LinkedService IPersistableModel<AmazonS3LinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmazonS3LinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmazonS3LinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmazonS3LinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmazonS3LinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
