// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210101
{
    public static class ListStorageAccountKeys
    {
        public static Task<ListStorageAccountKeysResult> InvokeAsync(ListStorageAccountKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListStorageAccountKeysResult>("azure-native:machinelearningservices/v20210101:listStorageAccountKeys", args ?? new ListStorageAccountKeysArgs(), options.WithDefaults());

        public static Output<ListStorageAccountKeysResult> Invoke(ListStorageAccountKeysInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListStorageAccountKeysResult>("azure-native:machinelearningservices/v20210101:listStorageAccountKeys", args ?? new ListStorageAccountKeysInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListStorageAccountKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public ListStorageAccountKeysArgs()
        {
        }
    }

    public sealed class ListStorageAccountKeysInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public ListStorageAccountKeysInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListStorageAccountKeysResult
    {
        public readonly string UserStorageKey;

        [OutputConstructor]
        private ListStorageAccountKeysResult(string userStorageKey)
        {
            UserStorageKey = userStorageKey;
        }
    }
}
