// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Web
{
    public static class ListWorkflowTriggerCallbackUrl
    {
        /// <summary>
        /// The workflow trigger callback URL.
        /// API Version: 2022-03-01.
        /// </summary>
        public static Task<ListWorkflowTriggerCallbackUrlResult> InvokeAsync(ListWorkflowTriggerCallbackUrlArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWorkflowTriggerCallbackUrlResult>("azure-native:web:listWorkflowTriggerCallbackUrl", args ?? new ListWorkflowTriggerCallbackUrlArgs(), options.WithDefaults());

        /// <summary>
        /// The workflow trigger callback URL.
        /// API Version: 2022-03-01.
        /// </summary>
        public static Output<ListWorkflowTriggerCallbackUrlResult> Invoke(ListWorkflowTriggerCallbackUrlInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWorkflowTriggerCallbackUrlResult>("azure-native:web:listWorkflowTriggerCallbackUrl", args ?? new ListWorkflowTriggerCallbackUrlInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWorkflowTriggerCallbackUrlArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The workflow trigger name.
        /// </summary>
        [Input("triggerName", required: true)]
        public string TriggerName { get; set; } = null!;

        /// <summary>
        /// The workflow name.
        /// </summary>
        [Input("workflowName", required: true)]
        public string WorkflowName { get; set; } = null!;

        public ListWorkflowTriggerCallbackUrlArgs()
        {
        }
    }

    public sealed class ListWorkflowTriggerCallbackUrlInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The workflow trigger name.
        /// </summary>
        [Input("triggerName", required: true)]
        public Input<string> TriggerName { get; set; } = null!;

        /// <summary>
        /// The workflow name.
        /// </summary>
        [Input("workflowName", required: true)]
        public Input<string> WorkflowName { get; set; } = null!;

        public ListWorkflowTriggerCallbackUrlInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWorkflowTriggerCallbackUrlResult
    {
        /// <summary>
        /// Gets the workflow trigger callback URL base path.
        /// </summary>
        public readonly string BasePath;
        /// <summary>
        /// Gets the workflow trigger callback URL HTTP method.
        /// </summary>
        public readonly string Method;
        /// <summary>
        /// Gets the workflow trigger callback URL query parameters.
        /// </summary>
        public readonly Outputs.WorkflowTriggerListCallbackUrlQueriesResponse? Queries;
        /// <summary>
        /// Gets the workflow trigger callback URL relative path.
        /// </summary>
        public readonly string RelativePath;
        /// <summary>
        /// Gets the workflow trigger callback URL relative path parameters.
        /// </summary>
        public readonly ImmutableArray<string> RelativePathParameters;
        /// <summary>
        /// Gets the workflow trigger callback URL.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ListWorkflowTriggerCallbackUrlResult(
            string basePath,

            string method,

            Outputs.WorkflowTriggerListCallbackUrlQueriesResponse? queries,

            string relativePath,

            ImmutableArray<string> relativePathParameters,

            string value)
        {
            BasePath = basePath;
            Method = method;
            Queries = queries;
            RelativePath = relativePath;
            RelativePathParameters = relativePathParameters;
            Value = value;
        }
    }
}
