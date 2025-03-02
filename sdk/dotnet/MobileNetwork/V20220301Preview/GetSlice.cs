// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220301Preview
{
    public static class GetSlice
    {
        /// <summary>
        /// Network slice resource.
        /// </summary>
        public static Task<GetSliceResult> InvokeAsync(GetSliceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSliceResult>("azure-native:mobilenetwork/v20220301preview:getSlice", args ?? new GetSliceArgs(), options.WithDefaults());

        /// <summary>
        /// Network slice resource.
        /// </summary>
        public static Output<GetSliceResult> Invoke(GetSliceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSliceResult>("azure-native:mobilenetwork/v20220301preview:getSlice", args ?? new GetSliceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSliceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the mobile network.
        /// </summary>
        [Input("mobileNetworkName", required: true)]
        public string MobileNetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the mobile network slice.
        /// </summary>
        [Input("sliceName", required: true)]
        public string SliceName { get; set; } = null!;

        public GetSliceArgs()
        {
        }
    }

    public sealed class GetSliceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the mobile network.
        /// </summary>
        [Input("mobileNetworkName", required: true)]
        public Input<string> MobileNetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the mobile network slice.
        /// </summary>
        [Input("sliceName", required: true)]
        public Input<string> SliceName { get; set; } = null!;

        public GetSliceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSliceResult
    {
        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        public readonly string? CreatedAt;
        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        public readonly string? CreatedBy;
        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        public readonly string? CreatedByType;
        /// <summary>
        /// An optional description for this network slice.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The timestamp of resource last modification (UTC)
        /// </summary>
        public readonly string? LastModifiedAt;
        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedBy;
        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedByType;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the network slice resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The S-NSSAI (single network slice selection assistance information). Unique at the scope of a MobileNetwork.
        /// </summary>
        public readonly Outputs.SnssaiResponse Snssai;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSliceResult(
            string? createdAt,

            string? createdBy,

            string? createdByType,

            string? description,

            string id,

            string? lastModifiedAt,

            string? lastModifiedBy,

            string? lastModifiedByType,

            string location,

            string name,

            string provisioningState,

            Outputs.SnssaiResponse snssai,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            Description = description;
            Id = id;
            LastModifiedAt = lastModifiedAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Snssai = snssai;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
