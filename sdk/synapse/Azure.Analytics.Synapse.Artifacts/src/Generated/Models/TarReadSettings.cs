// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The Tar compression read settings. </summary>
    public partial class TarReadSettings : CompressionReadSettings
    {
        /// <summary> Initializes a new instance of <see cref="TarReadSettings"/>. </summary>
        public TarReadSettings()
        {
            Type = "TarReadSettings";
        }

        /// <summary> Initializes a new instance of <see cref="TarReadSettings"/>. </summary>
        /// <param name="type"> The Compression setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preserveCompressionFileNameAsFolder"> Preserve the compression file name as folder path. Type: boolean (or Expression with resultType boolean). </param>
        internal TarReadSettings(string type, IDictionary<string, object> additionalProperties, object preserveCompressionFileNameAsFolder) : base(type, additionalProperties)
        {
            PreserveCompressionFileNameAsFolder = preserveCompressionFileNameAsFolder;
            Type = type ?? "TarReadSettings";
        }

        /// <summary> Preserve the compression file name as folder path. Type: boolean (or Expression with resultType boolean). </summary>
        public object PreserveCompressionFileNameAsFolder { get; set; }
    }
}
