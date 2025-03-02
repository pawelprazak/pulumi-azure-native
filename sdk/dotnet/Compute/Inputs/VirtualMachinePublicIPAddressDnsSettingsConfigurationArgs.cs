// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.Inputs
{

    /// <summary>
    /// Describes a virtual machines network configuration's DNS settings.
    /// </summary>
    public sealed class VirtualMachinePublicIPAddressDnsSettingsConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the domain name label and vm network profile unique ID.
        /// </summary>
        [Input("domainNameLabel", required: true)]
        public Input<string> DomainNameLabel { get; set; } = null!;

        public VirtualMachinePublicIPAddressDnsSettingsConfigurationArgs()
        {
        }
    }
}
