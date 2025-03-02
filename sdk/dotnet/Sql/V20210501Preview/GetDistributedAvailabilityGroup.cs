// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Sql.V20210501Preview
{
    public static class GetDistributedAvailabilityGroup
    {
        /// <summary>
        /// Distributed availability group between box and Sql Managed Instance.
        /// </summary>
        public static Task<GetDistributedAvailabilityGroupResult> InvokeAsync(GetDistributedAvailabilityGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDistributedAvailabilityGroupResult>("azure-native:sql/v20210501preview:getDistributedAvailabilityGroup", args ?? new GetDistributedAvailabilityGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Distributed availability group between box and Sql Managed Instance.
        /// </summary>
        public static Output<GetDistributedAvailabilityGroupResult> Invoke(GetDistributedAvailabilityGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDistributedAvailabilityGroupResult>("azure-native:sql/v20210501preview:getDistributedAvailabilityGroup", args ?? new GetDistributedAvailabilityGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDistributedAvailabilityGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The distributed availability group name.
        /// </summary>
        [Input("distributedAvailabilityGroupName", required: true)]
        public string DistributedAvailabilityGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the managed instance.
        /// </summary>
        [Input("managedInstanceName", required: true)]
        public string ManagedInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDistributedAvailabilityGroupArgs()
        {
        }
    }

    public sealed class GetDistributedAvailabilityGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The distributed availability group name.
        /// </summary>
        [Input("distributedAvailabilityGroupName", required: true)]
        public Input<string> DistributedAvailabilityGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the managed instance.
        /// </summary>
        [Input("managedInstanceName", required: true)]
        public Input<string> ManagedInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetDistributedAvailabilityGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDistributedAvailabilityGroupResult
    {
        /// <summary>
        /// The distributed availability group id
        /// </summary>
        public readonly string DistributedAvailabilityGroupId;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The last hardened lsn
        /// </summary>
        public readonly string LastHardenedLsn;
        /// <summary>
        /// The link state
        /// </summary>
        public readonly string LinkState;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The primary availability group name
        /// </summary>
        public readonly string? PrimaryAvailabilityGroupName;
        /// <summary>
        /// The replication mode of a distributed availability group. Parameter will be ignored during link creation.
        /// </summary>
        public readonly string? ReplicationMode;
        /// <summary>
        /// The secondary availability group name
        /// </summary>
        public readonly string? SecondaryAvailabilityGroupName;
        /// <summary>
        /// The source endpoint
        /// </summary>
        public readonly string? SourceEndpoint;
        /// <summary>
        /// The source replica id
        /// </summary>
        public readonly string SourceReplicaId;
        /// <summary>
        /// The name of the target database
        /// </summary>
        public readonly string? TargetDatabase;
        /// <summary>
        /// The target replica id
        /// </summary>
        public readonly string TargetReplicaId;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDistributedAvailabilityGroupResult(
            string distributedAvailabilityGroupId,

            string id,

            string lastHardenedLsn,

            string linkState,

            string name,

            string? primaryAvailabilityGroupName,

            string? replicationMode,

            string? secondaryAvailabilityGroupName,

            string? sourceEndpoint,

            string sourceReplicaId,

            string? targetDatabase,

            string targetReplicaId,

            string type)
        {
            DistributedAvailabilityGroupId = distributedAvailabilityGroupId;
            Id = id;
            LastHardenedLsn = lastHardenedLsn;
            LinkState = linkState;
            Name = name;
            PrimaryAvailabilityGroupName = primaryAvailabilityGroupName;
            ReplicationMode = replicationMode;
            SecondaryAvailabilityGroupName = secondaryAvailabilityGroupName;
            SourceEndpoint = sourceEndpoint;
            SourceReplicaId = sourceReplicaId;
            TargetDatabase = targetDatabase;
            TargetReplicaId = targetReplicaId;
            Type = type;
        }
    }
}
