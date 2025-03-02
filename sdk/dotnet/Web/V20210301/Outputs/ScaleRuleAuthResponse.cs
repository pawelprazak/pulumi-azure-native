// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web.V20210301.Outputs
{

    /// <summary>
    /// Auth Secrets for Container App Scale Rule
    /// </summary>
    [OutputType]
    public sealed class ScaleRuleAuthResponse
    {
        /// <summary>
        /// Name of the Container App secret from which to pull the auth params.
        /// </summary>
        public readonly string? SecretRef;
        /// <summary>
        /// Trigger Parameter that uses the secret
        /// </summary>
        public readonly string? TriggerParameter;

        [OutputConstructor]
        private ScaleRuleAuthResponse(
            string? secretRef,

            string? triggerParameter)
        {
            SecretRef = secretRef;
            TriggerParameter = triggerParameter;
        }
    }
}
