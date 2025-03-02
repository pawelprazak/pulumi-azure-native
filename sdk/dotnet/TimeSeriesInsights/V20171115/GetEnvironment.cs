// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.TimeSeriesInsights.V20171115
{
    [Obsolete(@"Version 2017-11-15 will be removed in v2 of the provider.")]
    public static class GetEnvironment
    {
        /// <summary>
        /// An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
        /// </summary>
        public static Task<GetEnvironmentResult> InvokeAsync(GetEnvironmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentResult>("azure-native:timeseriesinsights/v20171115:getEnvironment", args ?? new GetEnvironmentArgs(), options.WithDefaults());

        /// <summary>
        /// An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
        /// </summary>
        public static Output<GetEnvironmentResult> Invoke(GetEnvironmentInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetEnvironmentResult>("azure-native:timeseriesinsights/v20171115:getEnvironment", args ?? new GetEnvironmentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnvironmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Time Series Insights environment associated with the specified resource group.
        /// </summary>
        [Input("environmentName", required: true)]
        public string EnvironmentName { get; set; } = null!;

        /// <summary>
        /// Setting $expand=status will include the status of the internal services of the environment in the Time Series Insights service.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetEnvironmentArgs()
        {
        }
    }

    public sealed class GetEnvironmentInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Time Series Insights environment associated with the specified resource group.
        /// </summary>
        [Input("environmentName", required: true)]
        public Input<string> EnvironmentName { get; set; } = null!;

        /// <summary>
        /// Setting $expand=status will include the status of the internal services of the environment in the Time Series Insights service.
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetEnvironmentInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEnvironmentResult
    {
        /// <summary>
        /// The time the resource was created.
        /// </summary>
        public readonly string CreationTime;
        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        public readonly string DataAccessFqdn;
        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        public readonly string DataAccessId;
        /// <summary>
        /// ISO8601 timespan specifying the minimum number of days the environment's events will be available for query.
        /// </summary>
        public readonly string DataRetentionTime;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of partition keys according to which the data in the environment will be ordered.
        /// </summary>
        public readonly ImmutableArray<Outputs.PartitionKeyPropertyResponse> PartitionKeyProperties;
        /// <summary>
        /// Provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The sku determines the capacity of the environment, the SLA (in queries-per-minute and total capacity), and the billing rate.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// An object that represents the status of the environment, and its internal state in the Time Series Insights service.
        /// </summary>
        public readonly Outputs.EnvironmentStatusResponse Status;
        /// <summary>
        /// The behavior the Time Series Insights service should take when the environment's capacity has been exceeded. If "PauseIngress" is specified, new events will not be read from the event source. If "PurgeOldData" is specified, new events will continue to be read and old events will be deleted from the environment. The default behavior is PurgeOldData.
        /// </summary>
        public readonly string? StorageLimitExceededBehavior;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetEnvironmentResult(
            string creationTime,

            string dataAccessFqdn,

            string dataAccessId,

            string dataRetentionTime,

            string id,

            string location,

            string name,

            ImmutableArray<Outputs.PartitionKeyPropertyResponse> partitionKeyProperties,

            string provisioningState,

            Outputs.SkuResponse? sku,

            Outputs.EnvironmentStatusResponse status,

            string? storageLimitExceededBehavior,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CreationTime = creationTime;
            DataAccessFqdn = dataAccessFqdn;
            DataAccessId = dataAccessId;
            DataRetentionTime = dataRetentionTime;
            Id = id;
            Location = location;
            Name = name;
            PartitionKeyProperties = partitionKeyProperties;
            ProvisioningState = provisioningState;
            Sku = sku;
            Status = status;
            StorageLimitExceededBehavior = storageLimitExceededBehavior;
            Tags = tags;
            Type = type;
        }
    }
}
