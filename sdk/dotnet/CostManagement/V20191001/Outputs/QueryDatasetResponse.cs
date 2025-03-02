// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20191001.Outputs
{

    /// <summary>
    /// The definition of data present in the query.
    /// </summary>
    [OutputType]
    public sealed class QueryDatasetResponse
    {
        /// <summary>
        /// Dictionary of aggregation expression to use in the query. The key of each item in the dictionary is the alias for the aggregated column. Query can have up to 2 aggregation clauses.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.QueryAggregationResponse>? Aggregation;
        /// <summary>
        /// Has configuration information for the data in the export. The configuration will be ignored if aggregation and grouping are provided.
        /// </summary>
        public readonly Outputs.QueryDatasetConfigurationResponse? Configuration;
        /// <summary>
        /// The filter expression to use in the query. Please reference our Query API REST documentation for how to properly format the filter.
        /// </summary>
        public readonly Outputs.QueryFilterResponse? Filter;
        /// <summary>
        /// The granularity of rows in the query.
        /// </summary>
        public readonly string? Granularity;
        /// <summary>
        /// Array of group by expression to use in the query. Query can have up to 2 group by clauses.
        /// </summary>
        public readonly ImmutableArray<Outputs.QueryGroupingResponse> Grouping;
        /// <summary>
        /// Array of sorting by columns in query.
        /// </summary>
        public readonly ImmutableArray<Outputs.QuerySortingConfigurationResponse> Sorting;

        [OutputConstructor]
        private QueryDatasetResponse(
            ImmutableDictionary<string, Outputs.QueryAggregationResponse>? aggregation,

            Outputs.QueryDatasetConfigurationResponse? configuration,

            Outputs.QueryFilterResponse? filter,

            string? granularity,

            ImmutableArray<Outputs.QueryGroupingResponse> grouping,

            ImmutableArray<Outputs.QuerySortingConfigurationResponse> sorting)
        {
            Aggregation = aggregation;
            Configuration = configuration;
            Filter = filter;
            Granularity = granularity;
            Grouping = grouping;
            Sorting = sorting;
        }
    }
}
