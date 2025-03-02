// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MobileNetwork.V20220301Preview
{
    public static class ListMobileNetworkSimIds
    {
        /// <summary>
        /// Response for list sim ids API service call.
        /// </summary>
        public static Task<ListMobileNetworkSimIdsResult> InvokeAsync(ListMobileNetworkSimIdsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListMobileNetworkSimIdsResult>("azure-native:mobilenetwork/v20220301preview:listMobileNetworkSimIds", args ?? new ListMobileNetworkSimIdsArgs(), options.WithDefaults());

        /// <summary>
        /// Response for list sim ids API service call.
        /// </summary>
        public static Output<ListMobileNetworkSimIdsResult> Invoke(ListMobileNetworkSimIdsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListMobileNetworkSimIdsResult>("azure-native:mobilenetwork/v20220301preview:listMobileNetworkSimIds", args ?? new ListMobileNetworkSimIdsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListMobileNetworkSimIdsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the mobile network.
        /// </summary>
        [Input("mobileNetworkName", required: true)]
        public string MobileNetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListMobileNetworkSimIdsArgs()
        {
        }
    }

    public sealed class ListMobileNetworkSimIdsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the mobile network.
        /// </summary>
        [Input("mobileNetworkName", required: true)]
        public Input<string> MobileNetworkName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ListMobileNetworkSimIdsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListMobileNetworkSimIdsResult
    {
        /// <summary>
        /// The URL to get the next set of results.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// A list of sim profile ids in a resource group.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> Value;

        [OutputConstructor]
        private ListMobileNetworkSimIdsResult(
            string nextLink,

            ImmutableArray<Outputs.SubResourceResponse> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
