// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20210301.Inputs
{

    /// <summary>
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    public sealed class SshConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("publicKeys")]
        private InputList<Inputs.SshPublicKeyArgs>? _publicKeys;

        /// <summary>
        /// The list of SSH public keys used to authenticate with linux based VMs.
        /// </summary>
        public InputList<Inputs.SshPublicKeyArgs> PublicKeys
        {
            get => _publicKeys ?? (_publicKeys = new InputList<Inputs.SshPublicKeyArgs>());
            set => _publicKeys = value;
        }

        public SshConfigurationArgs()
        {
        }
    }
}
