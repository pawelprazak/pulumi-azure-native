// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Solutions.V20160901Preview.Inputs
{

    /// <summary>
    /// Appliance artifact.
    /// </summary>
    public sealed class ApplianceArtifactArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The appliance artifact name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The appliance artifact type.
        /// </summary>
        [Input("type")]
        public Input<Pulumi.AzureNative.Solutions.V20160901Preview.ApplianceArtifactType>? Type { get; set; }

        /// <summary>
        /// The appliance artifact blob uri.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public ApplianceArtifactArgs()
        {
        }
    }
}
