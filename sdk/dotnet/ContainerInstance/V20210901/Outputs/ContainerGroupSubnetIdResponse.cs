// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerInstance.V20210901.Outputs
{

    /// <summary>
    /// Container group subnet information.
    /// </summary>
    [OutputType]
    public sealed class ContainerGroupSubnetIdResponse
    {
        /// <summary>
        /// Resource ID of virtual network and subnet.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Friendly name for the subnet.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private ContainerGroupSubnetIdResponse(
            string id,

            string? name)
        {
            Id = id;
            Name = name;
        }
    }
}
