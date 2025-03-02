// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220501Preview.Outputs
{

    /// <summary>
    /// The available data types for Microsoft Threat Intelligence Platforms data connector.
    /// </summary>
    [OutputType]
    public sealed class MSTIDataConnectorDataTypesResponse
    {
        /// <summary>
        /// Data type for Microsoft Threat Intelligence Platforms data connector.
        /// </summary>
        public readonly Outputs.MSTIDataConnectorDataTypesResponseBingSafetyPhishingURL BingSafetyPhishingURL;
        /// <summary>
        /// Data type for Microsoft Threat Intelligence Platforms data connector.
        /// </summary>
        public readonly Outputs.MSTIDataConnectorDataTypesResponseMicrosoftEmergingThreatFeed MicrosoftEmergingThreatFeed;

        [OutputConstructor]
        private MSTIDataConnectorDataTypesResponse(
            Outputs.MSTIDataConnectorDataTypesResponseBingSafetyPhishingURL bingSafetyPhishingURL,

            Outputs.MSTIDataConnectorDataTypesResponseMicrosoftEmergingThreatFeed microsoftEmergingThreatFeed)
        {
            BingSafetyPhishingURL = bingSafetyPhishingURL;
            MicrosoftEmergingThreatFeed = microsoftEmergingThreatFeed;
        }
    }
}
