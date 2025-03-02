// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Batch.Outputs
{

    [OutputType]
    public sealed class ResourceFileResponse
    {
        /// <summary>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified.
        /// </summary>
        public readonly string? AutoStorageContainerName;
        /// <summary>
        /// The property is valid only when autoStorageContainerName or storageContainerUrl is used. This prefix can be a partial filename or a subdirectory. If a prefix is not specified, all the files in the container will be downloaded.
        /// </summary>
        public readonly string? BlobPrefix;
        /// <summary>
        /// This property applies only to files being downloaded to Linux compute nodes. It will be ignored if it is specified for a resourceFile which will be downloaded to a Windows node. If this property is not specified for a Linux node, then a default value of 0770 is applied to the file.
        /// </summary>
        public readonly string? FileMode;
        /// <summary>
        /// If the httpUrl property is specified, the filePath is required and describes the path which the file will be downloaded to, including the filename. Otherwise, if the autoStorageContainerName or storageContainerUrl property is specified, filePath is optional and is the directory to download the files to. In the case where filePath is used as a directory, any directory structure already associated with the input data will be retained in full and appended to the specified filePath directory. The specified relative path cannot break out of the task's working directory (for example by using '..').
        /// </summary>
        public readonly string? FilePath;
        /// <summary>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. If the URL is Azure Blob Storage, it must be readable using anonymous access; that is, the Batch service does not present any credentials when downloading the blob. There are two ways to get such a URL for a blob in Azure storage: include a Shared Access Signature (SAS) granting read permissions on the blob, or set the ACL for the blob or its container to allow public access.
        /// </summary>
        public readonly string? HttpUrl;
        /// <summary>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. This URL must be readable and listable using anonymous access; that is, the Batch service does not present any credentials when downloading the blob. There are two ways to get such a URL for a blob in Azure storage: include a Shared Access Signature (SAS) granting read and list permissions on the blob, or set the ACL for the blob or its container to allow public access.
        /// </summary>
        public readonly string? StorageContainerUrl;

        [OutputConstructor]
        private ResourceFileResponse(
            string? autoStorageContainerName,

            string? blobPrefix,

            string? fileMode,

            string? filePath,

            string? httpUrl,

            string? storageContainerUrl)
        {
            AutoStorageContainerName = autoStorageContainerName;
            BlobPrefix = blobPrefix;
            FileMode = fileMode;
            FilePath = filePath;
            HttpUrl = httpUrl;
            StorageContainerUrl = storageContainerUrl;
        }
    }
}
