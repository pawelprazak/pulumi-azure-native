// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20170330.Inputs
{

    /// <summary>
    /// Describes a storage profile.
    /// </summary>
    public sealed class ImageStorageProfileArgs : Pulumi.ResourceArgs
    {
        [Input("dataDisks")]
        private InputList<Inputs.ImageDataDiskArgs>? _dataDisks;

        /// <summary>
        /// Specifies the parameters that are used to add a data disk to a virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// </summary>
        public InputList<Inputs.ImageDataDiskArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.ImageDataDiskArgs>());
            set => _dataDisks = value;
        }

        /// <summary>
        /// Specifies information about the operating system disk used by the virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// </summary>
        [Input("osDisk", required: true)]
        public Input<Inputs.ImageOSDiskArgs> OsDisk { get; set; } = null!;

        public ImageStorageProfileArgs()
        {
        }
    }
}
