// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Resources.V20160701.Outputs
{

    /// <summary>
    /// Plan for the resource.
    /// </summary>
    [OutputType]
    public sealed class PlanResponse
    {
        /// <summary>
        /// The plan ID.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The offer ID.
        /// </summary>
        public readonly string? Product;
        /// <summary>
        /// The promotion code.
        /// </summary>
        public readonly string? PromotionCode;
        /// <summary>
        /// The publisher ID.
        /// </summary>
        public readonly string? Publisher;

        [OutputConstructor]
        private PlanResponse(
            string? name,

            string? product,

            string? promotionCode,

            string? publisher)
        {
            Name = name;
            Product = product;
            PromotionCode = promotionCode;
            Publisher = publisher;
        }
    }
}
