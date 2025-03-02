// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Inputs
{

    /// <summary>
    /// Gets or sets the HA software configuration.
    /// </summary>
    public sealed class HighAvailabilitySoftwareConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The fencing client id.
        /// </summary>
        [Input("fencingClientId", required: true)]
        public Input<string> FencingClientId { get; set; } = null!;

        /// <summary>
        /// The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs.
        /// </summary>
        [Input("fencingClientPassword", required: true)]
        public Input<string> FencingClientPassword { get; set; } = null!;

        public HighAvailabilitySoftwareConfigurationArgs()
        {
        }
    }
}
