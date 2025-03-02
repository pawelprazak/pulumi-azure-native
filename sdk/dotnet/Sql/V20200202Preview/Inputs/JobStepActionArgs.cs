// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Sql.V20200202Preview.Inputs
{

    /// <summary>
    /// The action to be executed by a job step.
    /// </summary>
    public sealed class JobStepActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The source of the action to execute.
        /// </summary>
        [Input("source")]
        public InputUnion<string, Pulumi.AzureNative.Sql.V20200202Preview.JobStepActionSource>? Source { get; set; }

        /// <summary>
        /// Type of action being executed by the job step.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNative.Sql.V20200202Preview.JobStepActionType>? Type { get; set; }

        /// <summary>
        /// The action value, for example the text of the T-SQL script to execute.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public JobStepActionArgs()
        {
            Source = "Inline";
            Type = "TSql";
        }
    }
}
