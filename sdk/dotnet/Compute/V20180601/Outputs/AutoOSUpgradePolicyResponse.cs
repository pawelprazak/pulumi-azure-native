// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20180601.Outputs
{

    /// <summary>
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    [OutputType]
    public sealed class AutoOSUpgradePolicyResponse
    {
        /// <summary>
        /// Whether OS image rollback feature should be disabled. Default value is false.
        /// </summary>
        public readonly bool? DisableAutoRollback;

        [OutputConstructor]
        private AutoOSUpgradePolicyResponse(bool? disableAutoRollback)
        {
            DisableAutoRollback = disableAutoRollback;
        }
    }
}
