// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20211001.Outputs
{

    /// <summary>
    /// Long term policy schedule.
    /// </summary>
    [OutputType]
    public sealed class LongTermSchedulePolicyResponse
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// Expected value is 'LongTermSchedulePolicy'.
        /// </summary>
        public readonly string SchedulePolicyType;

        [OutputConstructor]
        private LongTermSchedulePolicyResponse(string schedulePolicyType)
        {
            SchedulePolicyType = schedulePolicyType;
        }
    }
}
