// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20210201.Inputs
{

    /// <summary>
    /// Describes the connection monitor endpoint scope item.
    /// </summary>
    public sealed class ConnectionMonitorEndpointScopeItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The address of the endpoint item. Supported types are IPv4/IPv6 subnet mask or IPv4/IPv6 IP address.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        public ConnectionMonitorEndpointScopeItemArgs()
        {
        }
    }
}
