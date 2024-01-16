// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn Client Parameters for package generation. </summary>
    public partial class VpnClientContent
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

        /// <summary> Initializes a new instance of <see cref="VpnClientContent"/>. </summary>
        public VpnClientContent()
        {
            ClientRootCertificates = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientContent"/>. </summary>
        /// <param name="processorArchitecture"> VPN client Processor Architecture. </param>
        /// <param name="authenticationMethod"> VPN client authentication method. </param>
        /// <param name="radiusServerAuthCertificate"> The public certificate data for the radius server authentication certificate as a Base-64 encoded string. Required only if external radius authentication has been configured with EAPTLS authentication. </param>
        /// <param name="clientRootCertificates"> A list of client root certificates public certificate data encoded as Base-64 strings. Optional parameter for external radius based authentication with EAPTLS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnClientContent(ProcessorArchitecture? processorArchitecture, NetworkAuthenticationMethod? authenticationMethod, string radiusServerAuthCertificate, IList<string> clientRootCertificates, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProcessorArchitecture = processorArchitecture;
            AuthenticationMethod = authenticationMethod;
            RadiusServerAuthCertificate = radiusServerAuthCertificate;
            ClientRootCertificates = clientRootCertificates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> VPN client Processor Architecture. </summary>
        public ProcessorArchitecture? ProcessorArchitecture { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public NetworkAuthenticationMethod? AuthenticationMethod { get; set; }
        /// <summary> The public certificate data for the radius server authentication certificate as a Base-64 encoded string. Required only if external radius authentication has been configured with EAPTLS authentication. </summary>
        public string RadiusServerAuthCertificate { get; set; }
        /// <summary> A list of client root certificates public certificate data encoded as Base-64 strings. Optional parameter for external radius based authentication with EAPTLS. </summary>
        public IList<string> ClientRootCertificates { get; }
    }
}
