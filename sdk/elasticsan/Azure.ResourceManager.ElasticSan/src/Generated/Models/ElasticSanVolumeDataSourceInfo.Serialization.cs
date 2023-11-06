// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVolumeDataSourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CreateSource))
            {
                writer.WritePropertyName("createSource"u8);
                writer.WriteStringValue(CreateSource.Value.ToString());
            }
            if (Optional.IsDefined(SourceId))
            {
                writer.WritePropertyName("sourceId"u8);
                writer.WriteStringValue(SourceId);
            }
            writer.WriteEndObject();
        }

        internal static ElasticSanVolumeDataSourceInfo DeserializeElasticSanVolumeDataSourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ElasticSanVolumeCreateOption> createSource = default;
            Optional<ResourceIdentifier> sourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createSource = new ElasticSanVolumeCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ElasticSanVolumeDataSourceInfo(Optional.ToNullable(createSource), sourceId.Value);
        }
    }
}
