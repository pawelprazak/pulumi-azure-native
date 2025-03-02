// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AppPlatform.V20201101Preview.Outputs
{

    /// <summary>
    /// App resource properties payload
    /// </summary>
    [OutputType]
    public sealed class AppResourcePropertiesResponse
    {
        /// <summary>
        /// Name of the active deployment of the App
        /// </summary>
        public readonly string? ActiveDeploymentName;
        /// <summary>
        /// Date time when the resource is created
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// Indicate if end to end TLS is enabled.
        /// </summary>
        public readonly bool? EnableEndToEndTLS;
        /// <summary>
        /// Fully qualified dns Name.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// Indicate if only https is allowed.
        /// </summary>
        public readonly bool? HttpsOnly;
        /// <summary>
        /// Persistent disk settings
        /// </summary>
        public readonly Outputs.PersistentDiskResponse? PersistentDisk;
        /// <summary>
        /// Provisioning state of the App
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Indicates whether the App exposes public endpoint
        /// </summary>
        public readonly bool? Public;
        /// <summary>
        /// Temporary disk settings
        /// </summary>
        public readonly Outputs.TemporaryDiskResponse? TemporaryDisk;
        /// <summary>
        /// URL of the App
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private AppResourcePropertiesResponse(
            string? activeDeploymentName,

            string createdTime,

            bool? enableEndToEndTLS,

            string? fqdn,

            bool? httpsOnly,

            Outputs.PersistentDiskResponse? persistentDisk,

            string provisioningState,

            bool? @public,

            Outputs.TemporaryDiskResponse? temporaryDisk,

            string url)
        {
            ActiveDeploymentName = activeDeploymentName;
            CreatedTime = createdTime;
            EnableEndToEndTLS = enableEndToEndTLS;
            Fqdn = fqdn;
            HttpsOnly = httpsOnly;
            PersistentDisk = persistentDisk;
            ProvisioningState = provisioningState;
            Public = @public;
            TemporaryDisk = temporaryDisk;
            Url = url;
        }
    }
}
