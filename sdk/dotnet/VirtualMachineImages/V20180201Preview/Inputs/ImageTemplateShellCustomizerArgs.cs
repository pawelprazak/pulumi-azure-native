// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VirtualMachineImages.V20180201Preview.Inputs
{

    /// <summary>
    /// Runs a shell script during the customization phase
    /// </summary>
    public sealed class ImageTemplateShellCustomizerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Friendly Name to provide context on what this customization step does
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        /// </summary>
        [Input("script")]
        public Input<string>? Script { get; set; }

        /// <summary>
        /// The type of customization tool you want to use on the Image. For example, "shell" can be shellCustomizer
        /// Expected value is 'shell'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ImageTemplateShellCustomizerArgs()
        {
        }
    }
}
