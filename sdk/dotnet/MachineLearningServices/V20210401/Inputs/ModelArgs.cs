// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210401.Inputs
{

    /// <summary>
    /// An Azure Machine Learning Model.
    /// </summary>
    public sealed class ModelArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Model creation time (UTC).
        /// </summary>
        [Input("createdTime")]
        public Input<string>? CreatedTime { get; set; }

        [Input("datasets")]
        private InputList<Inputs.DatasetReferenceArgs>? _datasets;

        /// <summary>
        /// The list of datasets associated with the model.
        /// </summary>
        public InputList<Inputs.DatasetReferenceArgs> Datasets
        {
            get => _datasets ?? (_datasets = new InputList<Inputs.DatasetReferenceArgs>());
            set => _datasets = value;
        }

        [Input("derivedModelIds")]
        private InputList<string>? _derivedModelIds;

        /// <summary>
        /// Models derived from this model
        /// </summary>
        public InputList<string> DerivedModelIds
        {
            get => _derivedModelIds ?? (_derivedModelIds = new InputList<string>());
            set => _derivedModelIds = value;
        }

        /// <summary>
        /// The Model description text.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the experiment where this model was created.
        /// </summary>
        [Input("experimentName")]
        public Input<string>? ExperimentName { get; set; }

        /// <summary>
        /// The Model framework.
        /// </summary>
        [Input("framework")]
        public Input<string>? Framework { get; set; }

        /// <summary>
        /// The Model framework version.
        /// </summary>
        [Input("frameworkVersion")]
        public Input<string>? FrameworkVersion { get; set; }

        /// <summary>
        /// The Model Id.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("kvTags")]
        private InputMap<string>? _kvTags;

        /// <summary>
        /// The Model tag dictionary. Items are mutable.
        /// </summary>
        public InputMap<string> KvTags
        {
            get => _kvTags ?? (_kvTags = new InputMap<string>());
            set => _kvTags = value;
        }

        /// <summary>
        /// The MIME type of Model content. For more details about MIME type, please open https://www.iana.org/assignments/media-types/media-types.xhtml
        /// </summary>
        [Input("mimeType", required: true)]
        public Input<string> MimeType { get; set; } = null!;

        /// <summary>
        /// The Model last modified time (UTC).
        /// </summary>
        [Input("modifiedTime")]
        public Input<string>? ModifiedTime { get; set; }

        /// <summary>
        /// The Model name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Parent Model Id.
        /// </summary>
        [Input("parentModelId")]
        public Input<string>? ParentModelId { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// The Model property dictionary. Properties are immutable.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// Resource requirements for the model
        /// </summary>
        [Input("resourceRequirements")]
        public Input<Inputs.ContainerResourceRequirementsArgs>? ResourceRequirements { get; set; }

        /// <summary>
        /// The RunId that created this model.
        /// </summary>
        [Input("runId")]
        public Input<string>? RunId { get; set; }

        /// <summary>
        /// Sample Input Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}
        /// </summary>
        [Input("sampleInputData")]
        public Input<string>? SampleInputData { get; set; }

        /// <summary>
        /// Sample Output Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}
        /// </summary>
        [Input("sampleOutputData")]
        public Input<string>? SampleOutputData { get; set; }

        /// <summary>
        /// Indicates whether we need to unpack the Model during docker Image creation.
        /// </summary>
        [Input("unpack")]
        public Input<bool>? Unpack { get; set; }

        /// <summary>
        /// The URL of the Model. Usually a SAS URL.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        /// <summary>
        /// The Model version assigned by Model Management Service.
        /// </summary>
        [Input("version")]
        public Input<double>? Version { get; set; }

        public ModelArgs()
        {
        }
    }
}
