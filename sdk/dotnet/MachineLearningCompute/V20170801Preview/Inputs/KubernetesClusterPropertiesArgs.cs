// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningCompute.V20170801Preview.Inputs
{

    /// <summary>
    /// Kubernetes cluster specific properties
    /// </summary>
    public sealed class KubernetesClusterPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Azure Service Principal used by Kubernetes
        /// </summary>
        [Input("servicePrincipal")]
        public Input<Inputs.ServicePrincipalPropertiesArgs>? ServicePrincipal { get; set; }

        public KubernetesClusterPropertiesArgs()
        {
        }
    }
}
