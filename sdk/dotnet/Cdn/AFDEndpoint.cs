// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn
{
    /// <summary>
    /// CDN endpoint is the entity within a CDN profile containing configuration information such as origin, protocol, content caching and delivery behavior. The AzureFrontDoor endpoint uses the URL format &lt;endpointname&gt;.azureedge.net.
    /// API Version: 2020-09-01.
    /// </summary>
    [AzureNativeResourceType("azure-native:cdn:AFDEndpoint")]
    public partial class AFDEndpoint : Pulumi.CustomResource
    {
        [Output("deploymentStatus")]
        public Output<string> DeploymentStatus { get; private set; } = null!;

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Output("enabledState")]
        public Output<string?> EnabledState { get; private set; } = null!;

        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Output("hostName")]
        public Output<string> HostName { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Output("originResponseTimeoutSeconds")]
        public Output<int?> OriginResponseTimeoutSeconds { get; private set; } = null!;

        /// <summary>
        /// Provisioning status
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Read only system data
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a AFDEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AFDEndpoint(string name, AFDEndpointArgs args, CustomResourceOptions? options = null)
            : base("azure-native:cdn:AFDEndpoint", name, args ?? new AFDEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AFDEndpoint(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:cdn:AFDEndpoint", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:cdn/v20200901:AFDEndpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20210601:AFDEndpoint"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AFDEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AFDEndpoint Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AFDEndpoint(name, id, options);
        }
    }

    public sealed class AFDEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Input("enabledState")]
        public InputUnion<string, Pulumi.AzureNative.Cdn.EnabledState>? EnabledState { get; set; }

        /// <summary>
        /// Name of the endpoint under the profile which is unique globally.
        /// </summary>
        [Input("endpointName")]
        public Input<string>? EndpointName { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Input("originResponseTimeoutSeconds")]
        public Input<int>? OriginResponseTimeoutSeconds { get; set; }

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public AFDEndpointArgs()
        {
        }
    }
}
