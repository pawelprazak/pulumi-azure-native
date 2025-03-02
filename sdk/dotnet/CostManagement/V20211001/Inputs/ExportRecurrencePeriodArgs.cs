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
    /// The start and end date for recurrence schedule.
    /// </summary>
    public sealed class ExportRecurrencePeriodArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The start date of recurrence.
        /// </summary>
        [Input("from", required: true)]
        public Input<string> From { get; set; } = null!;

        /// <summary>
        /// The end date of recurrence.
        /// </summary>
        [Input("to")]
        public Input<string>? To { get; set; }

        public ExportRecurrencePeriodArgs()
        {
        }
    }
}
