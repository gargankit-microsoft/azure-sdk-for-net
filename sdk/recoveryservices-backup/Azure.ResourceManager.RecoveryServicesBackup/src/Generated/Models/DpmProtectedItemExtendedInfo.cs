// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information of DPM Protected item. </summary>
    public partial class DpmProtectedItemExtendedInfo
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

        /// <summary> Initializes a new instance of <see cref="DpmProtectedItemExtendedInfo"/>. </summary>
        public DpmProtectedItemExtendedInfo()
        {
            ProtectableObjectLoadPath = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DpmProtectedItemExtendedInfo"/>. </summary>
        /// <param name="protectableObjectLoadPath"> Attribute to provide information on various DBs. </param>
        /// <param name="isProtected"> To check if backup item is disk protected. </param>
        /// <param name="isPresentOnCloud"> To check if backup item is cloud protected. </param>
        /// <param name="lastBackupStatus"> Last backup status information on backup item. </param>
        /// <param name="lastRefreshedOn"> Last refresh time on backup item. </param>
        /// <param name="oldestRecoverOn"> Oldest cloud recovery point time. </param>
        /// <param name="recoveryPointCount"> cloud recovery point count. </param>
        /// <param name="onPremiseOldestRecoverOn"> Oldest disk recovery point time. </param>
        /// <param name="onPremiseLatestRecoverOn"> latest disk recovery point time. </param>
        /// <param name="onPremiseRecoveryPointCount"> disk recovery point count. </param>
        /// <param name="isCollocated"> To check if backup item is collocated. </param>
        /// <param name="protectionGroupName"> Protection group name of the backup item. </param>
        /// <param name="diskStorageUsedInBytes"> Used Disk storage in bytes. </param>
        /// <param name="totalDiskStorageSizeInBytes"> total Disk storage in bytes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DpmProtectedItemExtendedInfo(IDictionary<string, string> protectableObjectLoadPath, bool? isProtected, bool? isPresentOnCloud, string lastBackupStatus, DateTimeOffset? lastRefreshedOn, DateTimeOffset? oldestRecoverOn, int? recoveryPointCount, DateTimeOffset? onPremiseOldestRecoverOn, DateTimeOffset? onPremiseLatestRecoverOn, int? onPremiseRecoveryPointCount, bool? isCollocated, string protectionGroupName, string diskStorageUsedInBytes, string totalDiskStorageSizeInBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtectableObjectLoadPath = protectableObjectLoadPath;
            IsProtected = isProtected;
            IsPresentOnCloud = isPresentOnCloud;
            LastBackupStatus = lastBackupStatus;
            LastRefreshedOn = lastRefreshedOn;
            OldestRecoverOn = oldestRecoverOn;
            RecoveryPointCount = recoveryPointCount;
            OnPremiseOldestRecoverOn = onPremiseOldestRecoverOn;
            OnPremiseLatestRecoverOn = onPremiseLatestRecoverOn;
            OnPremiseRecoveryPointCount = onPremiseRecoveryPointCount;
            IsCollocated = isCollocated;
            ProtectionGroupName = protectionGroupName;
            DiskStorageUsedInBytes = diskStorageUsedInBytes;
            TotalDiskStorageSizeInBytes = totalDiskStorageSizeInBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Attribute to provide information on various DBs. </summary>
        public IDictionary<string, string> ProtectableObjectLoadPath { get; }
        /// <summary> To check if backup item is disk protected. </summary>
        public bool? IsProtected { get; set; }
        /// <summary> To check if backup item is cloud protected. </summary>
        public bool? IsPresentOnCloud { get; set; }
        /// <summary> Last backup status information on backup item. </summary>
        public string LastBackupStatus { get; set; }
        /// <summary> Last refresh time on backup item. </summary>
        public DateTimeOffset? LastRefreshedOn { get; set; }
        /// <summary> Oldest cloud recovery point time. </summary>
        public DateTimeOffset? OldestRecoverOn { get; set; }
        /// <summary> cloud recovery point count. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> Oldest disk recovery point time. </summary>
        public DateTimeOffset? OnPremiseOldestRecoverOn { get; set; }
        /// <summary> latest disk recovery point time. </summary>
        public DateTimeOffset? OnPremiseLatestRecoverOn { get; set; }
        /// <summary> disk recovery point count. </summary>
        public int? OnPremiseRecoveryPointCount { get; set; }
        /// <summary> To check if backup item is collocated. </summary>
        public bool? IsCollocated { get; set; }
        /// <summary> Protection group name of the backup item. </summary>
        public string ProtectionGroupName { get; set; }
        /// <summary> Used Disk storage in bytes. </summary>
        public string DiskStorageUsedInBytes { get; set; }
        /// <summary> total Disk storage in bytes. </summary>
        public string TotalDiskStorageSizeInBytes { get; set; }
    }
}
