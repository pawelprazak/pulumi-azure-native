// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Outputs
{

    /// <summary>
    /// Gets or sets the PrometheusOS provider properties.
    /// </summary>
    [OutputType]
    public sealed class PrometheusOSProviderInstancePropertiesResponse
    {
        /// <summary>
        /// URL of the Node Exporter endpoint
        /// </summary>
        public readonly string? PrometheusUrl;
        /// <summary>
        /// The provider type. For example, the value can be SapHana.
        /// Expected value is 'PrometheusOS'.
        /// </summary>
        public readonly string ProviderType;

        [OutputConstructor]
        private PrometheusOSProviderInstancePropertiesResponse(
            string? prometheusUrl,

            string providerType)
        {
            PrometheusUrl = prometheusUrl;
            ProviderType = providerType;
        }
    }
}
