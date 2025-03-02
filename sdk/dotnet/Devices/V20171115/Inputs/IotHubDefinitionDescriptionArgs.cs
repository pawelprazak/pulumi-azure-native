// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Devices.V20171115.Inputs
{

    /// <summary>
    /// Description of the IoT hub.
    /// </summary>
    public sealed class IotHubDefinitionDescriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Weight to apply for a given IoT hub.
        /// </summary>
        [Input("allocationWeight")]
        public Input<int>? AllocationWeight { get; set; }

        /// <summary>
        /// Flag for applying allocationPolicy or not for a given IoT hub.
        /// </summary>
        [Input("applyAllocationPolicy")]
        public Input<bool>? ApplyAllocationPolicy { get; set; }

        /// <summary>
        /// Connection string of the IoT hub.
        /// </summary>
        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        /// <summary>
        /// ARM region of the IoT hub.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        public IotHubDefinitionDescriptionArgs()
        {
        }
    }
}
