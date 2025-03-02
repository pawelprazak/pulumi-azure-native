// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.SqlVirtualMachine.Outputs
{

    /// <summary>
    /// Storage Configurations for SQL Data, Log and TempDb.
    /// </summary>
    [OutputType]
    public sealed class StorageConfigurationSettingsResponse
    {
        /// <summary>
        /// Disk configuration to apply to SQL Server.
        /// </summary>
        public readonly string? DiskConfigurationType;
        /// <summary>
        /// SQL Server Data Storage Settings.
        /// </summary>
        public readonly Outputs.SQLStorageSettingsResponse? SqlDataSettings;
        /// <summary>
        /// SQL Server Log Storage Settings.
        /// </summary>
        public readonly Outputs.SQLStorageSettingsResponse? SqlLogSettings;
        /// <summary>
        /// SQL Server TempDb Storage Settings.
        /// </summary>
        public readonly Outputs.SQLStorageSettingsResponse? SqlTempDbSettings;
        /// <summary>
        /// Storage workload type.
        /// </summary>
        public readonly string? StorageWorkloadType;

        [OutputConstructor]
        private StorageConfigurationSettingsResponse(
            string? diskConfigurationType,

            Outputs.SQLStorageSettingsResponse? sqlDataSettings,

            Outputs.SQLStorageSettingsResponse? sqlLogSettings,

            Outputs.SQLStorageSettingsResponse? sqlTempDbSettings,

            string? storageWorkloadType)
        {
            DiskConfigurationType = diskConfigurationType;
            SqlDataSettings = sqlDataSettings;
            SqlLogSettings = sqlLogSettings;
            SqlTempDbSettings = sqlTempDbSettings;
            StorageWorkloadType = storageWorkloadType;
        }
    }
}
