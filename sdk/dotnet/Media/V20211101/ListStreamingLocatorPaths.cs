// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20211101
{
    public static class ListStreamingLocatorPaths
    {
        /// <summary>
        /// Class of response for listPaths action
        /// </summary>
        public static Task<ListStreamingLocatorPathsResult> InvokeAsync(ListStreamingLocatorPathsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListStreamingLocatorPathsResult>("azure-native:media/v20211101:listStreamingLocatorPaths", args ?? new ListStreamingLocatorPathsArgs(), options.WithDefaults());

        /// <summary>
        /// Class of response for listPaths action
        /// </summary>
        public static Output<ListStreamingLocatorPathsResult> Invoke(ListStreamingLocatorPathsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListStreamingLocatorPathsResult>("azure-native:media/v20211101:listStreamingLocatorPaths", args ?? new ListStreamingLocatorPathsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListStreamingLocatorPathsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Streaming Locator name.
        /// </summary>
        [Input("streamingLocatorName", required: true)]
        public string StreamingLocatorName { get; set; } = null!;

        public ListStreamingLocatorPathsArgs()
        {
        }
    }

    public sealed class ListStreamingLocatorPathsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Streaming Locator name.
        /// </summary>
        [Input("streamingLocatorName", required: true)]
        public Input<string> StreamingLocatorName { get; set; } = null!;

        public ListStreamingLocatorPathsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListStreamingLocatorPathsResult
    {
        /// <summary>
        /// Download Paths supported by current Streaming Locator
        /// </summary>
        public readonly ImmutableArray<string> DownloadPaths;
        /// <summary>
        /// Streaming Paths supported by current Streaming Locator
        /// </summary>
        public readonly ImmutableArray<Outputs.StreamingPathResponse> StreamingPaths;

        [OutputConstructor]
        private ListStreamingLocatorPathsResult(
            ImmutableArray<string> downloadPaths,

            ImmutableArray<Outputs.StreamingPathResponse> streamingPaths)
        {
            DownloadPaths = downloadPaths;
            StreamingPaths = streamingPaths;
        }
    }
}
