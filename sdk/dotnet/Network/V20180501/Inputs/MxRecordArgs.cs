// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Network.V20180501.Inputs
{

    /// <summary>
    /// An MX record.
    /// </summary>
    public sealed class MxRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The domain name of the mail host for this MX record.
        /// </summary>
        [Input("exchange")]
        public Input<string>? Exchange { get; set; }

        /// <summary>
        /// The preference value for this MX record.
        /// </summary>
        [Input("preference")]
        public Input<int>? Preference { get; set; }

        public MxRecordArgs()
        {
        }
    }
}
