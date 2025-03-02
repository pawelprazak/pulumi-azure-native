// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.StorSimple.V20161001
{
    [Obsolete(@"Version 2016-10-01 will be removed in v2 of the provider.")]
    public static class GetFileServer
    {
        /// <summary>
        /// The file server.
        /// </summary>
        public static Task<GetFileServerResult> InvokeAsync(GetFileServerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFileServerResult>("azure-native:storsimple/v20161001:getFileServer", args ?? new GetFileServerArgs(), options.WithDefaults());

        /// <summary>
        /// The file server.
        /// </summary>
        public static Output<GetFileServerResult> Invoke(GetFileServerInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFileServerResult>("azure-native:storsimple/v20161001:getFileServer", args ?? new GetFileServerInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFileServerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// The file server name.
        /// </summary>
        [Input("fileServerName", required: true)]
        public string FileServerName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public string ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetFileServerArgs()
        {
        }
    }

    public sealed class GetFileServerInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The file server name.
        /// </summary>
        [Input("fileServerName", required: true)]
        public Input<string> FileServerName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public Input<string> ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetFileServerInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFileServerResult
    {
        /// <summary>
        /// The backup policy id.
        /// </summary>
        public readonly string BackupScheduleGroupId;
        /// <summary>
        /// The description of the file server
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Domain of the file server
        /// </summary>
        public readonly string DomainName;
        /// <summary>
        /// The identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The storage domain id.
        /// </summary>
        public readonly string StorageDomainId;
        /// <summary>
        /// The type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetFileServerResult(
            string backupScheduleGroupId,

            string? description,

            string domainName,

            string id,

            string name,

            string storageDomainId,

            string type)
        {
            BackupScheduleGroupId = backupScheduleGroupId;
            Description = description;
            DomainName = domainName;
            Id = id;
            Name = name;
            StorageDomainId = storageDomainId;
            Type = type;
        }
    }
}
