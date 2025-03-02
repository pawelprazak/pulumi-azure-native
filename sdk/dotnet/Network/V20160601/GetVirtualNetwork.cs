// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20160601
{
    [Obsolete(@"Version 2016-06-01 will be removed in v2 of the provider.")]
    public static class GetVirtualNetwork
    {
        /// <summary>
        /// Virtual Network resource
        /// </summary>
        public static Task<GetVirtualNetworkResult> InvokeAsync(GetVirtualNetworkArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkResult>("azure-native:network/v20160601:getVirtualNetwork", args ?? new GetVirtualNetworkArgs(), options.WithDefaults());

        /// <summary>
        /// Virtual Network resource
        /// </summary>
        public static Output<GetVirtualNetworkResult> Invoke(GetVirtualNetworkInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualNetworkResult>("azure-native:network/v20160601:getVirtualNetwork", args ?? new GetVirtualNetworkInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualNetworkArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// expand references resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual network.
        /// </summary>
        [Input("virtualNetworkName", required: true)]
        public string VirtualNetworkName { get; set; } = null!;

        public GetVirtualNetworkArgs()
        {
        }
    }

    public sealed class GetVirtualNetworkInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// expand references resources.
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual network.
        /// </summary>
        [Input("virtualNetworkName", required: true)]
        public Input<string> VirtualNetworkName { get; set; } = null!;

        public GetVirtualNetworkInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkResult
    {
        /// <summary>
        /// Gets or sets AddressSpace that contains an array of IP address ranges that can be used by subnets
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? AddressSpace;
        /// <summary>
        /// Gets or sets DHCPOptions that contains an array of DNS servers available to VMs deployed in the virtual network
        /// </summary>
        public readonly Outputs.DhcpOptionsResponse? DhcpOptions;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Gets or sets resource guid property of the VirtualNetwork resource
        /// </summary>
        public readonly string? ResourceGuid;
        /// <summary>
        /// Gets or sets list of subnets in a VirtualNetwork
        /// </summary>
        public readonly ImmutableArray<Outputs.SubnetResponse> Subnets;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Gets or sets list of peerings in a VirtualNetwork
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNetworkPeeringResponse> VirtualNetworkPeerings;

        [OutputConstructor]
        private GetVirtualNetworkResult(
            Outputs.AddressSpaceResponse? addressSpace,

            Outputs.DhcpOptionsResponse? dhcpOptions,

            string? etag,

            string? id,

            string? location,

            string name,

            string? provisioningState,

            string? resourceGuid,

            ImmutableArray<Outputs.SubnetResponse> subnets,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.VirtualNetworkPeeringResponse> virtualNetworkPeerings)
        {
            AddressSpace = addressSpace;
            DhcpOptions = dhcpOptions;
            Etag = etag;
            Id = id;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            Subnets = subnets;
            Tags = tags;
            Type = type;
            VirtualNetworkPeerings = virtualNetworkPeerings;
        }
    }
}
