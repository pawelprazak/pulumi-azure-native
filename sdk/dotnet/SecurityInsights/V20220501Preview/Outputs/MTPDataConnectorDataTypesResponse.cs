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
    /// The available data types for Microsoft Threat Protection Platforms data connector.
    /// </summary>
    [OutputType]
    public sealed class MTPDataConnectorDataTypesResponse
    {
        /// <summary>
        /// Data type for Microsoft Threat Protection Platforms data connector.
        /// </summary>
        public readonly Outputs.MTPDataConnectorDataTypesResponseIncidents Incidents;

        [OutputConstructor]
        private MTPDataConnectorDataTypesResponse(Outputs.MTPDataConnectorDataTypesResponseIncidents incidents)
        {
            Incidents = incidents;
        }
    }
}
