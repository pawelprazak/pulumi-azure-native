// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Synapse.V20210301
{
    public static class GetWorkspaceSqlAadAdmin
    {
        /// <summary>
        /// Workspace active directory administrator
        /// </summary>
        public static Task<GetWorkspaceSqlAadAdminResult> InvokeAsync(GetWorkspaceSqlAadAdminArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWorkspaceSqlAadAdminResult>("azure-native:synapse/v20210301:getWorkspaceSqlAadAdmin", args ?? new GetWorkspaceSqlAadAdminArgs(), options.WithDefaults());

        /// <summary>
        /// Workspace active directory administrator
        /// </summary>
        public static Output<GetWorkspaceSqlAadAdminResult> Invoke(GetWorkspaceSqlAadAdminInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetWorkspaceSqlAadAdminResult>("azure-native:synapse/v20210301:getWorkspaceSqlAadAdmin", args ?? new GetWorkspaceSqlAadAdminInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWorkspaceSqlAadAdminArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetWorkspaceSqlAadAdminArgs()
        {
        }
    }

    public sealed class GetWorkspaceSqlAadAdminInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public GetWorkspaceSqlAadAdminInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWorkspaceSqlAadAdminResult
    {
        /// <summary>
        /// Workspace active directory administrator type
        /// </summary>
        public readonly string? AdministratorType;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Login of the workspace active directory administrator
        /// </summary>
        public readonly string? Login;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Object ID of the workspace active directory administrator
        /// </summary>
        public readonly string? Sid;
        /// <summary>
        /// Tenant ID of the workspace active directory administrator
        /// </summary>
        public readonly string? TenantId;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWorkspaceSqlAadAdminResult(
            string? administratorType,

            string id,

            string? login,

            string name,

            string? sid,

            string? tenantId,

            string type)
        {
            AdministratorType = administratorType;
            Id = id;
            Login = login;
            Name = name;
            Sid = sid;
            TenantId = tenantId;
            Type = type;
        }
    }
}
