// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20200701
{
    public static class GetActiveSessions
    {
        /// <summary>
        /// Response for GetActiveSessions.
        /// </summary>
        public static Task<GetActiveSessionsResult> InvokeAsync(GetActiveSessionsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetActiveSessionsResult>("azure-native:network/v20200701:getActiveSessions", args ?? new GetActiveSessionsArgs(), options.WithDefaults());

        /// <summary>
        /// Response for GetActiveSessions.
        /// </summary>
        public static Output<GetActiveSessionsResult> Invoke(GetActiveSessionsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetActiveSessionsResult>("azure-native:network/v20200701:getActiveSessions", args ?? new GetActiveSessionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetActiveSessionsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bastion Host.
        /// </summary>
        [Input("bastionHostName", required: true)]
        public string BastionHostName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetActiveSessionsArgs()
        {
        }
    }

    public sealed class GetActiveSessionsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bastion Host.
        /// </summary>
        [Input("bastionHostName", required: true)]
        public Input<string> BastionHostName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetActiveSessionsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetActiveSessionsResult
    {
        /// <summary>
        /// The URL to get the next set of results.
        /// </summary>
        public readonly string? NextLink;
        /// <summary>
        /// List of active sessions on the bastion.
        /// </summary>
        public readonly ImmutableArray<Outputs.BastionActiveSessionResponse> Value;

        [OutputConstructor]
        private GetActiveSessionsResult(
            string? nextLink,

            ImmutableArray<Outputs.BastionActiveSessionResponse> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
