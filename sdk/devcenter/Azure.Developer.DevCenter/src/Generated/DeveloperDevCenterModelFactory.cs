// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class DeveloperDevCenterModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DevCenterProject"/>. </summary>
        /// <param name="name"> Name of the project. </param>
        /// <param name="description"> Description of the project. </param>
        /// <param name="maxDevBoxesPerUser">
        /// When specified, indicates the maximum number of Dev Boxes a single user can
        /// create across all pools in the project.
        /// </param>
        /// <returns> A new <see cref="Models.DevCenterProject"/> instance for mocking. </returns>
        public static DevCenterProject DevCenterProject(string name = null, string description = null, int? maxDevBoxesPerUser = null)
        {
            return new DevCenterProject(name, description, maxDevBoxesPerUser);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxPool"/>. </summary>
        /// <param name="name"> Pool name. </param>
        /// <param name="location"> Azure region where Dev Boxes in the pool are located. </param>
        /// <param name="osType"> The operating system type of Dev Boxes in this pool. </param>
        /// <param name="hardwareProfile"> Hardware settings for the Dev Boxes created in this pool. </param>
        /// <param name="hibernateSupport"> Indicates whether hibernate is enabled/disabled or unknown. </param>
        /// <param name="storageProfile"> Storage settings for Dev Box created in this pool. </param>
        /// <param name="imageReference"> Image settings for Dev Boxes create in this pool. </param>
        /// <param name="localAdministratorStatus">
        /// Indicates whether owners of Dev Boxes in this pool are local administrators on
        /// the Dev Boxes.
        /// </param>
        /// <param name="stopOnDisconnect"> Stop on disconnect configuration settings for Dev Boxes created in this pool. </param>
        /// <param name="healthStatus">
        /// Overall health status of the Pool. Indicates whether or not the Pool is
        /// available to create Dev Boxes.
        /// </param>
        /// <returns> A new <see cref="Models.DevBoxPool"/> instance for mocking. </returns>
        public static DevBoxPool DevBoxPool(string name = null, string location = null, string osType = null, DevBoxHardwareProfile hardwareProfile = null, HibernateSupport? hibernateSupport = null, DevBoxStorageProfile storageProfile = null, DevBoxImageReference imageReference = null, string localAdministratorStatus = null, StopOnDisconnectConfiguration stopOnDisconnect = null, PoolHealthStatus healthStatus = default)
        {
            return new DevBoxPool(name, location, osType, hardwareProfile, hibernateSupport, storageProfile, imageReference, localAdministratorStatus, stopOnDisconnect, healthStatus);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxHardwareProfile"/>. </summary>
        /// <param name="skuName"> The name of the SKU. </param>
        /// <param name="vCpus"> The number of vCPUs available for the Dev Box. </param>
        /// <param name="memoryGB"> The amount of memory available for the Dev Box. </param>
        /// <returns> A new <see cref="Models.DevBoxHardwareProfile"/> instance for mocking. </returns>
        public static DevBoxHardwareProfile DevBoxHardwareProfile(SkuName? skuName = null, int? vCpus = null, int? memoryGB = null)
        {
            return new DevBoxHardwareProfile(skuName, vCpus, memoryGB);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OSDisk"/>. </summary>
        /// <param name="diskSizeGB"> The size of the OS Disk in gigabytes. </param>
        /// <returns> A new <see cref="Models.OSDisk"/> instance for mocking. </returns>
        public static OSDisk OSDisk(int? diskSizeGB = null)
        {
            return new OSDisk(diskSizeGB);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxImageReference"/>. </summary>
        /// <param name="name"> The name of the image used. </param>
        /// <param name="version"> The version of the image. </param>
        /// <param name="operatingSystem"> The operating system of the image. </param>
        /// <param name="osBuildNumber"> The operating system build number of the image. </param>
        /// <param name="publishedDate"> The datetime that the backing image version was published. </param>
        /// <returns> A new <see cref="Models.DevBoxImageReference"/> instance for mocking. </returns>
        public static DevBoxImageReference DevBoxImageReference(string name = null, string version = null, string operatingSystem = null, string osBuildNumber = null, DateTimeOffset? publishedDate = null)
        {
            return new DevBoxImageReference(name, version, operatingSystem, osBuildNumber, publishedDate);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StopOnDisconnectConfiguration"/>. </summary>
        /// <param name="status">
        /// Indicates whether the feature to stop the devbox on disconnect once the grace
        /// period has lapsed is enabled.
        /// </param>
        /// <param name="gracePeriodMinutes">
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect
        /// is detected.
        /// </param>
        /// <returns> A new <see cref="Models.StopOnDisconnectConfiguration"/> instance for mocking. </returns>
        public static StopOnDisconnectConfiguration StopOnDisconnectConfiguration(string status = null, int? gracePeriodMinutes = null)
        {
            return new StopOnDisconnectConfiguration(status, gracePeriodMinutes);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxSchedule"/>. </summary>
        /// <param name="name"> Display name for the Schedule. </param>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        /// <returns> A new <see cref="Models.DevBoxSchedule"/> instance for mocking. </returns>
        public static DevBoxSchedule DevBoxSchedule(string name = null, ScheduledType scheduledType = default, string frequency = null, TimeSpan time = default, string timeZone = null)
        {
            return new DevBoxSchedule(name, scheduledType, frequency, time, timeZone);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBox"/>. </summary>
        /// <param name="name"> Display name for the Dev Box. </param>
        /// <param name="projectName"> Name of the project this Dev Box belongs to. </param>
        /// <param name="poolName"> The name of the Dev Box pool this machine belongs to. </param>
        /// <param name="hibernateSupport"> Indicates whether hibernate is enabled/disabled or unknown. </param>
        /// <param name="provisioningState"> The current provisioning state of the Dev Box. </param>
        /// <param name="actionState">
        /// The current action state of the Dev Box. This is state is based on previous
        /// action performed by user.
        /// </param>
        /// <param name="powerState"> The current power state of the Dev Box. </param>
        /// <param name="uniqueId">
        /// A unique identifier for the Dev Box. This is a GUID-formatted string (e.g.
        /// 00000000-0000-0000-0000-000000000000).
        /// </param>
        /// <param name="error"> Provisioning or action error details. Populated only for error states. </param>
        /// <param name="location">
        /// Azure region where this Dev Box is located. This will be the same region as the
        /// Virtual Network it is attached to.
        /// </param>
        /// <param name="osType"> The operating system type of this Dev Box. </param>
        /// <param name="userId"> The AAD object id of the user this Dev Box is assigned to. </param>
        /// <param name="hardwareProfile"> Information about the Dev Box's hardware resources. </param>
        /// <param name="storageProfile"> Storage settings for this Dev Box. </param>
        /// <param name="imageReference"> Information about the image used for this Dev Box. </param>
        /// <param name="createdTime"> Creation time of this Dev Box. </param>
        /// <param name="localAdministratorStatus"> Indicates whether the owner of the Dev Box is a local administrator. </param>
        /// <returns> A new <see cref="Models.DevBox"/> instance for mocking. </returns>
        public static DevBox DevBox(string name = null, string projectName = null, string poolName = null, HibernateSupport? hibernateSupport = null, DevBoxProvisioningState? provisioningState = null, string actionState = null, PowerState powerState = default, Guid? uniqueId = null, ResponseError error = null, string location = null, string osType = null, Guid? userId = null, DevBoxHardwareProfile hardwareProfile = null, DevBoxStorageProfile storageProfile = null, DevBoxImageReference imageReference = null, DateTimeOffset? createdTime = null, string localAdministratorStatus = null)
        {
            return new DevBox(name, projectName, poolName, hibernateSupport, provisioningState, actionState, powerState, uniqueId, error, location, osType, userId, hardwareProfile, storageProfile, imageReference, createdTime, localAdministratorStatus);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterOperationDetails"/>. </summary>
        /// <param name="id"> Fully qualified ID for the operation status. </param>
        /// <param name="name"> The operation id name. </param>
        /// <param name="status"> Provisioning state of the resource. </param>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="startTime"> The start time of the operation. </param>
        /// <param name="endTime"> The end time of the operation. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="properties"> Custom operation properties, populated only for a successful operation. </param>
        /// <param name="error"> Operation Error message. </param>
        /// <returns> A new <see cref="Models.DevCenterOperationDetails"/> instance for mocking. </returns>
        public static DevCenterOperationDetails DevCenterOperationDetails(string id = null, string name = null, string status = null, string resourceId = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, float? percentComplete = null, BinaryData properties = null, ResponseError error = null)
        {
            return new DevCenterOperationDetails(id, name, status, resourceId, startTime, endTime, percentComplete, properties, error);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RemoteConnection"/>. </summary>
        /// <param name="webUri"> URL to open a browser based RDP session. </param>
        /// <param name="rdpConnectionUri"> Link to open a Remote Desktop session. </param>
        /// <returns> A new <see cref="Models.RemoteConnection"/> instance for mocking. </returns>
        public static RemoteConnection RemoteConnection(Uri webUri = null, Uri rdpConnectionUri = null)
        {
            return new RemoteConnection(webUri, rdpConnectionUri);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxAction"/>. </summary>
        /// <param name="name"> The name of the action. </param>
        /// <param name="actionType"> The action that will be taken. </param>
        /// <param name="sourceId"> The id of the resource which triggered this action. </param>
        /// <param name="suspendedUntil"> The earliest time that the action could occur (UTC). </param>
        /// <param name="nextAction"> Details about the next run of this action. </param>
        /// <returns> A new <see cref="Models.DevBoxAction"/> instance for mocking. </returns>
        public static DevBoxAction DevBoxAction(string name = null, DevBoxActionType actionType = default, string sourceId = null, DateTimeOffset? suspendedUntil = null, DevBoxNextAction nextAction = null)
        {
            return new DevBoxAction(name, actionType, sourceId, suspendedUntil, nextAction);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxNextAction"/>. </summary>
        /// <param name="scheduledTime"> The time the action will be triggered (UTC). </param>
        /// <returns> A new <see cref="Models.DevBoxNextAction"/> instance for mocking. </returns>
        public static DevBoxNextAction DevBoxNextAction(DateTimeOffset scheduledTime = default)
        {
            return new DevBoxNextAction(scheduledTime);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxActionDelayResult"/>. </summary>
        /// <param name="actionName"> The name of the action. </param>
        /// <param name="result"> The result of the delay operation on this action. </param>
        /// <param name="action"> The delayed action. </param>
        /// <param name="error"> Information about the error that occurred. Only populated on error. </param>
        /// <returns> A new <see cref="Models.DevBoxActionDelayResult"/> instance for mocking. </returns>
        public static DevBoxActionDelayResult DevBoxActionDelayResult(string actionName = null, string result = null, DevBoxAction action = null, ResponseError error = null)
        {
            return new DevBoxActionDelayResult(actionName, result, action, error);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterEnvironment"/>. </summary>
        /// <param name="parameters"> Parameters object for the environment. </param>
        /// <param name="name"> Environment name. </param>
        /// <param name="environmentTypeName"> Environment type. </param>
        /// <param name="userId"> The AAD object id of the owner of this Environment. </param>
        /// <param name="provisioningState"> The provisioning state of the environment. </param>
        /// <param name="resourceGroupId"> The identifier of the resource group containing the environment's resources. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="environmentDefinitionName"> Name of the environment definition. </param>
        /// <param name="error"> Provisioning error details. Populated only for error states. </param>
        /// <returns> A new <see cref="Models.DevCenterEnvironment"/> instance for mocking. </returns>
        public static DevCenterEnvironment DevCenterEnvironment(BinaryData parameters = null, string name = null, string environmentTypeName = null, Guid? userId = null, EnvironmentProvisioningState? provisioningState = null, string resourceGroupId = null, string catalogName = null, string environmentDefinitionName = null, ResponseError error = null)
        {
            return new DevCenterEnvironment(parameters, name, environmentTypeName, userId, provisioningState, resourceGroupId, catalogName, environmentDefinitionName, error);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterCatalog"/>. </summary>
        /// <param name="name"> Name of the catalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <returns> A new <see cref="Models.DevCenterCatalog"/> instance for mocking. </returns>
        public static DevCenterCatalog DevCenterCatalog(string name = null)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new DevCenterCatalog(name);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EnvironmentDefinition"/>. </summary>
        /// <param name="id"> The ID of the environment definition. </param>
        /// <param name="name"> Name of the environment definition. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="description"> A short description of the environment definition. </param>
        /// <param name="parameters"> Input parameters passed to an environment. </param>
        /// <param name="parametersSchema"> JSON schema defining the parameters object passed to an environment. </param>
        /// <param name="templatePath"> Path to the Environment Definition entrypoint file. </param>
        /// <returns> A new <see cref="Models.EnvironmentDefinition"/> instance for mocking. </returns>
        public static EnvironmentDefinition EnvironmentDefinition(string id = null, string name = null, string catalogName = null, string description = null, IEnumerable<EnvironmentDefinitionParameter> parameters = null, BinaryData parametersSchema = null, string templatePath = null)
        {
            parameters ??= new List<EnvironmentDefinitionParameter>();

            return new EnvironmentDefinition(id, name, catalogName, description, parameters?.ToList(), parametersSchema, templatePath);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EnvironmentDefinitionParameter"/>. </summary>
        /// <param name="id"> Unique ID of the parameter. </param>
        /// <param name="name"> Display name of the parameter. </param>
        /// <param name="description"> Description of the parameter. </param>
        /// <param name="defaultValue"> Default value of the parameter. </param>
        /// <param name="parameterType">
        /// A string of one of the basic JSON types (number, integer, array, object,
        /// boolean, string)
        /// </param>
        /// <param name="readOnly">
        /// Whether or not this parameter is read-only.  If true, default should have a
        /// value.
        /// </param>
        /// <param name="required"> Whether or not this parameter is required. </param>
        /// <param name="allowed"> An array of allowed values. </param>
        /// <returns> A new <see cref="Models.EnvironmentDefinitionParameter"/> instance for mocking. </returns>
        public static EnvironmentDefinitionParameter EnvironmentDefinitionParameter(string id = null, string name = null, string description = null, BinaryData defaultValue = null, string parameterType = null, bool? readOnly = null, bool required = default, IEnumerable<string> allowed = null)
        {
            allowed ??= new List<string>();

            return new EnvironmentDefinitionParameter(id, name, description, defaultValue, parameterType, readOnly, required, allowed?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterEnvironmentType"/>. </summary>
        /// <param name="name"> Name of the environment type. </param>
        /// <param name="deploymentTargetId">
        /// Id of a subscription or management group that the environment type will be
        /// mapped to. The environment's resources will be deployed into this subscription
        /// or management group.
        /// </param>
        /// <param name="status"> Indicates whether this environment type is enabled for use in this project. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="deploymentTargetId"/> or <paramref name="status"/> is null. </exception>
        /// <returns> A new <see cref="Models.DevCenterEnvironmentType"/> instance for mocking. </returns>
        public static DevCenterEnvironmentType DevCenterEnvironmentType(string name = null, string deploymentTargetId = null, string status = null)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (deploymentTargetId == null)
            {
                throw new ArgumentNullException(nameof(deploymentTargetId));
            }
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }

            return new DevCenterEnvironmentType(name, deploymentTargetId, status);
        }
    }
}
