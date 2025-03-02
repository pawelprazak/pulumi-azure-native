// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Batch.V20190801
{
    [Obsolete(@"Version 2019-08-01 will be removed in v2 of the provider.")]
    public static class GetBatchAccount
    {
        /// <summary>
        /// Contains information about an Azure Batch account.
        /// </summary>
        public static Task<GetBatchAccountResult> InvokeAsync(GetBatchAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBatchAccountResult>("azure-native:batch/v20190801:getBatchAccount", args ?? new GetBatchAccountArgs(), options.WithDefaults());

        /// <summary>
        /// Contains information about an Azure Batch account.
        /// </summary>
        public static Output<GetBatchAccountResult> Invoke(GetBatchAccountInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBatchAccountResult>("azure-native:batch/v20190801:getBatchAccount", args ?? new GetBatchAccountInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBatchAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Batch account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the Batch account.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetBatchAccountArgs()
        {
        }
    }

    public sealed class GetBatchAccountInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Batch account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the Batch account.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetBatchAccountInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBatchAccountResult
    {
        /// <summary>
        /// The account endpoint used to interact with the Batch service.
        /// </summary>
        public readonly string AccountEndpoint;
        public readonly int ActiveJobAndJobScheduleQuota;
        /// <summary>
        /// Contains information about the auto-storage account associated with a Batch account.
        /// </summary>
        public readonly Outputs.AutoStoragePropertiesResponse AutoStorage;
        /// <summary>
        /// For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned.
        /// </summary>
        public readonly int DedicatedCoreQuota;
        /// <summary>
        /// A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineFamilyCoreQuotaResponse> DedicatedCoreQuotaPerVMFamily;
        /// <summary>
        /// Batch is transitioning its core quota system for dedicated cores to be enforced per Virtual Machine family. During this transitional phase, the dedicated core quota per Virtual Machine family may not yet be enforced. If this flag is false, dedicated core quota is enforced via the old dedicatedCoreQuota property on the account and does not consider Virtual Machine family. If this flag is true, dedicated core quota is enforced via the dedicatedCoreQuotaPerVMFamily property on the account, and the old dedicatedCoreQuota does not apply.
        /// </summary>
        public readonly bool DedicatedCoreQuotaPerVMFamilyEnforced;
        /// <summary>
        /// The ID of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Identifies the Azure key vault associated with a Batch account.
        /// </summary>
        public readonly Outputs.KeyVaultReferenceResponse KeyVaultReference;
        /// <summary>
        /// The location of the resource.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned.
        /// </summary>
        public readonly int LowPriorityCoreQuota;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The allocation mode for creating pools in the Batch account.
        /// </summary>
        public readonly string PoolAllocationMode;
        public readonly int PoolQuota;
        /// <summary>
        /// The provisioned state of the resource
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetBatchAccountResult(
            string accountEndpoint,

            int activeJobAndJobScheduleQuota,

            Outputs.AutoStoragePropertiesResponse autoStorage,

            int dedicatedCoreQuota,

            ImmutableArray<Outputs.VirtualMachineFamilyCoreQuotaResponse> dedicatedCoreQuotaPerVMFamily,

            bool dedicatedCoreQuotaPerVMFamilyEnforced,

            string id,

            Outputs.KeyVaultReferenceResponse keyVaultReference,

            string location,

            int lowPriorityCoreQuota,

            string name,

            string poolAllocationMode,

            int poolQuota,

            string provisioningState,

            ImmutableDictionary<string, string> tags,

            string type)
        {
            AccountEndpoint = accountEndpoint;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            AutoStorage = autoStorage;
            DedicatedCoreQuota = dedicatedCoreQuota;
            DedicatedCoreQuotaPerVMFamily = dedicatedCoreQuotaPerVMFamily;
            DedicatedCoreQuotaPerVMFamilyEnforced = dedicatedCoreQuotaPerVMFamilyEnforced;
            Id = id;
            KeyVaultReference = keyVaultReference;
            Location = location;
            LowPriorityCoreQuota = lowPriorityCoreQuota;
            Name = name;
            PoolAllocationMode = poolAllocationMode;
            PoolQuota = poolQuota;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
        }
    }
}
