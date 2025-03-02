// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Security.V20170801Preview.Outputs
{

    /// <summary>
    /// Properties of the solution's user defined resources.
    /// </summary>
    [OutputType]
    public sealed class UserDefinedResourcesPropertiesResponse
    {
        /// <summary>
        /// Azure Resource Graph query which represents the security solution's user defined resources. Required to start with "where type != "Microsoft.Devices/IotHubs""
        /// </summary>
        public readonly string Query;
        /// <summary>
        /// List of Azure subscription ids on which the user defined resources query should be executed.
        /// </summary>
        public readonly ImmutableArray<string> QuerySubscriptions;

        [OutputConstructor]
        private UserDefinedResourcesPropertiesResponse(
            string query,

            ImmutableArray<string> querySubscriptions)
        {
            Query = query;
            QuerySubscriptions = querySubscriptions;
        }
    }
}
