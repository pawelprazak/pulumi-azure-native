// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20191101.Outputs
{

    /// <summary>
    /// The definition of a query.
    /// </summary>
    [OutputType]
    public sealed class ExportDefinitionResponse
    {
        /// <summary>
        /// Has definition for data in this query.
        /// </summary>
        public readonly Outputs.QueryDatasetResponse? DataSet;
        /// <summary>
        /// Has time period for pulling data for the query.
        /// </summary>
        public readonly Outputs.QueryTimePeriodResponse? TimePeriod;
        /// <summary>
        /// The time frame for pulling data for the query. If custom, then a specific time period must be provided.
        /// </summary>
        public readonly string Timeframe;
        /// <summary>
        /// The type of the query.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ExportDefinitionResponse(
            Outputs.QueryDatasetResponse? dataSet,

            Outputs.QueryTimePeriodResponse? timePeriod,

            string timeframe,

            string type)
        {
            DataSet = dataSet;
            TimePeriod = timePeriod;
            Timeframe = timeframe;
            Type = type;
        }
    }
}
