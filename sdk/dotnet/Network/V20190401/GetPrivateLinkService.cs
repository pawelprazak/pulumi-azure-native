// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20190401
{
    public static class GetPrivateLinkService
    {
        /// <summary>
        /// Private link service resource.
        /// </summary>
        public static Task<GetPrivateLinkServiceResult> InvokeAsync(GetPrivateLinkServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateLinkServiceResult>("azure-native:network/v20190401:getPrivateLinkService", args ?? new GetPrivateLinkServiceArgs(), options.WithDefaults());

        /// <summary>
        /// Private link service resource.
        /// </summary>
        public static Output<GetPrivateLinkServiceResult> Invoke(GetPrivateLinkServiceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPrivateLinkServiceResult>("azure-native:network/v20190401:getPrivateLinkService", args ?? new GetPrivateLinkServiceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPrivateLinkServiceArgs : Pulumi.InvokeArgs
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
        /// The name of the private link service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetPrivateLinkServiceArgs()
        {
        }
    }

    public sealed class GetPrivateLinkServiceInvokeArgs : Pulumi.InvokeArgs
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
        /// The name of the private link service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public GetPrivateLinkServiceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateLinkServiceResult
    {
        /// <summary>
        /// The alias of the private link service.
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// The auto-approval list of the private link service.
        /// </summary>
        public readonly Outputs.PrivateLinkServicePropertiesResponseAutoApproval? AutoApproval;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// The list of Fqdn.
        /// </summary>
        public readonly ImmutableArray<string> Fqdns;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// An array of references to the private link service IP configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateLinkServiceIpConfigurationResponse> IpConfigurations;
        /// <summary>
        /// An array of references to the load balancer IP configurations.
        /// </summary>
        public readonly ImmutableArray<Outputs.FrontendIPConfigurationResponse> LoadBalancerFrontendIpConfigurations;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets an array of references to the network interfaces created for this private link service.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceResponse> NetworkInterfaces;
        /// <summary>
        /// An array of list about connections to the private endpoint.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionResponse> PrivateEndpointConnections;
        /// <summary>
        /// The provisioning state of the private link service.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The visibility list of the private link service.
        /// </summary>
        public readonly Outputs.PrivateLinkServicePropertiesResponseVisibility? Visibility;

        [OutputConstructor]
        private GetPrivateLinkServiceResult(
            string alias,

            Outputs.PrivateLinkServicePropertiesResponseAutoApproval? autoApproval,

            string? etag,

            ImmutableArray<string> fqdns,

            string? id,

            ImmutableArray<Outputs.PrivateLinkServiceIpConfigurationResponse> ipConfigurations,

            ImmutableArray<Outputs.FrontendIPConfigurationResponse> loadBalancerFrontendIpConfigurations,

            string? location,

            string name,

            ImmutableArray<Outputs.NetworkInterfaceResponse> networkInterfaces,

            ImmutableArray<Outputs.PrivateEndpointConnectionResponse> privateEndpointConnections,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.PrivateLinkServicePropertiesResponseVisibility? visibility)
        {
            Alias = alias;
            AutoApproval = autoApproval;
            Etag = etag;
            Fqdns = fqdns;
            Id = id;
            IpConfigurations = ipConfigurations;
            LoadBalancerFrontendIpConfigurations = loadBalancerFrontendIpConfigurations;
            Location = location;
            Name = name;
            NetworkInterfaces = networkInterfaces;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            Visibility = visibility;
        }
    }
}
