// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.NotificationHubs
{
    public static class GetNotificationHub
    {
        /// <summary>
        /// Description of a NotificationHub Resource.
        /// API Version: 2017-04-01.
        /// </summary>
        public static Task<GetNotificationHubResult> InvokeAsync(GetNotificationHubArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNotificationHubResult>("azure-native:notificationhubs:getNotificationHub", args ?? new GetNotificationHubArgs(), options.WithDefaults());

        /// <summary>
        /// Description of a NotificationHub Resource.
        /// API Version: 2017-04-01.
        /// </summary>
        public static Output<GetNotificationHubResult> Invoke(GetNotificationHubInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetNotificationHubResult>("azure-native:notificationhubs:getNotificationHub", args ?? new GetNotificationHubInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNotificationHubArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The notification hub name.
        /// </summary>
        [Input("notificationHubName", required: true)]
        public string NotificationHubName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetNotificationHubArgs()
        {
        }
    }

    public sealed class GetNotificationHubInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The notification hub name.
        /// </summary>
        [Input("notificationHubName", required: true)]
        public Input<string> NotificationHubName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetNotificationHubInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNotificationHubResult
    {
        /// <summary>
        /// The AdmCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.AdmCredentialResponse? AdmCredential;
        /// <summary>
        /// The ApnsCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.ApnsCredentialResponse? ApnsCredential;
        /// <summary>
        /// The AuthorizationRules of the created NotificationHub
        /// </summary>
        public readonly ImmutableArray<Outputs.SharedAccessAuthorizationRulePropertiesResponse> AuthorizationRules;
        /// <summary>
        /// The BaiduCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.BaiduCredentialResponse? BaiduCredential;
        /// <summary>
        /// The GcmCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.GcmCredentialResponse? GcmCredential;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The MpnsCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.MpnsCredentialResponse? MpnsCredential;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The RegistrationTtl of the created NotificationHub
        /// </summary>
        public readonly string? RegistrationTtl;
        /// <summary>
        /// The sku of the created namespace
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The WnsCredential of the created NotificationHub
        /// </summary>
        public readonly Outputs.WnsCredentialResponse? WnsCredential;

        [OutputConstructor]
        private GetNotificationHubResult(
            Outputs.AdmCredentialResponse? admCredential,

            Outputs.ApnsCredentialResponse? apnsCredential,

            ImmutableArray<Outputs.SharedAccessAuthorizationRulePropertiesResponse> authorizationRules,

            Outputs.BaiduCredentialResponse? baiduCredential,

            Outputs.GcmCredentialResponse? gcmCredential,

            string id,

            string? location,

            Outputs.MpnsCredentialResponse? mpnsCredential,

            string name,

            string? registrationTtl,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.WnsCredentialResponse? wnsCredential)
        {
            AdmCredential = admCredential;
            ApnsCredential = apnsCredential;
            AuthorizationRules = authorizationRules;
            BaiduCredential = baiduCredential;
            GcmCredential = gcmCredential;
            Id = id;
            Location = location;
            MpnsCredential = mpnsCredential;
            Name = name;
            RegistrationTtl = registrationTtl;
            Sku = sku;
            Tags = tags;
            Type = type;
            WnsCredential = wnsCredential;
        }
    }
}
