// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20210301
{
    public static class GetLogAnalyticExportThrottledRequests
    {
        /// <summary>
        /// LogAnalytics operation status response
        /// </summary>
        public static Task<GetLogAnalyticExportThrottledRequestsResult> InvokeAsync(GetLogAnalyticExportThrottledRequestsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLogAnalyticExportThrottledRequestsResult>("azure-native:compute/v20210301:getLogAnalyticExportThrottledRequests", args ?? new GetLogAnalyticExportThrottledRequestsArgs(), options.WithDefaults());

        /// <summary>
        /// LogAnalytics operation status response
        /// </summary>
        public static Output<GetLogAnalyticExportThrottledRequestsResult> Invoke(GetLogAnalyticExportThrottledRequestsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetLogAnalyticExportThrottledRequestsResult>("azure-native:compute/v20210301:getLogAnalyticExportThrottledRequests", args ?? new GetLogAnalyticExportThrottledRequestsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLogAnalyticExportThrottledRequestsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// </summary>
        [Input("blobContainerSasUri", required: true)]
        public string BlobContainerSasUri { get; set; } = null!;

        /// <summary>
        /// From time of the query
        /// </summary>
        [Input("fromTime", required: true)]
        public string FromTime { get; set; } = null!;

        /// <summary>
        /// Group query result by Client Application ID.
        /// </summary>
        [Input("groupByClientApplicationId")]
        public bool? GroupByClientApplicationId { get; set; }

        /// <summary>
        /// Group query result by Operation Name.
        /// </summary>
        [Input("groupByOperationName")]
        public bool? GroupByOperationName { get; set; }

        /// <summary>
        /// Group query result by Resource Name.
        /// </summary>
        [Input("groupByResourceName")]
        public bool? GroupByResourceName { get; set; }

        /// <summary>
        /// Group query result by Throttle Policy applied.
        /// </summary>
        [Input("groupByThrottlePolicy")]
        public bool? GroupByThrottlePolicy { get; set; }

        /// <summary>
        /// Group query result by User Agent.
        /// </summary>
        [Input("groupByUserAgent")]
        public bool? GroupByUserAgent { get; set; }

        /// <summary>
        /// The location upon which virtual-machine-sizes is queried.
        /// </summary>
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// To time of the query
        /// </summary>
        [Input("toTime", required: true)]
        public string ToTime { get; set; } = null!;

        public GetLogAnalyticExportThrottledRequestsArgs()
        {
        }
    }

    public sealed class GetLogAnalyticExportThrottledRequestsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// </summary>
        [Input("blobContainerSasUri", required: true)]
        public Input<string> BlobContainerSasUri { get; set; } = null!;

        /// <summary>
        /// From time of the query
        /// </summary>
        [Input("fromTime", required: true)]
        public Input<string> FromTime { get; set; } = null!;

        /// <summary>
        /// Group query result by Client Application ID.
        /// </summary>
        [Input("groupByClientApplicationId")]
        public Input<bool>? GroupByClientApplicationId { get; set; }

        /// <summary>
        /// Group query result by Operation Name.
        /// </summary>
        [Input("groupByOperationName")]
        public Input<bool>? GroupByOperationName { get; set; }

        /// <summary>
        /// Group query result by Resource Name.
        /// </summary>
        [Input("groupByResourceName")]
        public Input<bool>? GroupByResourceName { get; set; }

        /// <summary>
        /// Group query result by Throttle Policy applied.
        /// </summary>
        [Input("groupByThrottlePolicy")]
        public Input<bool>? GroupByThrottlePolicy { get; set; }

        /// <summary>
        /// Group query result by User Agent.
        /// </summary>
        [Input("groupByUserAgent")]
        public Input<bool>? GroupByUserAgent { get; set; }

        /// <summary>
        /// The location upon which virtual-machine-sizes is queried.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// To time of the query
        /// </summary>
        [Input("toTime", required: true)]
        public Input<string> ToTime { get; set; } = null!;

        public GetLogAnalyticExportThrottledRequestsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLogAnalyticExportThrottledRequestsResult
    {
        /// <summary>
        /// LogAnalyticsOutput
        /// </summary>
        public readonly Outputs.LogAnalyticsOutputResponse Properties;

        [OutputConstructor]
        private GetLogAnalyticExportThrottledRequestsResult(Outputs.LogAnalyticsOutputResponse properties)
        {
            Properties = properties;
        }
    }
}
