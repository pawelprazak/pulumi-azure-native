// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Search.V20191001Preview.Outputs
{

    /// <summary>
    /// Describes an existing Private Endpoint connection to the Azure Cognitive Search service.
    /// </summary>
    [OutputType]
    public sealed class PrivateEndpointConnectionResponse
    {
        /// <summary>
        /// The ID of the private endpoint connection. This can be used with the Azure Resource Manager to link resources together.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the private endpoint connection.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Describes the properties of an existing Private Endpoint connection to the Azure Cognitive Search service.
        /// </summary>
        public readonly Outputs.PrivateEndpointConnectionPropertiesResponse? Properties;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrivateEndpointConnectionResponse(
            string? id,

            string name,

            Outputs.PrivateEndpointConnectionPropertiesResponse? properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
