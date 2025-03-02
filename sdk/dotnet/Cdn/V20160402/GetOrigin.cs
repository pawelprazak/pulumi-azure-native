// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20160402
{
    [Obsolete(@"Version 2016-04-02 will be removed in v2 of the provider.")]
    public static class GetOrigin
    {
        /// <summary>
        /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
        /// </summary>
        public static Task<GetOriginResult> InvokeAsync(GetOriginArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetOriginResult>("azure-native:cdn/v20160402:getOrigin", args ?? new GetOriginArgs(), options.WithDefaults());

        /// <summary>
        /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
        /// </summary>
        public static Output<GetOriginResult> Invoke(GetOriginInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetOriginResult>("azure-native:cdn/v20160402:getOrigin", args ?? new GetOriginInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOriginArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the endpoint within the CDN profile.
        /// </summary>
        [Input("endpointName", required: true)]
        public string EndpointName { get; set; } = null!;

        /// <summary>
        /// Name of the origin, an arbitrary value but it needs to be unique under endpoint
        /// </summary>
        [Input("originName", required: true)]
        public string OriginName { get; set; } = null!;

        /// <summary>
        /// Name of the CDN profile within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public string ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetOriginArgs()
        {
        }
    }

    public sealed class GetOriginInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the endpoint within the CDN profile.
        /// </summary>
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        /// <summary>
        /// Name of the origin, an arbitrary value but it needs to be unique under endpoint
        /// </summary>
        [Input("originName", required: true)]
        public Input<string> OriginName { get; set; } = null!;

        /// <summary>
        /// Name of the CDN profile within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetOriginInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetOriginResult
    {
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        /// </summary>
        public readonly string HostName;
        /// <summary>
        /// The value of the HTTP port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpPort;
        /// <summary>
        /// The value of the https port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpsPort;
        /// <summary>
        /// Resource ID
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Provisioning status of the origin.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource status of the origin.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetOriginResult(
            string hostName,

            int? httpPort,

            int? httpsPort,

            string id,

            string name,

            string provisioningState,

            string resourceState,

            string type)
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            Type = type;
        }
    }
}
