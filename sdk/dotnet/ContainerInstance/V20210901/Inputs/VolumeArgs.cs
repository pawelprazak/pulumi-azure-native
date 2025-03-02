// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerInstance.V20210901.Inputs
{

    /// <summary>
    /// The properties of the volume.
    /// </summary>
    public sealed class VolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Azure File volume.
        /// </summary>
        [Input("azureFile")]
        public Input<Inputs.AzureFileVolumeArgs>? AzureFile { get; set; }

        /// <summary>
        /// The empty directory volume.
        /// </summary>
        [Input("emptyDir")]
        public Input<object>? EmptyDir { get; set; }

        /// <summary>
        /// The git repo volume.
        /// </summary>
        [Input("gitRepo")]
        public Input<Inputs.GitRepoVolumeArgs>? GitRepo { get; set; }

        /// <summary>
        /// The name of the volume.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("secret")]
        private InputMap<string>? _secret;

        /// <summary>
        /// The secret volume.
        /// </summary>
        public InputMap<string> Secret
        {
            get => _secret ?? (_secret = new InputMap<string>());
            set => _secret = value;
        }

        public VolumeArgs()
        {
        }
    }
}
