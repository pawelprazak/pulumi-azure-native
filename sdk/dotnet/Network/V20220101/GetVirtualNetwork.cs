// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220101
{
    public static class GetVirtualNetwork
    {
        /// <summary>
        /// Virtual Network resource.
        /// </summary>
        public static Task<GetVirtualNetworkResult> InvokeAsync(GetVirtualNetworkArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkResult>("azure-native:network/v20220101:getVirtualNetwork", args ?? new GetVirtualNetworkArgs(), options.WithDefaults());

        /// <summary>
        /// Virtual Network resource.
        /// </summary>
        public static Output<GetVirtualNetworkResult> Invoke(GetVirtualNetworkInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualNetworkResult>("azure-native:network/v20220101:getVirtualNetwork", args ?? new GetVirtualNetworkInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualNetworkArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
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
        /// Expands referenced resources.
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
        /// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? AddressSpace;
        /// <summary>
        /// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
        /// </summary>
        public readonly Outputs.VirtualNetworkBgpCommunitiesResponse? BgpCommunities;
        /// <summary>
        /// The DDoS protection plan associated with the virtual network.
        /// </summary>
        public readonly Outputs.SubResourceResponse? DdosProtectionPlan;
        /// <summary>
        /// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
        /// </summary>
        public readonly Outputs.DhcpOptionsResponse? DhcpOptions;
        /// <summary>
        /// Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It requires a DDoS protection plan associated with the resource.
        /// </summary>
        public readonly bool? EnableDdosProtection;
        /// <summary>
        /// Indicates if VM protection is enabled for all the subnets in the virtual network.
        /// </summary>
        public readonly bool? EnableVmProtection;
        /// <summary>
        /// Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted VNet.
        /// </summary>
        public readonly Outputs.VirtualNetworkEncryptionResponse? Encryption;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The extended location of the virtual network.
        /// </summary>
        public readonly Outputs.ExtendedLocationResponse? ExtendedLocation;
        /// <summary>
        /// The FlowTimeout value (in minutes) for the Virtual Network
        /// </summary>
        public readonly int? FlowTimeoutInMinutes;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Array of IpAllocation which reference this VNET.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> IpAllocations;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the virtual network resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resourceGuid property of the Virtual Network resource.
        /// </summary>
        public readonly string ResourceGuid;
        /// <summary>
        /// A list of subnets in a Virtual Network.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubnetResponse> Subnets;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// A list of peerings in a Virtual Network.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNetworkPeeringResponse> VirtualNetworkPeerings;

        [OutputConstructor]
        private GetVirtualNetworkResult(
            Outputs.AddressSpaceResponse? addressSpace,

            Outputs.VirtualNetworkBgpCommunitiesResponse? bgpCommunities,

            Outputs.SubResourceResponse? ddosProtectionPlan,

            Outputs.DhcpOptionsResponse? dhcpOptions,

            bool? enableDdosProtection,

            bool? enableVmProtection,

            Outputs.VirtualNetworkEncryptionResponse? encryption,

            string etag,

            Outputs.ExtendedLocationResponse? extendedLocation,

            int? flowTimeoutInMinutes,

            string? id,

            ImmutableArray<Outputs.SubResourceResponse> ipAllocations,

            string? location,

            string name,

            string provisioningState,

            string resourceGuid,

            ImmutableArray<Outputs.SubnetResponse> subnets,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.VirtualNetworkPeeringResponse> virtualNetworkPeerings)
        {
            AddressSpace = addressSpace;
            BgpCommunities = bgpCommunities;
            DdosProtectionPlan = ddosProtectionPlan;
            DhcpOptions = dhcpOptions;
            EnableDdosProtection = enableDdosProtection;
            EnableVmProtection = enableVmProtection;
            Encryption = encryption;
            Etag = etag;
            ExtendedLocation = extendedLocation;
            FlowTimeoutInMinutes = flowTimeoutInMinutes;
            Id = id;
            IpAllocations = ipAllocations;
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
