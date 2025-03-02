// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Resources.V20200801.Outputs
{

    [OutputType]
    public sealed class ZoneMappingResponse
    {
        /// <summary>
        /// The location of the zone mapping.
        /// </summary>
        public readonly string? Location;
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private ZoneMappingResponse(
            string? location,

            ImmutableArray<string> zones)
        {
            Location = location;
            Zones = zones;
        }
    }
}
