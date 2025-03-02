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
    /// Describes parsed pattern entity
    /// </summary>
    public sealed class ThreatIntelligenceParsedPatternArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Pattern type key
        /// </summary>
        [Input("patternTypeKey")]
        public Input<string>? PatternTypeKey { get; set; }

        [Input("patternTypeValues")]
        private InputList<Inputs.ThreatIntelligenceParsedPatternTypeValueArgs>? _patternTypeValues;

        /// <summary>
        /// Pattern type keys
        /// </summary>
        public InputList<Inputs.ThreatIntelligenceParsedPatternTypeValueArgs> PatternTypeValues
        {
            get => _patternTypeValues ?? (_patternTypeValues = new InputList<Inputs.ThreatIntelligenceParsedPatternTypeValueArgs>());
            set => _patternTypeValues = value;
        }

        public ThreatIntelligenceParsedPatternArgs()
        {
        }
    }
}
