// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ProviderHub.V20210901Preview.Inputs
{

    public sealed class OpenApiValidationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether a non compliance response is allowed for a LIST call
        /// </summary>
        [Input("allowNoncompliantCollectionResponse")]
        public Input<bool>? AllowNoncompliantCollectionResponse { get; set; }

        public OpenApiValidationArgs()
        {
        }
    }
}
