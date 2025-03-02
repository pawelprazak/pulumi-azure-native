// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Portal.V20200901Preview.Outputs
{

    /// <summary>
    /// Markdown part metadata.
    /// </summary>
    [OutputType]
    public sealed class MarkdownPartMetadataResponse
    {
        /// <summary>
        /// Input to dashboard part.
        /// </summary>
        public readonly ImmutableArray<object> Inputs;
        /// <summary>
        /// Markdown part settings.
        /// </summary>
        public readonly Outputs.MarkdownPartMetadataResponseSettings? Settings;
        /// <summary>
        /// The type of dashboard part.
        /// Expected value is 'Extension/HubsExtension/PartType/MarkdownPart'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private MarkdownPartMetadataResponse(
            ImmutableArray<object> inputs,

            Outputs.MarkdownPartMetadataResponseSettings? settings,

            string type)
        {
            Inputs = inputs;
            Settings = settings;
            Type = type;
        }
    }
}
