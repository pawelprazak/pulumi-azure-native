// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20180801.Outputs
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
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The routing weight associated to the connection.
        /// </summary>
        public readonly int? RoutingWeight;

        [OutputConstructor]
        private ExpressRouteConnectionResponse(
            string? authorizationKey,

            Outputs.ExpressRouteCircuitPeeringIdResponse expressRouteCircuitPeering,

            string? id,

            string name,

            string provisioningState,

            int? routingWeight)
        {
            AuthorizationKey = authorizationKey;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            RoutingWeight = routingWeight;
        }
    }
}
