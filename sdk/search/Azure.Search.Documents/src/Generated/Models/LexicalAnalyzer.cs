// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for analyzers.
    /// Please note <see cref="LexicalAnalyzer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CustomAnalyzer"/>, <see cref="PatternAnalyzer"/>, <see cref="LuceneStandardAnalyzer"/> and <see cref="StopAnalyzer"/>.
    /// </summary>
    public partial class LexicalAnalyzer
    {
        /// <summary> Initializes a new instance of <see cref="LexicalAnalyzer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of analyzer. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal LexicalAnalyzer(string oDataType, string name)
        {
            ODataType = oDataType;
            Name = name;
        }

        /// <summary> A URI fragment specifying the type of analyzer. </summary>
        internal string ODataType { get; set; }
        /// <summary> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
