// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.PolicyInsights
{
    public static class ListRemediationDeploymentsAtResource
    {
        /// <summary>
        /// List of deployments for a remediation.
        /// API Version: 2019-07-01.
        /// </summary>
        public static Task<ListRemediationDeploymentsAtResourceResult> InvokeAsync(ListRemediationDeploymentsAtResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListRemediationDeploymentsAtResourceResult>("azure-native:policyinsights:listRemediationDeploymentsAtResource", args ?? new ListRemediationDeploymentsAtResourceArgs(), options.WithDefaults());

        /// <summary>
        /// List of deployments for a remediation.
        /// API Version: 2019-07-01.
        /// </summary>
        public static Output<ListRemediationDeploymentsAtResourceResult> Invoke(ListRemediationDeploymentsAtResourceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListRemediationDeploymentsAtResourceResult>("azure-native:policyinsights:listRemediationDeploymentsAtResource", args ?? new ListRemediationDeploymentsAtResourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListRemediationDeploymentsAtResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the remediation.
        /// </summary>
        [Input("remediationName", required: true)]
        public string RemediationName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("resourceId", required: true)]
        public string ResourceId { get; set; } = null!;

        /// <summary>
        /// Maximum number of records to return.
        /// </summary>
        [Input("top")]
        public int? Top { get; set; }

        public ListRemediationDeploymentsAtResourceArgs()
        {
        }
    }

    public sealed class ListRemediationDeploymentsAtResourceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the remediation.
        /// </summary>
        [Input("remediationName", required: true)]
        public Input<string> RemediationName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        /// <summary>
        /// Maximum number of records to return.
        /// </summary>
        [Input("top")]
        public Input<int>? Top { get; set; }

        public ListRemediationDeploymentsAtResourceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListRemediationDeploymentsAtResourceResult
    {
        /// <summary>
        /// The URL to get the next set of results.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// Array of deployments for the remediation.
        /// </summary>
        public readonly ImmutableArray<Outputs.RemediationDeploymentResponse> Value;

        [OutputConstructor]
        private ListRemediationDeploymentsAtResourceResult(
            string nextLink,

            ImmutableArray<Outputs.RemediationDeploymentResponse> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
