// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Marketplace.V20210601.Inputs
{

    public sealed class PlanArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Plan accessibility
        /// </summary>
        [Input("accessibility")]
        public InputUnion<string, Pulumi.AzureNative.Marketplace.V20210601.Accessibility>? Accessibility { get; set; }

        public PlanArgs()
        {
        }
    }
}
