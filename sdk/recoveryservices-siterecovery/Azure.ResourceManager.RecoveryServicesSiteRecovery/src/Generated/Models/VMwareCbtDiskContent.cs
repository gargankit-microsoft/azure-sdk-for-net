// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt disk input. </summary>
    public partial class VMwareCbtDiskContent
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

        /// <summary> Initializes a new instance of <see cref="VMwareCbtDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="logStorageAccountSasSecretName"> The key vault secret name of the log storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/>, <paramref name="isOSDisk"/>, <paramref name="logStorageAccountId"/> or <paramref name="logStorageAccountSasSecretName"/> is null. </exception>
        public VMwareCbtDiskContent(string diskId, string isOSDisk, ResourceIdentifier logStorageAccountId, string logStorageAccountSasSecretName)
        {
            if (diskId == null)
            {
                throw new ArgumentNullException(nameof(diskId));
            }
            if (isOSDisk == null)
            {
                throw new ArgumentNullException(nameof(isOSDisk));
            }
            if (logStorageAccountId == null)
            {
                throw new ArgumentNullException(nameof(logStorageAccountId));
            }
            if (logStorageAccountSasSecretName == null)
            {
                throw new ArgumentNullException(nameof(logStorageAccountSasSecretName));
            }

            DiskId = diskId;
            IsOSDisk = isOSDisk;
            LogStorageAccountId = logStorageAccountId;
            LogStorageAccountSasSecretName = logStorageAccountSasSecretName;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="diskType"> The disk type. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="logStorageAccountSasSecretName"> The key vault secret name of the log storage account. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareCbtDiskContent(string diskId, SiteRecoveryDiskAccountType? diskType, string isOSDisk, ResourceIdentifier logStorageAccountId, string logStorageAccountSasSecretName, ResourceIdentifier diskEncryptionSetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskType = diskType;
            IsOSDisk = isOSDisk;
            LogStorageAccountId = logStorageAccountId;
            LogStorageAccountSasSecretName = logStorageAccountSasSecretName;
            DiskEncryptionSetId = diskEncryptionSetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtDiskContent"/> for deserialization. </summary>
        internal VMwareCbtDiskContent()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The key vault secret name of the log storage account. </summary>
        public string LogStorageAccountSasSecretName { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
