// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Details for KeyVault. </summary>
    public partial class NetworkAnalyticsKeyVaultContent
    {
        /// <summary> Initializes a new instance of NetworkAnalyticsKeyVaultContent. </summary>
        /// <param name="keyVaultUri"> key vault url. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultUri"/> is null. </exception>
        public NetworkAnalyticsKeyVaultContent(Uri keyVaultUri)
        {
            Argument.AssertNotNull(keyVaultUri, nameof(keyVaultUri));

            KeyVaultUri = keyVaultUri;
        }

        /// <summary> key vault url. </summary>
        public Uri KeyVaultUri { get; }
    }
}
