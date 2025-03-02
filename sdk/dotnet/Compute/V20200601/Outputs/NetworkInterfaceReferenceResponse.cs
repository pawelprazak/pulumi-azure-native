// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20200601.Outputs
{

    /// <summary>
    /// Describes a network interface reference.
    /// </summary>
    [OutputType]
    public sealed class NetworkInterfaceReferenceResponse
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// </summary>
        public readonly bool? Primary;

        [OutputConstructor]
        private NetworkInterfaceReferenceResponse(
            string? id,

            bool? primary)
        {
            Id = id;
            Primary = primary;
        }
    }
}
