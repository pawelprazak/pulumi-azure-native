// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220101Preview.Inputs
{

    /// <summary>
    /// The available data types for office data connector.
    /// </summary>
    public sealed class OfficeDataConnectorDataTypesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Exchange data type connection.
        /// </summary>
        [Input("exchange", required: true)]
        public Input<Inputs.OfficeDataConnectorDataTypesExchangeArgs> Exchange { get; set; } = null!;

        /// <summary>
        /// SharePoint data type connection.
        /// </summary>
        [Input("sharePoint", required: true)]
        public Input<Inputs.OfficeDataConnectorDataTypesSharePointArgs> SharePoint { get; set; } = null!;

        /// <summary>
        /// Teams data type connection.
        /// </summary>
        [Input("teams", required: true)]
        public Input<Inputs.OfficeDataConnectorDataTypesTeamsArgs> Teams { get; set; } = null!;

        public OfficeDataConnectorDataTypesArgs()
        {
        }
    }
}
