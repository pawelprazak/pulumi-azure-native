// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20181201
{
    /// <summary>
    /// ExpressRouteConnection resource.
    /// </summary>
    [AzureNativeResourceType("azure-native:network/v20181201:ExpressRouteConnection")]
    public partial class ExpressRouteConnection : Pulumi.CustomResource
    {
        /// <summary>
        /// Authorization key to establish the connection.
        /// </summary>
        [Output("authorizationKey")]
        public Output<string?> AuthorizationKey { get; private set; } = null!;

        /// <summary>
        /// The ExpressRoute circuit peering.
        /// </summary>
        [Output("expressRouteCircuitPeering")]
        public Output<Outputs.ExpressRouteCircuitPeeringIdResponse> ExpressRouteCircuitPeering { get; private set; } = null!;

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The routing weight associated to the connection.
        /// </summary>
        [Output("routingWeight")]
        public Output<int?> RoutingWeight { get; private set; } = null!;


        /// <summary>
        /// Create a ExpressRouteConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExpressRouteConnection(string name, ExpressRouteConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure-native:network/v20181201:ExpressRouteConnection", name, args ?? new ExpressRouteConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExpressRouteConnection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:network/v20181201:ExpressRouteConnection", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-native:network:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20180801:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20181001:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20181101:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190201:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190401:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190601:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190701:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190801:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20190901:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20191101:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20191201:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200301:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200401:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200501:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200601:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200701:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20200801:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20201101:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20210201:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20210301:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20210501:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20210801:ExpressRouteConnection"},
                    new Pulumi.Alias { Type = "azure-native:network/v20220101:ExpressRouteConnection"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ExpressRouteConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExpressRouteConnection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ExpressRouteConnection(name, id, options);
        }
    }

    public sealed class ExpressRouteConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authorization key to establish the connection.
        /// </summary>
        [Input("authorizationKey")]
        public Input<string>? AuthorizationKey { get; set; }

        /// <summary>
        /// The name of the connection subresource.
        /// </summary>
        [Input("connectionName")]
        public Input<string>? ConnectionName { get; set; }

        /// <summary>
        /// The ExpressRoute circuit peering.
        /// </summary>
        [Input("expressRouteCircuitPeering", required: true)]
        public Input<Inputs.ExpressRouteCircuitPeeringIdArgs> ExpressRouteCircuitPeering { get; set; } = null!;

        /// <summary>
        /// The name of the ExpressRoute gateway.
        /// </summary>
        [Input("expressRouteGatewayName", required: true)]
        public Input<string> ExpressRouteGatewayName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The routing weight associated to the connection.
        /// </summary>
        [Input("routingWeight")]
        public Input<int>? RoutingWeight { get; set; }

        public ExpressRouteConnectionArgs()
        {
        }
    }
}
