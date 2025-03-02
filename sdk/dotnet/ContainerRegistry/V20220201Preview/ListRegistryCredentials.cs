// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerRegistry.V20220201Preview
{
    public static class ListRegistryCredentials
    {
        /// <summary>
        /// The response from the ListCredentials operation.
        /// </summary>
        public static Task<ListRegistryCredentialsResult> InvokeAsync(ListRegistryCredentialsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListRegistryCredentialsResult>("azure-native:containerregistry/v20220201preview:listRegistryCredentials", args ?? new ListRegistryCredentialsArgs(), options.WithDefaults());

        /// <summary>
        /// The response from the ListCredentials operation.
        /// </summary>
        public static Output<ListRegistryCredentialsResult> Invoke(ListRegistryCredentialsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListRegistryCredentialsResult>("azure-native:containerregistry/v20220201preview:listRegistryCredentials", args ?? new ListRegistryCredentialsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListRegistryCredentialsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the container registry.
        /// </summary>
        [Input("registryName", required: true)]
        public string RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListRegistryCredentialsArgs()
        {
        }
    }

    public sealed class ListRegistryCredentialsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the container registry.
        /// </summary>
        [Input("registryName", required: true)]
        public Input<string> RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListRegistryCredentialsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListRegistryCredentialsResult
    {
        /// <summary>
        /// The list of passwords for a container registry.
        /// </summary>
        public readonly ImmutableArray<Outputs.RegistryPasswordResponse> Passwords;
        /// <summary>
        /// The username for a container registry.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private ListRegistryCredentialsResult(
            ImmutableArray<Outputs.RegistryPasswordResponse> passwords,

            string? username)
        {
            Passwords = passwords;
            Username = username;
        }
    }
}
