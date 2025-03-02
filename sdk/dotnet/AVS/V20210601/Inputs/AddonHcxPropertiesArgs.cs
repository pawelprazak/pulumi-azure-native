// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AVS.V20210601.Inputs
{

    /// <summary>
    /// The properties of an HCX addon
    /// </summary>
    public sealed class AddonHcxPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of private cloud addon
        /// Expected value is 'HCX'.
        /// </summary>
        [Input("addonType", required: true)]
        public Input<string> AddonType { get; set; } = null!;

        /// <summary>
        /// The HCX offer, example VMware MaaS Cloud Provider (Enterprise)
        /// </summary>
        [Input("offer", required: true)]
        public Input<string> Offer { get; set; } = null!;

        public AddonHcxPropertiesArgs()
        {
        }
    }
}
