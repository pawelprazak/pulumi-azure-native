// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20210501.Inputs
{

    /// <summary>
    /// The role based access control (RBAC) authorization type integration runtime.
    /// </summary>
    public sealed class LinkedIntegrationRuntimeRbacAuthorizationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The authorization type for integration runtime sharing.
        /// Expected value is 'RBAC'.
        /// </summary>
        [Input("authorizationType", required: true)]
        public Input<string> AuthorizationType { get; set; } = null!;

        /// <summary>
        /// The resource identifier of the integration runtime to be shared.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        public LinkedIntegrationRuntimeRbacAuthorizationArgs()
        {
        }
    }
}
