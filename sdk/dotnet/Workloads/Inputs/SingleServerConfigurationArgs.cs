// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Inputs
{

    /// <summary>
    /// Gets or sets the single server configuration.
    /// </summary>
    public sealed class SingleServerConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The application resource group where SAP system resources will be deployed.
        /// </summary>
        [Input("appResourceGroup", required: true)]
        public Input<string> AppResourceGroup { get; set; } = null!;

        /// <summary>
        /// The database type.
        /// </summary>
        [Input("databaseType")]
        public InputUnion<string, Pulumi.AzureNative.Workloads.SAPDatabaseType>? DatabaseType { get; set; }

        /// <summary>
        /// The deployment Type.
        /// Expected value is 'SingleServer'.
        /// </summary>
        [Input("deploymentType", required: true)]
        public Input<string> DeploymentType { get; set; } = null!;

        /// <summary>
        /// Network configuration for the server
        /// </summary>
        [Input("networkConfiguration")]
        public Input<Inputs.NetworkConfigurationArgs>? NetworkConfiguration { get; set; }

        /// <summary>
        /// The subnet id.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the virtual machine configuration.
        /// </summary>
        [Input("virtualMachineConfiguration", required: true)]
        public Input<Inputs.VirtualMachineConfigurationArgs> VirtualMachineConfiguration { get; set; } = null!;

        public SingleServerConfigurationArgs()
        {
        }
    }
}
