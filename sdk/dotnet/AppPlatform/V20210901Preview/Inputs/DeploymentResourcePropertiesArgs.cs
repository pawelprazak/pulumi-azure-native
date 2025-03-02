// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20210901Preview.Inputs
{

    /// <summary>
    /// Deployment resource properties payload
    /// </summary>
    public sealed class DeploymentResourcePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Deployment settings of the Deployment
        /// </summary>
        [Input("deploymentSettings")]
        public Input<Inputs.DeploymentSettingsArgs>? DeploymentSettings { get; set; }

        /// <summary>
        /// Uploaded source information of the deployment.
        /// </summary>
        [Input("source")]
        public Input<Inputs.UserSourceInfoArgs>? Source { get; set; }

        public DeploymentResourcePropertiesArgs()
        {
        }
    }
}
