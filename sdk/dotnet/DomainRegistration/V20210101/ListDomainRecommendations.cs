// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DomainRegistration.V20210101
{
    public static class ListDomainRecommendations
    {
        /// <summary>
        /// Collection of domain name identifiers.
        /// </summary>
        public static Task<ListDomainRecommendationsResult> InvokeAsync(ListDomainRecommendationsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListDomainRecommendationsResult>("azure-native:domainregistration/v20210101:listDomainRecommendations", args ?? new ListDomainRecommendationsArgs(), options.WithDefaults());

        /// <summary>
        /// Collection of domain name identifiers.
        /// </summary>
        public static Output<ListDomainRecommendationsResult> Invoke(ListDomainRecommendationsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<ListDomainRecommendationsResult>("azure-native:domainregistration/v20210101:listDomainRecommendations", args ?? new ListDomainRecommendationsInvokeArgs(), options.WithDefaults());
    }


    public sealed class ListDomainRecommendationsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Keywords to be used for generating domain recommendations.
        /// </summary>
        [Input("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// Maximum number of recommendations.
        /// </summary>
        [Input("maxDomainRecommendations")]
        public int? MaxDomainRecommendations { get; set; }

        public ListDomainRecommendationsArgs()
        {
        }
    }

    public sealed class ListDomainRecommendationsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Keywords to be used for generating domain recommendations.
        /// </summary>
        [Input("keywords")]
        public Input<string>? Keywords { get; set; }

        /// <summary>
        /// Maximum number of recommendations.
        /// </summary>
        [Input("maxDomainRecommendations")]
        public Input<int>? MaxDomainRecommendations { get; set; }

        public ListDomainRecommendationsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListDomainRecommendationsResult
    {
        /// <summary>
        /// Link to next page of resources.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// Collection of resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.NameIdentifierResponse> Value;

        [OutputConstructor]
        private ListDomainRecommendationsResult(
            string nextLink,

            ImmutableArray<Outputs.NameIdentifierResponse> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
