// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220601Preview.Inputs
{

    /// <summary>
    /// Data type for Microsoft Threat Protection Platforms data connector.
    /// </summary>
    public sealed class MTPDataConnectorDataTypesIncidentsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describe whether this data type connection is enabled or not.
        /// </summary>
        [Input("state", required: true)]
        public InputUnion<string, Pulumi.AzureNative.SecurityInsights.V20220601Preview.DataTypeState> State { get; set; } = null!;

        public MTPDataConnectorDataTypesIncidentsArgs()
        {
        }
    }
}
