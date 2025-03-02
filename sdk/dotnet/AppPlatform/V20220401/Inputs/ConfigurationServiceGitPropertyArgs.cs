// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20220401.Inputs
{

    /// <summary>
    /// Property of git environment.
    /// </summary>
    public sealed class ConfigurationServiceGitPropertyArgs : Pulumi.ResourceArgs
    {
        [Input("repositories")]
        private InputList<Inputs.ConfigurationServiceGitRepositoryArgs>? _repositories;

        /// <summary>
        /// Repositories of Application Configuration Service git property.
        /// </summary>
        public InputList<Inputs.ConfigurationServiceGitRepositoryArgs> Repositories
        {
            get => _repositories ?? (_repositories = new InputList<Inputs.ConfigurationServiceGitRepositoryArgs>());
            set => _repositories = value;
        }

        public ConfigurationServiceGitPropertyArgs()
        {
        }
    }
}
