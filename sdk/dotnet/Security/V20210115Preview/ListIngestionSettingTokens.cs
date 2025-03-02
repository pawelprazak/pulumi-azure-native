// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Security.V20210115Preview
{
    public static class ListIngestionSettingTokens
    {
        /// <summary>
        /// Configures how to correlate scan data and logs with resources associated with the subscription.
        /// </summary>
        public static Task<ListIngestionSettingTokensResult> InvokeAsync(ListIngestionSettingTokensArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListIngestionSettingTokensResult>("azure-native:security/v20210115preview:listIngestionSettingTokens", args ?? new ListIngestionSettingTokensArgs(), options.WithDefaults());

        /// <summary>
        /// Configures how to correlate scan data and logs with resources associated with the subscription.
        /// </summary>
        public static Output<ListIngestionSettingTokensResult> Invoke(ListIngestionSettingTokensInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListIngestionSettingTokensResult>("azure-native:security/v20210115preview:listIngestionSettingTokens", args ?? new ListIngestionSettingTokensInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListIngestionSettingTokensArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the ingestion setting
        /// </summary>
        [Input("ingestionSettingName", required: true)]
        public string IngestionSettingName { get; set; } = null!;

        public ListIngestionSettingTokensArgs()
        {
        }
    }

    public sealed class ListIngestionSettingTokensInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the ingestion setting
        /// </summary>
        [Input("ingestionSettingName", required: true)]
        public Input<string> IngestionSettingName { get; set; } = null!;

        public ListIngestionSettingTokensInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListIngestionSettingTokensResult
    {
        /// <summary>
        /// The token is used for correlating security data and logs with the resources in the subscription.
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private ListIngestionSettingTokensResult(string token)
        {
            Token = token;
        }
    }
}
