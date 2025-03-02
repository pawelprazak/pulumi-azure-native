// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20181001.Inputs
{

    /// <summary>
    /// Identifies the service being brought into the virtual network.
    /// </summary>
    public sealed class EndpointServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique identifier of the service being referenced by the interface endpoint.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        public EndpointServiceArgs()
        {
        }
    }
}
