// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Kusto.V20200215.Outputs
{

    /// <summary>
    /// The list of language extension objects.
    /// </summary>
    [OutputType]
    public sealed class LanguageExtensionsListResponse
    {
        /// <summary>
        /// The list of language extensions.
        /// </summary>
        public readonly ImmutableArray<Outputs.LanguageExtensionResponse> Value;

        [OutputConstructor]
        private LanguageExtensionsListResponse(ImmutableArray<Outputs.LanguageExtensionResponse> value)
        {
            Value = value;
        }
    }
}
