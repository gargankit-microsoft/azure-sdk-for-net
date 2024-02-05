// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAppPlatformArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppPlatformArmClient"/> class for mocking. </summary>
        protected MockableAppPlatformArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppPlatformArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppPlatformArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAppPlatformArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformServiceResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformServiceResource"/> object. </returns>
        public virtual AppPlatformServiceResource GetAppPlatformServiceResource(ResourceIdentifier id)
        {
            AppPlatformServiceResource.ValidateResourceId(id);
            return new AppPlatformServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformConfigServerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformConfigServerResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformConfigServerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformConfigServerResource"/> object. </returns>
        public virtual AppPlatformConfigServerResource GetAppPlatformConfigServerResource(ResourceIdentifier id)
        {
            AppPlatformConfigServerResource.ValidateResourceId(id);
            return new AppPlatformConfigServerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformConfigurationServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformConfigurationServiceResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformConfigurationServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformConfigurationServiceResource"/> object. </returns>
        public virtual AppPlatformConfigurationServiceResource GetAppPlatformConfigurationServiceResource(ResourceIdentifier id)
        {
            AppPlatformConfigurationServiceResource.ValidateResourceId(id);
            return new AppPlatformConfigurationServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformServiceRegistryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformServiceRegistryResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformServiceRegistryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformServiceRegistryResource"/> object. </returns>
        public virtual AppPlatformServiceRegistryResource GetAppPlatformServiceRegistryResource(ResourceIdentifier id)
        {
            AppPlatformServiceRegistryResource.ValidateResourceId(id);
            return new AppPlatformServiceRegistryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuildServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuildServiceResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuildServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuildServiceResource"/> object. </returns>
        public virtual AppPlatformBuildServiceResource GetAppPlatformBuildServiceResource(ResourceIdentifier id)
        {
            AppPlatformBuildServiceResource.ValidateResourceId(id);
            return new AppPlatformBuildServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuildResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuildResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuildResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuildResource"/> object. </returns>
        public virtual AppPlatformBuildResource GetAppPlatformBuildResource(ResourceIdentifier id)
        {
            AppPlatformBuildResource.ValidateResourceId(id);
            return new AppPlatformBuildResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuildResultResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuildResultResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuildResultResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuildResultResource"/> object. </returns>
        public virtual AppPlatformBuildResultResource GetAppPlatformBuildResultResource(ResourceIdentifier id)
        {
            AppPlatformBuildResultResource.ValidateResourceId(id);
            return new AppPlatformBuildResultResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformSupportedBuildpackResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformSupportedBuildpackResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformSupportedBuildpackResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformSupportedBuildpackResource"/> object. </returns>
        public virtual AppPlatformSupportedBuildpackResource GetAppPlatformSupportedBuildpackResource(ResourceIdentifier id)
        {
            AppPlatformSupportedBuildpackResource.ValidateResourceId(id);
            return new AppPlatformSupportedBuildpackResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformSupportedStackResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformSupportedStackResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformSupportedStackResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformSupportedStackResource"/> object. </returns>
        public virtual AppPlatformSupportedStackResource GetAppPlatformSupportedStackResource(ResourceIdentifier id)
        {
            AppPlatformSupportedStackResource.ValidateResourceId(id);
            return new AppPlatformSupportedStackResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuildpackBindingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuildpackBindingResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuildpackBindingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuildpackBindingResource"/> object. </returns>
        public virtual AppPlatformBuildpackBindingResource GetAppPlatformBuildpackBindingResource(ResourceIdentifier id)
        {
            AppPlatformBuildpackBindingResource.ValidateResourceId(id);
            return new AppPlatformBuildpackBindingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuilderResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuilderResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuilderResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuilderResource"/> object. </returns>
        public virtual AppPlatformBuilderResource GetAppPlatformBuilderResource(ResourceIdentifier id)
        {
            AppPlatformBuilderResource.ValidateResourceId(id);
            return new AppPlatformBuilderResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBuildServiceAgentPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBuildServiceAgentPoolResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBuildServiceAgentPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBuildServiceAgentPoolResource"/> object. </returns>
        public virtual AppPlatformBuildServiceAgentPoolResource GetAppPlatformBuildServiceAgentPoolResource(ResourceIdentifier id)
        {
            AppPlatformBuildServiceAgentPoolResource.ValidateResourceId(id);
            return new AppPlatformBuildServiceAgentPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformMonitoringSettingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformMonitoringSettingResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformMonitoringSettingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformMonitoringSettingResource"/> object. </returns>
        public virtual AppPlatformMonitoringSettingResource GetAppPlatformMonitoringSettingResource(ResourceIdentifier id)
        {
            AppPlatformMonitoringSettingResource.ValidateResourceId(id);
            return new AppPlatformMonitoringSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformAppResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformAppResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformAppResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformAppResource"/> object. </returns>
        public virtual AppPlatformAppResource GetAppPlatformAppResource(ResourceIdentifier id)
        {
            AppPlatformAppResource.ValidateResourceId(id);
            return new AppPlatformAppResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformBindingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformBindingResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformBindingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformBindingResource"/> object. </returns>
        public virtual AppPlatformBindingResource GetAppPlatformBindingResource(ResourceIdentifier id)
        {
            AppPlatformBindingResource.ValidateResourceId(id);
            return new AppPlatformBindingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformStorageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformStorageResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformStorageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformStorageResource"/> object. </returns>
        public virtual AppPlatformStorageResource GetAppPlatformStorageResource(ResourceIdentifier id)
        {
            AppPlatformStorageResource.ValidateResourceId(id);
            return new AppPlatformStorageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformCertificateResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformCertificateResource"/> object. </returns>
        public virtual AppPlatformCertificateResource GetAppPlatformCertificateResource(ResourceIdentifier id)
        {
            AppPlatformCertificateResource.ValidateResourceId(id);
            return new AppPlatformCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformCustomDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformCustomDomainResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformCustomDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformCustomDomainResource"/> object. </returns>
        public virtual AppPlatformCustomDomainResource GetAppPlatformCustomDomainResource(ResourceIdentifier id)
        {
            AppPlatformCustomDomainResource.ValidateResourceId(id);
            return new AppPlatformCustomDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformDeploymentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformDeploymentResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformDeploymentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformDeploymentResource"/> object. </returns>
        public virtual AppPlatformDeploymentResource GetAppPlatformDeploymentResource(ResourceIdentifier id)
        {
            AppPlatformDeploymentResource.ValidateResourceId(id);
            return new AppPlatformDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformGatewayResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformGatewayResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformGatewayResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformGatewayResource"/> object. </returns>
        public virtual AppPlatformGatewayResource GetAppPlatformGatewayResource(ResourceIdentifier id)
        {
            AppPlatformGatewayResource.ValidateResourceId(id);
            return new AppPlatformGatewayResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformGatewayRouteConfigResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformGatewayRouteConfigResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformGatewayRouteConfigResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformGatewayRouteConfigResource"/> object. </returns>
        public virtual AppPlatformGatewayRouteConfigResource GetAppPlatformGatewayRouteConfigResource(ResourceIdentifier id)
        {
            AppPlatformGatewayRouteConfigResource.ValidateResourceId(id);
            return new AppPlatformGatewayRouteConfigResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformGatewayCustomDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformGatewayCustomDomainResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformGatewayCustomDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformGatewayCustomDomainResource"/> object. </returns>
        public virtual AppPlatformGatewayCustomDomainResource GetAppPlatformGatewayCustomDomainResource(ResourceIdentifier id)
        {
            AppPlatformGatewayCustomDomainResource.ValidateResourceId(id);
            return new AppPlatformGatewayCustomDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformApiPortalResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformApiPortalResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformApiPortalResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformApiPortalResource"/> object. </returns>
        public virtual AppPlatformApiPortalResource GetAppPlatformApiPortalResource(ResourceIdentifier id)
        {
            AppPlatformApiPortalResource.ValidateResourceId(id);
            return new AppPlatformApiPortalResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppPlatformApiPortalCustomDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppPlatformApiPortalCustomDomainResource.CreateResourceIdentifier" /> to create an <see cref="AppPlatformApiPortalCustomDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppPlatformApiPortalCustomDomainResource"/> object. </returns>
        public virtual AppPlatformApiPortalCustomDomainResource GetAppPlatformApiPortalCustomDomainResource(ResourceIdentifier id)
        {
            AppPlatformApiPortalCustomDomainResource.ValidateResourceId(id);
            return new AppPlatformApiPortalCustomDomainResource(Client, id);
        }
    }
}
