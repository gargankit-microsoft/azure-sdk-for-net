// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Response from Diagnostic Detectors. </summary>
    public partial class DiagnosticDetectorResponse : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of DiagnosticDetectorResponse. </summary>
        public DiagnosticDetectorResponse()
        {
            Metrics = new ChangeTrackingList<DiagnosticMetricSet>();
            AbnormalTimePeriods = new ChangeTrackingList<DetectorAbnormalTimePeriod>();
            Data = new ChangeTrackingList<IList<NameValuePair>>();
        }

        /// <summary> Initializes a new instance of DiagnosticDetectorResponse. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="startTime"> Start time of the period. </param>
        /// <param name="endTime"> End time of the period. </param>
        /// <param name="issueDetected"> Flag representing Issue was detected. </param>
        /// <param name="detectorDefinition"> Detector&apos;s definition. </param>
        /// <param name="metrics"> Metrics provided by the detector. </param>
        /// <param name="abnormalTimePeriods"> List of Correlated events found by the detector. </param>
        /// <param name="data"> Additional Data that detector wants to send. </param>
        /// <param name="responseMetaData"> Meta Data. </param>
        internal DiagnosticDetectorResponse(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, DateTimeOffset? startTime, DateTimeOffset? endTime, bool? issueDetected, DetectorDefinition detectorDefinition, IList<DiagnosticMetricSet> metrics, IList<DetectorAbnormalTimePeriod> abnormalTimePeriods, IList<IList<NameValuePair>> data, ResponseMetaData responseMetaData) : base(id, name, resourceType, systemData, kind)
        {
            StartTime = startTime;
            EndTime = endTime;
            IssueDetected = issueDetected;
            DetectorDefinition = detectorDefinition;
            Metrics = metrics;
            AbnormalTimePeriods = abnormalTimePeriods;
            Data = data;
            ResponseMetaData = responseMetaData;
        }

        /// <summary> Start time of the period. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> End time of the period. </summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary> Flag representing Issue was detected. </summary>
        public bool? IssueDetected { get; set; }
        /// <summary> Detector&apos;s definition. </summary>
        public DetectorDefinition DetectorDefinition { get; set; }
        /// <summary> Metrics provided by the detector. </summary>
        public IList<DiagnosticMetricSet> Metrics { get; }
        /// <summary> List of Correlated events found by the detector. </summary>
        public IList<DetectorAbnormalTimePeriod> AbnormalTimePeriods { get; }
        /// <summary> Additional Data that detector wants to send. </summary>
        public IList<IList<NameValuePair>> Data { get; }
        /// <summary> Meta Data. </summary>
        internal ResponseMetaData ResponseMetaData { get; set; }
        /// <summary> Source of the Data. </summary>
        public DataSource DataSource
        {
            get => ResponseMetaData is null ? default : ResponseMetaData.DataSource;
            set
            {
                if (ResponseMetaData is null)
                    ResponseMetaData = new ResponseMetaData();
                ResponseMetaData.DataSource = value;
            }
        }
    }
}
