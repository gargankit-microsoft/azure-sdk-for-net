// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A Class representing a DevTestLabArmTemplate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DevTestLabArmTemplateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDevTestLabArmTemplateResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevTestLabArtifactSourceResource" /> using the GetDevTestLabArmTemplate method.
    /// </summary>
    public partial class DevTestLabArmTemplateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DevTestLabArmTemplateResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="labName"> The labName. </param>
        /// <param name="artifactSourceName"> The artifactSourceName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string artifactSourceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _devTestLabArmTemplateArmTemplatesClientDiagnostics;
        private readonly ArmTemplatesRestOperations _devTestLabArmTemplateArmTemplatesRestClient;
        private readonly DevTestLabArmTemplateData _data;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArmTemplateResource"/> class for mocking. </summary>
        protected DevTestLabArmTemplateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DevTestLabArmTemplateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DevTestLabArmTemplateResource(ArmClient client, DevTestLabArmTemplateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabArmTemplateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DevTestLabArmTemplateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabArmTemplateArmTemplatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string devTestLabArmTemplateArmTemplatesApiVersion);
            _devTestLabArmTemplateArmTemplatesRestClient = new ArmTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabArmTemplateArmTemplatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevTestLab/labs/artifactsources/armtemplates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevTestLabArmTemplateData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get azure resource manager template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArmTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DevTestLabArmTemplateResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _devTestLabArmTemplateArmTemplatesClientDiagnostics.CreateScope("DevTestLabArmTemplateResource.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabArmTemplateArmTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get azure resource manager template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArmTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DevTestLabArmTemplateResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _devTestLabArmTemplateArmTemplatesClientDiagnostics.CreateScope("DevTestLabArmTemplateResource.Get");
            scope.Start();
            try
            {
                var response = _devTestLabArmTemplateArmTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabArmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
