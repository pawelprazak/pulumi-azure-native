// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200501.Outputs
{

    /// <summary>
    /// ExpressRouteConnection resource.
    /// </summary>
    [OutputType]
    public sealed class ExpressRouteConnectionResponse
    {
        /// <summary>
        /// Authorization key to establish the connection.
        /// </summary>
        public readonly string? AuthorizationKey;
        /// <summary>
        /// Enable internet security.
        /// </summary>
        public readonly bool? EnableInternetSecurity;
        /// <summary>
        /// The ExpressRoute circuit peering.
        /// </summary>
        public readonly Outputs.ExpressRouteCircuitPeeringIdResponse ExpressRouteCircuitPeering;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the express route connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        public readonly Outputs.RoutingConfigurationResponse? RoutingConfiguration;
        /// <summary>
        /// The routing weight associated to the connection.
        /// </summary>
        public readonly int? RoutingWeight;

        [OutputConstructor]
        private ExpressRouteConnectionResponse(
            string? authorizationKey,

            bool? enableInternetSecurity,

            Outputs.ExpressRouteCircuitPeeringIdResponse expressRouteCircuitPeering,

            string? id,

            string name,

            string provisioningState,

            Outputs.RoutingConfigurationResponse? routingConfiguration,

            int? routingWeight)
        {
            AuthorizationKey = authorizationKey;
            EnableInternetSecurity = enableInternetSecurity;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            RoutingConfiguration = routingConfiguration;
            RoutingWeight = routingWeight;
        }
    }
}
