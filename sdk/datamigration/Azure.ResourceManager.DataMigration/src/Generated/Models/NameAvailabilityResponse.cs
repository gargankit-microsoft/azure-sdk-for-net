// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Indicates whether a proposed resource name is available. </summary>
    public partial class NameAvailabilityResponse
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

        /// <summary> Initializes a new instance of <see cref="NameAvailabilityResponse"/>. </summary>
        internal NameAvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NameAvailabilityResponse"/>. </summary>
        /// <param name="nameAvailable"> If true, the name is valid and available. If false, 'reason' describes why not. </param>
        /// <param name="reason"> The reason why the name is not available, if nameAvailable is false. </param>
        /// <param name="message"> The localized reason why the name is not available, if nameAvailable is false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NameAvailabilityResponse(bool? nameAvailable, NameCheckFailureReason? reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> If true, the name is valid and available. If false, 'reason' describes why not. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the name is not available, if nameAvailable is false. </summary>
        public NameCheckFailureReason? Reason { get; }
        /// <summary> The localized reason why the name is not available, if nameAvailable is false. </summary>
        public string Message { get; }
    }
}
