// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20150801
{
    /// <summary>
    /// VnetRoute contract used to pass routing information for a vnet.
    /// </summary>
    [Obsolete(@"Version 2015-08-01 will be removed in v2 of the provider.")]
    [AzureNativeResourceType("azure-native:web/v20150801:ServerFarmRouteForVnet")]
    public partial class ServerFarmRouteForVnet : Pulumi.CustomResource
    {
        /// <summary>
        /// The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
        /// </summary>
        [Output("endAddress")]
        public Output<string?> EndAddress { get; private set; } = null!;

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// The type of route this is:
        ///             DEFAULT - By default, every web app has routes to the local address ranges specified by RFC1918
        ///             INHERITED - Routes inherited from the real Virtual Network routes
        ///             STATIC - Static route set on the web app only
        ///             
        ///             These values will be used for syncing a Web App's routes with those from a Virtual Network. This operation will clear all DEFAULT and INHERITED routes and replace them
        ///             with new INHERITED routes.
        /// </summary>
        [Output("routeType")]
        public Output<string?> RouteType { get; private set; } = null!;

        /// <summary>
        /// The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
        /// </summary>
        [Output("startAddress")]
        public Output<string?> StartAddress { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ServerFarmRouteForVnet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerFarmRouteForVnet(string name, ServerFarmRouteForVnetArgs args, CustomResourceOptions? options = null)
            : base("azure-native:web/v20150801:ServerFarmRouteForVnet", name, args ?? new ServerFarmRouteForVnetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServerFarmRouteForVnet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:web/v20150801:ServerFarmRouteForVnet", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:web:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20160901:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20180201:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20190801:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20200601:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20200901:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20201001:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20201201:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210101:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210115:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210201:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20210301:ServerFarmRouteForVnet"},
                    new Pulumi.Alias { Type = "azure-native:web/v20220301:ServerFarmRouteForVnet"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServerFarmRouteForVnet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerFarmRouteForVnet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServerFarmRouteForVnet(name, id, options);
        }
    }

    public sealed class ServerFarmRouteForVnetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
        /// </summary>
        [Input("endAddress")]
        public Input<string>? EndAddress { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the virtual network route
        /// </summary>
        [Input("routeName")]
        public Input<string>? RouteName { get; set; }

        /// <summary>
        /// The type of route this is:
        ///             DEFAULT - By default, every web app has routes to the local address ranges specified by RFC1918
        ///             INHERITED - Routes inherited from the real Virtual Network routes
        ///             STATIC - Static route set on the web app only
        ///             
        ///             These values will be used for syncing a Web App's routes with those from a Virtual Network. This operation will clear all DEFAULT and INHERITED routes and replace them
        ///             with new INHERITED routes.
        /// </summary>
        [Input("routeType")]
        public Input<string>? RouteType { get; set; }

        /// <summary>
        /// The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
        /// </summary>
        [Input("startAddress")]
        public Input<string>? StartAddress { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Name of virtual network
        /// </summary>
        [Input("vnetName", required: true)]
        public Input<string> VnetName { get; set; } = null!;

        public ServerFarmRouteForVnetArgs()
        {
        }
    }
}
