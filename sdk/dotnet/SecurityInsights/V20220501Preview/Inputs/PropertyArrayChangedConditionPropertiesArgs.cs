// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.V20220501Preview.Inputs
{

    /// <summary>
    /// Describes an automation rule condition that evaluates an array property's value change
    /// </summary>
    public sealed class PropertyArrayChangedConditionPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("conditionProperties")]
        public Input<Inputs.AutomationRulePropertyArrayChangedValuesConditionArgs>? ConditionProperties { get; set; }

        /// <summary>
        /// 
        /// Expected value is 'PropertyArrayChanged'.
        /// </summary>
        [Input("conditionType", required: true)]
        public Input<string> ConditionType { get; set; } = null!;

        public PropertyArrayChangedConditionPropertiesArgs()
        {
        }
    }
}
