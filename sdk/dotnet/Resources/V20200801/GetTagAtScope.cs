// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Resources.V20200801
{
    public static class GetTagAtScope
    {
        /// <summary>
        /// Wrapper resource for tags API requests and responses.
        /// </summary>
        public static Task<GetTagAtScopeResult> InvokeAsync(GetTagAtScopeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTagAtScopeResult>("azure-native:resources/v20200801:getTagAtScope", args ?? new GetTagAtScopeArgs(), options.WithDefaults());

        /// <summary>
        /// Wrapper resource for tags API requests and responses.
        /// </summary>
        public static Output<GetTagAtScopeResult> Invoke(GetTagAtScopeInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTagAtScopeResult>("azure-native:resources/v20200801:getTagAtScope", args ?? new GetTagAtScopeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTagAtScopeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The resource scope.
        /// </summary>
        [Input("scope", required: true)]
        public string Scope { get; set; } = null!;

        public GetTagAtScopeArgs()
        {
        }
    }

    public sealed class GetTagAtScopeInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The resource scope.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        public GetTagAtScopeInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTagAtScopeResult
    {
        /// <summary>
        /// The ID of the tags wrapper resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the tags wrapper resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The set of tags.
        /// </summary>
        public readonly Outputs.TagsResponse Properties;
        /// <summary>
        /// The type of the tags wrapper resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetTagAtScopeResult(
            string id,

            string name,

            Outputs.TagsResponse properties,

            string type)
        {
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
