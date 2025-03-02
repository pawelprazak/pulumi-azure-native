// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.NetworkFunction.Inputs
{

    /// <summary>
    /// Collector policy resource.
    /// </summary>
    public sealed class CollectorPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("emissionPolicies")]
        private InputList<Inputs.EmissionPoliciesPropertiesFormatArgs>? _emissionPolicies;

        /// <summary>
        /// Emission policies.
        /// </summary>
        public InputList<Inputs.EmissionPoliciesPropertiesFormatArgs> EmissionPolicies
        {
            get => _emissionPolicies ?? (_emissionPolicies = new InputList<Inputs.EmissionPoliciesPropertiesFormatArgs>());
            set => _emissionPolicies = value;
        }

        /// <summary>
        /// Ingestion policies.
        /// </summary>
        [Input("ingestionPolicy")]
        public Input<Inputs.IngestionPolicyPropertiesFormatArgs>? IngestionPolicy { get; set; }

        public CollectorPolicyArgs()
        {
        }
    }
}
