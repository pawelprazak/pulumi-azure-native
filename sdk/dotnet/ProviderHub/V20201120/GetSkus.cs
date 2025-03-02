// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ProviderHub.V20201120
{
    public static class GetSkus
    {
        public static Task<GetSkusResult> InvokeAsync(GetSkusArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSkusResult>("azure-native:providerhub/v20201120:getSkus", args ?? new GetSkusArgs(), options.WithDefaults());

        public static Output<GetSkusResult> Invoke(GetSkusInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSkusResult>("azure-native:providerhub/v20201120:getSkus", args ?? new GetSkusInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSkusArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource provider hosted within ProviderHub.
        /// </summary>
        [Input("providerNamespace", required: true)]
        public string ProviderNamespace { get; set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Input("resourceType", required: true)]
        public string ResourceType { get; set; } = null!;

        /// <summary>
        /// The SKU.
        /// </summary>
        [Input("sku", required: true)]
        public string Sku { get; set; } = null!;

        public GetSkusArgs()
        {
        }
    }

    public sealed class GetSkusInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource provider hosted within ProviderHub.
        /// </summary>
        [Input("providerNamespace", required: true)]
        public Input<string> ProviderNamespace { get; set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        /// <summary>
        /// The SKU.
        /// </summary>
        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

        public GetSkusInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSkusResult
    {
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        public readonly Outputs.SkuResourceResponseProperties Properties;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSkusResult(
            string id,

            string name,

            Outputs.SkuResourceResponseProperties properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
