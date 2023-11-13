// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Failed LockToken information. </summary>
    public partial class FailedLockToken
    {
        /// <summary> Initializes a new instance of FailedLockToken. </summary>
        /// <param name="lockToken"> The lock token of an entry in the request. </param>
        /// <param name="error"> Error information of the failed operation result for the lock token in the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockToken"/> or <paramref name="error"/> is null. </exception>
        internal FailedLockToken(string lockToken, ResponseError error)
        {
            Argument.AssertNotNull(lockToken, nameof(lockToken));
            Argument.AssertNotNull(error, nameof(error));

            LockToken = lockToken;
            Error = error;
        }

        /// <summary> The lock token of an entry in the request. </summary>
        public string LockToken { get; }
        /// <summary> Error information of the failed operation result for the lock token in the request. </summary>
        public ResponseError Error { get; }
    }
}
