// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Blueprint.V20171111Preview
{
    [Obsolete(@"Version 2017-11-11-preview will be removed in v2 of the provider.")]
    public static class GetPublishedBlueprint
    {
        /// <summary>
        /// Represents a published Blueprint.
        /// </summary>
        public static Task<GetPublishedBlueprintResult> InvokeAsync(GetPublishedBlueprintArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPublishedBlueprintResult>("azure-native:blueprint/v20171111preview:getPublishedBlueprint", args ?? new GetPublishedBlueprintArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a published Blueprint.
        /// </summary>
        public static Output<GetPublishedBlueprintResult> Invoke(GetPublishedBlueprintInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPublishedBlueprintResult>("azure-native:blueprint/v20171111preview:getPublishedBlueprint", args ?? new GetPublishedBlueprintInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPublishedBlueprintArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// name of the blueprint.
        /// </summary>
        [Input("blueprintName", required: true)]
        public string BlueprintName { get; set; } = null!;

        /// <summary>
        /// ManagementGroup where blueprint stores.
        /// </summary>
        [Input("managementGroupName", required: true)]
        public string ManagementGroupName { get; set; } = null!;

        /// <summary>
        /// version of the published blueprint.
        /// </summary>
        [Input("versionId", required: true)]
        public string VersionId { get; set; } = null!;

        public GetPublishedBlueprintArgs()
        {
        }
    }

    public sealed class GetPublishedBlueprintInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// name of the blueprint.
        /// </summary>
        [Input("blueprintName", required: true)]
        public Input<string> BlueprintName { get; set; } = null!;

        /// <summary>
        /// ManagementGroup where blueprint stores.
        /// </summary>
        [Input("managementGroupName", required: true)]
        public Input<string> ManagementGroupName { get; set; } = null!;

        /// <summary>
        /// version of the published blueprint.
        /// </summary>
        [Input("versionId", required: true)]
        public Input<string> VersionId { get; set; } = null!;

        public GetPublishedBlueprintInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPublishedBlueprintResult
    {
        /// <summary>
        /// Name of the Blueprint definition.
        /// </summary>
        public readonly string? BlueprintName;
        /// <summary>
        /// Version-specific change notes
        /// </summary>
        public readonly string? ChangeNotes;
        /// <summary>
        /// Multi-line explain this resource.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// One-liner string explain this resource.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// String Id used to locate any resource on Azure.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of this resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parameters required by this Blueprint definition.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterDefinitionResponse>? Parameters;
        /// <summary>
        /// Resource group placeholders defined by this Blueprint definition.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ResourceGroupDefinitionResponse>? ResourceGroups;
        /// <summary>
        /// Status of the Blueprint. This field is readonly.
        /// </summary>
        public readonly Outputs.BlueprintStatusResponse Status;
        /// <summary>
        /// The scope where this Blueprint can be applied.
        /// </summary>
        public readonly string? TargetScope;
        /// <summary>
        /// Type of this resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPublishedBlueprintResult(
            string? blueprintName,

            string? changeNotes,

            string? description,

            string? displayName,

            string id,

            string name,

            ImmutableDictionary<string, Outputs.ParameterDefinitionResponse>? parameters,

            ImmutableDictionary<string, Outputs.ResourceGroupDefinitionResponse>? resourceGroups,

            Outputs.BlueprintStatusResponse status,

            string? targetScope,

            string type)
        {
            BlueprintName = blueprintName;
            ChangeNotes = changeNotes;
            Description = description;
            DisplayName = displayName;
            Id = id;
            Name = name;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Status = status;
            TargetScope = targetScope;
            Type = type;
        }
    }
}
