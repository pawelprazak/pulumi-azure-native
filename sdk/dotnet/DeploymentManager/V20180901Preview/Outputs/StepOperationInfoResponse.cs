// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DeploymentManager.V20180901Preview.Outputs
{

    /// <summary>
    /// Detailed information of a specific step run.
    /// </summary>
    [OutputType]
    public sealed class StepOperationInfoResponse
    {
        /// <summary>
        /// Unique identifier to track the request for ARM-based resources.
        /// </summary>
        public readonly string CorrelationId;
        /// <summary>
        /// The name of the ARM deployment initiated as part of the step.
        /// </summary>
        public readonly string DeploymentName;
        /// <summary>
        /// End time of the action in UTC.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// The errors, if any, for the action.
        /// </summary>
        public readonly Outputs.CloudErrorBodyResponse? Error;
        /// <summary>
        /// Last time in UTC this operation was updated.
        /// </summary>
        public readonly string LastUpdatedTime;
        /// <summary>
        /// Start time of the action in UTC.
        /// </summary>
        public readonly string StartTime;

        [OutputConstructor]
        private StepOperationInfoResponse(
            string correlationId,

            string deploymentName,

            string endTime,

            Outputs.CloudErrorBodyResponse? error,

            string lastUpdatedTime,

            string startTime)
        {
            CorrelationId = correlationId;
            DeploymentName = deploymentName;
            EndTime = endTime;
            Error = error;
            LastUpdatedTime = lastUpdatedTime;
            StartTime = startTime;
        }
    }
}
