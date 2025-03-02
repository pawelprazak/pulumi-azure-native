// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200601
{
    public static class GetIpAllocation
    {
        /// <summary>
        /// IpAllocation resource.
        /// </summary>
        public static Task<GetIpAllocationResult> InvokeAsync(GetIpAllocationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIpAllocationResult>("azure-native:network/v20200601:getIpAllocation", args ?? new GetIpAllocationArgs(), options.WithDefaults());

        /// <summary>
        /// IpAllocation resource.
        /// </summary>
        public static Output<GetIpAllocationResult> Invoke(GetIpAllocationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetIpAllocationResult>("azure-native:network/v20200601:getIpAllocation", args ?? new GetIpAllocationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetIpAllocationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the IpAllocation.
        /// </summary>
        [Input("ipAllocationName", required: true)]
        public string IpAllocationName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetIpAllocationArgs()
        {
        }
    }

    public sealed class GetIpAllocationInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// The name of the IpAllocation.
        /// </summary>
        [Input("ipAllocationName", required: true)]
        public Input<string> IpAllocationName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetIpAllocationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIpAllocationResult
    {
        /// <summary>
        /// IpAllocation tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? AllocationTags;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The IPAM allocation ID.
        /// </summary>
        public readonly string? IpamAllocationId;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The address prefix for the IpAllocation.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// The address prefix length for the IpAllocation.
        /// </summary>
        public readonly int? PrefixLength;
        /// <summary>
        /// The address prefix Type for the IpAllocation.
        /// </summary>
        public readonly string? PrefixType;
        /// <summary>
        /// The Subnet that using the prefix of this IpAllocation resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse Subnet;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The VirtualNetwork that using the prefix of this IpAllocation resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse VirtualNetwork;

        [OutputConstructor]
        private GetIpAllocationResult(
            ImmutableDictionary<string, string>? allocationTags,

            string etag,

            string? id,

            string? ipamAllocationId,

            string? location,

            string name,

            string? prefix,

            int? prefixLength,

            string? prefixType,

            Outputs.SubResourceResponse subnet,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.SubResourceResponse virtualNetwork)
        {
            AllocationTags = allocationTags;
            Etag = etag;
            Id = id;
            IpamAllocationId = ipamAllocationId;
            Location = location;
            Name = name;
            Prefix = prefix;
            PrefixLength = prefixLength;
            PrefixType = prefixType;
            Subnet = subnet;
            Tags = tags;
            Type = type;
            VirtualNetwork = virtualNetwork;
        }
    }
}
