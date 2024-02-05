// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The CustomLabelClassificationResultDocumentsItem. </summary>
    internal partial class CustomLabelClassificationResultDocumentsItem : ClassificationDocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomLabelClassificationResultDocumentsItem"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="class"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="class"/> is null. </exception>
        public CustomLabelClassificationResultDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<ClassificationResult> @class) : base(id, warnings, @class)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(@class, nameof(@class));
        }

        /// <summary> Initializes a new instance of <see cref="CustomLabelClassificationResultDocumentsItem"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="class"></param>
        internal CustomLabelClassificationResultDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<ClassificationResult> @class) : base(id, warnings, statistics, @class)
        {
        }
    }
}
