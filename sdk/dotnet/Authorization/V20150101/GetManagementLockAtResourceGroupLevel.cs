// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Authorization.V20150101
{
    [Obsolete(@"Version 2015-01-01 will be removed in v2 of the provider.")]
    public static class GetManagementLockAtResourceGroupLevel
    {
        /// <summary>
        /// Management lock information.
        /// </summary>
        public static Task<GetManagementLockAtResourceGroupLevelResult> InvokeAsync(GetManagementLockAtResourceGroupLevelArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagementLockAtResourceGroupLevelResult>("azure-native:authorization/v20150101:getManagementLockAtResourceGroupLevel", args ?? new GetManagementLockAtResourceGroupLevelArgs(), options.WithDefaults());

        /// <summary>
        /// Management lock information.
        /// </summary>
        public static Output<GetManagementLockAtResourceGroupLevelResult> Invoke(GetManagementLockAtResourceGroupLevelInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetManagementLockAtResourceGroupLevelResult>("azure-native:authorization/v20150101:getManagementLockAtResourceGroupLevel", args ?? new GetManagementLockAtResourceGroupLevelInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagementLockAtResourceGroupLevelArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The lock name.
        /// </summary>
        [Input("lockName", required: true)]
        public string LockName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetManagementLockAtResourceGroupLevelArgs()
        {
        }
    }

    public sealed class GetManagementLockAtResourceGroupLevelInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The lock name.
        /// </summary>
        [Input("lockName", required: true)]
        public Input<string> LockName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetManagementLockAtResourceGroupLevelInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagementLockAtResourceGroupLevelResult
    {
        /// <summary>
        /// The Id of the lock.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The lock level of the management lock.
        /// </summary>
        public readonly string? Level;
        /// <summary>
        /// The name of the lock.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The notes of the management lock.
        /// </summary>
        public readonly string? Notes;
        /// <summary>
        /// The type of the lock.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetManagementLockAtResourceGroupLevelResult(
            string id,

            string? level,

            string? name,

            string? notes,

            string type)
        {
            Id = id;
            Level = level;
            Name = name;
            Notes = notes;
            Type = type;
        }
    }
}
