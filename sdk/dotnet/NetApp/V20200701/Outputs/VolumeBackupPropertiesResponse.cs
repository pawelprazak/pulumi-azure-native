// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.NetApp.V20200701.Outputs
{

    /// <summary>
    /// Volume Backup Properties
    /// </summary>
    [OutputType]
    public sealed class VolumeBackupPropertiesResponse
    {
        /// <summary>
        /// Backup Enabled
        /// </summary>
        public readonly bool? BackupEnabled;
        /// <summary>
        /// Backup Policy Resource ID
        /// </summary>
        public readonly string? BackupPolicyId;
        /// <summary>
        /// Policy Enforced
        /// </summary>
        public readonly bool? PolicyEnforced;
        /// <summary>
        /// Vault Resource ID
        /// </summary>
        public readonly string? VaultId;

        [OutputConstructor]
        private VolumeBackupPropertiesResponse(
            bool? backupEnabled,

            string? backupPolicyId,

            bool? policyEnforced,

            string? vaultId)
        {
            BackupEnabled = backupEnabled;
            BackupPolicyId = backupPolicyId;
            PolicyEnforced = policyEnforced;
            VaultId = vaultId;
        }
    }
}
