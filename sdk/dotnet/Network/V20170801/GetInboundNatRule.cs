// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20170801
{
    [Obsolete(@"Version 2017-08-01 will be removed in v2 of the provider.")]
    public static class GetInboundNatRule
    {
        /// <summary>
        /// Inbound NAT rule of the load balancer.
        /// </summary>
        public static Task<GetInboundNatRuleResult> InvokeAsync(GetInboundNatRuleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInboundNatRuleResult>("azure-native:network/v20170801:getInboundNatRule", args ?? new GetInboundNatRuleArgs(), options.WithDefaults());

        /// <summary>
        /// Inbound NAT rule of the load balancer.
        /// </summary>
        public static Output<GetInboundNatRuleResult> Invoke(GetInboundNatRuleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetInboundNatRuleResult>("azure-native:network/v20170801:getInboundNatRule", args ?? new GetInboundNatRuleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInboundNatRuleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the inbound nat rule.
        /// </summary>
        [Input("inboundNatRuleName", required: true)]
        public string InboundNatRuleName { get; set; } = null!;

        /// <summary>
        /// The name of the load balancer.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public string LoadBalancerName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetInboundNatRuleArgs()
        {
        }
    }

    public sealed class GetInboundNatRuleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// The name of the inbound nat rule.
        /// </summary>
        [Input("inboundNatRuleName", required: true)]
        public Input<string> InboundNatRuleName { get; set; } = null!;

        /// <summary>
        /// The name of the load balancer.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public Input<string> LoadBalancerName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetInboundNatRuleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetInboundNatRuleResult
    {
        /// <summary>
        /// A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
        /// </summary>
        public readonly Outputs.NetworkInterfaceIPConfigurationResponse BackendIPConfiguration;
        /// <summary>
        /// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
        /// </summary>
        public readonly int? BackendPort;
        /// <summary>
        /// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
        /// </summary>
        public readonly bool? EnableFloatingIP;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// A reference to frontend IP addresses.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FrontendIPConfiguration;
        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
        /// </summary>
        public readonly int? FrontendPort;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
        /// </summary>
        public readonly int? IdleTimeoutInMinutes;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private GetInboundNatRuleResult(
            Outputs.NetworkInterfaceIPConfigurationResponse backendIPConfiguration,

            int? backendPort,

            bool? enableFloatingIP,

            string? etag,

            Outputs.SubResourceResponse? frontendIPConfiguration,

            int? frontendPort,

            string? id,

            int? idleTimeoutInMinutes,

            string? name,

            string? protocol,

            string? provisioningState)
        {
            BackendIPConfiguration = backendIPConfiguration;
            BackendPort = backendPort;
            EnableFloatingIP = enableFloatingIP;
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Id = id;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            Name = name;
            Protocol = protocol;
            ProvisioningState = provisioningState;
        }
    }
}
