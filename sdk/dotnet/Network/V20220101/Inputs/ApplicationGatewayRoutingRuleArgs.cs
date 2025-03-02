// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20220101.Inputs
{

    /// <summary>
    /// Routing rule of an application gateway.
    /// </summary>
    public sealed class ApplicationGatewayRoutingRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Backend address pool resource of the application gateway.
        /// </summary>
        [Input("backendAddressPool")]
        public Input<Inputs.SubResourceArgs>? BackendAddressPool { get; set; }

        /// <summary>
        /// Backend settings resource of the application gateway.
        /// </summary>
        [Input("backendSettings")]
        public Input<Inputs.SubResourceArgs>? BackendSettings { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Listener resource of the application gateway.
        /// </summary>
        [Input("listener")]
        public Input<Inputs.SubResourceArgs>? Listener { get; set; }

        /// <summary>
        /// Name of the routing rule that is unique within an Application Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Priority of the routing rule.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// Rule type.
        /// </summary>
        [Input("ruleType")]
        public InputUnion<string, Pulumi.AzureNative.Network.V20220101.ApplicationGatewayRequestRoutingRuleType>? RuleType { get; set; }

        public ApplicationGatewayRoutingRuleArgs()
        {
        }
    }
}
