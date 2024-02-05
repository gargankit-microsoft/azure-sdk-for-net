// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmTrafficManagerModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.TrafficManagerNameAvailabilityResult"/>. </summary>
        /// <param name="name"> The relative name. </param>
        /// <param name="resourceType"> Traffic Manager profile resource type. </param>
        /// <param name="isNameAvailable"> Describes whether the relative name is available or not. </param>
        /// <param name="unavailableReason"> The reason why the name is not available, when applicable. </param>
        /// <param name="message"> Descriptive message that explains why the name is not available, when applicable. </param>
        /// <returns> A new <see cref="Models.TrafficManagerNameAvailabilityResult"/> instance for mocking. </returns>
        public static TrafficManagerNameAvailabilityResult TrafficManagerNameAvailabilityResult(string name = null, ResourceType? resourceType = null, bool? isNameAvailable = null, string unavailableReason = null, string message = null)
        {
            return new TrafficManagerNameAvailabilityResult(name, resourceType, isNameAvailable, unavailableReason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TrafficManagerDnsConfig"/>. </summary>
        /// <param name="relativeName"> The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile. </param>
        /// <param name="fqdn"> The fully-qualified domain name (FQDN) of the Traffic Manager profile. This is formed from the concatenation of the RelativeName with the DNS domain used by Azure Traffic Manager. </param>
        /// <param name="ttl"> The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile. </param>
        /// <returns> A new <see cref="Models.TrafficManagerDnsConfig"/> instance for mocking. </returns>
        public static TrafficManagerDnsConfig TrafficManagerDnsConfig(string relativeName = null, string fqdn = null, long? ttl = null)
        {
            return new TrafficManagerDnsConfig(relativeName, fqdn, ttl, serializedAdditionalRawData: null);
        }
    }
}
