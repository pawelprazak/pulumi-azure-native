// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.HybridNetwork
{
    public static class GetVendorSkus
    {
        /// <summary>
        /// Sku sub resource.
        /// API Version: 2020-01-01-preview.
        /// </summary>
        public static Task<GetVendorSkusResult> InvokeAsync(GetVendorSkusArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVendorSkusResult>("azure-native:hybridnetwork:getVendorSkus", args ?? new GetVendorSkusArgs(), options.WithDefaults());

        /// <summary>
        /// Sku sub resource.
        /// API Version: 2020-01-01-preview.
        /// </summary>
        public static Output<GetVendorSkusResult> Invoke(GetVendorSkusInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVendorSkusResult>("azure-native:hybridnetwork:getVendorSkus", args ?? new GetVendorSkusInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVendorSkusArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the sku.
        /// </summary>
        [Input("skuName", required: true)]
        public string SkuName { get; set; } = null!;

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        [Input("vendorName", required: true)]
        public string VendorName { get; set; } = null!;

        public GetVendorSkusArgs()
        {
        }
    }

    public sealed class GetVendorSkusInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the sku.
        /// </summary>
        [Input("skuName", required: true)]
        public Input<string> SkuName { get; set; } = null!;

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        [Input("vendorName", required: true)]
        public Input<string> VendorName { get; set; } = null!;

        public GetVendorSkusInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVendorSkusResult
    {
        /// <summary>
        /// The sku deployment mode.
        /// </summary>
        public readonly string? DeploymentMode;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The parameters for the managed application to be supplied by the vendor.
        /// </summary>
        public readonly object? ManagedApplicationParameters;
        /// <summary>
        /// The template for the managed application deployment.
        /// </summary>
        public readonly object? ManagedApplicationTemplate;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The template definition of the network function.
        /// </summary>
        public readonly Outputs.NetworkFunctionTemplateResponse? NetworkFunctionTemplate;
        /// <summary>
        /// Indicates if the vendor sku is in preview mode.
        /// </summary>
        public readonly bool? Preview;
        /// <summary>
        /// The provisioning state of the vendor sku sub resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The sku type.
        /// </summary>
        public readonly string? SkuType;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetVendorSkusResult(
            string? deploymentMode,

            string id,

            object? managedApplicationParameters,

            object? managedApplicationTemplate,

            string name,

            Outputs.NetworkFunctionTemplateResponse? networkFunctionTemplate,

            bool? preview,

            string provisioningState,

            string? skuType,

            string type)
        {
            DeploymentMode = deploymentMode;
            Id = id;
            ManagedApplicationParameters = managedApplicationParameters;
            ManagedApplicationTemplate = managedApplicationTemplate;
            Name = name;
            NetworkFunctionTemplate = networkFunctionTemplate;
            Preview = preview;
            ProvisioningState = provisioningState;
            SkuType = skuType;
            Type = type;
        }
    }
}
