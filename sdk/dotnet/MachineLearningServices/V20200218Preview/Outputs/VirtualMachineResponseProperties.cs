// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20200218Preview.Outputs
{

    [OutputType]
    public sealed class VirtualMachineResponseProperties
    {
        /// <summary>
        /// Public IP address of the virtual machine.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// Admin credentials for virtual machine
        /// </summary>
        public readonly Outputs.VirtualMachineSshCredentialsResponse? AdministratorAccount;
        /// <summary>
        /// Port open for ssh connections.
        /// </summary>
        public readonly int? SshPort;
        /// <summary>
        /// Virtual Machine size
        /// </summary>
        public readonly string? VirtualMachineSize;

        [OutputConstructor]
        private VirtualMachineResponseProperties(
            string? address,

            Outputs.VirtualMachineSshCredentialsResponse? administratorAccount,

            int? sshPort,

            string? virtualMachineSize)
        {
            Address = address;
            AdministratorAccount = administratorAccount;
            SshPort = sshPort;
            VirtualMachineSize = virtualMachineSize;
        }
    }
}
