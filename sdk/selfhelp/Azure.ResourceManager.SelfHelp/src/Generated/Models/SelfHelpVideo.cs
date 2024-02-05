// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Video detail. </summary>
    public partial class SelfHelpVideo : VideoGroupVideo
    {
        /// <summary> Initializes a new instance of <see cref="SelfHelpVideo"/>. </summary>
        public SelfHelpVideo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelpVideo"/>. </summary>
        /// <param name="src"> Link to the video. </param>
        /// <param name="title"> Title of the video. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="replacementKey"> Place holder used in HTML Content replace control with the insight content. </param>
        internal SelfHelpVideo(string src, string title, IDictionary<string, BinaryData> serializedAdditionalRawData, string replacementKey) : base(src, title, serializedAdditionalRawData)
        {
            ReplacementKey = replacementKey;
        }

        /// <summary> Place holder used in HTML Content replace control with the insight content. </summary>
        public string ReplacementKey { get; set; }
    }
}
