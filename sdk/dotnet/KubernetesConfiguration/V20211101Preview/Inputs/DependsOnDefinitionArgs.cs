// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.KubernetesConfiguration.V20211101Preview.Inputs
{

    /// <summary>
    /// Specify which kustomizations must succeed reconciliation on the cluster prior to reconciling this kustomization
    /// </summary>
    public sealed class DependsOnDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the kustomization to claim dependency on
        /// </summary>
        [Input("kustomizationName")]
        public Input<string>? KustomizationName { get; set; }

        public DependsOnDefinitionArgs()
        {
        }
    }
}
