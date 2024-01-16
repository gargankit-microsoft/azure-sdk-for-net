// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Manager Commit. </summary>
    public partial class NetworkManagerCommit
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

        /// <summary> Initializes a new instance of <see cref="NetworkManagerCommit"/>. </summary>
        /// <param name="targetLocations"> List of target locations. </param>
        /// <param name="commitType"> Commit Type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetLocations"/> is null. </exception>
        public NetworkManagerCommit(IEnumerable<string> targetLocations, NetworkConfigurationDeploymentType commitType)
        {
            Argument.AssertNotNull(targetLocations, nameof(targetLocations));

            TargetLocations = targetLocations.ToList();
            ConfigurationIds = new ChangeTrackingList<string>();
            CommitType = commitType;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerCommit"/>. </summary>
        /// <param name="commitId"> Commit Id. </param>
        /// <param name="targetLocations"> List of target locations. </param>
        /// <param name="configurationIds"> List of configuration ids. </param>
        /// <param name="commitType"> Commit Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerCommit(string commitId, IList<string> targetLocations, IList<string> configurationIds, NetworkConfigurationDeploymentType commitType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CommitId = commitId;
            TargetLocations = targetLocations;
            ConfigurationIds = configurationIds;
            CommitType = commitType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerCommit"/> for deserialization. </summary>
        internal NetworkManagerCommit()
        {
        }

        /// <summary> Commit Id. </summary>
        public string CommitId { get; }
        /// <summary> List of target locations. </summary>
        public IList<string> TargetLocations { get; }
        /// <summary> List of configuration ids. </summary>
        public IList<string> ConfigurationIds { get; }
        /// <summary> Commit Type. </summary>
        public NetworkConfigurationDeploymentType CommitType { get; set; }
    }
}
