// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.CostManagement.V20191101.Outputs
{

    /// <summary>
    /// The destination information for the delivery of the export. To allow access to a storage account, you must register the account's subscription with the Microsoft.CostManagementExports resource provider. This is required once per subscription. When creating an export in the Azure portal, it is done automatically, however API users need to register the subscription. For more information see https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-supported-services .
    /// </summary>
    [OutputType]
    public sealed class ExportDeliveryDestinationResponse
    {
        /// <summary>
        /// The name of the container where exports will be uploaded.
        /// </summary>
        public readonly string Container;
        /// <summary>
        /// The resource id of the storage account where exports will be delivered.
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// The name of the directory where exports will be uploaded.
        /// </summary>
        public readonly string? RootFolderPath;

        [OutputConstructor]
        private ExportDeliveryDestinationResponse(
            string container,

            string resourceId,

            string? rootFolderPath)
        {
            Container = container;
            ResourceId = resourceId;
            RootFolderPath = rootFolderPath;
        }
    }
}
