// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20210401.Inputs
{

    /// <summary>
    /// Compute Instance properties
    /// </summary>
    public sealed class ComputeInstancePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role.
        /// </summary>
        [Input("applicationSharingPolicy")]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.V20210401.ApplicationSharingPolicy>? ApplicationSharingPolicy { get; set; }

        /// <summary>
        /// The Compute Instance Authorization type. Available values are personal (default).
        /// </summary>
        [Input("computeInstanceAuthorizationType")]
        public InputUnion<string, Pulumi.AzureNative.MachineLearningServices.V20210401.ComputeInstanceAuthorizationType>? ComputeInstanceAuthorizationType { get; set; }

        /// <summary>
        /// Settings for a personal compute instance.
        /// </summary>
        [Input("personalComputeInstanceSettings")]
        public Input<Inputs.PersonalComputeInstanceSettingsArgs>? PersonalComputeInstanceSettings { get; set; }

        /// <summary>
        /// Details of customized scripts to execute for setting up the cluster.
        /// </summary>
        [Input("setupScripts")]
        public Input<Inputs.SetupScriptsArgs>? SetupScripts { get; set; }

        /// <summary>
        /// Specifies policy and settings for SSH access.
        /// </summary>
        [Input("sshSettings")]
        public Input<Inputs.ComputeInstanceSshSettingsArgs>? SshSettings { get; set; }

        /// <summary>
        /// Virtual network subnet resource ID the compute nodes belong to.
        /// </summary>
        [Input("subnet")]
        public Input<Inputs.ResourceIdArgs>? Subnet { get; set; }

        /// <summary>
        /// Virtual Machine Size
        /// </summary>
        [Input("vmSize")]
        public Input<string>? VmSize { get; set; }

        public ComputeInstancePropertiesArgs()
        {
            ApplicationSharingPolicy = "Shared";
            ComputeInstanceAuthorizationType = "personal";
        }
    }
}
