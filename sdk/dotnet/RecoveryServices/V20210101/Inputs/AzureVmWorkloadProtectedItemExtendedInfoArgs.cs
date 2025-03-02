// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20210101.Inputs
{

    /// <summary>
    /// Additional information on Azure Workload for SQL specific backup item.
    /// </summary>
    public sealed class AzureVmWorkloadProtectedItemExtendedInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The oldest backup copy available for this backup item.
        /// </summary>
        [Input("oldestRecoveryPoint")]
        public Input<string>? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Indicates consistency of policy object and policy applied to this backup item.
        /// </summary>
        [Input("policyState")]
        public Input<string>? PolicyState { get; set; }

        /// <summary>
        /// Number of backup copies available for this backup item.
        /// </summary>
        [Input("recoveryPointCount")]
        public Input<int>? RecoveryPointCount { get; set; }

        public AzureVmWorkloadProtectedItemExtendedInfoArgs()
        {
        }
    }
}
