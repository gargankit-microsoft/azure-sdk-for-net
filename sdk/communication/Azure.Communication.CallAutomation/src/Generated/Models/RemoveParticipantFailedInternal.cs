// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The failed to remove participant event. </summary>
    internal partial class RemoveParticipantFailedInternal
    {
        /// <summary> Initializes a new instance of <see cref="RemoveParticipantFailedInternal"/>. </summary>
        internal RemoveParticipantFailedInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantFailedInternal"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="participant"> Participant. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal RemoveParticipantFailedInternal(string operationContext, ResultInformation resultInformation, CommunicationIdentifierModel participant, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            Participant = participant;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code, sub-code and message. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Participant. </summary>
        public CommunicationIdentifierModel Participant { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
