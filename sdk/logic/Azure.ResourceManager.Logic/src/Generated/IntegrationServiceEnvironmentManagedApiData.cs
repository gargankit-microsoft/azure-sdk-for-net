// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the IntegrationServiceEnvironmentManagedApi data model.
    /// The integration service environment managed api.
    /// </summary>
    public partial class IntegrationServiceEnvironmentManagedApiData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApiData. </summary>
        /// <param name="location"> The location. </param>
        public IntegrationServiceEnvironmentManagedApiData(AzureLocation location) : base(location)
        {
            ConnectionParameters = new ChangeTrackingDictionary<string, BinaryData>();
            RuntimeUris = new ChangeTrackingList<Uri>();
            Capabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentManagedApiData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namePropertiesName"> The name. </param>
        /// <param name="connectionParameters"> The connection parameters. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="runtimeUris"> The runtime urls. </param>
        /// <param name="generalInformation"> The api general information. </param>
        /// <param name="capabilities"> The capabilities. </param>
        /// <param name="backendService"> The backend service. </param>
        /// <param name="policies"> The policies for the API. </param>
        /// <param name="apiDefinitionUri"> The API definition. </param>
        /// <param name="apiDefinitions"> The api definitions. </param>
        /// <param name="integrationServiceEnvironment"> The integration service environment reference. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="category"> The category. </param>
        /// <param name="deploymentParameters"> The integration service environment managed api deployment parameters. </param>
        internal IntegrationServiceEnvironmentManagedApiData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string namePropertiesName, IReadOnlyDictionary<string, BinaryData> connectionParameters, LogicApiResourceMetadata metadata, IReadOnlyList<Uri> runtimeUris, LogicApiResourceGeneralInformation generalInformation, IReadOnlyList<string> capabilities, LogicApiResourceBackendService backendService, LogicApiResourcePolicies policies, Uri apiDefinitionUri, LogicApiResourceDefinitions apiDefinitions, LogicResourceReference integrationServiceEnvironment, LogicWorkflowProvisioningState? provisioningState, LogicApiTier? category, IntegrationServiceEnvironmentManagedApiDeploymentParameters deploymentParameters) : base(id, name, resourceType, systemData, tags, location)
        {
            NamePropertiesName = namePropertiesName;
            ConnectionParameters = connectionParameters;
            Metadata = metadata;
            RuntimeUris = runtimeUris;
            GeneralInformation = generalInformation;
            Capabilities = capabilities;
            BackendService = backendService;
            Policies = policies;
            ApiDefinitionUri = apiDefinitionUri;
            ApiDefinitions = apiDefinitions;
            IntegrationServiceEnvironment = integrationServiceEnvironment;
            ProvisioningState = provisioningState;
            Category = category;
            DeploymentParameters = deploymentParameters;
        }

        /// <summary> The name. </summary>
        public string NamePropertiesName { get; }
        /// <summary>
        /// The connection parameters.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> ConnectionParameters { get; }
        /// <summary> The metadata. </summary>
        public LogicApiResourceMetadata Metadata { get; }
        /// <summary> The runtime urls. </summary>
        public IReadOnlyList<Uri> RuntimeUris { get; }
        /// <summary> The api general information. </summary>
        public LogicApiResourceGeneralInformation GeneralInformation { get; }
        /// <summary> The capabilities. </summary>
        public IReadOnlyList<string> Capabilities { get; }
        /// <summary> The backend service. </summary>
        internal LogicApiResourceBackendService BackendService { get; }
        /// <summary> The service URL. </summary>
        public Uri ServiceUri
        {
            get => BackendService?.ServiceUri;
        }

        /// <summary> The policies for the API. </summary>
        public LogicApiResourcePolicies Policies { get; }
        /// <summary> The API definition. </summary>
        public Uri ApiDefinitionUri { get; }
        /// <summary> The api definitions. </summary>
        public LogicApiResourceDefinitions ApiDefinitions { get; }
        /// <summary> The integration service environment reference. </summary>
        public LogicResourceReference IntegrationServiceEnvironment { get; set; }
        /// <summary> The provisioning state. </summary>
        public LogicWorkflowProvisioningState? ProvisioningState { get; }
        /// <summary> The category. </summary>
        public LogicApiTier? Category { get; }
        /// <summary> The integration service environment managed api deployment parameters. </summary>
        internal IntegrationServiceEnvironmentManagedApiDeploymentParameters DeploymentParameters { get; set; }
        /// <summary> The integration service environment managed api content link for deployment. </summary>
        public LogicContentLink DeploymentParametersContentLinkDefinition
        {
            get => DeploymentParameters is null ? default : DeploymentParameters.ContentLinkDefinition;
            set
            {
                if (DeploymentParameters is null)
                    DeploymentParameters = new IntegrationServiceEnvironmentManagedApiDeploymentParameters();
                DeploymentParameters.ContentLinkDefinition = value;
            }
        }
    }
}
