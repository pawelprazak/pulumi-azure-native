// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20210601Preview.Inputs
{

    /// <summary>
    /// Initial workspace AAD admin properties for a CSP subscription
    /// </summary>
    public sealed class CspWorkspaceAdminPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AAD object ID of initial workspace admin
        /// </summary>
        [Input("initialWorkspaceAdminObjectId")]
        public Input<string>? InitialWorkspaceAdminObjectId { get; set; }

        public CspWorkspaceAdminPropertiesArgs()
        {
        }
    }
}
