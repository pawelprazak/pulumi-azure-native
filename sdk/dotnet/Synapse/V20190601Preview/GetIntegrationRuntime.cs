// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20190601Preview
{
    [Obsolete(@"Version 2019-06-01-preview will be removed in v2 of the provider.")]
    public static class GetIntegrationRuntime
    {
        /// <summary>
        /// Integration runtime resource type.
        /// </summary>
        public static Task<GetIntegrationRuntimeResult> InvokeAsync(GetIntegrationRuntimeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIntegrationRuntimeResult>("azure-native:synapse/v20190601preview:getIntegrationRuntime", args ?? new GetIntegrationRuntimeArgs(), options.WithDefaults());

        /// <summary>
        /// Integration runtime resource type.
        /// </summary>
        public static Output<GetIntegrationRuntimeResult> Invoke(GetIntegrationRuntimeInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetIntegrationRuntimeResult>("azure-native:synapse/v20190601preview:getIntegrationRuntime", args ?? new GetIntegrationRuntimeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetIntegrationRuntimeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Integration runtime name
        /// </summary>
        [Input("integrationRuntimeName", required: true)]
        public string IntegrationRuntimeName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetIntegrationRuntimeArgs()
        {
        }
    }

    public sealed class GetIntegrationRuntimeInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Integration runtime name
        /// </summary>
        [Input("integrationRuntimeName", required: true)]
        public Input<string> IntegrationRuntimeName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetIntegrationRuntimeInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIntegrationRuntimeResult
    {
        /// <summary>
        /// Resource Etag.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Integration runtime properties.
        /// </summary>
        public readonly Union<Outputs.ManagedIntegrationRuntimeResponse, Outputs.SelfHostedIntegrationRuntimeResponse> Properties;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetIntegrationRuntimeResult(
            string etag,

            string id,

            string name,

            Union<Outputs.ManagedIntegrationRuntimeResponse, Outputs.SelfHostedIntegrationRuntimeResponse> properties,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
