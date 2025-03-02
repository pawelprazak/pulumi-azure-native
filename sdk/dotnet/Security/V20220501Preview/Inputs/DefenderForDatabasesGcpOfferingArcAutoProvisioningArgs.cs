// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Security.V20220501Preview.Inputs
{

    /// <summary>
    /// The ARC autoprovisioning configuration
    /// </summary>
    public sealed class DefenderForDatabasesGcpOfferingArcAutoProvisioningArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration for ARC autoprovisioning
        /// </summary>
        [Input("configuration")]
        public Input<Inputs.DefenderForDatabasesGcpOfferingConfigurationArgs>? Configuration { get; set; }

        /// <summary>
        /// Is arc auto provisioning enabled
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public DefenderForDatabasesGcpOfferingArcAutoProvisioningArgs()
        {
        }
    }
}
