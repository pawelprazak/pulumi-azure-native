// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads
{
    public static class GetSAPDatabaseInstance
    {
        /// <summary>
        /// Define the SAP Database Instance.
        /// API Version: 2021-12-01-preview.
        /// </summary>
        public static Task<GetSAPDatabaseInstanceResult> InvokeAsync(GetSAPDatabaseInstanceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSAPDatabaseInstanceResult>("azure-native:workloads:getSAPDatabaseInstance", args ?? new GetSAPDatabaseInstanceArgs(), options.WithDefaults());

        /// <summary>
        /// Define the SAP Database Instance.
        /// API Version: 2021-12-01-preview.
        /// </summary>
        public static Output<GetSAPDatabaseInstanceResult> Invoke(GetSAPDatabaseInstanceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSAPDatabaseInstanceResult>("azure-native:workloads:getSAPDatabaseInstance", args ?? new GetSAPDatabaseInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSAPDatabaseInstanceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Database Instance string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("databaseInstanceName", required: true)]
        public string DatabaseInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Instances for SAP.
        /// </summary>
        [Input("sapVirtualInstanceName", required: true)]
        public string SapVirtualInstanceName { get; set; } = null!;

        public GetSAPDatabaseInstanceArgs()
        {
        }
    }

    public sealed class GetSAPDatabaseInstanceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Database Instance string modeled as parameter for auto generation to work correctly.
        /// </summary>
        [Input("databaseInstanceName", required: true)]
        public Input<string> DatabaseInstanceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Virtual Instances for SAP.
        /// </summary>
        [Input("sapVirtualInstanceName", required: true)]
        public Input<string> SapVirtualInstanceName { get; set; } = null!;

        public GetSAPDatabaseInstanceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSAPDatabaseInstanceResult
    {
        /// <summary>
        /// The database SID.
        /// </summary>
        public readonly string DatabaseSid;
        /// <summary>
        /// The SAP database type.
        /// </summary>
        public readonly string DatabaseType;
        /// <summary>
        /// Defines the Database Instance errors.
        /// </summary>
        public readonly Outputs.SAPVirtualInstanceErrorResponse Errors;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The database IP Address.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the provisioning states.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Defines the SAP Instance status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The database subnet.
        /// </summary>
        public readonly string Subnet;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The list of virtual machines.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatabaseVmDetailsResponse> VmDetails;

        [OutputConstructor]
        private GetSAPDatabaseInstanceResult(
            string databaseSid,

            string databaseType,

            Outputs.SAPVirtualInstanceErrorResponse errors,

            string id,

            string ipAddress,

            string location,

            string name,

            string provisioningState,

            string status,

            string subnet,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.DatabaseVmDetailsResponse> vmDetails)
        {
            DatabaseSid = databaseSid;
            DatabaseType = databaseType;
            Errors = errors;
            Id = id;
            IpAddress = ipAddress;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Status = status;
            Subnet = subnet;
            SystemData = systemData;
            Tags = tags;
            Type = type;
            VmDetails = vmDetails;
        }
    }
}
