// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20160601.Outputs
{

    /// <summary>
    /// IP configuration of application gateway
    /// </summary>
    [OutputType]
    public sealed class ApplicationGatewayIPConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Provisioning state of the application gateway subnet resource Updating/Deleting/Failed
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Reference of the subnet resource. A subnet from where application gateway gets its private address 
        /// </summary>
        public readonly Outputs.SubResourceResponse? Subnet;

        [OutputConstructor]
        private ApplicationGatewayIPConfigurationResponse(
            string? etag,

            string? id,

            string? name,

            string? provisioningState,

            Outputs.SubResourceResponse? subnet)
        {
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            Subnet = subnet;
        }
    }
}
