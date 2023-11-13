// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("iconUri"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Swagger))
            {
                writer.WritePropertyName("swagger"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Swagger);
#else
                using (JsonDocument document = JsonDocument.Parse(Swagger))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(BrandColor))
            {
                writer.WritePropertyName("brandColor"u8);
                writer.WriteStringValue(BrandColor);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(IntegrationServiceEnvironment))
            {
                writer.WritePropertyName("integrationServiceEnvironment"u8);
                writer.WriteObjectValue(IntegrationServiceEnvironment);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static LogicApiReference DeserializeLogicApiReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> iconUri = default;
            Optional<BinaryData> swagger = default;
            Optional<string> brandColor = default;
            Optional<LogicApiTier> category = default;
            Optional<LogicResourceReference> integrationServiceEnvironment = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swagger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    swagger = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("brandColor"u8))
                {
                    brandColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new LogicApiTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("integrationServiceEnvironment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationServiceEnvironment = DeserializeLogicResourceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new LogicApiReference(id.Value, name.Value, Optional.ToNullable(type), displayName.Value, description.Value, iconUri.Value, swagger.Value, brandColor.Value, Optional.ToNullable(category), integrationServiceEnvironment.Value);
        }
    }
}
