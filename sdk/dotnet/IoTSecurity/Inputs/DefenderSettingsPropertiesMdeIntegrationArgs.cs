// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.IoTSecurity.Inputs
{

    /// <summary>
    /// MDE integration configuration
    /// </summary>
    public sealed class DefenderSettingsPropertiesMdeIntegrationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Integration status
        /// </summary>
        [Input("status", required: true)]
        public InputUnion<string, Pulumi.AzureNative.IoTSecurity.MdeIntegration> Status { get; set; } = null!;

        public DefenderSettingsPropertiesMdeIntegrationArgs()
        {
        }
    }
}
