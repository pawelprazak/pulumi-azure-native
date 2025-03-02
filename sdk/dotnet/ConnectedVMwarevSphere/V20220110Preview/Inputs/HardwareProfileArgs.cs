// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ConnectedVMwarevSphere.V20220110Preview.Inputs
{

    /// <summary>
    /// Defines the resource properties.
    /// </summary>
    public sealed class HardwareProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets memory size in MBs for the vm.
        /// </summary>
        [Input("memorySizeMB")]
        public Input<int>? MemorySizeMB { get; set; }

        /// <summary>
        /// Gets or sets the number of vCPUs for the vm.
        /// </summary>
        [Input("numCPUs")]
        public Input<int>? NumCPUs { get; set; }

        /// <summary>
        /// Gets or sets the number of cores per socket for the vm. Defaults to 1 if unspecified.
        /// </summary>
        [Input("numCoresPerSocket")]
        public Input<int>? NumCoresPerSocket { get; set; }

        public HardwareProfileArgs()
        {
        }
    }
}
