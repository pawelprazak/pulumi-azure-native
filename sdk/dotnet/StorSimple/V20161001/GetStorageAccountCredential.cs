// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorSimple.V20161001
{
    [Obsolete(@"Version 2016-10-01 will be removed in v2 of the provider.")]
    public static class GetStorageAccountCredential
    {
        /// <summary>
        /// The storage account credential
        /// </summary>
        public static Task<GetStorageAccountCredentialResult> InvokeAsync(GetStorageAccountCredentialArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStorageAccountCredentialResult>("azure-native:storsimple/v20161001:getStorageAccountCredential", args ?? new GetStorageAccountCredentialArgs(), options.WithDefaults());

        /// <summary>
        /// The storage account credential
        /// </summary>
        public static Output<GetStorageAccountCredentialResult> Invoke(GetStorageAccountCredentialInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStorageAccountCredentialResult>("azure-native:storsimple/v20161001:getStorageAccountCredential", args ?? new GetStorageAccountCredentialInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStorageAccountCredentialArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of storage account credential to be fetched.
        /// </summary>
        [Input("credentialName", required: true)]
        public string CredentialName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public string ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetStorageAccountCredentialArgs()
        {
        }
    }

    public sealed class GetStorageAccountCredentialInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of storage account credential to be fetched.
        /// </summary>
        [Input("credentialName", required: true)]
        public Input<string> CredentialName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public Input<string> ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetStorageAccountCredentialInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStorageAccountCredentialResult
    {
        /// <summary>
        /// The details of the storage account password
        /// </summary>
        public readonly Outputs.AsymmetricEncryptedSecretResponse? AccessKey;
        /// <summary>
        /// The cloud service provider
        /// </summary>
        public readonly string CloudType;
        /// <summary>
        /// SSL needs to be enabled or not
        /// </summary>
        public readonly string EnableSSL;
        /// <summary>
        /// The storage endpoint
        /// </summary>
        public readonly string EndPoint;
        /// <summary>
        /// The identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The storage account's geo location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The storage account login
        /// </summary>
        public readonly string Login;
        /// <summary>
        /// The name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStorageAccountCredentialResult(
            Outputs.AsymmetricEncryptedSecretResponse? accessKey,

            string cloudType,

            string enableSSL,

            string endPoint,

            string id,

            string? location,

            string login,

            string name,

            string type)
        {
            AccessKey = accessKey;
            CloudType = cloudType;
            EnableSSL = enableSSL;
            EndPoint = endPoint;
            Id = id;
            Location = location;
            Login = login;
            Name = name;
            Type = type;
        }
    }
}
