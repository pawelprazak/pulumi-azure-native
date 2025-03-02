// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20180202
{
    public static class GetGroup
    {
        /// <summary>
        /// A group created in a Migration project.
        /// </summary>
        public static Task<GetGroupResult> InvokeAsync(GetGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGroupResult>("azure-native:migrate/v20180202:getGroup", args ?? new GetGroupArgs(), options.WithDefaults());

        /// <summary>
        /// A group created in a Migration project.
        /// </summary>
        public static Output<GetGroupResult> Invoke(GetGroupInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetGroupResult>("azure-native:migrate/v20180202:getGroup", args ?? new GetGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique name of a group within a project.
        /// </summary>
        [Input("groupName", required: true)]
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Migrate project.
        /// </summary>
        [Input("projectName", required: true)]
        public string ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Resource Group that project is part of.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetGroupArgs()
        {
        }
    }

    public sealed class GetGroupInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique name of a group within a project.
        /// </summary>
        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Migrate project.
        /// </summary>
        [Input("projectName", required: true)]
        public Input<string> ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Resource Group that project is part of.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetGroupInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGroupResult
    {
        /// <summary>
        /// List of References to Assessments created on this group.
        /// </summary>
        public readonly ImmutableArray<string> Assessments;
        /// <summary>
        /// Time when this project was created. Date-Time represented in ISO-8601 format.
        /// </summary>
        public readonly string CreatedTimestamp;
        /// <summary>
        /// For optimistic concurrency control.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// Path reference to this group. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/projects/{projectName}/groups/{groupName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// List of machine names that are part of this group.
        /// </summary>
        public readonly ImmutableArray<string> Machines;
        /// <summary>
        /// Name of the group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Type of the object = [Microsoft.Migrate/projects/groups].
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Time when this project was last updated. Date-Time represented in ISO-8601 format.
        /// </summary>
        public readonly string UpdatedTimestamp;

        [OutputConstructor]
        private GetGroupResult(
            ImmutableArray<string> assessments,

            string createdTimestamp,

            string? eTag,

            string id,

            ImmutableArray<string> machines,

            string name,

            string type,

            string updatedTimestamp)
        {
            Assessments = assessments;
            CreatedTimestamp = createdTimestamp;
            ETag = eTag;
            Id = id;
            Machines = machines;
            Name = name;
            Type = type;
            UpdatedTimestamp = updatedTimestamp;
        }
    }
}
