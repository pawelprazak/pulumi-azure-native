// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20220201Preview.Inputs
{

    /// <summary>
    /// Classification task in AutoML Table vertical.
    /// </summary>
    public sealed class ClassificationArgs : Pulumi.ResourceArgs
    {
        [Input("allowedModels")]
        private InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>>? _allowedModels;

        /// <summary>
        /// Allowed models for classification task.
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>> AllowedModels
        {
            get => _allowedModels ?? (_allowedModels = new InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>>());
            set => _allowedModels = value;
        }

        [Input("blockedModels")]
        private InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>>? _blockedModels;

        /// <summary>
        /// Blocked models for classification task.
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>> BlockedModels
        {
            get => _blockedModels ?? (_blockedModels = new InputList<Union<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationModels>>());
            set => _blockedModels = value;
        }

        /// <summary>
        /// Data inputs for AutoMLJob.
        /// </summary>
        [Input("dataSettings")]
        public Input<Inputs.TableVerticalDataSettingsArgs>? DataSettings { get; set; }

        /// <summary>
        /// Featurization inputs needed for AutoML job.
        /// </summary>
        [Input("featurizationSettings")]
        public Input<Inputs.TableVerticalFeaturizationSettingsArgs>? FeaturizationSettings { get; set; }

        /// <summary>
        /// Execution constraints for AutoMLJob.
        /// </summary>
        [Input("limitSettings")]
        public Input<Inputs.TableVerticalLimitSettingsArgs>? LimitSettings { get; set; }

        /// <summary>
        /// Log verbosity for the job.
        /// </summary>
        [Input("logVerbosity")]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.LogVerbosity>? LogVerbosity { get; set; }

        /// <summary>
        /// Primary metric for the task.
        /// </summary>
        [Input("primaryMetric")]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.V20220201Preview.ClassificationPrimaryMetrics>? PrimaryMetric { get; set; }

        /// <summary>
        /// AutoMLJob Task type.
        /// Expected value is 'Classification'.
        /// </summary>
        [Input("taskType", required: true)]
        public Input<string> TaskType { get; set; } = null!;

        /// <summary>
        /// Inputs for training phase for an AutoML Job.
        /// </summary>
        [Input("trainingSettings")]
        public Input<Inputs.TrainingSettingsArgs>? TrainingSettings { get; set; }

        public ClassificationArgs()
        {
            LogVerbosity = "Info";
            PrimaryMetric = "AUCWeighted";
        }
    }
}
