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
    /// The schedule associated with the export.
    /// </summary>
    public sealed class ExportScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The schedule recurrence.
        /// </summary>
        [Input("recurrence")]
        public InputUnion<string, Pulumi.AzureNative.CostManagement.V20211001.RecurrenceType>? Recurrence { get; set; }

        /// <summary>
        /// Has start and end date of the recurrence. The start date must be in future. If present, the end date must be greater than start date.
        /// </summary>
        [Input("recurrencePeriod")]
        public Input<Inputs.ExportRecurrencePeriodArgs>? RecurrencePeriod { get; set; }

        /// <summary>
        /// The status of the export's schedule. If 'Inactive', the export's schedule is paused.
        /// </summary>
        [Input("status")]
        public InputUnion<string, Pulumi.AzureNative.CostManagement.V20211001.StatusType>? Status { get; set; }

        public ExportScheduleArgs()
        {
        }
    }
}
