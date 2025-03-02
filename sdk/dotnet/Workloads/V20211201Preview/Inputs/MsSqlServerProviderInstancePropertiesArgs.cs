// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.V20211201Preview.Inputs
{

    /// <summary>
    /// Gets or sets the SQL server provider properties.
    /// </summary>
    public sealed class MsSqlServerProviderInstancePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets the database password.
        /// </summary>
        [Input("dbPassword")]
        public Input<string>? DbPassword { get; set; }

        /// <summary>
        /// Gets or sets the key vault URI to secret with the database password.
        /// </summary>
        [Input("dbPasswordUri")]
        public Input<string>? DbPasswordUri { get; set; }

        /// <summary>
        /// Gets or sets the database sql port.
        /// </summary>
        [Input("dbPort")]
        public Input<string>? DbPort { get; set; }

        /// <summary>
        /// Gets or sets the database user name.
        /// </summary>
        [Input("dbUsername")]
        public Input<string>? DbUsername { get; set; }

        /// <summary>
        /// Gets or sets the SQL server host name.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The provider type. For example, the value can be SapHana.
        /// Expected value is 'MsSqlServer'.
        /// </summary>
        [Input("providerType", required: true)]
        public Input<string> ProviderType { get; set; } = null!;

        /// <summary>
        /// Gets or sets the SAP System Identifier
        /// </summary>
        [Input("sapSid")]
        public Input<string>? SapSid { get; set; }

        public MsSqlServerProviderInstancePropertiesArgs()
        {
        }
    }
}
