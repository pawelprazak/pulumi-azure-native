// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureArcData.V20210701Preview
{
    public static class GetSqlServerInstance
    {
        /// <summary>
        /// A SqlServerInstance.
        /// </summary>
        public static Task<GetSqlServerInstanceResult> InvokeAsync(GetSqlServerInstanceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSqlServerInstanceResult>("azure-native:azurearcdata/v20210701preview:getSqlServerInstance", args ?? new GetSqlServerInstanceArgs(), options.WithDefaults());

        /// <summary>
        /// A SqlServerInstance.
        /// </summary>
        public static Output<GetSqlServerInstanceResult> Invoke(GetSqlServerInstanceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSqlServerInstanceResult>("azure-native:azurearcdata/v20210701preview:getSqlServerInstance", args ?? new GetSqlServerInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSqlServerInstanceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Azure resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of SQL Server Instance
        /// </summary>
        [Input("sqlServerInstanceName", required: true)]
        public string SqlServerInstanceName { get; set; } = null!;

        public GetSqlServerInstanceArgs()
        {
        }
    }

    public sealed class GetSqlServerInstanceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Azure resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of SQL Server Instance
        /// </summary>
        [Input("sqlServerInstanceName", required: true)]
        public Input<string> SqlServerInstanceName { get; set; } = null!;

        public GetSqlServerInstanceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSqlServerInstanceResult
    {
        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// null
        /// </summary>
        public readonly Outputs.SqlServerInstancePropertiesResponse Properties;
        /// <summary>
        /// Read only system data
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSqlServerInstanceResult(
            string id,

            string location,

            string name,

            Outputs.SqlServerInstancePropertiesResponse properties,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
