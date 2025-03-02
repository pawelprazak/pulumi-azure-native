// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./availabilitySet";
export * from "./capacityReservation";
export * from "./capacityReservationGroup";
export * from "./cloudService";
export * from "./dedicatedHost";
export * from "./dedicatedHostGroup";
export * from "./disk";
export * from "./diskAccess";
export * from "./diskAccessAPrivateEndpointConnection";
export * from "./diskEncryptionSet";
export * from "./gallery";
export * from "./galleryApplication";
export * from "./galleryApplicationVersion";
export * from "./galleryImage";
export * from "./galleryImageVersion";
export * from "./getAvailabilitySet";
export * from "./getCapacityReservation";
export * from "./getCapacityReservationGroup";
export * from "./getCloudService";
export * from "./getDedicatedHost";
export * from "./getDedicatedHostGroup";
export * from "./getDisk";
export * from "./getDiskAccess";
export * from "./getDiskAccessAPrivateEndpointConnection";
export * from "./getDiskEncryptionSet";
export * from "./getGallery";
export * from "./getGalleryApplication";
export * from "./getGalleryApplicationVersion";
export * from "./getGalleryImage";
export * from "./getGalleryImageVersion";
export * from "./getImage";
export * from "./getLogAnalyticExportRequestRateByInterval";
export * from "./getLogAnalyticExportThrottledRequests";
export * from "./getProximityPlacementGroup";
export * from "./getRestorePoint";
export * from "./getRestorePointCollection";
export * from "./getSnapshot";
export * from "./getSshPublicKey";
export * from "./getVirtualMachine";
export * from "./getVirtualMachineExtension";
export * from "./getVirtualMachineRunCommandByVirtualMachine";
export * from "./getVirtualMachineScaleSet";
export * from "./getVirtualMachineScaleSetExtension";
export * from "./getVirtualMachineScaleSetVM";
export * from "./getVirtualMachineScaleSetVMExtension";
export * from "./getVirtualMachineScaleSetVMRunCommand";
export * from "./image";
export * from "./proximityPlacementGroup";
export * from "./restorePoint";
export * from "./restorePointCollection";
export * from "./snapshot";
export * from "./sshPublicKey";
export * from "./virtualMachine";
export * from "./virtualMachineExtension";
export * from "./virtualMachineRunCommandByVirtualMachine";
export * from "./virtualMachineScaleSet";
export * from "./virtualMachineScaleSetExtension";
export * from "./virtualMachineScaleSetVM";
export * from "./virtualMachineScaleSetVMExtension";
export * from "./virtualMachineScaleSetVMRunCommand";

// Export enums:
export * from "../types/enums/compute";

// Export sub-modules:
import * as v20150615 from "./v20150615";
import * as v20160330 from "./v20160330";
import * as v20160430preview from "./v20160430preview";
import * as v20170330 from "./v20170330";
import * as v20171201 from "./v20171201";
import * as v20180401 from "./v20180401";
import * as v20180601 from "./v20180601";
import * as v20180930 from "./v20180930";
import * as v20181001 from "./v20181001";
import * as v20190301 from "./v20190301";
import * as v20190701 from "./v20190701";
import * as v20191101 from "./v20191101";
import * as v20191201 from "./v20191201";
import * as v20200501 from "./v20200501";
import * as v20200601 from "./v20200601";
import * as v20200630 from "./v20200630";
import * as v20200930 from "./v20200930";
import * as v20201001preview from "./v20201001preview";
import * as v20201201 from "./v20201201";
import * as v20210301 from "./v20210301";
import * as v20210401 from "./v20210401";
import * as v20210701 from "./v20210701";
import * as v20210801 from "./v20210801";
import * as v20211001 from "./v20211001";
import * as v20211101 from "./v20211101";
import * as v20211201 from "./v20211201";

export {
    v20150615,
    v20160330,
    v20160430preview,
    v20170330,
    v20171201,
    v20180401,
    v20180601,
    v20180930,
    v20181001,
    v20190301,
    v20190701,
    v20191101,
    v20191201,
    v20200501,
    v20200601,
    v20200630,
    v20200930,
    v20201001preview,
    v20201201,
    v20210301,
    v20210401,
    v20210701,
    v20210801,
    v20211001,
    v20211101,
    v20211201,
};

