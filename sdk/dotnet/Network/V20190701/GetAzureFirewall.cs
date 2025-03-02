// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190701
{
    public static class GetAzureFirewall
    {
        /// <summary>
        /// Azure Firewall resource.
        /// </summary>
        public static Task<GetAzureFirewallResult> InvokeAsync(GetAzureFirewallArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAzureFirewallResult>("azure-native:network/v20190701:getAzureFirewall", args ?? new GetAzureFirewallArgs(), options.WithDefaults());

        /// <summary>
        /// Azure Firewall resource.
        /// </summary>
        public static Output<GetAzureFirewallResult> Invoke(GetAzureFirewallInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAzureFirewallResult>("azure-native:network/v20190701:getAzureFirewall", args ?? new GetAzureFirewallInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAzureFirewallArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("azureFirewallName", required: true)]
        public string AzureFirewallName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAzureFirewallArgs()
        {
        }
    }

    public sealed class GetAzureFirewallInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("azureFirewallName", required: true)]
        public Input<string> AzureFirewallName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetAzureFirewallInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAzureFirewallResult
    {
        /// <summary>
        /// Collection of application rule collections used by Azure Firewall.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureFirewallApplicationRuleCollectionResponse> ApplicationRuleCollections;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The firewallPolicy associated with this azure firewall.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FirewallPolicy;
        /// <summary>
        /// IP addresses associated with AzureFirewall.
        /// </summary>
        public readonly Outputs.HubIPAddressesResponse HubIpAddresses;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureFirewallIPConfigurationResponse> IpConfigurations;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Collection of NAT rule collections used by Azure Firewall.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureFirewallNatRuleCollectionResponse> NatRuleCollections;
        /// <summary>
        /// Collection of network rule collections used by Azure Firewall.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureFirewallNetworkRuleCollectionResponse> NetworkRuleCollections;
        /// <summary>
        /// The provisioning state of the Azure firewall resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The operation mode for Threat Intelligence.
        /// </summary>
        public readonly string? ThreatIntelMode;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The virtualHub to which the firewall belongs.
        /// </summary>
        public readonly Outputs.SubResourceResponse? VirtualHub;
        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetAzureFirewallResult(
            ImmutableArray<Outputs.AzureFirewallApplicationRuleCollectionResponse> applicationRuleCollections,

            string etag,

            Outputs.SubResourceResponse? firewallPolicy,

            Outputs.HubIPAddressesResponse hubIpAddresses,

            string? id,

            ImmutableArray<Outputs.AzureFirewallIPConfigurationResponse> ipConfigurations,

            string? location,

            string name,

            ImmutableArray<Outputs.AzureFirewallNatRuleCollectionResponse> natRuleCollections,

            ImmutableArray<Outputs.AzureFirewallNetworkRuleCollectionResponse> networkRuleCollections,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string? threatIntelMode,

            string type,

            Outputs.SubResourceResponse? virtualHub,

            ImmutableArray<string> zones)
        {
            ApplicationRuleCollections = applicationRuleCollections;
            Etag = etag;
            FirewallPolicy = firewallPolicy;
            HubIpAddresses = hubIpAddresses;
            Id = id;
            IpConfigurations = ipConfigurations;
            Location = location;
            Name = name;
            NatRuleCollections = natRuleCollections;
            NetworkRuleCollections = networkRuleCollections;
            ProvisioningState = provisioningState;
            Tags = tags;
            ThreatIntelMode = threatIntelMode;
            Type = type;
            VirtualHub = virtualHub;
            Zones = zones;
        }
    }
}
