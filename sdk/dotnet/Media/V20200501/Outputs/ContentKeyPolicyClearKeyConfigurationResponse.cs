// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Media.V20200501.Outputs
{

    /// <summary>
    /// Represents a configuration for non-DRM keys.
    /// </summary>
    [OutputType]
    public sealed class ContentKeyPolicyClearKeyConfigurationResponse
    {
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.ContentKeyPolicyClearKeyConfiguration'.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private ContentKeyPolicyClearKeyConfigurationResponse(string odataType)
        {
            OdataType = odataType;
        }
    }
}
