// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB.V20211115Preview.Inputs
{

    /// <summary>
    /// Cosmos DB capability object
    /// </summary>
    public sealed class CapabilityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the Cosmos DB capability. For example, "name": "EnableCassandra". Current values also include "EnableTable" and "EnableGremlin".
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public CapabilityArgs()
        {
        }
    }
}
