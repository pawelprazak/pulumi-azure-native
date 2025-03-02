// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210301Preview.Inputs
{

    public sealed class InferenceContainerPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The route to check the liveness of the inference server container.
        /// </summary>
        [Input("livenessRoute")]
        public Input<Inputs.RouteArgs>? LivenessRoute { get; set; }

        /// <summary>
        /// The route to check the readiness of the inference server container.
        /// </summary>
        [Input("readinessRoute")]
        public Input<Inputs.RouteArgs>? ReadinessRoute { get; set; }

        /// <summary>
        /// The port to send the scoring requests to, within the inference server container.
        /// </summary>
        [Input("scoringRoute")]
        public Input<Inputs.RouteArgs>? ScoringRoute { get; set; }

        public InferenceContainerPropertiesArgs()
        {
        }
    }
}
