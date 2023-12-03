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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a MonitorPrivateLinkScopedResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MonitorPrivateLinkScopedResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMonitorPrivateLinkScopedResource method.
    /// Otherwise you can get one from its parent resource <see cref="MonitorPrivateLinkScopeResource"/> using the GetMonitorPrivateLinkScopedResource method.
    /// </summary>
    public partial class MonitorPrivateLinkScopedResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MonitorPrivateLinkScopedResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="scopeName"> The scopeName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string scopeName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics;
        private readonly PrivateLinkScopedResourcesRestOperations _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient;
        private readonly MonitorPrivateLinkScopedResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/privateLinkScopes/scopedResources";

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkScopedResource"/> class for mocking. </summary>
        protected MonitorPrivateLinkScopedResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkScopedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MonitorPrivateLinkScopedResource(ArmClient client, MonitorPrivateLinkScopedResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MonitorPrivateLinkScopedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MonitorPrivateLinkScopedResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesApiVersion);
            _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient = new PrivateLinkScopedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MonitorPrivateLinkScopedResourceData Data
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
        /// Gets a scoped resource in a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MonitorPrivateLinkScopedResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Get");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a scoped resource in a private link scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MonitorPrivateLinkScopedResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Get");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitorPrivateLinkScopedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Delete");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(_monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Delete");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(_monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="MonitorPrivateLinkScopedResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MonitorPrivateLinkScopedResource>> UpdateAsync(WaitUntil waitUntil, MonitorPrivateLinkScopedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Update");
            scope.Start();
            try
            {
                var response = await _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<MonitorPrivateLinkScopedResource>(new MonitorPrivateLinkScopedResourceOperationSource(Client), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopedResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="MonitorPrivateLinkScopedResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MonitorPrivateLinkScopedResource> Update(WaitUntil waitUntil, MonitorPrivateLinkScopedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics.CreateScope("MonitorPrivateLinkScopedResource.Update");
            scope.Start();
            try
            {
                var response = _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MonitorArmOperation<MonitorPrivateLinkScopedResource>(new MonitorPrivateLinkScopedResourceOperationSource(Client), _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesClientDiagnostics, Pipeline, _monitorPrivateLinkScopedResourcePrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
