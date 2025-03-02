// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190801
{
    public static class GetVirtualNetworkGatewayVpnclientIpsecParameters
    {
        /// <summary>
        /// An IPSec parameters for a virtual network gateway P2S connection.
        /// </summary>
        public static Task<GetVirtualNetworkGatewayVpnclientIpsecParametersResult> InvokeAsync(GetVirtualNetworkGatewayVpnclientIpsecParametersArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayVpnclientIpsecParametersResult>("azure-native:network/v20190801:getVirtualNetworkGatewayVpnclientIpsecParameters", args ?? new GetVirtualNetworkGatewayVpnclientIpsecParametersArgs(), options.WithDefaults());

        /// <summary>
        /// An IPSec parameters for a virtual network gateway P2S connection.
        /// </summary>
        public static Output<GetVirtualNetworkGatewayVpnclientIpsecParametersResult> Invoke(GetVirtualNetworkGatewayVpnclientIpsecParametersInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualNetworkGatewayVpnclientIpsecParametersResult>("azure-native:network/v20190801:getVirtualNetworkGatewayVpnclientIpsecParameters", args ?? new GetVirtualNetworkGatewayVpnclientIpsecParametersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualNetworkGatewayVpnclientIpsecParametersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The virtual network gateway name.
        /// </summary>
        [Input("virtualNetworkGatewayName", required: true)]
        public string VirtualNetworkGatewayName { get; set; } = null!;

        public GetVirtualNetworkGatewayVpnclientIpsecParametersArgs()
        {
        }
    }

    public sealed class GetVirtualNetworkGatewayVpnclientIpsecParametersInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The virtual network gateway name.
        /// </summary>
        [Input("virtualNetworkGatewayName", required: true)]
        public Input<string> VirtualNetworkGatewayName { get; set; } = null!;

        public GetVirtualNetworkGatewayVpnclientIpsecParametersInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayVpnclientIpsecParametersResult
    {
        /// <summary>
        /// The DH Group used in IKE Phase 1 for initial SA.
        /// </summary>
        public readonly string DhGroup;
        /// <summary>
        /// The IKE encryption algorithm (IKE phase 2).
        /// </summary>
        public readonly string IkeEncryption;
        /// <summary>
        /// The IKE integrity algorithm (IKE phase 2).
        /// </summary>
        public readonly string IkeIntegrity;
        /// <summary>
        /// The IPSec encryption algorithm (IKE phase 1).
        /// </summary>
        public readonly string IpsecEncryption;
        /// <summary>
        /// The IPSec integrity algorithm (IKE phase 1).
        /// </summary>
        public readonly string IpsecIntegrity;
        /// <summary>
        /// The Pfs Group used in IKE Phase 2 for new child SA.
        /// </summary>
        public readonly string PfsGroup;
        /// <summary>
        /// The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for P2S client..
        /// </summary>
        public readonly int SaDataSizeKilobytes;
        /// <summary>
        /// The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for P2S client.
        /// </summary>
        public readonly int SaLifeTimeSeconds;

        [OutputConstructor]
        private GetVirtualNetworkGatewayVpnclientIpsecParametersResult(
            string dhGroup,

            string ikeEncryption,

            string ikeIntegrity,

            string ipsecEncryption,

            string ipsecIntegrity,

            string pfsGroup,

            int saDataSizeKilobytes,

            int saLifeTimeSeconds)
        {
            DhGroup = dhGroup;
            IkeEncryption = ikeEncryption;
            IkeIntegrity = ikeIntegrity;
            IpsecEncryption = ipsecEncryption;
            IpsecIntegrity = ipsecIntegrity;
            PfsGroup = pfsGroup;
            SaDataSizeKilobytes = saDataSizeKilobytes;
            SaLifeTimeSeconds = saLifeTimeSeconds;
        }
    }
}