// Import resources to register:
import { AvailabilitySet } from "./availabilitySet";
import { CapacityReservation } from "./capacityReservation";
import { CapacityReservationGroup } from "./capacityReservationGroup";
import { CloudService } from "./cloudService";
import { DedicatedHost } from "./dedicatedHost";
import { DedicatedHostGroup } from "./dedicatedHostGroup";
import { Disk } from "./disk";
import { DiskAccess } from "./diskAccess";
import { DiskAccessAPrivateEndpointConnection } from "./diskAccessAPrivateEndpointConnection";
import { DiskEncryptionSet } from "./diskEncryptionSet";
import { Gallery } from "./gallery";
import { GalleryApplication } from "./galleryApplication";
import { GalleryApplicationVersion } from "./galleryApplicationVersion";
import { GalleryImage } from "./galleryImage";
import { GalleryImageVersion } from "./galleryImageVersion";
import { Image } from "./image";
import { ProximityPlacementGroup } from "./proximityPlacementGroup";
import { RestorePoint } from "./restorePoint";
import { RestorePointCollection } from "./restorePointCollection";
import { Snapshot } from "./snapshot";
import { SshPublicKey } from "./sshPublicKey";
import { VirtualMachine } from "./virtualMachine";
import { VirtualMachineExtension } from "./virtualMachineExtension";
import { VirtualMachineRunCommandByVirtualMachine } from "./virtualMachineRunCommandByVirtualMachine";
import { VirtualMachineScaleSet } from "./virtualMachineScaleSet";
import { VirtualMachineScaleSetExtension } from "./virtualMachineScaleSetExtension";
import { VirtualMachineScaleSetVM } from "./virtualMachineScaleSetVM";
import { VirtualMachineScaleSetVMExtension } from "./virtualMachineScaleSetVMExtension";
import { VirtualMachineScaleSetVMRunCommand } from "./virtualMachineScaleSetVMRunCommand";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:compute:AvailabilitySet":
                return new AvailabilitySet(name, <any>undefined, { urn })
            case "azure-native:compute:CapacityReservation":
                return new CapacityReservation(name, <any>undefined, { urn })
            case "azure-native:compute:CapacityReservationGroup":
                return new CapacityReservationGroup(name, <any>undefined, { urn })
            case "azure-native:compute:CloudService":
                return new CloudService(name, <any>undefined, { urn })
            case "azure-native:compute:DedicatedHost":
                return new DedicatedHost(name, <any>undefined, { urn })
            case "azure-native:compute:DedicatedHostGroup":
                return new DedicatedHostGroup(name, <any>undefined, { urn })
            case "azure-native:compute:Disk":
                return new Disk(name, <any>undefined, { urn })
            case "azure-native:compute:DiskAccess":
                return new DiskAccess(name, <any>undefined, { urn })
            case "azure-native:compute:DiskAccessAPrivateEndpointConnection":
                return new DiskAccessAPrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:compute:DiskEncryptionSet":
                return new DiskEncryptionSet(name, <any>undefined, { urn })
            case "azure-native:compute:Gallery":
                return new Gallery(name, <any>undefined, { urn })
            case "azure-native:compute:GalleryApplication":
                return new GalleryApplication(name, <any>undefined, { urn })
            case "azure-native:compute:GalleryApplicationVersion":
                return new GalleryApplicationVersion(name, <any>undefined, { urn })
            case "azure-native:compute:GalleryImage":
                return new GalleryImage(name, <any>undefined, { urn })
            case "azure-native:compute:GalleryImageVersion":
                return new GalleryImageVersion(name, <any>undefined, { urn })
            case "azure-native:compute:Image":
                return new Image(name, <any>undefined, { urn })
            case "azure-native:compute:ProximityPlacementGroup":
                return new ProximityPlacementGroup(name, <any>undefined, { urn })
            case "azure-native:compute:RestorePoint":
                return new RestorePoint(name, <any>undefined, { urn })
            case "azure-native:compute:RestorePointCollection":
                return new RestorePointCollection(name, <any>undefined, { urn })
            case "azure-native:compute:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:compute:SshPublicKey":
                return new SshPublicKey(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachine":
                return new VirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineExtension":
                return new VirtualMachineExtension(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineRunCommandByVirtualMachine":
                return new VirtualMachineRunCommandByVirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineScaleSet":
                return new VirtualMachineScaleSet(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineScaleSetExtension":
                return new VirtualMachineScaleSetExtension(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineScaleSetVM":
                return new VirtualMachineScaleSetVM(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineScaleSetVMExtension":
                return new VirtualMachineScaleSetVMExtension(name, <any>undefined, { urn })
            case "azure-native:compute:VirtualMachineScaleSetVMRunCommand":
                return new VirtualMachineScaleSetVMRunCommand(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "compute", _module)
