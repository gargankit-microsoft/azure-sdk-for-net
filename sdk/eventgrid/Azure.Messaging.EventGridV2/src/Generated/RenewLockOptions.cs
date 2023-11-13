// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Array of lock tokens for the corresponding received Cloud Events to be renewed. </summary>
    public partial class RenewLockOptions
    {
        /// <summary> Initializes a new instance of RenewLockOptions. </summary>
        /// <param name="lockTokens"> Array of lock tokens. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockTokens"/> is null. </exception>
        public RenewLockOptions(IEnumerable<string> lockTokens)
        {
            Argument.AssertNotNull(lockTokens, nameof(lockTokens));

            LockTokens = lockTokens.ToList();
        }

        /// <summary> Initializes a new instance of RenewLockOptions. </summary>
        /// <param name="lockTokens"> Array of lock tokens. </param>
        internal RenewLockOptions(IList<string> lockTokens)
        {
            LockTokens = lockTokens;
        }

        /// <summary> Array of lock tokens. </summary>
        public IList<string> LockTokens { get; }
    }
}
