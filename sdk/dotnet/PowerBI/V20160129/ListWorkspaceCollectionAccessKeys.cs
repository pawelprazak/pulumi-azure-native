// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.PowerBI.V20160129
{
    public static class ListWorkspaceCollectionAccessKeys
    {
        public static Task<ListWorkspaceCollectionAccessKeysResult> InvokeAsync(ListWorkspaceCollectionAccessKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWorkspaceCollectionAccessKeysResult>("azure-native:powerbi/v20160129:listWorkspaceCollectionAccessKeys", args ?? new ListWorkspaceCollectionAccessKeysArgs(), options.WithDefaults());

        public static Output<ListWorkspaceCollectionAccessKeysResult> Invoke(ListWorkspaceCollectionAccessKeysInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWorkspaceCollectionAccessKeysResult>("azure-native:powerbi/v20160129:listWorkspaceCollectionAccessKeys", args ?? new ListWorkspaceCollectionAccessKeysInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWorkspaceCollectionAccessKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Azure resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Power BI Embedded Workspace Collection name
        /// </summary>
        [Input("workspaceCollectionName", required: true)]
        public string WorkspaceCollectionName { get; set; } = null!;

        public ListWorkspaceCollectionAccessKeysArgs()
        {
        }
    }

    public sealed class ListWorkspaceCollectionAccessKeysInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Azure resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Power BI Embedded Workspace Collection name
        /// </summary>
        [Input("workspaceCollectionName", required: true)]
        public Input<string> WorkspaceCollectionName { get; set; } = null!;

        public ListWorkspaceCollectionAccessKeysInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWorkspaceCollectionAccessKeysResult
    {
        /// <summary>
        /// Access key 1
        /// </summary>
        public readonly string? Key1;
        /// <summary>
        /// Access key 2
        /// </summary>
        public readonly string? Key2;

        [OutputConstructor]
        private ListWorkspaceCollectionAccessKeysResult(
            string? key1,

            string? key2)
        {
            Key1 = key1;
            Key2 = key2;
        }
    }
}
