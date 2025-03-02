// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningCompute.Outputs
{

    /// <summary>
    /// Global service auth configuration properties. These are the data-plane authorization keys and are used if a service doesn't define it's own.
    /// </summary>
    [OutputType]
    public sealed class ServiceAuthConfigurationResponse
    {
        /// <summary>
        /// The primary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API.
        /// </summary>
        public readonly string PrimaryAuthKeyHash;
        /// <summary>
        /// The secondary auth key hash. This is not returned in response of GET/PUT on the resource.. To see this please call listKeys API.
        /// </summary>
        public readonly string SecondaryAuthKeyHash;

        [OutputConstructor]
        private ServiceAuthConfigurationResponse(
            string primaryAuthKeyHash,

            string secondaryAuthKeyHash)
        {
            PrimaryAuthKeyHash = primaryAuthKeyHash;
            SecondaryAuthKeyHash = secondaryAuthKeyHash;
        }
    }
}
