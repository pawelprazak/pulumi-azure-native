// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Devices.V20210701.Inputs
{

    /// <summary>
    /// The private endpoint connection of an IotHub
    /// </summary>
    public sealed class PrivateEndpointConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The properties of a private endpoint connection
        /// </summary>
        [Input("properties", required: true)]
        public Input<Inputs.PrivateEndpointConnectionPropertiesArgs> Properties { get; set; } = null!;

        public PrivateEndpointConnectionArgs()
        {
        }
    }
}
