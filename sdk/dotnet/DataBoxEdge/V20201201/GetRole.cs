// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DataBoxEdge.V20201201
{
    [Obsolete(@"Please use one of the variants: CloudEdgeManagementRole, IoTRole, KubernetesRole, MECRole.")]
    public static class GetRole
    {
        /// <summary>
        /// Compute role.
        /// </summary>
        public static Task<GetRoleResult> InvokeAsync(GetRoleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleResult>("azure-native:databoxedge/v20201201:getRole", args ?? new GetRoleArgs(), options.WithDefaults());

        /// <summary>
        /// Compute role.
        /// </summary>
        public static Output<GetRoleResult> Invoke(GetRoleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetRoleResult>("azure-native:databoxedge/v20201201:getRole", args ?? new GetRoleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRoleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// The role name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetRoleArgs()
        {
        }
    }

    public sealed class GetRoleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The role name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetRoleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRoleResult
    {
        /// <summary>
        /// The path ID that uniquely identifies the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Role type.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The object name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Role configured on ASE resource
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetRoleResult(
            string id,

            string kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            Type = type;
        }
    }
}
