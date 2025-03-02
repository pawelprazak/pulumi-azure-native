// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logic.V20160601.Outputs
{

    /// <summary>
    /// The RosettaNet ProcessConfiguration business document settings.
    /// </summary>
    [OutputType]
    public sealed class RosettaNetPipBusinessDocumentResponse
    {
        /// <summary>
        /// The business document description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The business document name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The business document version.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private RosettaNetPipBusinessDocumentResponse(
            string? description,

            string name,

            string version)
        {
            Description = description;
            Name = name;
            Version = version;
        }
    }
}
