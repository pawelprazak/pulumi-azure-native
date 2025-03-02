// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.Inputs
{

    /// <summary>
    /// Network Profile for the cloud service.
    /// </summary>
    public sealed class CloudServiceNetworkProfileArgs : Pulumi.ResourceArgs
    {
        [Input("loadBalancerConfigurations")]
        private InputList<Inputs.LoadBalancerConfigurationArgs>? _loadBalancerConfigurations;

        /// <summary>
        /// List of Load balancer configurations. Cloud service can have up to two load balancer configurations, corresponding to a Public Load Balancer and an Internal Load Balancer.
        /// </summary>
        public InputList<Inputs.LoadBalancerConfigurationArgs> LoadBalancerConfigurations
        {
            get => _loadBalancerConfigurations ?? (_loadBalancerConfigurations = new InputList<Inputs.LoadBalancerConfigurationArgs>());
            set => _loadBalancerConfigurations = value;
        }

        /// <summary>
        /// The id reference of the cloud service containing the target IP with which the subject cloud service can perform a swap. This property cannot be updated once it is set. The swappable cloud service referred by this id must be present otherwise an error will be thrown.
        /// </summary>
        [Input("swappableCloudService")]
        public Input<Inputs.SubResourceArgs>? SwappableCloudService { get; set; }

        public CloudServiceNetworkProfileArgs()
        {
        }
    }
}
