// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20220501Preview.Outputs
{

    /// <summary>
    /// Service network profile payload
    /// </summary>
    [OutputType]
    public sealed class NetworkProfileResponse
    {
        /// <summary>
        /// Name of the resource group containing network resources for customer apps in Azure Spring Apps
        /// </summary>
        public readonly string? AppNetworkResourceGroup;
        /// <summary>
        /// Fully qualified resource Id of the subnet to host customer apps in Azure Spring Apps
        /// </summary>
        public readonly string? AppSubnetId;
        /// <summary>
        /// Ingress configuration payload for Azure Spring Apps resource.
        /// </summary>
        public readonly Outputs.IngressConfigResponse? IngressConfig;
        /// <summary>
        /// Desired outbound IP resources for Azure Spring Apps resource.
        /// </summary>
        public readonly Outputs.NetworkProfileResponseOutboundIPs OutboundIPs;
        /// <summary>
        /// Required inbound or outbound traffics for Azure Spring Apps resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.RequiredTrafficResponse> RequiredTraffics;
        /// <summary>
        /// Azure Spring Apps service reserved CIDR
        /// </summary>
        public readonly string? ServiceCidr;
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Apps Service Runtime
        /// </summary>
        public readonly string? ServiceRuntimeNetworkResourceGroup;
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Apps Service Runtime
        /// </summary>
        public readonly string? ServiceRuntimeSubnetId;

        [OutputConstructor]
        private NetworkProfileResponse(
            string? appNetworkResourceGroup,

            string? appSubnetId,

            Outputs.IngressConfigResponse? ingressConfig,

            Outputs.NetworkProfileResponseOutboundIPs outboundIPs,

            ImmutableArray<Outputs.RequiredTrafficResponse> requiredTraffics,

            string? serviceCidr,

            string? serviceRuntimeNetworkResourceGroup,

            string? serviceRuntimeSubnetId)
        {
            AppNetworkResourceGroup = appNetworkResourceGroup;
            AppSubnetId = appSubnetId;
            IngressConfig = ingressConfig;
            OutboundIPs = outboundIPs;
            RequiredTraffics = requiredTraffics;
            ServiceCidr = serviceCidr;
            ServiceRuntimeNetworkResourceGroup = serviceRuntimeNetworkResourceGroup;
            ServiceRuntimeSubnetId = serviceRuntimeSubnetId;
        }
    }
}
