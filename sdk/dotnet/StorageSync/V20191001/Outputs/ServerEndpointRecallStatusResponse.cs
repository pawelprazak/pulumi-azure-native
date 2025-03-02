// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorageSync.V20191001.Outputs
{

    /// <summary>
    /// Server endpoint recall status object.
    /// </summary>
    [OutputType]
    public sealed class ServerEndpointRecallStatusResponse
    {
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        public readonly string LastUpdatedTimestamp;
        /// <summary>
        /// Array of recall errors
        /// </summary>
        public readonly ImmutableArray<Outputs.ServerEndpointRecallErrorResponse> RecallErrors;
        /// <summary>
        /// Total count of recall errors.
        /// </summary>
        public readonly double TotalRecallErrorsCount;

        [OutputConstructor]
        private ServerEndpointRecallStatusResponse(
            string lastUpdatedTimestamp,

            ImmutableArray<Outputs.ServerEndpointRecallErrorResponse> recallErrors,

            double totalRecallErrorsCount)
        {
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            RecallErrors = recallErrors;
            TotalRecallErrorsCount = totalRecallErrorsCount;
        }
    }
}
