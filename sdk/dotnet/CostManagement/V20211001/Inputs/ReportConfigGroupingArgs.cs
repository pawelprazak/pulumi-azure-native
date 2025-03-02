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
    /// The group by expression to be used in the report.
    /// </summary>
    public sealed class ReportConfigGroupingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the column to group. This version supports subscription lowest possible grain.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Has type of the column to group.
        /// </summary>
        [Input("type", required: true)]
        public InputUnion<string, Pulumi.AzureNative.CostManagement.V20211001.ReportConfigColumnType> Type { get; set; } = null!;

        public ReportConfigGroupingArgs()
        {
        }
    }
}
