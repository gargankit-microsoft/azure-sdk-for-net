// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> The UnknownPolicyModelCustomProperties. </summary>
    internal partial class UnknownPolicyModelCustomProperties : PolicyModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPolicyModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPolicyModelCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownPolicyModelCustomProperties"/> for deserialization. </summary>
        internal UnknownPolicyModelCustomProperties()
        {
        }
    }
}
