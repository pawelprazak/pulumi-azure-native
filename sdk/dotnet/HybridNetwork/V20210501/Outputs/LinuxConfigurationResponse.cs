// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridNetwork.V20210501.Outputs
{

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine.
    /// </summary>
    [OutputType]
    public sealed class LinuxConfigurationResponse
    {
        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS.
        /// </summary>
        public readonly Outputs.SshConfigurationResponse? Ssh;

        [OutputConstructor]
        private LinuxConfigurationResponse(Outputs.SshConfigurationResponse? ssh)
        {
            Ssh = ssh;
        }
    }
}
