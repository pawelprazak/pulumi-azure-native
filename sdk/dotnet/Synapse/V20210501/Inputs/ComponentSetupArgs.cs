// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20210501.Inputs
{

    /// <summary>
    /// The custom setup of installing 3rd party components.
    /// </summary>
    public sealed class ComponentSetupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the 3rd party component.
        /// </summary>
        [Input("componentName", required: true)]
        public Input<string> ComponentName { get; set; } = null!;

        /// <summary>
        /// The license key to activate the component.
        /// </summary>
        [Input("licenseKey")]
        public Input<Inputs.SecureStringArgs>? LicenseKey { get; set; }

        /// <summary>
        /// The type of custom setup.
        /// Expected value is 'ComponentSetup'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ComponentSetupArgs()
        {
        }
    }
}
