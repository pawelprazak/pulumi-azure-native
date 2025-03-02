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
    public static class GetStorageSyncService
    {
        /// <summary>
        /// Storage Sync Service object.
        /// </summary>
        public static Task<GetStorageSyncServiceResult> InvokeAsync(GetStorageSyncServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStorageSyncServiceResult>("azure-native:storagesync/v20190201:getStorageSyncService", args ?? new GetStorageSyncServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Storage Sync Service object.
        /// </summary>
        public static Output<GetStorageSyncServiceResult> Invoke(GetStorageSyncServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStorageSyncServiceResult>("azure-native:storagesync/v20190201:getStorageSyncService", args ?? new GetStorageSyncServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStorageSyncServiceArgs : Pulumi.InvokeArgs
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

        public GetStorageSyncServiceArgs()
        {
        }
    }

    public sealed class GetStorageSyncServiceInvokeArgs : Pulumi.InvokeArgs
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

        public GetStorageSyncServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStorageSyncServiceResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Storage Sync service status.
        /// </summary>
        public readonly int StorageSyncServiceStatus;
        /// <summary>
        /// Storage Sync service Uid
        /// </summary>
        public readonly string StorageSyncServiceUid;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStorageSyncServiceResult(
            string id,

            string location,

            string name,

            int storageSyncServiceStatus,

            string storageSyncServiceUid,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            StorageSyncServiceStatus = storageSyncServiceStatus;
            StorageSyncServiceUid = storageSyncServiceUid;
            Tags = tags;
            Type = type;
        }
    }
}
