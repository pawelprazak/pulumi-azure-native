// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DBforPostgreSQL.V20171201
{
    public static class GetServerAdministrator
    {
        /// <summary>
        /// Represents a and external administrator to be created.
        /// </summary>
        public static Task<GetServerAdministratorResult> InvokeAsync(GetServerAdministratorArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServerAdministratorResult>("azure-native:dbforpostgresql/v20171201:getServerAdministrator", args ?? new GetServerAdministratorArgs(), options.WithDefaults());

        /// <summary>
        /// Represents a and external administrator to be created.
        /// </summary>
        public static Output<GetServerAdministratorResult> Invoke(GetServerAdministratorInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServerAdministratorResult>("azure-native:dbforpostgresql/v20171201:getServerAdministrator", args ?? new GetServerAdministratorInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServerAdministratorArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public string ServerName { get; set; } = null!;

        public GetServerAdministratorArgs()
        {
        }
    }

    public sealed class GetServerAdministratorInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        public GetServerAdministratorInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServerAdministratorResult
    {
        /// <summary>
        /// The type of administrator.
        /// </summary>
        public readonly string AdministratorType;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The server administrator login account name.
        /// </summary>
        public readonly string Login;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The server administrator Sid (Secure ID).
        /// </summary>
        public readonly string Sid;
        /// <summary>
        /// The server Active Directory Administrator tenant id.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetServerAdministratorResult(
            string administratorType,

            string id,

            string login,

            string name,

            string sid,

            string tenantId,

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
