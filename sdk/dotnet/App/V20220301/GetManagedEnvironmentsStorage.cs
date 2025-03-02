// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.App.V20220301
{
    public static class GetManagedEnvironmentsStorage
    {
        /// <summary>
        /// Storage resource for managedEnvironment.
        /// </summary>
        public static Task<GetManagedEnvironmentsStorageResult> InvokeAsync(GetManagedEnvironmentsStorageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagedEnvironmentsStorageResult>("azure-native:app/v20220301:getManagedEnvironmentsStorage", args ?? new GetManagedEnvironmentsStorageArgs(), options.WithDefaults());

        /// <summary>
        /// Storage resource for managedEnvironment.
        /// </summary>
        public static Output<GetManagedEnvironmentsStorageResult> Invoke(GetManagedEnvironmentsStorageInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetManagedEnvironmentsStorageResult>("azure-native:app/v20220301:getManagedEnvironmentsStorage", args ?? new GetManagedEnvironmentsStorageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagedEnvironmentsStorageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Environment.
        /// </summary>
        [Input("environmentName", required: true)]
        public string EnvironmentName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the storage.
        /// </summary>
        [Input("storageName", required: true)]
        public string StorageName { get; set; } = null!;

        public GetManagedEnvironmentsStorageArgs()
        {
        }
    }

    public sealed class GetManagedEnvironmentsStorageInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Environment.
        /// </summary>
        [Input("environmentName", required: true)]
        public Input<string> EnvironmentName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the storage.
        /// </summary>
        [Input("storageName", required: true)]
        public Input<string> StorageName { get; set; } = null!;

        public GetManagedEnvironmentsStorageInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagedEnvironmentsStorageResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Storage properties
        /// </summary>
        public readonly Outputs.ManagedEnvironmentStorageResponseProperties Properties;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetManagedEnvironmentsStorageResult(
            string id,

            string name,

            Outputs.ManagedEnvironmentStorageResponseProperties properties,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
