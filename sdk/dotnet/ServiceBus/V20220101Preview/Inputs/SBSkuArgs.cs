// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceBus.V20220101Preview.Inputs
{

    /// <summary>
    /// SKU of the namespace.
    /// </summary>
    public sealed class SBSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The specified messaging units for the tier. For Premium tier, capacity are 1,2 and 4.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// Name of this SKU.
        /// </summary>
        [Input("name", required: true)]
        public InputUnion<string, Pulumi.AzureNative.ServiceBus.V20220101Preview.SkuName> Name { get; set; } = null!;

        /// <summary>
        /// The billing tier of this particular SKU.
        /// </summary>
        [Input("tier")]
        public InputUnion<string, Pulumi.AzureNative.ServiceBus.V20220101Preview.SkuTier>? Tier { get; set; }

        public SBSkuArgs()
        {
        }
    }
}
