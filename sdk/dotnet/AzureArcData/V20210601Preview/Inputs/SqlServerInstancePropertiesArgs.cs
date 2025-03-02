// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureArcData.V20210601Preview.Inputs
{

    /// <summary>
    /// Properties of SqlServerInstance.
    /// </summary>
    public sealed class SqlServerInstancePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SQL Server collation.
        /// </summary>
        [Input("collation")]
        public Input<string>? Collation { get; set; }

        /// <summary>
        /// ARM Resource id of the container resource (Azure Arc for Servers).
        /// </summary>
        [Input("containerResourceId", required: true)]
        public Input<string> ContainerResourceId { get; set; } = null!;

        /// <summary>
        /// SQL Server current version.
        /// </summary>
        [Input("currentVersion")]
        public Input<string>? CurrentVersion { get; set; }

        /// <summary>
        /// SQL Server edition.
        /// </summary>
        [Input("edition")]
        public Input<string>? Edition { get; set; }

        /// <summary>
        /// SQL Server instance name.
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// SQL Server license type.
        /// </summary>
        [Input("licenseType")]
        public Input<string>? LicenseType { get; set; }

        /// <summary>
        /// SQL Server update level.
        /// </summary>
        [Input("patchLevel")]
        public Input<string>? PatchLevel { get; set; }

        /// <summary>
        /// SQL Server product ID.
        /// </summary>
        [Input("productId")]
        public Input<string>? ProductId { get; set; }

        /// <summary>
        /// The cloud connectivity status.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Dynamic TCP ports used by SQL Server.
        /// </summary>
        [Input("tcpDynamicPorts")]
        public Input<string>? TcpDynamicPorts { get; set; }

        /// <summary>
        /// Static TCP ports used by SQL Server.
        /// </summary>
        [Input("tcpStaticPorts")]
        public Input<string>? TcpStaticPorts { get; set; }

        /// <summary>
        /// The number of logical processors used by the SQL Server instance.
        /// </summary>
        [Input("vCore")]
        public Input<string>? VCore { get; set; }

        /// <summary>
        /// SQL Server version.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public SqlServerInstancePropertiesArgs()
        {
        }
    }
}
