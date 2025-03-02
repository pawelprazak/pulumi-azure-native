// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.M365SecurityAndCompliance.V20210325Preview
{
    public static class GetprivateLinkServicesForO365ManagementActivityAPI
    {
        /// <summary>
        /// The description of the service.
        /// </summary>
        public static Task<GetprivateLinkServicesForO365ManagementActivityAPIResult> InvokeAsync(GetprivateLinkServicesForO365ManagementActivityAPIArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetprivateLinkServicesForO365ManagementActivityAPIResult>("azure-native:m365securityandcompliance/v20210325preview:getprivateLinkServicesForO365ManagementActivityAPI", args ?? new GetprivateLinkServicesForO365ManagementActivityAPIArgs(), options.WithDefaults());

        /// <summary>
        /// The description of the service.
        /// </summary>
        public static Output<GetprivateLinkServicesForO365ManagementActivityAPIResult> Invoke(GetprivateLinkServicesForO365ManagementActivityAPIInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetprivateLinkServicesForO365ManagementActivityAPIResult>("azure-native:m365securityandcompliance/v20210325preview:getprivateLinkServicesForO365ManagementActivityAPI", args ?? new GetprivateLinkServicesForO365ManagementActivityAPIInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetprivateLinkServicesForO365ManagementActivityAPIArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group that contains the service instance.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetprivateLinkServicesForO365ManagementActivityAPIArgs()
        {
        }
    }

    public sealed class GetprivateLinkServicesForO365ManagementActivityAPIInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group that contains the service instance.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        public GetprivateLinkServicesForO365ManagementActivityAPIInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetprivateLinkServicesForO365ManagementActivityAPIResult
    {
        /// <summary>
        /// An etag associated with the resource, used for optimistic concurrency when editing it.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// The resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Setting indicating whether the service has a managed identity associated with it.
        /// </summary>
        public readonly Outputs.ServicesResourceResponseIdentity? Identity;
        /// <summary>
        /// The kind of the service.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The common properties of a service.
        /// </summary>
        public readonly Outputs.ServicesPropertiesResponse Properties;
        /// <summary>
        /// Required property for system data
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetprivateLinkServicesForO365ManagementActivityAPIResult(
            string? etag,

            string id,

            Outputs.ServicesResourceResponseIdentity? identity,

            string kind,

            string location,

            string name,

            Outputs.ServicesPropertiesResponse properties,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            Id = id;
            Identity = identity;
            Kind = kind;
            Location = location;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
