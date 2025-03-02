// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Authorization.V20160401
{
    [Obsolete(@"Version 2016-04-01 will be removed in v2 of the provider.")]
    public static class GetPolicyDefinition
    {
        /// <summary>
        /// The policy definition.
        /// </summary>
        public static Task<GetPolicyDefinitionResult> InvokeAsync(GetPolicyDefinitionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicyDefinitionResult>("azure-native:authorization/v20160401:getPolicyDefinition", args ?? new GetPolicyDefinitionArgs(), options.WithDefaults());

        /// <summary>
        /// The policy definition.
        /// </summary>
        public static Output<GetPolicyDefinitionResult> Invoke(GetPolicyDefinitionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPolicyDefinitionResult>("azure-native:authorization/v20160401:getPolicyDefinition", args ?? new GetPolicyDefinitionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPolicyDefinitionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the policy definition to get.
        /// </summary>
        [Input("policyDefinitionName", required: true)]
        public string PolicyDefinitionName { get; set; } = null!;

        public GetPolicyDefinitionArgs()
        {
        }
    }

    public sealed class GetPolicyDefinitionInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the policy definition to get.
        /// </summary>
        [Input("policyDefinitionName", required: true)]
        public Input<string> PolicyDefinitionName { get; set; } = null!;

        public GetPolicyDefinitionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicyDefinitionResult
    {
        /// <summary>
        /// The policy definition description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The display name of the policy definition.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The ID of the policy definition.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The policy rule.
        /// </summary>
        public readonly object? PolicyRule;
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        public readonly string? PolicyType;

        [OutputConstructor]
        private GetPolicyDefinitionResult(
            string? description,

            string? displayName,

            string id,

            string? name,

            object? policyRule,

            string? policyType)
        {
            Description = description;
            DisplayName = displayName;
            Id = id;
            Name = name;
            PolicyRule = policyRule;
            PolicyType = policyType;
        }
    }
}
