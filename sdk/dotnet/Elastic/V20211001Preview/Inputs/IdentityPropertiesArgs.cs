// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Elastic.V20211001Preview.Inputs
{

    /// <summary>
    /// Identity properties.
    /// </summary>
    public sealed class IdentityPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Managed identity type.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNative.Elastic.V20211001Preview.ManagedIdentityTypes>? Type { get; set; }

        public IdentityPropertiesArgs()
        {
        }
    }
}
