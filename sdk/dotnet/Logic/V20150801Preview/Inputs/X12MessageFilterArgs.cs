// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logic.V20150801Preview.Inputs
{

    public sealed class X12MessageFilterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The message filter type.
        /// </summary>
        [Input("messageFilterType")]
        public Input<Pulumi.AzureNative.Logic.V20150801Preview.MessageFilterType>? MessageFilterType { get; set; }

        public X12MessageFilterArgs()
        {
        }
    }
}
