// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the url rewrite action for the delivery rule. </summary>
    public partial class UriRewriteAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UriRewriteAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public UriRewriteAction(UriRewriteActionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = DeliveryRuleActionType.UriRewrite;
        }

        /// <summary> Initializes a new instance of <see cref="UriRewriteAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal UriRewriteAction(DeliveryRuleActionType name, IDictionary<string, BinaryData> serializedAdditionalRawData, UriRewriteActionProperties properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="UriRewriteAction"/> for deserialization. </summary>
        internal UriRewriteAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        public UriRewriteActionProperties Properties { get; set; }
    }
}
