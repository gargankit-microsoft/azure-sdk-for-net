// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The backup storage result, containing the backup blob. </summary>
    public partial class BackupStorageResult
    {
        /// <summary> Initializes a new instance of <see cref="BackupStorageResult"/>. </summary>
        internal BackupStorageResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupStorageResult"/>. </summary>
        /// <param name="value"> The backup blob containing the backed up storage account. </param>
        internal BackupStorageResult(byte[] value)
        {
            Value = value;
        }

        /// <summary> The backup blob containing the backed up storage account. </summary>
        public byte[] Value { get; }
    }
}
