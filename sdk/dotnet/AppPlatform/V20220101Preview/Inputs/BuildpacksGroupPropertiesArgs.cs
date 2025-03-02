// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20220101Preview.Inputs
{

    /// <summary>
    /// Buildpack group properties of the Builder
    /// </summary>
    public sealed class BuildpacksGroupPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("buildpacks")]
        private InputList<Inputs.BuildpackPropertiesArgs>? _buildpacks;

        /// <summary>
        /// Buildpacks in the buildpack group
        /// </summary>
        public InputList<Inputs.BuildpackPropertiesArgs> Buildpacks
        {
            get => _buildpacks ?? (_buildpacks = new InputList<Inputs.BuildpackPropertiesArgs>());
            set => _buildpacks = value;
        }

        /// <summary>
        /// Buildpack group name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public BuildpacksGroupPropertiesArgs()
        {
        }
    }
}
