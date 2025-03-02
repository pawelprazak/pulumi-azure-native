// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.LabServices.V20211001Preview.Inputs
{

    /// <summary>
    /// Recurrence pattern of a lab schedule.
    /// </summary>
    public sealed class RecurrencePatternArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// When the recurrence will expire. This date is inclusive.
        /// </summary>
        [Input("expirationDate", required: true)]
        public Input<string> ExpirationDate { get; set; } = null!;

        /// <summary>
        /// The frequency of the recurrence.
        /// </summary>
        [Input("frequency", required: true)]
        public Input<Pulumi.AzureNative.LabServices.V20211001Preview.RecurrenceFrequency> Frequency { get; set; } = null!;

        /// <summary>
        /// The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days. When no interval is supplied, an interval of 1 is used.
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        [Input("weekDays")]
        private InputList<Pulumi.AzureNative.LabServices.V20211001Preview.WeekDay>? _weekDays;

        /// <summary>
        /// The week days the schedule runs. Used for when the Frequency is set to Weekly.
        /// </summary>
        public InputList<Pulumi.AzureNative.LabServices.V20211001Preview.WeekDay> WeekDays
        {
            get => _weekDays ?? (_weekDays = new InputList<Pulumi.AzureNative.LabServices.V20211001Preview.WeekDay>());
            set => _weekDays = value;
        }

        public RecurrencePatternArgs()
        {
        }
    }
}
