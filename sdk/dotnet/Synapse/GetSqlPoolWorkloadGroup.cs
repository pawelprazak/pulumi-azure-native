// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse
{
    public static class GetSqlPoolWorkloadGroup
    {
        /// <summary>
        /// Workload group operations for a sql pool
        /// API Version: 2021-03-01.
        /// </summary>
        public static Task<GetSqlPoolWorkloadGroupResult> InvokeAsync(GetSqlPoolWorkloadGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSqlPoolWorkloadGroupResult>("azure-native:synapse:getSqlPoolWorkloadGroup", args ?? new GetSqlPoolWorkloadGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Workload group operations for a sql pool
        /// API Version: 2021-03-01.
        /// </summary>
        public static Output<GetSqlPoolWorkloadGroupResult> Invoke(GetSqlPoolWorkloadGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSqlPoolWorkloadGroupResult>("azure-native:synapse:getSqlPoolWorkloadGroup", args ?? new GetSqlPoolWorkloadGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSqlPoolWorkloadGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// SQL pool name
        /// </summary>
        [Input("sqlPoolName", required: true)]
        public string SqlPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the workload group.
        /// </summary>
        [Input("workloadGroupName", required: true)]
        public string WorkloadGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetSqlPoolWorkloadGroupArgs()
        {
        }
    }

    public sealed class GetSqlPoolWorkloadGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// SQL pool name
        /// </summary>
        [Input("sqlPoolName", required: true)]
        public Input<string> SqlPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the workload group.
        /// </summary>
        [Input("workloadGroupName", required: true)]
        public Input<string> WorkloadGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetSqlPoolWorkloadGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSqlPoolWorkloadGroupResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The workload group importance level.
        /// </summary>
        public readonly string? Importance;
        /// <summary>
        /// The workload group cap percentage resource.
        /// </summary>
        public readonly int MaxResourcePercent;
        /// <summary>
        /// The workload group request maximum grant percentage.
        /// </summary>
        public readonly double? MaxResourcePercentPerRequest;
        /// <summary>
        /// The workload group minimum percentage resource.
        /// </summary>
        public readonly int MinResourcePercent;
        /// <summary>
        /// The workload group request minimum grant percentage.
        /// </summary>
        public readonly double MinResourcePercentPerRequest;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The workload group query execution timeout.
        /// </summary>
        public readonly int? QueryExecutionTimeout;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSqlPoolWorkloadGroupResult(
            string id,

            string? importance,

            int maxResourcePercent,

            double? maxResourcePercentPerRequest,

            int minResourcePercent,

            double minResourcePercentPerRequest,

            string name,

            int? queryExecutionTimeout,

            string type)
        {
            Id = id;
            Importance = importance;
            MaxResourcePercent = maxResourcePercent;
            MaxResourcePercentPerRequest = maxResourcePercentPerRequest;
            MinResourcePercent = minResourcePercent;
            MinResourcePercentPerRequest = minResourcePercentPerRequest;
            Name = name;
            QueryExecutionTimeout = queryExecutionTimeout;
            Type = type;
        }
    }
}
