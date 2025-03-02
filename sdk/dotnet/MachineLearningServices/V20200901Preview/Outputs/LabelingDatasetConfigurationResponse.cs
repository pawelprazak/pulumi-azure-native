// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20200901Preview.Outputs
{

    /// <summary>
    /// Represents configuration of dataset used in a labeling job.
    /// </summary>
    [OutputType]
    public sealed class LabelingDatasetConfigurationResponse
    {
        /// <summary>
        /// Name of the data asset to perform labeling.
        /// </summary>
        public readonly string AssetName;
        /// <summary>
        /// AML dataset version.
        /// </summary>
        public readonly string DatasetVersion;
        /// <summary>
        /// Indicates whether to enable incremental dataset refresh.
        /// </summary>
        public readonly bool? EnableIncrementalDatasetRefresh;

        [OutputConstructor]
        private LabelingDatasetConfigurationResponse(
            string assetName,

            string datasetVersion,

            bool? enableIncrementalDatasetRefresh)
        {
            AssetName = assetName;
            DatasetVersion = datasetVersion;
            EnableIncrementalDatasetRefresh = enableIncrementalDatasetRefresh;
        }
    }
}
