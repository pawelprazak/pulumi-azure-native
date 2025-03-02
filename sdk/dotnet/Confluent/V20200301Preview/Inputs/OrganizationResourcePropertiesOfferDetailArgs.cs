// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Confluent.V20200301Preview.Inputs
{

    /// <summary>
    /// Confluent offer detail
    /// </summary>
    public sealed class OrganizationResourcePropertiesOfferDetailArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Offer Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Offer Plan Id
        /// </summary>
        [Input("planId")]
        public Input<string>? PlanId { get; set; }

        /// <summary>
        /// Offer Plan Name
        /// </summary>
        [Input("planName")]
        public Input<string>? PlanName { get; set; }

        /// <summary>
        /// Publisher Id
        /// </summary>
        [Input("publisherId")]
        public Input<string>? PublisherId { get; set; }

        /// <summary>
        /// Offer Plan Term unit
        /// </summary>
        [Input("termUnit")]
        public Input<string>? TermUnit { get; set; }

        public OrganizationResourcePropertiesOfferDetailArgs()
        {
        }
    }
}
