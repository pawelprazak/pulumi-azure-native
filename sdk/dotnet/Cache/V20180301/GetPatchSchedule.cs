// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Cache.V20180301
{
    [Obsolete(@"Version 2018-03-01 will be removed in v2 of the provider.")]
    public static class GetPatchSchedule
    {
        /// <summary>
        /// Response to put/get patch schedules for Redis cache.
        /// </summary>
        public static Task<GetPatchScheduleResult> InvokeAsync(GetPatchScheduleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPatchScheduleResult>("azure-native:cache/v20180301:getPatchSchedule", args ?? new GetPatchScheduleArgs(), options.WithDefaults());

        /// <summary>
        /// Response to put/get patch schedules for Redis cache.
        /// </summary>
        public static Output<GetPatchScheduleResult> Invoke(GetPatchScheduleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPatchScheduleResult>("azure-native:cache/v20180301:getPatchSchedule", args ?? new GetPatchScheduleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPatchScheduleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Default string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("default", required: true)]
        public string Default { get; set; } = null!;

        /// <summary>
        /// The name of the redis cache.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPatchScheduleArgs()
        {
        }
    }

    public sealed class GetPatchScheduleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Default string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("default", required: true)]
        public Input<string> Default { get; set; } = null!;

        /// <summary>
        /// The name of the redis cache.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetPatchScheduleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPatchScheduleResult
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of patch schedules for a Redis cache.
        /// </summary>
        public readonly ImmutableArray<Outputs.ScheduleEntryResponse> ScheduleEntries;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPatchScheduleResult(
            string id,

            string name,

            ImmutableArray<Outputs.ScheduleEntryResponse> scheduleEntries,

            string type)
        {
            Id = id;
            Name = name;
            ScheduleEntries = scheduleEntries;
            Type = type;
        }
    }
}
