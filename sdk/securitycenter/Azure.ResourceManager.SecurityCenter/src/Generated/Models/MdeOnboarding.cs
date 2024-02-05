// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The resource of the configuration or data needed to onboard the machine to MDE. </summary>
    public partial class MdeOnboarding : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MdeOnboarding"/>. </summary>
        public MdeOnboarding()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MdeOnboarding"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="onboardingPackageWindows"> The onboarding package used to onboard Windows machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </param>
        /// <param name="onboardingPackageLinux"> The onboarding package used to onboard Linux machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MdeOnboarding(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, byte[] onboardingPackageWindows, byte[] onboardingPackageLinux, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OnboardingPackageWindows = onboardingPackageWindows;
            OnboardingPackageLinux = onboardingPackageLinux;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The onboarding package used to onboard Windows machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </summary>
        public byte[] OnboardingPackageWindows { get; set; }
        /// <summary> The onboarding package used to onboard Linux machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </summary>
        public byte[] OnboardingPackageLinux { get; set; }
    }
}
