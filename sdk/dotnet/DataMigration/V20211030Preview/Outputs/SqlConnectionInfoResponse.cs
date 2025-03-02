// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataMigration.V20211030Preview.Outputs
{

    /// <summary>
    /// Information for connecting to SQL database server
    /// </summary>
    [OutputType]
    public sealed class SqlConnectionInfoResponse
    {
        /// <summary>
        /// Additional connection settings
        /// </summary>
        public readonly string? AdditionalSettings;
        /// <summary>
        /// Authentication type to use for connection
        /// </summary>
        public readonly string? Authentication;
        /// <summary>
        /// Data source in the format Protocol:MachineName\SQLServerInstanceName,PortNumber
        /// </summary>
        public readonly string DataSource;
        /// <summary>
        /// Whether to encrypt the connection
        /// </summary>
        public readonly bool? EncryptConnection;
        /// <summary>
        /// Password credential.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// Server platform type for connection
        /// </summary>
        public readonly string? Platform;
        /// <summary>
        /// port for server
        /// </summary>
        public readonly string? Port;
        /// <summary>
        /// Represents the ID of an HTTP resource represented by an Azure resource provider.
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// name of the server
        /// </summary>
        public readonly string? ServerName;
        /// <summary>
        /// Whether to trust the server certificate
        /// </summary>
        public readonly bool? TrustServerCertificate;
        /// <summary>
        /// Type of connection info
        /// Expected value is 'SqlConnectionInfo'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User name
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private SqlConnectionInfoResponse(
            string? additionalSettings,

            string? authentication,

            string dataSource,

            bool? encryptConnection,

            string? password,

            string? platform,

            string? port,

            string? resourceId,

            string? serverName,

            bool? trustServerCertificate,

            string type,

            string? userName)
        {
            AdditionalSettings = additionalSettings;
            Authentication = authentication;
            DataSource = dataSource;
            EncryptConnection = encryptConnection;
            Password = password;
            Platform = platform;
            Port = port;
            ResourceId = resourceId;
            ServerName = serverName;
            TrustServerCertificate = trustServerCertificate;
            Type = type;
            UserName = userName;
        }
    }
}
