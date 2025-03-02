// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ManagementPartner
{
    public static class GetPartner
    {
        /// <summary>
        /// this is the management partner operations response
        /// API Version: 2018-02-01.
        /// </summary>
        public static Task<GetPartnerResult> InvokeAsync(GetPartnerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPartnerResult>("azure-native:managementpartner:getPartner", args ?? new GetPartnerArgs(), options.WithDefaults());

        /// <summary>
        /// this is the management partner operations response
        /// API Version: 2018-02-01.
        /// </summary>
        public static Output<GetPartnerResult> Invoke(GetPartnerInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPartnerResult>("azure-native:managementpartner:getPartner", args ?? new GetPartnerInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPartnerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the Partner
        /// </summary>
        [Input("partnerId", required: true)]
        public string PartnerId { get; set; } = null!;

        public GetPartnerArgs()
        {
        }
    }

    public sealed class GetPartnerInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the Partner
        /// </summary>
        [Input("partnerId", required: true)]
        public Input<string> PartnerId { get; set; } = null!;

        public GetPartnerInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPartnerResult
    {
        /// <summary>
        /// This is the DateTime when the partner was created.
        /// </summary>
        public readonly string? CreatedTime;
        /// <summary>
        /// Type of the partner
        /// </summary>
        public readonly int? Etag;
        /// <summary>
        /// Identifier of the partner
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the partner
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// This is the object id.
        /// </summary>
        public readonly string? ObjectId;
        /// <summary>
        /// This is the partner id
        /// </summary>
        public readonly string? PartnerId;
        /// <summary>
        /// This is the partner name
        /// </summary>
        public readonly string? PartnerName;
        /// <summary>
        /// This is the tenant id.
        /// </summary>
        public readonly string? TenantId;
        /// <summary>
        /// Type of resource. "Microsoft.ManagementPartner/partners"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// This is the DateTime when the partner was updated.
        /// </summary>
        public readonly string? UpdatedTime;
        /// <summary>
        /// This is the version.
        /// </summary>
        public readonly int? Version;

        [OutputConstructor]
        private GetPartnerResult(
            string? createdTime,

            int? etag,

            string id,

            string name,

            string? objectId,

            string? partnerId,

            string? partnerName,

            string? tenantId,

            string type,

            string? updatedTime,

            int? version)
        {
            CreatedTime = createdTime;
            Etag = etag;
            Id = id;
            Name = name;
            ObjectId = objectId;
            PartnerId = partnerId;
            PartnerName = partnerName;
            TenantId = tenantId;
            Type = type;
            UpdatedTime = updatedTime;
            Version = version;
        }
    }
}
