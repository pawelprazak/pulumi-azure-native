// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataFactory.Outputs
{

    /// <summary>
    /// Sftp read settings.
    /// </summary>
    [OutputType]
    public sealed class HttpReadSettingsResponse
    {
        /// <summary>
        /// The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? AdditionalHeaders;
        /// <summary>
        /// If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? DisableMetricsCollection;
        /// <summary>
        /// Indicates whether to enable partition discovery.
        /// </summary>
        public readonly bool? EnablePartitionDiscovery;
        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxConcurrentConnections;
        /// <summary>
        /// Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? PartitionRootPath;
        /// <summary>
        /// The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? RequestBody;
        /// <summary>
        /// The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? RequestMethod;
        /// <summary>
        /// Specifies the timeout for a HTTP client to get HTTP response from HTTP server.
        /// </summary>
        public readonly object? RequestTimeout;
        /// <summary>
        /// The read setting type.
        /// Expected value is 'HttpReadSettings'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private HttpReadSettingsResponse(
            object? additionalHeaders,

            object? disableMetricsCollection,

            bool? enablePartitionDiscovery,

            object? maxConcurrentConnections,

            object? partitionRootPath,

            object? requestBody,

            object? requestMethod,

            object? requestTimeout,

            string type)
        {
            AdditionalHeaders = additionalHeaders;
            DisableMetricsCollection = disableMetricsCollection;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            MaxConcurrentConnections = maxConcurrentConnections;
            PartitionRootPath = partitionRootPath;
            RequestBody = requestBody;
            RequestMethod = requestMethod;
            RequestTimeout = requestTimeout;
            Type = type;
        }
    }
}
