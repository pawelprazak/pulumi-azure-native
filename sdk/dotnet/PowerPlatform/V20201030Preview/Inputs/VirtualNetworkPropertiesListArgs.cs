// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.PowerPlatform.V20201030Preview.Inputs
{

    /// <summary>
    /// A list of private link resources
    /// </summary>
    public sealed class VirtualNetworkPropertiesListArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Next page link if any.
        /// </summary>
        [Input("nextLink")]
        public Input<string>? NextLink { get; set; }

        [Input("value")]
        private InputList<Inputs.VirtualNetworkPropertiesArgs>? _value;

        /// <summary>
        /// Array of virtual networks.
        /// </summary>
        public InputList<Inputs.VirtualNetworkPropertiesArgs> Value
        {
            get => _value ?? (_value = new InputList<Inputs.VirtualNetworkPropertiesArgs>());
            set => _value = value;
        }

        public VirtualNetworkPropertiesListArgs()
        {
        }
    }
}
