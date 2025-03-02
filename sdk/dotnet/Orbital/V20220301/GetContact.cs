// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Orbital.V20220301
{
    public static class GetContact
    {
        /// <summary>
        /// Customer creates a contact resource for a spacecraft resource.
        /// </summary>
        public static Task<GetContactResult> InvokeAsync(GetContactArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContactResult>("azure-native:orbital/v20220301:getContact", args ?? new GetContactArgs(), options.WithDefaults());

        /// <summary>
        /// Customer creates a contact resource for a spacecraft resource.
        /// </summary>
        public static Output<GetContactResult> Invoke(GetContactInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetContactResult>("azure-native:orbital/v20220301:getContact", args ?? new GetContactInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetContactArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Contact name.
        /// </summary>
        [Input("contactName", required: true)]
        public string ContactName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Spacecraft ID.
        /// </summary>
        [Input("spacecraftName", required: true)]
        public string SpacecraftName { get; set; } = null!;

        public GetContactArgs()
        {
        }
    }

    public sealed class GetContactInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Contact name.
        /// </summary>
        [Input("contactName", required: true)]
        public Input<string> ContactName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Spacecraft ID.
        /// </summary>
        [Input("spacecraftName", required: true)]
        public Input<string> SpacecraftName { get; set; } = null!;

        public GetContactInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContactResult
    {
        /// <summary>
        /// The configuration associated with the allocated antenna.
        /// </summary>
        public readonly Outputs.ContactsPropertiesResponseAntennaConfiguration AntennaConfiguration;
        /// <summary>
        /// The reference to the contact profile resource.
        /// </summary>
        public readonly Outputs.ContactsPropertiesResponseContactProfile ContactProfile;
        /// <summary>
        /// Azimuth of the antenna at the end of the contact in decimal degrees.
        /// </summary>
        public readonly double EndAzimuthDegrees;
        /// <summary>
        /// Spacecraft elevation above the horizon at contact end.
        /// </summary>
        public readonly double EndElevationDegrees;
        /// <summary>
        /// Any error message while scheduling a contact.
        /// </summary>
        public readonly string ErrorMessage;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Azure Ground Station name.
        /// </summary>
        public readonly string GroundStationName;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Maximum elevation of the antenna during the contact in decimal degrees.
        /// </summary>
        public readonly double MaximumElevationDegrees;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Reservation end time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string ReservationEndTime;
        /// <summary>
        /// Reservation start time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string ReservationStartTime;
        /// <summary>
        /// Receive end time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string RxEndTime;
        /// <summary>
        /// Receive start time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string RxStartTime;
        /// <summary>
        /// Azimuth of the antenna at the start of the contact in decimal degrees.
        /// </summary>
        public readonly double StartAzimuthDegrees;
        /// <summary>
        /// Spacecraft elevation above the horizon at contact start.
        /// </summary>
        public readonly double StartElevationDegrees;
        /// <summary>
        /// Status of a contact.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Transmit end time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string TxEndTime;
        /// <summary>
        /// Transmit start time of a contact (ISO 8601 UTC standard).
        /// </summary>
        public readonly string TxStartTime;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetContactResult(
            Outputs.ContactsPropertiesResponseAntennaConfiguration antennaConfiguration,

            Outputs.ContactsPropertiesResponseContactProfile contactProfile,

            double endAzimuthDegrees,

            double endElevationDegrees,

            string errorMessage,

            string etag,

            string groundStationName,

            string id,

            double maximumElevationDegrees,

            string name,

            string reservationEndTime,

            string reservationStartTime,

            string rxEndTime,

            string rxStartTime,

            double startAzimuthDegrees,

            double startElevationDegrees,

            string status,

            Outputs.SystemDataResponse systemData,

            string txEndTime,

            string txStartTime,

            string type)
        {
            AntennaConfiguration = antennaConfiguration;
            ContactProfile = contactProfile;
            EndAzimuthDegrees = endAzimuthDegrees;
            EndElevationDegrees = endElevationDegrees;
            ErrorMessage = errorMessage;
            Etag = etag;
            GroundStationName = groundStationName;
            Id = id;
            MaximumElevationDegrees = maximumElevationDegrees;
            Name = name;
            ReservationEndTime = reservationEndTime;
            ReservationStartTime = reservationStartTime;
            RxEndTime = rxEndTime;
            RxStartTime = rxStartTime;
            StartAzimuthDegrees = startAzimuthDegrees;
            StartElevationDegrees = startElevationDegrees;
            Status = status;
            SystemData = systemData;
            TxEndTime = txEndTime;
            TxStartTime = txStartTime;
            Type = type;
        }
    }
}
