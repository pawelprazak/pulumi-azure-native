// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20201201.Inputs
{

    /// <summary>
    /// Managed integration runtime, including managed elastic and managed dedicated integration runtimes.
    /// </summary>
    public sealed class ManagedIntegrationRuntimeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The compute resource for managed integration runtime.
        /// </summary>
        [Input("computeProperties")]
        public Input<Inputs.IntegrationRuntimeComputePropertiesArgs>? ComputeProperties { get; set; }

        /// <summary>
        /// Integration runtime description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// SSIS properties for managed integration runtime.
        /// </summary>
        [Input("ssisProperties")]
        public Input<Inputs.IntegrationRuntimeSsisPropertiesArgs>? SsisProperties { get; set; }

        /// <summary>
        /// The type of integration runtime.
        /// Expected value is 'Managed'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ManagedIntegrationRuntimeArgs()
        {
        }
    }
}
