// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200501
{
    public static class GetVirtualRouterPeering
    {
        /// <summary>
        /// Virtual Router Peering resource.
        /// </summary>
        public static Task<GetVirtualRouterPeeringResult> InvokeAsync(GetVirtualRouterPeeringArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualRouterPeeringResult>("azure-native:network/v20200501:getVirtualRouterPeering", args ?? new GetVirtualRouterPeeringArgs(), options.WithDefaults());

        /// <summary>
        /// Virtual Router Peering resource.
        /// </summary>
        public static Output<GetVirtualRouterPeeringResult> Invoke(GetVirtualRouterPeeringInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualRouterPeeringResult>("azure-native:network/v20200501:getVirtualRouterPeering", args ?? new GetVirtualRouterPeeringInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualRouterPeeringArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Virtual Router Peering.
        /// </summary>
        [Input("peeringName", required: true)]
        public string PeeringName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Router.
        /// </summary>
        [Input("virtualRouterName", required: true)]
        public string VirtualRouterName { get; set; } = null!;

        public GetVirtualRouterPeeringArgs()
        {
        }
    }

    public sealed class GetVirtualRouterPeeringInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Virtual Router Peering.
        /// </summary>
        [Input("peeringName", required: true)]
        public Input<string> PeeringName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Router.
        /// </summary>
        [Input("virtualRouterName", required: true)]
        public Input<string> VirtualRouterName { get; set; } = null!;

        public GetVirtualRouterPeeringInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualRouterPeeringResult
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the virtual router peering that is unique within a virtual router.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Peer ASN.
        /// </summary>
        public readonly double? PeerAsn;
        /// <summary>
        /// Peer IP.
        /// </summary>
        public readonly string? PeerIp;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Peering type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetVirtualRouterPeeringResult(
            string etag,

            string? id,

            string? name,

            double? peerAsn,

            string? peerIp,

            string provisioningState,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            PeerAsn = peerAsn;
            PeerIp = peerIp;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
