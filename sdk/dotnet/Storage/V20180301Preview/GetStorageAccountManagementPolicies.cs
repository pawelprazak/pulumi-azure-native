// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Storage.V20180301Preview
{
    [Obsolete(@"Version 2018-03-01-preview will be removed in v2 of the provider.")]
    public static class GetStorageAccountManagementPolicies
    {
        /// <summary>
        /// The Get Storage Account ManagementPolicies operation response.
        /// </summary>
        public static Task<GetStorageAccountManagementPoliciesResult> InvokeAsync(GetStorageAccountManagementPoliciesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStorageAccountManagementPoliciesResult>("azure-native:storage/v20180301preview:getStorageAccountManagementPolicies", args ?? new GetStorageAccountManagementPoliciesArgs(), options.WithDefaults());

        /// <summary>
        /// The Get Storage Account ManagementPolicies operation response.
        /// </summary>
        public static Output<GetStorageAccountManagementPoliciesResult> Invoke(GetStorageAccountManagementPoliciesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStorageAccountManagementPoliciesResult>("azure-native:storage/v20180301preview:getStorageAccountManagementPolicies", args ?? new GetStorageAccountManagementPoliciesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStorageAccountManagementPoliciesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the Storage Account Management Policy. It should always be 'default'
        /// </summary>
        [Input("managementPolicyName", required: true)]
        public string ManagementPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetStorageAccountManagementPoliciesArgs()
        {
        }
    }

    public sealed class GetStorageAccountManagementPoliciesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the Storage Account Management Policy. It should always be 'default'
        /// </summary>
        [Input("managementPolicyName", required: true)]
        public Input<string> ManagementPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetStorageAccountManagementPoliciesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStorageAccountManagementPoliciesResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Returns the date and time the ManagementPolicies was last modified.
        /// </summary>
        public readonly string LastModifiedTime;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Storage Account ManagementPolicies Rules, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
        /// </summary>
        public readonly object? Policy;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStorageAccountManagementPoliciesResult(
            string id,

            string lastModifiedTime,

            string name,

            object? policy,

            string type)
        {
            Id = id;
            LastModifiedTime = lastModifiedTime;
            Name = name;
            Policy = policy;
            Type = type;
        }
    }
}
