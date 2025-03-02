// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureArcData.Outputs
{

    /// <summary>
    /// Properties of sqlManagedInstance.
    /// </summary>
    [OutputType]
    public sealed class SqlManagedInstancePropertiesResponse
    {
        /// <summary>
        /// The instance admin user
        /// </summary>
        public readonly string? Admin;
        /// <summary>
        /// Username and password for basic authentication.
        /// </summary>
        public readonly Outputs.BasicLoginInformationResponse? BasicLoginInformation;
        /// <summary>
        /// null
        /// </summary>
        public readonly string? DataControllerId;
        /// <summary>
        /// The instance end time
        /// </summary>
        public readonly string? EndTime;
        /// <summary>
        /// The raw kubernetes information
        /// </summary>
        public readonly object? K8sRaw;
        /// <summary>
        /// Last uploaded date from Kubernetes cluster. Defaults to current date time
        /// </summary>
        public readonly string? LastUploadedDate;
        public readonly string ProvisioningState;
        /// <summary>
        /// The instance start time
        /// </summary>
        public readonly string? StartTime;

        [OutputConstructor]
        private SqlManagedInstancePropertiesResponse(
            string? admin,

            Outputs.BasicLoginInformationResponse? basicLoginInformation,

            string? dataControllerId,

            string? endTime,

            object? k8sRaw,

            string? lastUploadedDate,

            string provisioningState,

            string? startTime)
        {
            Admin = admin;
            BasicLoginInformation = basicLoginInformation;
            DataControllerId = dataControllerId;
            EndTime = endTime;
            K8sRaw = k8sRaw;
            LastUploadedDate = lastUploadedDate;
            ProvisioningState = provisioningState;
            StartTime = startTime;
        }
    }
}
