// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20171001.Outputs
{

    /// <summary>
    /// The restriction because of which SKU cannot be used.
    /// </summary>
    [OutputType]
    public sealed class RestrictionResponse
    {
        /// <summary>
        /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
        /// </summary>
        public readonly string? ReasonCode;
        /// <summary>
        /// The type of restrictions. As of now only possible value for this is location.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private RestrictionResponse(
            string? reasonCode,

            string type,

            ImmutableArray<string> values)
        {
            ReasonCode = reasonCode;
            Type = type;
            Values = values;
        }
    }
}
