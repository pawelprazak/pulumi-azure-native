// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cdn.V20210601.Outputs
{

    /// <summary>
    /// Defines the parameters for the cache-key query string action.
    /// </summary>
    [OutputType]
    public sealed class CacheKeyQueryStringActionParametersResponse
    {
        /// <summary>
        /// query parameters to include or exclude (comma separated).
        /// </summary>
        public readonly string? QueryParameters;
        /// <summary>
        /// Caching behavior for the requests
        /// </summary>
        public readonly string QueryStringBehavior;
        public readonly string TypeName;

        [OutputConstructor]
        private CacheKeyQueryStringActionParametersResponse(
            string? queryParameters,

            string queryStringBehavior,

            string typeName)
        {
            QueryParameters = queryParameters;
            QueryStringBehavior = queryStringBehavior;
            TypeName = typeName;
        }
    }
}
