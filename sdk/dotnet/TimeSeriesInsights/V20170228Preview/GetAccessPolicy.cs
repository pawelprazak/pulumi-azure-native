// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.TimeSeriesInsights.V20170228Preview
{
    [Obsolete(@"Version 2017-02-28-preview will be removed in v2 of the provider.")]
    public static class GetAccessPolicy
    {
        /// <summary>
        /// An access policy is used to grant users and applications access to the environment. Roles are assigned to service principals in Azure Active Directory. These roles define the actions the principal can perform through the Time Series Insights data plane APIs.
        /// </summary>
        public static Task<GetAccessPolicyResult> InvokeAsync(GetAccessPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAccessPolicyResult>("azure-native:timeseriesinsights/v20170228preview:getAccessPolicy", args ?? new GetAccessPolicyArgs(), options.WithDefaults());

        /// <summary>
        /// An access policy is used to grant users and applications access to the environment. Roles are assigned to service principals in Azure Active Directory. These roles define the actions the principal can perform through the Time Series Insights data plane APIs.
        /// </summary>
        public static Output<GetAccessPolicyResult> Invoke(GetAccessPolicyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAccessPolicyResult>("azure-native:timeseriesinsights/v20170228preview:getAccessPolicy", args ?? new GetAccessPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccessPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Time Series Insights access policy associated with the specified environment.
        /// </summary>
        [Input("accessPolicyName", required: true)]
        public string AccessPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the Time Series Insights environment associated with the specified resource group.
        /// </summary>
        [Input("environmentName", required: true)]
        public string EnvironmentName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAccessPolicyArgs()
        {
        }
    }

    public sealed class GetAccessPolicyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Time Series Insights access policy associated with the specified environment.
        /// </summary>
        [Input("accessPolicyName", required: true)]
        public Input<string> AccessPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the Time Series Insights environment associated with the specified resource group.
        /// </summary>
        [Input("environmentName", required: true)]
        public Input<string> EnvironmentName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetAccessPolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAccessPolicyResult
    {
        /// <summary>
        /// An description of the access policy.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The objectId of the principal in Azure Active Directory.
        /// </summary>
        public readonly string? PrincipalObjectId;
        /// <summary>
        /// The list of roles the principal is assigned on the environment.
        /// </summary>
        public readonly ImmutableArray<string> Roles;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAccessPolicyResult(
            string? description,

            string id,

            string name,

            string? principalObjectId,

            ImmutableArray<string> roles,

            string type)
        {
            Description = description;
            Id = id;
            Name = name;
            PrincipalObjectId = principalObjectId;
            Roles = roles;
            Type = type;
        }
    }
}
