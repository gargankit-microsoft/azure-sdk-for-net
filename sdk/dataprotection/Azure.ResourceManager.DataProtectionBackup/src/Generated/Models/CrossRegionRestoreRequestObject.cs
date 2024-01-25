// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Cross Region Restore Request Object. </summary>
    public partial class CrossRegionRestoreRequestObject
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

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreRequestObject"/>. </summary>
        /// <param name="restoreRequestObject">
        /// Gets or sets the restore request object.
        /// Please note <see cref="BackupRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BackupRecoveryPointBasedRestoreContent"/>, <see cref="BackupRecoveryTimeBasedRestoreContent"/> and <see cref="BackupRestoreWithRehydrationContent"/>.
        /// </param>
        /// <param name="crossRegionRestoreDetails"> Cross region restore details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreRequestObject"/> or <paramref name="crossRegionRestoreDetails"/> is null. </exception>
        public CrossRegionRestoreRequestObject(BackupRestoreContent restoreRequestObject, CrossRegionRestoreDetails crossRegionRestoreDetails)
        {
            Argument.AssertNotNull(restoreRequestObject, nameof(restoreRequestObject));
            Argument.AssertNotNull(crossRegionRestoreDetails, nameof(crossRegionRestoreDetails));

            RestoreRequestObject = restoreRequestObject;
            CrossRegionRestoreDetails = crossRegionRestoreDetails;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreRequestObject"/>. </summary>
        /// <param name="restoreRequestObject">
        /// Gets or sets the restore request object.
        /// Please note <see cref="BackupRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BackupRecoveryPointBasedRestoreContent"/>, <see cref="BackupRecoveryTimeBasedRestoreContent"/> and <see cref="BackupRestoreWithRehydrationContent"/>.
        /// </param>
        /// <param name="crossRegionRestoreDetails"> Cross region restore details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CrossRegionRestoreRequestObject(BackupRestoreContent restoreRequestObject, CrossRegionRestoreDetails crossRegionRestoreDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestoreRequestObject = restoreRequestObject;
            CrossRegionRestoreDetails = crossRegionRestoreDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreRequestObject"/> for deserialization. </summary>
        internal CrossRegionRestoreRequestObject()
        {
        }

        /// <summary>
        /// Gets or sets the restore request object.
        /// Please note <see cref="BackupRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BackupRecoveryPointBasedRestoreContent"/>, <see cref="BackupRecoveryTimeBasedRestoreContent"/> and <see cref="BackupRestoreWithRehydrationContent"/>.
        /// </summary>
        public BackupRestoreContent RestoreRequestObject { get; }
        /// <summary> Cross region restore details. </summary>
        public CrossRegionRestoreDetails CrossRegionRestoreDetails { get; }
    }
}
