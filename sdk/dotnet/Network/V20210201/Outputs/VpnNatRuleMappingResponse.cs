// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201.Outputs
{

    /// <summary>
    /// Vpn NatRule mapping.
    /// </summary>
    [OutputType]
    public sealed class VpnNatRuleMappingResponse
    {
        /// <summary>
        /// Address space for Vpn NatRule mapping.
        /// </summary>
        public readonly string? AddressSpace;

        [OutputConstructor]
        private VpnNatRuleMappingResponse(string? addressSpace)
        {
            AddressSpace = addressSpace;
        }
    }
}
