// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SqlVirtualMachine.V20211101Preview.Inputs
{

    /// <summary>
    /// Set the server/instance-level settings for SQL Server.
    /// </summary>
    public sealed class SQLInstanceSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SQL Server Collation.
        /// </summary>
        [Input("collation")]
        public Input<string>? Collation { get; set; }

        /// <summary>
        /// SQL Server Optimize for Adhoc workloads.
        /// </summary>
        [Input("isOptimizeForAdHocWorkloadsEnabled")]
        public Input<bool>? IsOptimizeForAdHocWorkloadsEnabled { get; set; }

        /// <summary>
        /// SQL Server MAXDOP.
        /// </summary>
        [Input("maxDop")]
        public Input<int>? MaxDop { get; set; }

        /// <summary>
        /// SQL Server maximum memory.
        /// </summary>
        [Input("maxServerMemoryMB")]
        public Input<int>? MaxServerMemoryMB { get; set; }

        /// <summary>
        /// SQL Server minimum memory.
        /// </summary>
        [Input("minServerMemoryMB")]
        public Input<int>? MinServerMemoryMB { get; set; }

        public SQLInstanceSettingsArgs()
        {
        }
    }
}
