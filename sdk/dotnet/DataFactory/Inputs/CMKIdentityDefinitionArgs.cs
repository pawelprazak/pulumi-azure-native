// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.Inputs
{

    /// <summary>
    /// Managed Identity used for CMK.
    /// </summary>
    public sealed class CMKIdentityDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource id of the user assigned identity to authenticate to customer's key vault.
        /// </summary>
        [Input("userAssignedIdentity")]
        public Input<string>? UserAssignedIdentity { get; set; }

        public CMKIdentityDefinitionArgs()
        {
        }
    }
}
