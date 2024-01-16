// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnClientConfiguration for P2S client. </summary>
    public partial class VpnClientConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VpnClientConfiguration"/>. </summary>
        public VpnClientConfiguration()
        {
            VpnClientRootCertificates = new ChangeTrackingList<VpnClientRootCertificate>();
            VpnClientRevokedCertificates = new ChangeTrackingList<VpnClientRevokedCertificate>();
            VpnClientProtocols = new ChangeTrackingList<VpnClientProtocol>();
            VpnAuthenticationTypes = new ChangeTrackingList<VpnAuthenticationType>();
            VpnClientIPsecPolicies = new ChangeTrackingList<IPsecPolicy>();
            RadiusServers = new ChangeTrackingList<RadiusServer>();
            VngClientConnectionConfigurations = new ChangeTrackingList<VngClientConnectionConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientConfiguration"/>. </summary>
        /// <param name="vpnClientAddressPool"> The reference to the address space resource which represents Address space for P2S VpnClient. </param>
        /// <param name="vpnClientRootCertificates"> VpnClientRootCertificate for virtual network gateway. </param>
        /// <param name="vpnClientRevokedCertificates"> VpnClientRevokedCertificate for Virtual network gateway. </param>
        /// <param name="vpnClientProtocols"> VpnClientProtocols for Virtual network gateway. </param>
        /// <param name="vpnAuthenticationTypes"> VPN authentication types for the virtual network gateway.. </param>
        /// <param name="vpnClientIPsecPolicies"> VpnClientIpsecPolicies for virtual network gateway P2S client. </param>
        /// <param name="radiusServerAddress"> The radius server address property of the VirtualNetworkGateway resource for vpn client connection. </param>
        /// <param name="radiusServerSecret"> The radius secret property of the VirtualNetworkGateway resource for vpn client connection. </param>
        /// <param name="radiusServers"> The radiusServers property for multiple radius server configuration. </param>
        /// <param name="aadTenant"> The AADTenant property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </param>
        /// <param name="aadAudience"> The AADAudience property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </param>
        /// <param name="aadIssuer"> The AADIssuer property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </param>
        /// <param name="vngClientConnectionConfigurations"> per ip address pool connection policy for virtual network gateway P2S client. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnClientConfiguration(AddressSpace vpnClientAddressPool, IList<VpnClientRootCertificate> vpnClientRootCertificates, IList<VpnClientRevokedCertificate> vpnClientRevokedCertificates, IList<VpnClientProtocol> vpnClientProtocols, IList<VpnAuthenticationType> vpnAuthenticationTypes, IList<IPsecPolicy> vpnClientIPsecPolicies, string radiusServerAddress, string radiusServerSecret, IList<RadiusServer> radiusServers, string aadTenant, string aadAudience, string aadIssuer, IList<VngClientConnectionConfiguration> vngClientConnectionConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VpnClientAddressPool = vpnClientAddressPool;
            VpnClientRootCertificates = vpnClientRootCertificates;
            VpnClientRevokedCertificates = vpnClientRevokedCertificates;
            VpnClientProtocols = vpnClientProtocols;
            VpnAuthenticationTypes = vpnAuthenticationTypes;
            VpnClientIPsecPolicies = vpnClientIPsecPolicies;
            RadiusServerAddress = radiusServerAddress;
            RadiusServerSecret = radiusServerSecret;
            RadiusServers = radiusServers;
            AadTenant = aadTenant;
            AadAudience = aadAudience;
            AadIssuer = aadIssuer;
            VngClientConnectionConfigurations = vngClientConnectionConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The reference to the address space resource which represents Address space for P2S VpnClient. </summary>
        internal AddressSpace VpnClientAddressPool { get; set; }
        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> VpnClientAddressPrefixes
        {
            get
            {
                if (VpnClientAddressPool is null)
                    VpnClientAddressPool = new AddressSpace();
                return VpnClientAddressPool.AddressPrefixes;
            }
        }

        /// <summary> VpnClientRootCertificate for virtual network gateway. </summary>
        public IList<VpnClientRootCertificate> VpnClientRootCertificates { get; }
        /// <summary> VpnClientRevokedCertificate for Virtual network gateway. </summary>
        public IList<VpnClientRevokedCertificate> VpnClientRevokedCertificates { get; }
        /// <summary> VpnClientProtocols for Virtual network gateway. </summary>
        public IList<VpnClientProtocol> VpnClientProtocols { get; }
        /// <summary> VPN authentication types for the virtual network gateway.. </summary>
        public IList<VpnAuthenticationType> VpnAuthenticationTypes { get; }
        /// <summary> VpnClientIpsecPolicies for virtual network gateway P2S client. </summary>
        public IList<IPsecPolicy> VpnClientIPsecPolicies { get; }
        /// <summary> The radius server address property of the VirtualNetworkGateway resource for vpn client connection. </summary>
        public string RadiusServerAddress { get; set; }
        /// <summary> The radius secret property of the VirtualNetworkGateway resource for vpn client connection. </summary>
        public string RadiusServerSecret { get; set; }
        /// <summary> The radiusServers property for multiple radius server configuration. </summary>
        public IList<RadiusServer> RadiusServers { get; }
        /// <summary> The AADTenant property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </summary>
        public string AadTenant { get; set; }
        /// <summary> The AADAudience property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </summary>
        public string AadAudience { get; set; }
        /// <summary> The AADIssuer property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication. </summary>
        public string AadIssuer { get; set; }
        /// <summary> per ip address pool connection policy for virtual network gateway P2S client. </summary>
        public IList<VngClientConnectionConfiguration> VngClientConnectionConfigurations { get; }
    }
}
