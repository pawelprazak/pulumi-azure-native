// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Insights.V20200301Preview
{
    public static class GetComponentLinkedStorageAccount
    {
        /// <summary>
        /// An Application Insights component linked storage accounts
        /// </summary>
        public static Task<GetComponentLinkedStorageAccountResult> InvokeAsync(GetComponentLinkedStorageAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComponentLinkedStorageAccountResult>("azure-native:insights/v20200301preview:getComponentLinkedStorageAccount", args ?? new GetComponentLinkedStorageAccountArgs(), options.WithDefaults());

        /// <summary>
        /// An Application Insights component linked storage accounts
        /// </summary>
        public static Output<GetComponentLinkedStorageAccountResult> Invoke(GetComponentLinkedStorageAccountInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComponentLinkedStorageAccountResult>("azure-native:insights/v20200301preview:getComponentLinkedStorageAccount", args ?? new GetComponentLinkedStorageAccountInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComponentLinkedStorageAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Application Insights component resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        /// <summary>
        /// The type of the Application Insights component data source for the linked storage account.
        /// </summary>
        [Input("storageType", required: true)]
        public string StorageType { get; set; } = null!;

        public GetComponentLinkedStorageAccountArgs()
        {
        }
    }

    public sealed class GetComponentLinkedStorageAccountInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Application Insights component resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        /// <summary>
        /// The type of the Application Insights component data source for the linked storage account.
        /// </summary>
        [Input("storageType", required: true)]
        public Input<string> StorageType { get; set; } = null!;

        public GetComponentLinkedStorageAccountInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComponentLinkedStorageAccountResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Linked storage account resource ID
        /// </summary>
        public readonly string? LinkedStorageAccount;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetComponentLinkedStorageAccountResult(
            string id,

            string? linkedStorageAccount,

            string name,

            string type)
        {
            Id = id;
            LinkedStorageAccount = linkedStorageAccount;
            Name = name;
            Type = type;
        }
    }
}
