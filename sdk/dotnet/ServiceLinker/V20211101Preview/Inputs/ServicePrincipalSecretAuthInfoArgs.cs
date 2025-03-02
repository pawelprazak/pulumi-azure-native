// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceLinker.V20211101Preview.Inputs
{

    /// <summary>
    /// The authentication info when authType is servicePrincipal secret
    /// </summary>
    public sealed class ServicePrincipalSecretAuthInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The authentication type.
        /// Expected value is 'servicePrincipalSecret'.
        /// </summary>
        [Input("authType", required: true)]
        public Input<string> AuthType { get; set; } = null!;

        /// <summary>
        /// ServicePrincipal application clientId for servicePrincipal auth.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// Principal Id for servicePrincipal auth.
        /// </summary>
        [Input("principalId", required: true)]
        public Input<string> PrincipalId { get; set; } = null!;

        /// <summary>
        /// Secret for servicePrincipal auth.
        /// </summary>
        [Input("secret", required: true)]
        public Input<string> Secret { get; set; } = null!;

        public ServicePrincipalSecretAuthInfoArgs()
        {
        }
    }
}
