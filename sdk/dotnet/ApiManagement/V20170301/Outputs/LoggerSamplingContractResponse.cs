// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ApiManagement.V20170301.Outputs
{

    /// <summary>
    /// Sampling settings contract.
    /// </summary>
    [OutputType]
    public sealed class LoggerSamplingContractResponse
    {
        /// <summary>
        /// Rate re-evaluation interval in ISO8601 format.
        /// </summary>
        public readonly string? EvaluationInterval;
        /// <summary>
        /// Initial sampling rate.
        /// </summary>
        public readonly double? InitialPercentage;
        /// <summary>
        /// Maximum allowed rate of sampling.
        /// </summary>
        public readonly double? MaxPercentage;
        /// <summary>
        /// Target rate of telemetry items per second.
        /// </summary>
        public readonly int? MaxTelemetryItemsPerSecond;
        /// <summary>
        /// Minimum allowed rate of sampling.
        /// </summary>
        public readonly double? MinPercentage;
        /// <summary>
        /// Moving average ration assigned to most recent value.
        /// </summary>
        public readonly double? MovingAverageRatio;
        /// <summary>
        /// Rate of sampling for fixed-rate sampling.
        /// </summary>
        public readonly double? Percentage;
        /// <summary>
        /// Duration in ISO8601 format after which it's allowed to lower the sampling rate.
        /// </summary>
        public readonly string? PercentageDecreaseTimeout;
        /// <summary>
        /// Duration in ISO8601 format after which it's allowed to increase the sampling rate.
        /// </summary>
        public readonly string? PercentageIncreaseTimeout;
        /// <summary>
        /// Sampling type.
        /// </summary>
        public readonly string? SamplingType;

        [OutputConstructor]
        private LoggerSamplingContractResponse(
            string? evaluationInterval,

            double? initialPercentage,

            double? maxPercentage,

            int? maxTelemetryItemsPerSecond,

            double? minPercentage,

            double? movingAverageRatio,

            double? percentage,

            string? percentageDecreaseTimeout,

            string? percentageIncreaseTimeout,

            string? samplingType)
        {
            EvaluationInterval = evaluationInterval;
            InitialPercentage = initialPercentage;
            MaxPercentage = maxPercentage;
            MaxTelemetryItemsPerSecond = maxTelemetryItemsPerSecond;
            MinPercentage = minPercentage;
            MovingAverageRatio = movingAverageRatio;
            Percentage = percentage;
            PercentageDecreaseTimeout = percentageDecreaseTimeout;
            PercentageIncreaseTimeout = percentageIncreaseTimeout;
            SamplingType = samplingType;
        }
    }
}
