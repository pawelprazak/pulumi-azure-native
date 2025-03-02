// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DBforMySQL.V20171201.Inputs
{

    /// <summary>
    /// The properties used to create a new server.
    /// </summary>
    public sealed class ServerPropertiesForDefaultCreateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). The login name is required when updating password.
        /// </summary>
        [Input("administratorLogin", required: true)]
        public Input<string> AdministratorLogin { get; set; } = null!;

        /// <summary>
        /// The password of the administrator login.
        /// </summary>
        [Input("administratorLoginPassword", required: true)]
        public Input<string> AdministratorLoginPassword { get; set; } = null!;

        /// <summary>
        /// The mode to create a new server.
        /// Expected value is 'Default'.
        /// </summary>
        [Input("createMode", required: true)]
        public Input<string> CreateMode { get; set; } = null!;

        /// <summary>
        /// Status showing whether the server enabled infrastructure encryption.
        /// </summary>
        [Input("infrastructureEncryption")]
        public InputUnion<string, Pulumi.AzureNative.DBforMySQL.V20171201.InfrastructureEncryption>? InfrastructureEncryption { get; set; }

        /// <summary>
        /// Enforce a minimal Tls version for the server.
        /// </summary>
        [Input("minimalTlsVersion")]
        public InputUnion<string, Pulumi.AzureNative.DBforMySQL.V20171201.MinimalTlsVersionEnum>? MinimalTlsVersion { get; set; }

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'
        /// </summary>
        [Input("publicNetworkAccess")]
        public InputUnion<string, Pulumi.AzureNative.DBforMySQL.V20171201.PublicNetworkAccessEnum>? PublicNetworkAccess { get; set; }

        /// <summary>
        /// Enable ssl enforcement or not when connect to server.
        /// </summary>
        [Input("sslEnforcement")]
        public Input<Pulumi.AzureNative.DBforMySQL.V20171201.SslEnforcementEnum>? SslEnforcement { get; set; }

        /// <summary>
        /// Storage profile of a server.
        /// </summary>
        [Input("storageProfile")]
        public Input<Inputs.StorageProfileArgs>? StorageProfile { get; set; }

        /// <summary>
        /// Server version.
        /// </summary>
        [Input("version")]
        public InputUnion<string, Pulumi.AzureNative.DBforMySQL.V20171201.ServerVersion>? Version { get; set; }

        public ServerPropertiesForDefaultCreateArgs()
        {
        }
    }
}
