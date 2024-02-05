// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVSite fabric specific details. </summary>
    public partial class HyperVSiteDetails : FabricSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="HyperVSiteDetails"/>. </summary>
        internal HyperVSiteDetails()
        {
            HyperVHosts = new ChangeTrackingList<HyperVHostDetails>();
            InstanceType = "HyperVSite";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVSiteDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="hyperVHosts"> The list of Hyper-V hosts associated with the fabric. </param>
        internal HyperVSiteDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<HyperVHostDetails> hyperVHosts) : base(instanceType, serializedAdditionalRawData)
        {
            HyperVHosts = hyperVHosts;
            InstanceType = instanceType ?? "HyperVSite";
        }

        /// <summary> The list of Hyper-V hosts associated with the fabric. </summary>
        public IReadOnlyList<HyperVHostDetails> HyperVHosts { get; }
    }
}
