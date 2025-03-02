// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20211001.Inputs
{

    /// <summary>
    /// Additional information on Azure Sql specific protected item.
    /// </summary>
    public sealed class AzureSqlProtectedItemExtendedInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The oldest backup copy available for this item in the service.
        /// </summary>
        [Input("oldestRecoveryPoint")]
        public Input<string>? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// State of the backup policy associated with this backup item.
        /// </summary>
        [Input("policyState")]
        public Input<string>? PolicyState { get; set; }

        /// <summary>
        /// Number of available backup copies associated with this backup item.
        /// </summary>
        [Input("recoveryPointCount")]
        public Input<int>? RecoveryPointCount { get; set; }

        public AzureSqlProtectedItemExtendedInfoArgs()
        {
        }
    }
}
