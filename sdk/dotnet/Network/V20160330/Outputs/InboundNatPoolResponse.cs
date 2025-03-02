// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20160330.Outputs
{

    /// <summary>
    /// Inbound NAT pool of the loadbalancer
    /// </summary>
    [OutputType]
    public sealed class InboundNatPoolResponse
    {
        /// <summary>
        /// Gets or sets a port used for internal connections on the endpoint. The localPort attribute maps the eternal port of the endpoint to an internal port on a role. This is useful in scenarios where a role must communicate to an internal component on a port that is different from the one that is exposed externally. If not specified, the value of localPort is the same as the port attribute. Set the value of localPort to '*' to automatically assign an unallocated port that is discoverable using the runtime API
        /// </summary>
        public readonly int BackendPort;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Gets or sets a reference to frontend IP Addresses
        /// </summary>
        public readonly Outputs.SubResourceResponse? FrontendIPConfiguration;
        /// <summary>
        /// Gets or sets the ending port range for the NAT pool. You can specify any port number you choose, but the port numbers specified for each role in the service must be unique. Possible values range between 1 and 65535, inclusive
        /// </summary>
        public readonly int FrontendPortRangeEnd;
        /// <summary>
        /// Gets or sets the starting port range for the NAT pool. You can specify any port number you choose, but the port numbers specified for each role in the service must be unique. Possible values range between 1 and 65535, inclusive
        /// </summary>
        public readonly int FrontendPortRangeStart;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Gets or sets the transport protocol for the external endpoint. Possible values are Udp or Tcp
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private InboundNatPoolResponse(
            int backendPort,

            string? etag,

            Outputs.SubResourceResponse? frontendIPConfiguration,

            int frontendPortRangeEnd,

            int frontendPortRangeStart,

            string? id,

            string? name,

            string protocol,

            string? provisioningState)
        {
            BackendPort = backendPort;
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            FrontendPortRangeStart = frontendPortRangeStart;
            Id = id;
            Name = name;
            Protocol = protocol;
            ProvisioningState = provisioningState;
        }
    }
}
