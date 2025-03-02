// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataProtection.V20211001Preview.Inputs
{

    /// <summary>
    /// Adhoc backup tagging criteria
    /// </summary>
    public sealed class AdhocBasedTaggingCriteriaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Retention tag information
        /// </summary>
        [Input("tagInfo")]
        public Input<Inputs.RetentionTagArgs>? TagInfo { get; set; }

        public AdhocBasedTaggingCriteriaArgs()
        {
        }
    }
}
