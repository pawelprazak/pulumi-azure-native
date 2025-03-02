// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20220501
{
    public static class ListWorkspaceNotebookAccessToken
    {
        public static Task<ListWorkspaceNotebookAccessTokenResult> InvokeAsync(ListWorkspaceNotebookAccessTokenArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWorkspaceNotebookAccessTokenResult>("azure-native:machinelearningservices/v20220501:listWorkspaceNotebookAccessToken", args ?? new ListWorkspaceNotebookAccessTokenArgs(), options.WithDefaults());

        public static Output<ListWorkspaceNotebookAccessTokenResult> Invoke(ListWorkspaceNotebookAccessTokenInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListWorkspaceNotebookAccessTokenResult>("azure-native:machinelearningservices/v20220501:listWorkspaceNotebookAccessToken", args ?? new ListWorkspaceNotebookAccessTokenInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListWorkspaceNotebookAccessTokenArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public ListWorkspaceNotebookAccessTokenArgs()
        {
        }
    }

    public sealed class ListWorkspaceNotebookAccessTokenInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public ListWorkspaceNotebookAccessTokenInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWorkspaceNotebookAccessTokenResult
    {
        public readonly string AccessToken;
        public readonly int ExpiresIn;
        public readonly string HostName;
        public readonly string NotebookResourceId;
        public readonly string PublicDns;
        public readonly string RefreshToken;
        public readonly string Scope;
        public readonly string TokenType;

        [OutputConstructor]
        private ListWorkspaceNotebookAccessTokenResult(
            string accessToken,

            int expiresIn,

            string hostName,

            string notebookResourceId,

            string publicDns,

            string refreshToken,

            string scope,

            string tokenType)
        {
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            HostName = hostName;
            NotebookResourceId = notebookResourceId;
            PublicDns = publicDns;
            RefreshToken = refreshToken;
            Scope = scope;
            TokenType = tokenType;
        }
    }
}
