// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageSync.V20190201
{
    [Obsolete(@"Version 2019-02-01 will be removed in v2 of the provider.")]
    public static class GetSyncGroup
    {
        /// <summary>
        /// Sync Group object.
        /// </summary>
        public static Task<GetSyncGroupResult> InvokeAsync(GetSyncGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSyncGroupResult>("azure-native:storagesync/v20190201:getSyncGroup", args ?? new GetSyncGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Sync Group object.
        /// </summary>
        public static Output<GetSyncGroupResult> Invoke(GetSyncGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSyncGroupResult>("azure-native:storagesync/v20190201:getSyncGroup", args ?? new GetSyncGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSyncGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Storage Sync Service resource.
        /// </summary>
        [Input("storageSyncServiceName", required: true)]
        public string StorageSyncServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Sync Group resource.
        /// </summary>
        [Input("syncGroupName", required: true)]
        public string SyncGroupName { get; set; } = null!;

        public GetSyncGroupArgs()
        {
        }
    }

    public sealed class GetSyncGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Storage Sync Service resource.
        /// </summary>
        [Input("storageSyncServiceName", required: true)]
        public Input<string> StorageSyncServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Sync Group resource.
        /// </summary>
        [Input("syncGroupName", required: true)]
        public Input<string> SyncGroupName { get; set; } = null!;

        public GetSyncGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSyncGroupResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Sync group status
        /// </summary>
        public readonly string SyncGroupStatus;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Unique Id
        /// </summary>
        public readonly string? UniqueId;

        [OutputConstructor]
        private GetSyncGroupResult(
            string id,

            string name,

            string syncGroupStatus,

            string type,

            string? uniqueId)
        {
            Id = id;
            Name = name;
            SyncGroupStatus = syncGroupStatus;
            Type = type;
            UniqueId = uniqueId;
        }
    }
}
