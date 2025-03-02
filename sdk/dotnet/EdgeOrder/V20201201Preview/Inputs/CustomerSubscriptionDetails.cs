// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.EdgeOrder.V20201201Preview.Inputs
{

    /// <summary>
    /// Holds Customer subscription details. Clients can display available products to unregistered customers by explicitly passing subscription details
    /// </summary>
    public sealed class CustomerSubscriptionDetails : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Location placement Id of a subscription
        /// </summary>
        [Input("locationPlacementId")]
        public string? LocationPlacementId { get; set; }

        /// <summary>
        /// Quota ID of a subscription
        /// </summary>
        [Input("quotaId", required: true)]
        public string QuotaId { get; set; } = null!;

        [Input("registeredFeatures")]
        private List<Inputs.CustomerSubscriptionRegisteredFeatures>? _registeredFeatures;

        /// <summary>
        /// List of registered feature flags for subscription
        /// </summary>
        public List<Inputs.CustomerSubscriptionRegisteredFeatures> RegisteredFeatures
        {
            get => _registeredFeatures ?? (_registeredFeatures = new List<Inputs.CustomerSubscriptionRegisteredFeatures>());
            set => _registeredFeatures = value;
        }

        public CustomerSubscriptionDetails()
        {
        }
    }
}
