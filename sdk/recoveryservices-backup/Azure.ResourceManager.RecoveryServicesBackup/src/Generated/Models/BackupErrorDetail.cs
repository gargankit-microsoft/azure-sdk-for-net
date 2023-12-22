// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Error Detail class which encapsulates Code, Message and Recommendations. </summary>
    public partial class BackupErrorDetail
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

        /// <summary> Initializes a new instance of <see cref="BackupErrorDetail"/>. </summary>
        public BackupErrorDetail()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupErrorDetail"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error Message related to the Code. </param>
        /// <param name="recommendations"> List of recommendation strings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupErrorDetail(string code, string message, IReadOnlyList<string> recommendations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Recommendations = recommendations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error Message related to the Code. </summary>
        public string Message { get; }
        /// <summary> List of recommendation strings. </summary>
        public IReadOnlyList<string> Recommendations { get; }
    }
}
