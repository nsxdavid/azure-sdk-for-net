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

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A Class representing a DeviceProvisioningServicesPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DeviceProvisioningServicesPrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDeviceProvisioningServicesPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceProvisioningServiceResource"/> using the GetDeviceProvisioningServicesPrivateLinkResource method.
    /// </summary>
    public partial class DeviceProvisioningServicesPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeviceProvisioningServicesPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="groupId"> The groupId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceClientDiagnostics;
        private readonly IotDpsResourceRestOperations _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceRestClient;
        private readonly DeviceProvisioningServicesPrivateLinkResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Devices/provisioningServices/privateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateLinkResource"/> class for mocking. </summary>
        protected DeviceProvisioningServicesPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateLinkResource(ArmClient client, DeviceProvisioningServicesPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deviceProvisioningServicesPrivateLinkResourceIotDpsResourceApiVersion);
            _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceRestClient = new IotDpsResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesPrivateLinkResourceIotDpsResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeviceProvisioningServicesPrivateLinkResourceData Data
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
        /// Get the specified private link resource for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateLinkResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeviceProvisioningServicesPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceRestClient.GetPrivateLinkResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private link resource for the given provisioning service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateLinkResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeviceProvisioningServicesPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateLinkResourceIotDpsResourceRestClient.GetPrivateLinkResources(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
