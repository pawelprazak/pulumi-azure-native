// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Outputs
{

    /// <summary>
    /// Gets or sets the SQL server provider properties.
    /// </summary>
    [OutputType]
    public sealed class MsSqlServerProviderInstancePropertiesResponse
    {
        /// <summary>
        /// Gets or sets the database password.
        /// </summary>
        public readonly string? DbPassword;
        /// <summary>
        /// Gets or sets the key vault URI to secret with the database password.
        /// </summary>
        public readonly string? DbPasswordUri;
        /// <summary>
        /// Gets or sets the database sql port.
        /// </summary>
        public readonly string? DbPort;
        /// <summary>
        /// Gets or sets the database user name.
        /// </summary>
        public readonly string? DbUsername;
        /// <summary>
        /// Gets or sets the SQL server host name.
        /// </summary>
        public readonly string? Hostname;
        /// <summary>
        /// The provider type. For example, the value can be SapHana.
        /// Expected value is 'MsSqlServer'.
        /// </summary>
        public readonly string ProviderType;
        /// <summary>
        /// Gets or sets the SAP System Identifier
        /// </summary>
        public readonly string? SapSid;

        [OutputConstructor]
        private MsSqlServerProviderInstancePropertiesResponse(
            string? dbPassword,

            string? dbPasswordUri,

            string? dbPort,

            string? dbUsername,

            string? hostname,

            string providerType,

            string? sapSid)
        {
            DbPassword = dbPassword;
            DbPasswordUri = dbPasswordUri;
            DbPort = dbPort;
            DbUsername = dbUsername;
            Hostname = hostname;
            ProviderType = providerType;
            SapSid = sapSid;
        }
    }
}
