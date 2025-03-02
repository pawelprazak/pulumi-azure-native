// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SecurityInsights.Inputs
{

    /// <summary>
    /// The Activity query definitions
    /// </summary>
    public sealed class ActivityEntityQueriesPropertiesQueryDefinitionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Activity query to run on a given entity
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        public ActivityEntityQueriesPropertiesQueryDefinitionsArgs()
        {
        }
    }
}
