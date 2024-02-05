// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnServerConfigurationData : IUtf8JsonSerializable, IJsonModel<VpnServerConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnServerConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnServerConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VpnProtocols))
            {
                writer.WritePropertyName("vpnProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in VpnProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnAuthenticationTypes))
            {
                writer.WritePropertyName("vpnAuthenticationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in VpnAuthenticationTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientRootCertificates))
            {
                writer.WritePropertyName("vpnClientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientRevokedCertificates))
            {
                writer.WritePropertyName("vpnClientRevokedCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientRevokedCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RadiusServerRootCertificates))
            {
                writer.WritePropertyName("radiusServerRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in RadiusServerRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RadiusClientRootCertificates))
            {
                writer.WritePropertyName("radiusClientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in RadiusClientRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VpnClientIPsecPolicies))
            {
                writer.WritePropertyName("vpnClientIpsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in VpnClientIPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RadiusServerAddress))
            {
                writer.WritePropertyName("radiusServerAddress"u8);
                writer.WriteStringValue(RadiusServerAddress);
            }
            if (Optional.IsDefined(RadiusServerSecret))
            {
                writer.WritePropertyName("radiusServerSecret"u8);
                writer.WriteStringValue(RadiusServerSecret);
            }
            if (Optional.IsCollectionDefined(RadiusServers))
            {
                writer.WritePropertyName("radiusServers"u8);
                writer.WriteStartArray();
                foreach (var item in RadiusServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AadAuthenticationParameters))
            {
                writer.WritePropertyName("aadAuthenticationParameters"u8);
                writer.WriteObjectValue(AadAuthenticationParameters);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(P2SVpnGateways))
            {
                writer.WritePropertyName("p2SVpnGateways"u8);
                writer.WriteStartArray();
                foreach (var item in P2SVpnGateways)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConfigurationPolicyGroups))
            {
                writer.WritePropertyName("configurationPolicyGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationPolicyGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        VpnServerConfigurationData IJsonModel<VpnServerConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnServerConfigurationData(document.RootElement, options);
        }

        internal static VpnServerConfigurationData DeserializeVpnServerConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<VpnGatewayTunnelingProtocol>> vpnProtocols = default;
            Optional<IList<VpnAuthenticationType>> vpnAuthenticationTypes = default;
            Optional<IList<VpnServerConfigVpnClientRootCertificate>> vpnClientRootCertificates = default;
            Optional<IList<VpnServerConfigVpnClientRevokedCertificate>> vpnClientRevokedCertificates = default;
            Optional<IList<VpnServerConfigRadiusServerRootCertificate>> radiusServerRootCertificates = default;
            Optional<IList<VpnServerConfigRadiusClientRootCertificate>> radiusClientRootCertificates = default;
            Optional<IList<IPsecPolicy>> vpnClientIPsecPolicies = default;
            Optional<string> radiusServerAddress = default;
            Optional<string> radiusServerSecret = default;
            Optional<IList<RadiusServer>> radiusServers = default;
            Optional<AadAuthenticationParameters> aadAuthenticationParameters = default;
            Optional<string> provisioningState = default;
            Optional<IReadOnlyList<P2SVpnGatewayData>> p2sVpnGateways = default;
            Optional<IList<VpnServerConfigurationPolicyGroupData>> configurationPolicyGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vpnProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnGatewayTunnelingProtocol> array = new List<VpnGatewayTunnelingProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VpnGatewayTunnelingProtocol(item.GetString()));
                            }
                            vpnProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnAuthenticationTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnAuthenticationType> array = new List<VpnAuthenticationType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VpnAuthenticationType(item.GetString()));
                            }
                            vpnAuthenticationTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientRootCertificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigVpnClientRootCertificate> array = new List<VpnServerConfigVpnClientRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigVpnClientRootCertificate.DeserializeVpnServerConfigVpnClientRootCertificate(item));
                            }
                            vpnClientRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientRevokedCertificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigVpnClientRevokedCertificate> array = new List<VpnServerConfigVpnClientRevokedCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigVpnClientRevokedCertificate.DeserializeVpnServerConfigVpnClientRevokedCertificate(item));
                            }
                            vpnClientRevokedCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusServerRootCertificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigRadiusServerRootCertificate> array = new List<VpnServerConfigRadiusServerRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigRadiusServerRootCertificate.DeserializeVpnServerConfigRadiusServerRootCertificate(item));
                            }
                            radiusServerRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusClientRootCertificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigRadiusClientRootCertificate> array = new List<VpnServerConfigRadiusClientRootCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigRadiusClientRootCertificate.DeserializeVpnServerConfigRadiusClientRootCertificate(item));
                            }
                            radiusClientRootCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnClientIpsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item));
                            }
                            vpnClientIPsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("radiusServerAddress"u8))
                        {
                            radiusServerAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("radiusServerSecret"u8))
                        {
                            radiusServerSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("radiusServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RadiusServer> array = new List<RadiusServer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RadiusServer.DeserializeRadiusServer(item));
                            }
                            radiusServers = array;
                            continue;
                        }
                        if (property0.NameEquals("aadAuthenticationParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadAuthenticationParameters = AadAuthenticationParameters.DeserializeAadAuthenticationParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<P2SVpnGatewayData> array = new List<P2SVpnGatewayData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(P2SVpnGatewayData.DeserializeP2SVpnGatewayData(item));
                            }
                            p2sVpnGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("configurationPolicyGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigurationPolicyGroupData> array = new List<VpnServerConfigurationPolicyGroupData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(item));
                            }
                            configurationPolicyGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnServerConfigurationData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(etag), Optional.ToList(vpnProtocols), Optional.ToList(vpnAuthenticationTypes), Optional.ToList(vpnClientRootCertificates), Optional.ToList(vpnClientRevokedCertificates), Optional.ToList(radiusServerRootCertificates), Optional.ToList(radiusClientRootCertificates), Optional.ToList(vpnClientIPsecPolicies), radiusServerAddress.Value, radiusServerSecret.Value, Optional.ToList(radiusServers), aadAuthenticationParameters.Value, provisioningState.Value, Optional.ToList(p2sVpnGateways), Optional.ToList(configurationPolicyGroups));
        }

        BinaryData IPersistableModel<VpnServerConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        VpnServerConfigurationData IPersistableModel<VpnServerConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnServerConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnServerConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
