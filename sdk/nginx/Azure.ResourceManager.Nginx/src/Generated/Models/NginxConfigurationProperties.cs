// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxConfigurationProperties. </summary>
    public partial class NginxConfigurationProperties
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

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationProperties"/>. </summary>
        public NginxConfigurationProperties()
        {
            Files = new ChangeTrackingList<NginxConfigurationFile>();
            ProtectedFiles = new ChangeTrackingList<NginxConfigurationFile>();
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="files"></param>
        /// <param name="protectedFiles"></param>
        /// <param name="package"></param>
        /// <param name="rootFile"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxConfigurationProperties(NginxProvisioningState? provisioningState, IList<NginxConfigurationFile> files, IList<NginxConfigurationFile> protectedFiles, NginxConfigurationPackage package, string rootFile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Files = files;
            ProtectedFiles = protectedFiles;
            Package = package;
            RootFile = rootFile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the provisioning state. </summary>
        public NginxProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the files. </summary>
        public IList<NginxConfigurationFile> Files { get; }
        /// <summary> Gets the protected files. </summary>
        public IList<NginxConfigurationFile> ProtectedFiles { get; }
        /// <summary> Gets or sets the package. </summary>
        public NginxConfigurationPackage Package { get; set; }
        /// <summary> Gets or sets the root file. </summary>
        public string RootFile { get; set; }
    }
}
