// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.NetApp.V20210401Preview
{
    public static class GetBackup
    {
        /// <summary>
        /// Backup of a Volume
        /// </summary>
        public static Task<GetBackupResult> InvokeAsync(GetBackupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBackupResult>("azure-native:netapp/v20210401preview:getBackup", args ?? new GetBackupArgs(), options.WithDefaults());

        /// <summary>
        /// Backup of a Volume
        /// </summary>
        public static Output<GetBackupResult> Invoke(GetBackupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBackupResult>("azure-native:netapp/v20210401preview:getBackup", args ?? new GetBackupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBackupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the backup
        /// </summary>
        [Input("backupName", required: true)]
        public string BackupName { get; set; } = null!;

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public string PoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the volume
        /// </summary>
        [Input("volumeName", required: true)]
        public string VolumeName { get; set; } = null!;

        public GetBackupArgs()
        {
        }
    }

    public sealed class GetBackupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the backup
        /// </summary>
        [Input("backupName", required: true)]
        public Input<string> BackupName { get; set; } = null!;

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public Input<string> PoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the volume
        /// </summary>
        [Input("volumeName", required: true)]
        public Input<string> VolumeName { get; set; } = null!;

        public GetBackupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBackupResult
    {
        /// <summary>
        /// UUID v4 used to identify the Backup
        /// </summary>
        public readonly string BackupId;
        /// <summary>
        /// Type of backup Manual or Scheduled
        /// </summary>
        public readonly string BackupType;
        /// <summary>
        /// The creation date of the backup
        /// </summary>
        public readonly string CreationDate;
        /// <summary>
        /// Failure reason
        /// </summary>
        public readonly string FailureReason;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Label for backup
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Size of backup
        /// </summary>
        public readonly double Size;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Manual backup an already existing snapshot. This will always be false for scheduled backups and true/false for manual backups
        /// </summary>
        public readonly bool? UseExistingSnapshot;
        /// <summary>
        /// Volume name
        /// </summary>
        public readonly string VolumeName;

        [OutputConstructor]
        private GetBackupResult(
            string backupId,

            string backupType,

            string creationDate,

            string failureReason,

            string id,

            string? label,

            string location,

            string name,

            string provisioningState,

            double size,

            string type,

            bool? useExistingSnapshot,

            string volumeName)
        {
            BackupId = backupId;
            BackupType = backupType;
            CreationDate = creationDate;
            FailureReason = failureReason;
            Id = id;
            Label = label;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Size = size;
            Type = type;
            UseExistingSnapshot = useExistingSnapshot;
            VolumeName = volumeName;
        }
    }
}
