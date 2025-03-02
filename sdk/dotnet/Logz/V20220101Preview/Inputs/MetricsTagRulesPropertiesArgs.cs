// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logz.V20220101Preview.Inputs
{

    /// <summary>
    /// Definition of the properties for a TagRules resource.
    /// </summary>
    public sealed class MetricsTagRulesPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("metricRules")]
        private InputList<Inputs.MetricRulesArgs>? _metricRules;
        public InputList<Inputs.MetricRulesArgs> MetricRules
        {
            get => _metricRules ?? (_metricRules = new InputList<Inputs.MetricRulesArgs>());
            set => _metricRules = value;
        }

        /// <summary>
        /// Flag specifying if metrics from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Input("sendMetrics")]
        public Input<bool>? SendMetrics { get; set; }

        public MetricsTagRulesPropertiesArgs()
        {
        }
    }
}
