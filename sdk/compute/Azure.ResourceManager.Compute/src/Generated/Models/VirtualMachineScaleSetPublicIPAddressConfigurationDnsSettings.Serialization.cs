// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings : IUtf8JsonSerializable, IJsonModelSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainNameLabel"u8);
            writer.WriteStringValue(DomainNameLabel);
            if (Optional.IsDefined(DomainNameLabelScope))
            {
                writer.WritePropertyName("domainNameLabelScope"u8);
                writer.WriteStringValue(DomainNameLabelScope.Value.ToString());
            }
            writer.WriteEndObject();
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options) => throw new NotImplementedException();

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        BinaryData IModelSerializable.Serialize(ModelSerializerOptions options) => throw new NotImplementedException();

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options) => DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(JsonDocument.Parse(data).RootElement);

        internal static VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainNameLabel = default;
            Optional<DomainNameLabelScopeType> domainNameLabelScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"u8))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainNameLabelScope = new DomainNameLabelScopeType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(domainNameLabel, Optional.ToNullable(domainNameLabelScope));
        }
    }
}
