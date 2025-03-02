// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.App.V20220101Preview
{
    public static class ListContainerAppSecrets
    {
        /// <summary>
        /// Container App Secrets Collection ARM resource.
        /// </summary>
        public static Task<ListContainerAppSecretsResult> InvokeAsync(ListContainerAppSecretsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListContainerAppSecretsResult>("azure-native:app/v20220101preview:listContainerAppSecrets", args ?? new ListContainerAppSecretsArgs(), options.WithDefaults());

        /// <summary>
        /// Container App Secrets Collection ARM resource.
        /// </summary>
        public static Output<ListContainerAppSecretsResult> Invoke(ListContainerAppSecretsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListContainerAppSecretsResult>("azure-native:app/v20220101preview:listContainerAppSecrets", args ?? new ListContainerAppSecretsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListContainerAppSecretsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Container App.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListContainerAppSecretsArgs()
        {
        }
    }

    public sealed class ListContainerAppSecretsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Container App.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListContainerAppSecretsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListContainerAppSecretsResult
    {
        /// <summary>
        /// Collection of resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.ContainerAppSecretResponse> Value;

        [OutputConstructor]
        private ListContainerAppSecretsResult(ImmutableArray<Outputs.ContainerAppSecretResponse> value)
        {
            Value = value;
        }
    }
}
