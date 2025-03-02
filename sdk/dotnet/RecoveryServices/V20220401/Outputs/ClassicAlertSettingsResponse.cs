// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20220401.Outputs
{

    /// <summary>
    /// Settings for classic alerts
    /// </summary>
    [OutputType]
    public sealed class ClassicAlertSettingsResponse
    {
        public readonly string? AlertsForCriticalOperations;

        [OutputConstructor]
        private ClassicAlertSettingsResponse(string? alertsForCriticalOperations)
        {
            AlertsForCriticalOperations = alertsForCriticalOperations;
        }
    }
}
