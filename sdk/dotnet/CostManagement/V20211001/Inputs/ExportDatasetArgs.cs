// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20211001.Inputs
{

    /// <summary>
    /// The definition for data in the export.
    /// </summary>
    public sealed class ExportDatasetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The export dataset configuration.
        /// </summary>
        [Input("configuration")]
        public Input<Inputs.ExportDatasetConfigurationArgs>? Configuration { get; set; }

        /// <summary>
        /// The granularity of rows in the export. Currently only 'Daily' is supported.
        /// </summary>
        [Input("granularity")]
        public InputUnion<string, Pulumi.AzureNative.CostManagement.V20211001.GranularityType>? Granularity { get; set; }

        public ExportDatasetArgs()
        {
        }
    }
}
