// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logic.V20160601.Inputs
{

    /// <summary>
    /// The batch configuration properties definition.
    /// </summary>
    public sealed class BatchConfigurationPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the batch group.
        /// </summary>
        [Input("batchGroupName", required: true)]
        public Input<string> BatchGroupName { get; set; } = null!;

        /// <summary>
        /// The artifact changed time.
        /// </summary>
        [Input("changedTime")]
        public Input<string>? ChangedTime { get; set; }

        /// <summary>
        /// The artifact creation time.
        /// </summary>
        [Input("createdTime")]
        public Input<string>? CreatedTime { get; set; }

        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The batch release criteria.
        /// </summary>
        [Input("releaseCriteria", required: true)]
        public Input<Inputs.BatchReleaseCriteriaArgs> ReleaseCriteria { get; set; } = null!;

        public BatchConfigurationPropertiesArgs()
        {
        }
    }
}
