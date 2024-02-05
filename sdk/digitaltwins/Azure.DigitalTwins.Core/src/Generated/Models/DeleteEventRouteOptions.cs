// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core
{
    /// <summary> Parameter group. </summary>
    internal partial class DeleteEventRouteOptions
    {
        /// <summary> Initializes a new instance of <see cref="DeleteEventRouteOptions"/>. </summary>
        public DeleteEventRouteOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeleteEventRouteOptions"/>. </summary>
        /// <param name="traceParent"> Identifies the request in a distributed tracing system. </param>
        /// <param name="traceState"> Provides vendor-specific trace identification information and is a companion to traceparent. </param>
        internal DeleteEventRouteOptions(string traceParent, string traceState)
        {
            TraceParent = traceParent;
            TraceState = traceState;
        }
    }
}
