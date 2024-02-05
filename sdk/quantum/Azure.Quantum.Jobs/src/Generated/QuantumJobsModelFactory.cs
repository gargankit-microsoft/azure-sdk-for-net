// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class QuantumJobsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.JobDetails"/>. </summary>
        /// <param name="id"> The job id. </param>
        /// <param name="name"> The job name. Is not required for the name to be unique and it's only used for display purposes. </param>
        /// <param name="containerUri"> The blob container SAS uri, the container is used to host job data. </param>
        /// <param name="inputDataUri"> The input blob SAS uri, if specified, it will override the default input blob in the container. </param>
        /// <param name="inputDataFormat"> The format of the input data. </param>
        /// <param name="inputParams"> The input parameters for the job. JSON object used by the target solver. It is expected that the size of this object is small and only used to specify parameters for the execution target, not the input data. </param>
        /// <param name="providerId"> The unique identifier for the provider. </param>
        /// <param name="target"> The target identifier to run the job. </param>
        /// <param name="metadata"> The job metadata. Metadata provides client the ability to store client-specific information. </param>
        /// <param name="outputDataUri"> The output blob SAS uri. When a job finishes successfully, results will be uploaded to this blob. </param>
        /// <param name="outputDataFormat"> The format of the output data. </param>
        /// <param name="status"> The job status. </param>
        /// <param name="creationTime"> The creation time of the job. </param>
        /// <param name="beginExecutionTime"> The time when the job began execution. </param>
        /// <param name="endExecutionTime"> The time when the job finished execution. </param>
        /// <param name="cancellationTime"> The time when a job was successfully cancelled. </param>
        /// <param name="costEstimate"> The job cost billed by the provider. The final cost on your bill might be slightly different due to added taxes and currency conversion rates. </param>
        /// <param name="errorData"> The error data for the job. This is expected only when Status 'Failed'. </param>
        /// <param name="tags"> List of user-supplied tags associated with the job. </param>
        /// <returns> A new <see cref="Models.JobDetails"/> instance for mocking. </returns>
        public static JobDetails JobDetails(string id = null, string name = null, string containerUri = null, string inputDataUri = null, string inputDataFormat = null, object inputParams = null, string providerId = null, string target = null, IDictionary<string, string> metadata = null, string outputDataUri = null, string outputDataFormat = null, JobStatus? status = null, DateTimeOffset? creationTime = null, DateTimeOffset? beginExecutionTime = null, DateTimeOffset? endExecutionTime = null, DateTimeOffset? cancellationTime = null, CostEstimate costEstimate = null, ErrorData errorData = null, IEnumerable<string> tags = null)
        {
            metadata ??= new Dictionary<string, string>();
            tags ??= new List<string>();

            return new JobDetails(id, name, containerUri, inputDataUri, inputDataFormat, inputParams, providerId, target, metadata, outputDataUri, outputDataFormat, status, creationTime, beginExecutionTime, endExecutionTime, cancellationTime, costEstimate, errorData, tags?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.CostEstimate"/>. </summary>
        /// <param name="currencyCode"> The currency code. </param>
        /// <param name="events"> List of usage events. </param>
        /// <param name="estimatedTotal"> The estimated total. </param>
        /// <returns> A new <see cref="Models.CostEstimate"/> instance for mocking. </returns>
        public static CostEstimate CostEstimate(string currencyCode = null, IEnumerable<UsageEvent> events = null, float? estimatedTotal = null)
        {
            events ??= new List<UsageEvent>();

            return new CostEstimate(currencyCode, events?.ToList(), estimatedTotal);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UsageEvent"/>. </summary>
        /// <param name="dimensionId"> The dimension id. </param>
        /// <param name="dimensionName"> The dimension name. </param>
        /// <param name="measureUnit"> The unit of measure. </param>
        /// <param name="amountBilled"> The amount billed. </param>
        /// <param name="amountConsumed"> The amount consumed. </param>
        /// <param name="unitPrice"> The unit price. </param>
        /// <returns> A new <see cref="Models.UsageEvent"/> instance for mocking. </returns>
        public static UsageEvent UsageEvent(string dimensionId = null, string dimensionName = null, string measureUnit = null, float? amountBilled = null, float? amountConsumed = null, float? unitPrice = null)
        {
            return new UsageEvent(dimensionId, dimensionName, measureUnit, amountBilled, amountConsumed, unitPrice);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ErrorData"/>. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the error, intended to be suitable for displaying in a user interface. </param>
        /// <returns> A new <see cref="Models.ErrorData"/> instance for mocking. </returns>
        public static ErrorData ErrorData(string code = null, string message = null)
        {
            return new ErrorData(code, message);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ProviderStatus"/>. </summary>
        /// <param name="id"> Provider id. </param>
        /// <param name="currentAvailability"> Provider availability. </param>
        /// <param name="targets"></param>
        /// <returns> A new <see cref="Models.ProviderStatus"/> instance for mocking. </returns>
        public static ProviderStatus ProviderStatus(string id = null, ProviderAvailability? currentAvailability = null, IEnumerable<TargetStatus> targets = null)
        {
            targets ??= new List<TargetStatus>();

            return new ProviderStatus(id, currentAvailability, targets?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.TargetStatus"/>. </summary>
        /// <param name="id"> Target id. </param>
        /// <param name="currentAvailability"> Target availability. </param>
        /// <param name="averageQueueTime"> Average queue time in seconds. </param>
        /// <param name="statusPage"> A page with detailed status of the provider. </param>
        /// <returns> A new <see cref="Models.TargetStatus"/> instance for mocking. </returns>
        public static TargetStatus TargetStatus(string id = null, TargetAvailability? currentAvailability = null, long? averageQueueTime = null, string statusPage = null)
        {
            return new TargetStatus(id, currentAvailability, averageQueueTime, statusPage);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SasUriResponse"/>. </summary>
        /// <param name="sasUri"> A URL with a SAS token to upload a blob for execution in the given workspace. </param>
        /// <returns> A new <see cref="Models.SasUriResponse"/> instance for mocking. </returns>
        public static SasUriResponse SasUriResponse(string sasUri = null)
        {
            return new SasUriResponse(sasUri);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuantumJobQuotaList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <returns> A new <see cref="Models.QuantumJobQuotaList"/> instance for mocking. </returns>
        public static QuantumJobQuotaList QuantumJobQuotaList(IEnumerable<QuantumJobQuota> value = null, string nextLink = null)
        {
            value ??= new List<QuantumJobQuota>();

            return new QuantumJobQuotaList(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QuantumJobQuota"/>. </summary>
        /// <param name="dimension"> The name of the dimension associated with the quota. </param>
        /// <param name="scope"> The scope at which the quota is applied. </param>
        /// <param name="providerId"> The unique identifier for the provider. </param>
        /// <param name="utilization"> The amount of the usage that has been applied for the current period. </param>
        /// <param name="holds"> The amount of the usage that has been reserved but not applied for the current period. </param>
        /// <param name="limit"> The maximum amount of usage allowed for the current period. </param>
        /// <param name="period"> The time period in which the quota's underlying meter is accumulated. Based on calendar year. 'None' is used for concurrent quotas. </param>
        /// <returns> A new <see cref="Models.QuantumJobQuota"/> instance for mocking. </returns>
        public static QuantumJobQuota QuantumJobQuota(string dimension = null, DimensionScope? scope = null, string providerId = null, float? utilization = null, float? holds = null, float? limit = null, MeterPeriod? period = null)
        {
            return new QuantumJobQuota(dimension, scope, providerId, utilization, holds, limit, period);
        }
    }
}
