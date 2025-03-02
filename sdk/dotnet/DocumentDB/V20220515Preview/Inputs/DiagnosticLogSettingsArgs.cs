// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20220515Preview.Inputs
{

    /// <summary>
    /// Indicates what diagnostic log settings are to be enabled.
    /// </summary>
    public sealed class DiagnosticLogSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describe the level of detail with which queries are to be logged.
        /// </summary>
        [Input("enableFullTextQuery")]
        public Input<Pulumi.AzureNative.DocumentDB.V20220515Preview.EnableFullTextQuery>? EnableFullTextQuery { get; set; }

        public DiagnosticLogSettingsArgs()
        {
        }
    }
}
