// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./availabilitySet";
export * from "./capacityReservation";
export * from "./capacityReservationGroup";
export * from "./dedicatedHost";
export * from "./dedicatedHostGroup";
export * from "./gallery";
export * from "./galleryApplication";
export * from "./galleryApplicationVersion";
export * from "./galleryImage";
export * from "./galleryImageVersion";
export * from "./getAvailabilitySet";
export * from "./getCapacityReservation";
export * from "./getCapacityReservationGroup";
export * from "./getDedicatedHost";
export * from "./getDedicatedHostGroup";
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
export * from "../../types/enums/compute/v20210701";

// Import resources to register:
import { AvailabilitySet } from "./availabilitySet";
import { CapacityReservation } from "./capacityReservation";
import { CapacityReservationGroup } from "./capacityReservationGroup";
import { DedicatedHost } from "./dedicatedHost";
import { DedicatedHostGroup } from "./dedicatedHostGroup";
import { Gallery } from "./gallery";
import { GalleryApplication } from "./galleryApplication";
import { GalleryApplicationVersion } from "./galleryApplicationVersion";
import { GalleryImage } from "./galleryImage";
import { GalleryImageVersion } from "./galleryImageVersion";
import { Image } from "./image";
import { ProximityPlacementGroup } from "./proximityPlacementGroup";
import { RestorePoint } from "./restorePoint";
import { RestorePointCollection } from "./restorePointCollection";
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
            case "azure-native:compute/v20210701:AvailabilitySet":
                return new AvailabilitySet(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:CapacityReservation":
                return new CapacityReservation(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:CapacityReservationGroup":
                return new CapacityReservationGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:DedicatedHost":
                return new DedicatedHost(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:DedicatedHostGroup":
                return new DedicatedHostGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:Gallery":
                return new Gallery(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:GalleryApplication":
                return new GalleryApplication(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:GalleryApplicationVersion":
                return new GalleryApplicationVersion(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:GalleryImage":
                return new GalleryImage(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:GalleryImageVersion":
                return new GalleryImageVersion(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:Image":
                return new Image(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:ProximityPlacementGroup":
                return new ProximityPlacementGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:RestorePoint":
                return new RestorePoint(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:RestorePointCollection":
                return new RestorePointCollection(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:SshPublicKey":
                return new SshPublicKey(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachine":
                return new VirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineExtension":
                return new VirtualMachineExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineRunCommandByVirtualMachine":
                return new VirtualMachineRunCommandByVirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineScaleSet":
                return new VirtualMachineScaleSet(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineScaleSetExtension":
                return new VirtualMachineScaleSetExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineScaleSetVM":
                return new VirtualMachineScaleSetVM(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineScaleSetVMExtension":
                return new VirtualMachineScaleSetVMExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210701:VirtualMachineScaleSetVMRunCommand":
                return new VirtualMachineScaleSetVMRunCommand(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "compute/v20210701", _module)
