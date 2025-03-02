// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Outputs
{

    /// <summary>
    /// Defines the network configuration for SAP infrastructure
    /// </summary>
    [OutputType]
    public sealed class NetworkConfigurationResponse
    {
        /// <summary>
        /// Specifies whether a secondary IP address should be added to the network interface on all VMs
        /// </summary>
        public readonly bool? IsSecondaryIpEnabled;

        [OutputConstructor]
        private NetworkConfigurationResponse(bool? isSecondaryIpEnabled)
        {
            IsSecondaryIpEnabled = isSecondaryIpEnabled;
        }
    }
}
