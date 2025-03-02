// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.MachineLearningServices.V20200501Preview.Outputs
{

    /// <summary>
    /// Image registry that contains the base image.
    /// </summary>
    [OutputType]
    public sealed class ModelDockerSectionResponseResponseBaseImageRegistry
    {
        public readonly string? Address;

        [OutputConstructor]
        private ModelDockerSectionResponseResponseBaseImageRegistry(string? address)
        {
            Address = address;
        }
    }
}
