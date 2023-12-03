// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an IotSecuritySolution along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="IotSecuritySolutionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetIotSecuritySolutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetIotSecuritySolution method.
    /// </summary>
    public partial class IotSecuritySolutionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotSecuritySolutionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="solutionName"> The solutionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string solutionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotSecuritySolutionClientDiagnostics;
        private readonly IotSecuritySolutionRestOperations _iotSecuritySolutionRestClient;
        private readonly IotSecuritySolutionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/iotSecuritySolutions";

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionResource"/> class for mocking. </summary>
        protected IotSecuritySolutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotSecuritySolutionResource(ArmClient client, IotSecuritySolutionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotSecuritySolutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotSecuritySolutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotSecuritySolutionApiVersion);
            _iotSecuritySolutionRestClient = new IotSecuritySolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotSecuritySolutionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotSecuritySolutionData Data
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

        /// <summary> Gets an object representing a IotSecuritySolutionAnalyticsModelResource along with the instance operations that can be performed on it in the IotSecuritySolution. </summary>
        /// <returns> Returns a <see cref="IotSecuritySolutionAnalyticsModelResource"/> object. </returns>
        public virtual IotSecuritySolutionAnalyticsModelResource GetIotSecuritySolutionAnalyticsModel()
        {
            return new IotSecuritySolutionAnalyticsModelResource(Client, Id.AppendChildResource("analyticsModels", "default"));
        }

        /// <summary>
        /// User this method to get details of a specific IoT Security solution based on solution name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotSecuritySolutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Get");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// User this method to get details of a specific IoT Security solution based on solution name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotSecuritySolutionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Get");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to delete yours IoT Security solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Delete");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Use this method to delete yours IoT Security solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Delete");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Use this method to update existing IoT Security solution tags or user defined resources. To update other fields use the CreateOrUpdate method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The security solution data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<IotSecuritySolutionResource>> UpdateAsync(IotSecuritySolutionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Update");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to update existing IoT Security solution tags or user defined resources. To update other fields use the CreateOrUpdate method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The security solution data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<IotSecuritySolutionResource> Update(IotSecuritySolutionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.Update");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<IotSecuritySolutionResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<IotSecuritySolutionResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<IotSecuritySolutionResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<IotSecuritySolutionResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<IotSecuritySolutionResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<IotSecuritySolutionResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new IotSecuritySolutionResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new IotSecuritySolutionPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
