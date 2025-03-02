// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20220401.Inputs
{

    /// <summary>
    /// Storage profile for the container service cluster.
    /// </summary>
    public sealed class ManagedClusterStorageProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AzureDisk CSI Driver settings for the storage profile.
        /// </summary>
        [Input("diskCSIDriver")]
        public Input<Inputs.ManagedClusterStorageProfileDiskCSIDriverArgs>? DiskCSIDriver { get; set; }

        /// <summary>
        /// AzureFile CSI Driver settings for the storage profile.
        /// </summary>
        [Input("fileCSIDriver")]
        public Input<Inputs.ManagedClusterStorageProfileFileCSIDriverArgs>? FileCSIDriver { get; set; }

        /// <summary>
        /// Snapshot Controller settings for the storage profile.
        /// </summary>
        [Input("snapshotController")]
        public Input<Inputs.ManagedClusterStorageProfileSnapshotControllerArgs>? SnapshotController { get; set; }

        public ManagedClusterStorageProfileArgs()
        {
        }
    }
}
