// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ServiceFabricMesh
{
    public static class ListSecretValue
    {
        /// <summary>
        /// This type represents the unencrypted value of the secret.
        /// API Version: 2018-09-01-preview.
        /// </summary>
        public static Task<ListSecretValueResult> InvokeAsync(ListSecretValueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListSecretValueResult>("azure-native:servicefabricmesh:listSecretValue", args ?? new ListSecretValueArgs(), options.WithDefaults());

        /// <summary>
        /// This type represents the unencrypted value of the secret.
        /// API Version: 2018-09-01-preview.
        /// </summary>
        public static Output<ListSecretValueResult> Invoke(ListSecretValueInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListSecretValueResult>("azure-native:servicefabricmesh:listSecretValue", args ?? new ListSecretValueInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListSecretValueArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Azure resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the secret resource.
        /// </summary>
        [Input("secretResourceName", required: true)]
        public string SecretResourceName { get; set; } = null!;

        /// <summary>
        /// The name of the secret resource value which is typically the version identifier for the value.
        /// </summary>
        [Input("secretValueResourceName", required: true)]
        public string SecretValueResourceName { get; set; } = null!;

        public ListSecretValueArgs()
        {
        }
    }

    public sealed class ListSecretValueInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Azure resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the secret resource.
        /// </summary>
        [Input("secretResourceName", required: true)]
        public Input<string> SecretResourceName { get; set; } = null!;

        /// <summary>
        /// The name of the secret resource value which is typically the version identifier for the value.
        /// </summary>
        [Input("secretValueResourceName", required: true)]
        public Input<string> SecretValueResourceName { get; set; } = null!;

        public ListSecretValueInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListSecretValueResult
    {
        /// <summary>
        /// The actual value of the secret.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private ListSecretValueResult(string? value)
        {
            Value = value;
        }
    }
}
