// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20200601.Outputs
{

    /// <summary>
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    [OutputType]
    public sealed class AutomaticOSUpgradePolicyResponse
    {
        /// <summary>
        /// Whether OS image rollback feature should be disabled. Default value is false.
        /// </summary>
        public readonly bool? DisableAutomaticRollback;
        /// <summary>
        /// Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. &lt;br&gt;&lt;br&gt; If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true.
        /// </summary>
        public readonly bool? EnableAutomaticOSUpgrade;

        [OutputConstructor]
        private AutomaticOSUpgradePolicyResponse(
            bool? disableAutomaticRollback,

            bool? enableAutomaticOSUpgrade)
        {
            DisableAutomaticRollback = disableAutomaticRollback;
            EnableAutomaticOSUpgrade = enableAutomaticOSUpgrade;
        }
    }
}
