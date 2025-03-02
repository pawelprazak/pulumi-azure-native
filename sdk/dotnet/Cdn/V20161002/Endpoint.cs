// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20161002
{
    /// <summary>
    /// CDN endpoint is the entity within a CDN profile containing configuration information such as origin, protocol, content caching and delivery behavior. The CDN endpoint uses the URL format &lt;endpointname&gt;.azureedge.net.
    /// </summary>
    [Obsolete(@"Version 2016-10-02 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:cdn/v20161002:Endpoint")]
    public partial class Endpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        [Output("contentTypesToCompress")]
        public Output<ImmutableArray<string>> ContentTypesToCompress { get; private set; } = null!;

        /// <summary>
        /// List of rules defining user geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/
        /// </summary>
        [Output("geoFilters")]
        public Output<ImmutableArray<Outputs.GeoFilterResponse>> GeoFilters { get; private set; } = null!;

        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Output("hostName")]
        public Output<string> HostName { get; private set; } = null!;

        /// <summary>
        /// Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [Output("isCompressionEnabled")]
        public Output<bool?> IsCompressionEnabled { get; private set; } = null!;

        /// <summary>
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// </summary>
        [Output("isHttpAllowed")]
        public Output<bool?> IsHttpAllowed { get; private set; } = null!;

        /// <summary>
        /// Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// </summary>
        [Output("isHttpsAllowed")]
        public Output<bool?> IsHttpsAllowed { get; private set; } = null!;

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
        /// Customer can specify what scenario they want this CDN endpoint to optimize, e.g. Download, Media services. With this information we can apply scenario driven optimization.
        /// </summary>
        [Output("optimizationType")]
        public Output<string?> OptimizationType { get; private set; } = null!;

        /// <summary>
        /// The host header CDN sends along with content requests to origin. The default value is the host name of the origin.
        /// </summary>
        [Output("originHostHeader")]
        public Output<string?> OriginHostHeader { get; private set; } = null!;

        /// <summary>
        /// The path used when CDN sends request to origin.
        /// </summary>
        [Output("originPath")]
        public Output<string?> OriginPath { get; private set; } = null!;

        /// <summary>
        /// The source of the content being delivered via CDN.
        /// </summary>
        [Output("origins")]
        public Output<ImmutableArray<Outputs.DeepCreatedOriginResponse>> Origins { get; private set; } = null!;

        /// <summary>
        /// Provisioning status of the endpoint.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Defines the query string caching behavior
        /// </summary>
        [Output("queryStringCachingBehavior")]
        public Output<string?> QueryStringCachingBehavior { get; private set; } = null!;

        /// <summary>
        /// Resource status of the endpoint.
        /// </summary>
        [Output("resourceState")]
        public Output<string> ResourceState { get; private set; } = null!;

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
        /// Create a Endpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Endpoint(string name, EndpointArgs args, CustomResourceOptions? options = null)
            : base("azure-native:cdn/v20161002:Endpoint", name, args ?? new EndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Endpoint(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:cdn/v20161002:Endpoint", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:cdn:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20150601:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20160402:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20170402:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20171012:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20190415:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20190615:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20190615preview:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20191231:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20200331:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20200415:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20200901:Endpoint"},
                    new Pulumi.Alias { Type = "azure-native:cdn/v20210601:Endpoint"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Endpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Endpoint Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Endpoint(name, id, options);
        }
    }

    public sealed class EndpointArgs : Pulumi.ResourceArgs
    {
        [Input("contentTypesToCompress")]
        private InputList<string>? _contentTypesToCompress;

        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        public InputList<string> ContentTypesToCompress
        {
            get => _contentTypesToCompress ?? (_contentTypesToCompress = new InputList<string>());
            set => _contentTypesToCompress = value;
        }

        /// <summary>
        /// Name of the endpoint under the profile which is unique globally.
        /// </summary>
        [Input("endpointName")]
        public Input<string>? EndpointName { get; set; }

        [Input("geoFilters")]
        private InputList<Inputs.GeoFilterArgs>? _geoFilters;

        /// <summary>
        /// List of rules defining user geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/
        /// </summary>
        public InputList<Inputs.GeoFilterArgs> GeoFilters
        {
            get => _geoFilters ?? (_geoFilters = new InputList<Inputs.GeoFilterArgs>());
            set => _geoFilters = value;
        }

        /// <summary>
        /// Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [Input("isCompressionEnabled")]
        public Input<bool>? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// </summary>
        [Input("isHttpAllowed")]
        public Input<bool>? IsHttpAllowed { get; set; }

        /// <summary>
        /// Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
        /// </summary>
        [Input("isHttpsAllowed")]
        public Input<bool>? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Customer can specify what scenario they want this CDN endpoint to optimize, e.g. Download, Media services. With this information we can apply scenario driven optimization.
        /// </summary>
        [Input("optimizationType")]
        public InputUnion<string, Pulumi.AzureNative.Cdn.V20161002.OptimizationType>? OptimizationType { get; set; }

        /// <summary>
        /// The host header CDN sends along with content requests to origin. The default value is the host name of the origin.
        /// </summary>
        [Input("originHostHeader")]
        public Input<string>? OriginHostHeader { get; set; }

        /// <summary>
        /// The path used when CDN sends request to origin.
        /// </summary>
        [Input("originPath")]
        public Input<string>? OriginPath { get; set; }

        [Input("origins", required: true)]
        private InputList<Inputs.DeepCreatedOriginArgs>? _origins;

        /// <summary>
        /// The source of the content being delivered via CDN.
        /// </summary>
        public InputList<Inputs.DeepCreatedOriginArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.DeepCreatedOriginArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Defines the query string caching behavior
        /// </summary>
        [Input("queryStringCachingBehavior")]
        public Input<Pulumi.AzureNative.Cdn.V20161002.QueryStringCachingBehavior>? QueryStringCachingBehavior { get; set; }

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

        public EndpointArgs()
        {
        }
    }
}
