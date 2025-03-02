// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20210801.Outputs
{

    /// <summary>
    /// Properties of the vault.
    /// </summary>
    [OutputType]
    public sealed class VaultPropertiesResponse
    {
        /// <summary>
        /// Customer Managed Key details of the resource.
        /// </summary>
        public readonly Outputs.VaultPropertiesResponseEncryption? Encryption;
        /// <summary>
        /// The details of the latest move operation performed on the Azure Resource
        /// </summary>
        public readonly Outputs.VaultPropertiesResponseMoveDetails? MoveDetails;
        /// <summary>
        /// The State of the Resource after the move operation
        /// </summary>
        public readonly string MoveState;
        /// <summary>
        /// List of private endpoint connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionVaultPropertiesResponse> PrivateEndpointConnections;
        /// <summary>
        /// Private endpoint state for backup.
        /// </summary>
        public readonly string PrivateEndpointStateForBackup;
        /// <summary>
        /// Private endpoint state for site recovery.
        /// </summary>
        public readonly string PrivateEndpointStateForSiteRecovery;
        /// <summary>
        /// Provisioning State.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Details for upgrading vault.
        /// </summary>
        public readonly Outputs.UpgradeDetailsResponse? UpgradeDetails;

        [OutputConstructor]
        private VaultPropertiesResponse(
            Outputs.VaultPropertiesResponseEncryption? encryption,

            Outputs.VaultPropertiesResponseMoveDetails? moveDetails,

            string moveState,

            ImmutableArray<Outputs.PrivateEndpointConnectionVaultPropertiesResponse> privateEndpointConnections,

            string privateEndpointStateForBackup,

            string privateEndpointStateForSiteRecovery,

            string provisioningState,

            Outputs.UpgradeDetailsResponse? upgradeDetails)
        {
            Encryption = encryption;
            MoveDetails = moveDetails;
            MoveState = moveState;
            PrivateEndpointConnections = privateEndpointConnections;
            PrivateEndpointStateForBackup = privateEndpointStateForBackup;
            PrivateEndpointStateForSiteRecovery = privateEndpointStateForSiteRecovery;
            ProvisioningState = provisioningState;
            UpgradeDetails = upgradeDetails;
        }
    }
}
