// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerRegistry.V20170601Preview.Outputs
{

    /// <summary>
    /// The properties of a storage account for a container registry. Only applicable to Basic SKU.
    /// </summary>
    [OutputType]
    public sealed class StorageAccountPropertiesResponse
    {
        /// <summary>
        /// The resource ID of the storage account.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private StorageAccountPropertiesResponse(string id)
        {
            Id = id;
        }
    }
}
