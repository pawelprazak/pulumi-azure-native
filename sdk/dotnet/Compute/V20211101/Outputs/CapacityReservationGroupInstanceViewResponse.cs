// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20211101.Outputs
{

    [OutputType]
    public sealed class CapacityReservationGroupInstanceViewResponse
    {
        /// <summary>
        /// List of instance view of the capacity reservations under the capacity reservation group.
        /// </summary>
        public readonly ImmutableArray<Outputs.CapacityReservationInstanceViewWithNameResponse> CapacityReservations;

        [OutputConstructor]
        private CapacityReservationGroupInstanceViewResponse(ImmutableArray<Outputs.CapacityReservationInstanceViewWithNameResponse> capacityReservations)
        {
            CapacityReservations = capacityReservations;
        }
    }
}
