// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.Outputs
{

    /// <summary>
    /// A2A provider specific settings.
    /// </summary>
    [OutputType]
    public sealed class A2AReplicationDetailsResponse
    {
        /// <summary>
        /// The agent version.
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// The fabric specific object Id of the virtual machine.
        /// </summary>
        public readonly string? FabricObjectId;
        /// <summary>
        /// The initial primary fabric location.
        /// </summary>
        public readonly string InitialPrimaryFabricLocation;
        /// <summary>
        /// The initial primary availability zone.
        /// </summary>
        public readonly string InitialPrimaryZone;
        /// <summary>
        /// The initial recovery fabric location.
        /// </summary>
        public readonly string InitialRecoveryFabricLocation;
        /// <summary>
        /// The initial recovery availability zone.
        /// </summary>
        public readonly string InitialRecoveryZone;
        /// <summary>
        /// Gets the Instance type.
        /// Expected value is 'A2A'.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// A value indicating whether replication agent update is required.
        /// </summary>
        public readonly bool? IsReplicationAgentUpdateRequired;
        /// <summary>
        /// The last heartbeat received from the source server.
        /// </summary>
        public readonly string? LastHeartbeat;
        /// <summary>
        /// The time (in UTC) when the last RPO value was calculated by Protection Service.
        /// </summary>
        public readonly string? LastRpoCalculatedTime;
        /// <summary>
        /// An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected item even though other internal Ids/ARM Id might be changing.
        /// </summary>
        public readonly string? LifecycleId;
        /// <summary>
        /// The management Id.
        /// </summary>
        public readonly string? ManagementId;
        /// <summary>
        /// The type of the monitoring job. The progress is contained in MonitoringPercentageCompletion property.
        /// </summary>
        public readonly string? MonitoringJobType;
        /// <summary>
        /// The percentage of the monitoring job. The type of the monitoring job is defined by MonitoringJobType property.
        /// </summary>
        public readonly int? MonitoringPercentageCompletion;
        /// <summary>
        /// Whether Multi VM group is auto created or specified by user.
        /// </summary>
        public readonly string? MultiVmGroupCreateOption;
        /// <summary>
        /// The multi vm group Id.
        /// </summary>
        public readonly string? MultiVmGroupId;
        /// <summary>
        /// The multi vm group name.
        /// </summary>
        public readonly string? MultiVmGroupName;
        /// <summary>
        /// The type of operating system.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// Primary fabric location.
        /// </summary>
        public readonly string? PrimaryFabricLocation;
        /// <summary>
        /// The list of protected disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.A2AProtectedDiskDetailsResponse> ProtectedDisks;
        /// <summary>
        /// The list of protected managed disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.A2AProtectedManagedDiskDetailsResponse> ProtectedManagedDisks;
        /// <summary>
        /// The recovery availability set.
        /// </summary>
        public readonly string? RecoveryAvailabilitySet;
        /// <summary>
        /// The recovery availability zone.
        /// </summary>
        public readonly string? RecoveryAvailabilityZone;
        /// <summary>
        /// The recovery resource group.
        /// </summary>
        public readonly string? RecoveryAzureResourceGroupId;
        /// <summary>
        /// The name of recovery virtual machine.
        /// </summary>
        public readonly string? RecoveryAzureVMName;
        /// <summary>
        /// The size of recovery virtual machine.
        /// </summary>
        public readonly string? RecoveryAzureVMSize;
        /// <summary>
        /// The recovery boot diagnostic storage account Arm Id.
        /// </summary>
        public readonly string? RecoveryBootDiagStorageAccountId;
        /// <summary>
        /// The recovery cloud service.
        /// </summary>
        public readonly string? RecoveryCloudService;
        /// <summary>
        /// The recovery fabric location.
        /// </summary>
        public readonly string? RecoveryFabricLocation;
        /// <summary>
        /// The recovery fabric object Id.
        /// </summary>
        public readonly string? RecoveryFabricObjectId;
        /// <summary>
        /// The recovery proximity placement group Id.
        /// </summary>
        public readonly string? RecoveryProximityPlacementGroupId;
        /// <summary>
        /// The last RPO value in seconds.
        /// </summary>
        public readonly double? RpoInSeconds;
        /// <summary>
        /// The recovery virtual network.
        /// </summary>
        public readonly string? SelectedRecoveryAzureNetworkId;
        /// <summary>
        /// The test failover virtual network.
        /// </summary>
        public readonly string? SelectedTfoAzureNetworkId;
        /// <summary>
        /// The test failover fabric object Id.
        /// </summary>
        public readonly string? TestFailoverRecoveryFabricObjectId;
        /// <summary>
        /// The test failover VM name.
        /// </summary>
        public readonly string? TfoAzureVMName;
        /// <summary>
        /// The list of unprotected disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.A2AUnprotectedDiskDetailsResponse> UnprotectedDisks;
        /// <summary>
        /// The encryption type of the VM.
        /// </summary>
        public readonly string VmEncryptionType;
        /// <summary>
        /// The virtual machine nic details.
        /// </summary>
        public readonly ImmutableArray<Outputs.VMNicDetailsResponse> VmNics;
        /// <summary>
        /// The protection state for the vm.
        /// </summary>
        public readonly string? VmProtectionState;
        /// <summary>
        /// The protection state description for the vm.
        /// </summary>
        public readonly string? VmProtectionStateDescription;
        /// <summary>
        /// The synced configuration details.
        /// </summary>
        public readonly Outputs.AzureToAzureVmSyncedConfigDetailsResponse? VmSyncedConfigDetails;

        [OutputConstructor]
        private A2AReplicationDetailsResponse(
            string? agentVersion,

            string? fabricObjectId,

            string initialPrimaryFabricLocation,

            string initialPrimaryZone,

            string initialRecoveryFabricLocation,

            string initialRecoveryZone,

            string instanceType,

            bool? isReplicationAgentUpdateRequired,

            string? lastHeartbeat,

            string? lastRpoCalculatedTime,

            string? lifecycleId,

            string? managementId,

            string? monitoringJobType,

            int? monitoringPercentageCompletion,

            string? multiVmGroupCreateOption,

            string? multiVmGroupId,

            string? multiVmGroupName,

            string? osType,

            string? primaryFabricLocation,

            ImmutableArray<Outputs.A2AProtectedDiskDetailsResponse> protectedDisks,

            ImmutableArray<Outputs.A2AProtectedManagedDiskDetailsResponse> protectedManagedDisks,

            string? recoveryAvailabilitySet,

            string? recoveryAvailabilityZone,

            string? recoveryAzureResourceGroupId,

            string? recoveryAzureVMName,

            string? recoveryAzureVMSize,

            string? recoveryBootDiagStorageAccountId,

            string? recoveryCloudService,

            string? recoveryFabricLocation,

            string? recoveryFabricObjectId,

            string? recoveryProximityPlacementGroupId,

            double? rpoInSeconds,

            string? selectedRecoveryAzureNetworkId,

            string? selectedTfoAzureNetworkId,

            string? testFailoverRecoveryFabricObjectId,

            string? tfoAzureVMName,

            ImmutableArray<Outputs.A2AUnprotectedDiskDetailsResponse> unprotectedDisks,

            string vmEncryptionType,

            ImmutableArray<Outputs.VMNicDetailsResponse> vmNics,

            string? vmProtectionState,

            string? vmProtectionStateDescription,

            Outputs.AzureToAzureVmSyncedConfigDetailsResponse? vmSyncedConfigDetails)
        {
            AgentVersion = agentVersion;
            FabricObjectId = fabricObjectId;
            InitialPrimaryFabricLocation = initialPrimaryFabricLocation;
            InitialPrimaryZone = initialPrimaryZone;
            InitialRecoveryFabricLocation = initialRecoveryFabricLocation;
            InitialRecoveryZone = initialRecoveryZone;
            InstanceType = instanceType;
            IsReplicationAgentUpdateRequired = isReplicationAgentUpdateRequired;
            LastHeartbeat = lastHeartbeat;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LifecycleId = lifecycleId;
            ManagementId = managementId;
            MonitoringJobType = monitoringJobType;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MultiVmGroupCreateOption = multiVmGroupCreateOption;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            OsType = osType;
            PrimaryFabricLocation = primaryFabricLocation;
            ProtectedDisks = protectedDisks;
            ProtectedManagedDisks = protectedManagedDisks;
            RecoveryAvailabilitySet = recoveryAvailabilitySet;
            RecoveryAvailabilityZone = recoveryAvailabilityZone;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            RecoveryCloudService = recoveryCloudService;
            RecoveryFabricLocation = recoveryFabricLocation;
            RecoveryFabricObjectId = recoveryFabricObjectId;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            RpoInSeconds = rpoInSeconds;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedTfoAzureNetworkId = selectedTfoAzureNetworkId;
            TestFailoverRecoveryFabricObjectId = testFailoverRecoveryFabricObjectId;
            TfoAzureVMName = tfoAzureVMName;
            UnprotectedDisks = unprotectedDisks;
            VmEncryptionType = vmEncryptionType;
            VmNics = vmNics;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            VmSyncedConfigDetails = vmSyncedConfigDetails;
        }
    }
}
