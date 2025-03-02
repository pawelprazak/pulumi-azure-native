// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.RecoveryServices.V20220201.Inputs
{

    /// <summary>
    /// InMageRcm fabric provider specific settings.
    /// </summary>
    public sealed class InMageRcmFabricCreationInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets the class type.
        /// Expected value is 'InMageRcm'.
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        /// <summary>
        /// The ARM Id of the physical site.
        /// </summary>
        [Input("physicalSiteId", required: true)]
        public Input<string> PhysicalSiteId { get; set; } = null!;

        /// <summary>
        /// The identity provider input for source agent authentication.
        /// </summary>
        [Input("sourceAgentIdentity", required: true)]
        public Input<Inputs.IdentityProviderInputArgs> SourceAgentIdentity { get; set; } = null!;

        /// <summary>
        /// The ARM Id of the VMware site.
        /// </summary>
        [Input("vmwareSiteId", required: true)]
        public Input<string> VmwareSiteId { get; set; } = null!;

        public InMageRcmFabricCreationInputArgs()
        {
        }
    }
}
