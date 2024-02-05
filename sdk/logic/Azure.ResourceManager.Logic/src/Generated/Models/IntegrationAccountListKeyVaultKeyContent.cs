// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list key vault keys definition. </summary>
    public partial class IntegrationAccountListKeyVaultKeyContent
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

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountListKeyVaultKeyContent"/>. </summary>
        /// <param name="keyVault"> The key vault reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVault"/> is null. </exception>
        public IntegrationAccountListKeyVaultKeyContent(IntegrationAccountKeyVaultNameReference keyVault)
        {
            Argument.AssertNotNull(keyVault, nameof(keyVault));

            KeyVault = keyVault;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountListKeyVaultKeyContent"/>. </summary>
        /// <param name="keyVault"> The key vault reference. </param>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountListKeyVaultKeyContent(IntegrationAccountKeyVaultNameReference keyVault, string skipToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyVault = keyVault;
            SkipToken = skipToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountListKeyVaultKeyContent"/> for deserialization. </summary>
        internal IntegrationAccountListKeyVaultKeyContent()
        {
        }

        /// <summary> The key vault reference. </summary>
        public IntegrationAccountKeyVaultNameReference KeyVault { get; }
        /// <summary> The skip token. </summary>
        public string SkipToken { get; set; }
    }
}
