// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The ExternalNetwork patch resource definition. </summary>
    public partial class NetworkFabricExternalNetworkPatch
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

        /// <summary> Initializes a new instance of <see cref="NetworkFabricExternalNetworkPatch"/>. </summary>
        public NetworkFabricExternalNetworkPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricExternalNetworkPatch"/>. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="importRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="exportRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="importRoutePolicy"> Import Route Policy either IPv4 or IPv6. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy either IPv4 or IPv6. </param>
        /// <param name="peeringOption"> Peering option list. </param>
        /// <param name="optionBProperties"> option B properties object. </param>
        /// <param name="optionAProperties"> option A properties object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricExternalNetworkPatch(string annotation, ResourceIdentifier importRoutePolicyId, ResourceIdentifier exportRoutePolicyId, ImportRoutePolicy importRoutePolicy, ExportRoutePolicy exportRoutePolicy, PeeringOption? peeringOption, L3OptionBProperties optionBProperties, ExternalNetworkPatchOptionAProperties optionAProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Annotation = annotation;
            ImportRoutePolicyId = importRoutePolicyId;
            ExportRoutePolicyId = exportRoutePolicyId;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            PeeringOption = peeringOption;
            OptionBProperties = optionBProperties;
            OptionAProperties = optionAProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ImportRoutePolicyId { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ExportRoutePolicyId { get; set; }
        /// <summary> Import Route Policy either IPv4 or IPv6. </summary>
        public ImportRoutePolicy ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy either IPv4 or IPv6. </summary>
        public ExportRoutePolicy ExportRoutePolicy { get; set; }
        /// <summary> Peering option list. </summary>
        public PeeringOption? PeeringOption { get; set; }
        /// <summary> option B properties object. </summary>
        public L3OptionBProperties OptionBProperties { get; set; }
        /// <summary> option A properties object. </summary>
        public ExternalNetworkPatchOptionAProperties OptionAProperties { get; set; }
    }
}
