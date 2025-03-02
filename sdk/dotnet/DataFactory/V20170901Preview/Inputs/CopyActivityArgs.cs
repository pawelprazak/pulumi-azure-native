// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Copy activity.
    /// </summary>
    public sealed class CopyActivityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum number of cloud data movement units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Input("cloudDataMovementUnits")]
        public Input<object>? CloudDataMovementUnits { get; set; }

        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("enableSkipIncompatibleRow")]
        public Input<object>? EnableSkipIncompatibleRow { get; set; }

        /// <summary>
        /// Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("enableStaging")]
        public Input<object>? EnableStaging { get; set; }

        [Input("inputs")]
        private InputList<Inputs.DatasetReferenceArgs>? _inputs;

        /// <summary>
        /// List of inputs for the activity.
        /// </summary>
        public InputList<Inputs.DatasetReferenceArgs> Inputs
        {
            get => _inputs ?? (_inputs = new InputList<Inputs.DatasetReferenceArgs>());
            set => _inputs = value;
        }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("outputs")]
        private InputList<Inputs.DatasetReferenceArgs>? _outputs;

        /// <summary>
        /// List of outputs for the activity.
        /// </summary>
        public InputList<Inputs.DatasetReferenceArgs> Outputs
        {
            get => _outputs ?? (_outputs = new InputList<Inputs.DatasetReferenceArgs>());
            set => _outputs = value;
        }

        /// <summary>
        /// Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Input("parallelCopies")]
        public Input<object>? ParallelCopies { get; set; }

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Redirect incompatible row settings when EnableSkipIncompatibleRow is true.
        /// </summary>
        [Input("redirectIncompatibleRowSettings")]
        public Input<Inputs.RedirectIncompatibleRowSettingsArgs>? RedirectIncompatibleRowSettings { get; set; }

        /// <summary>
        /// Copy activity sink.
        /// </summary>
        [Input("sink", required: true)]
        public object Sink { get; set; } = null!;

        /// <summary>
        /// Copy activity source.
        /// </summary>
        [Input("source", required: true)]
        public object Source { get; set; } = null!;

        /// <summary>
        /// Specifies interim staging settings when EnableStaging is true.
        /// </summary>
        [Input("stagingSettings")]
        public Input<Inputs.StagingSettingsArgs>? StagingSettings { get; set; }

        /// <summary>
        /// Copy activity translator. If not specified, tabular translator is used.
        /// </summary>
        [Input("translator")]
        public Input<object>? Translator { get; set; }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Copy'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CopyActivityArgs()
        {
        }
    }
}
