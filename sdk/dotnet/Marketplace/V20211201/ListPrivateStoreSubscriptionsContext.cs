// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Marketplace.V20211201
{
    public static class ListPrivateStoreSubscriptionsContext
    {
        /// <summary>
        /// List of subscription Ids in the private store
        /// </summary>
        public static Task<ListPrivateStoreSubscriptionsContextResult> InvokeAsync(ListPrivateStoreSubscriptionsContextArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListPrivateStoreSubscriptionsContextResult>("azure-native:marketplace/v20211201:listPrivateStoreSubscriptionsContext", args ?? new ListPrivateStoreSubscriptionsContextArgs(), options.WithDefaults());

        /// <summary>
        /// List of subscription Ids in the private store
        /// </summary>
        public static Output<ListPrivateStoreSubscriptionsContextResult> Invoke(ListPrivateStoreSubscriptionsContextInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListPrivateStoreSubscriptionsContextResult>("azure-native:marketplace/v20211201:listPrivateStoreSubscriptionsContext", args ?? new ListPrivateStoreSubscriptionsContextInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListPrivateStoreSubscriptionsContextArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The store ID - must use the tenant ID
        /// </summary>
        [Input("privateStoreId", required: true)]
        public string PrivateStoreId { get; set; } = null!;

        public ListPrivateStoreSubscriptionsContextArgs()
        {
        }
    }

    public sealed class ListPrivateStoreSubscriptionsContextInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The store ID - must use the tenant ID
        /// </summary>
        [Input("privateStoreId", required: true)]
        public Input<string> PrivateStoreId { get; set; } = null!;

        public ListPrivateStoreSubscriptionsContextInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListPrivateStoreSubscriptionsContextResult
    {
        public readonly ImmutableArray<string> SubscriptionsIds;

        [OutputConstructor]
        private ListPrivateStoreSubscriptionsContextResult(ImmutableArray<string> subscriptionsIds)
        {
            SubscriptionsIds = subscriptionsIds;
        }
    }
}
