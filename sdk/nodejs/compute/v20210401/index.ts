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
export * from "./disk";
export * from "./diskAccess";
export * from "./diskAccessAPrivateEndpointConnection";
export * from "./diskEncryptionSet";
export * from "./getAvailabilitySet";
export * from "./getCapacityReservation";
export * from "./getCapacityReservationGroup";
export * from "./getDedicatedHost";
export * from "./getDedicatedHostGroup";
export * from "./getDisk";
export * from "./getDiskAccess";
export * from "./getDiskAccessAPrivateEndpointConnection";
export * from "./getDiskEncryptionSet";
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
export * from "../../types/enums/compute/v20210401";

// Import resources to register:
import { AvailabilitySet } from "./availabilitySet";
import { CapacityReservation } from "./capacityReservation";
import { CapacityReservationGroup } from "./capacityReservationGroup";
import { DedicatedHost } from "./dedicatedHost";
import { DedicatedHostGroup } from "./dedicatedHostGroup";
import { Disk } from "./disk";
import { DiskAccess } from "./diskAccess";
import { DiskAccessAPrivateEndpointConnection } from "./diskAccessAPrivateEndpointConnection";
import { DiskEncryptionSet } from "./diskEncryptionSet";
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
            case "azure-native:compute/v20210401:AvailabilitySet":
                return new AvailabilitySet(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:CapacityReservation":
                return new CapacityReservation(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:CapacityReservationGroup":
                return new CapacityReservationGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:DedicatedHost":
                return new DedicatedHost(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:DedicatedHostGroup":
                return new DedicatedHostGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:Disk":
                return new Disk(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:DiskAccess":
                return new DiskAccess(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:DiskAccessAPrivateEndpointConnection":
                return new DiskAccessAPrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:DiskEncryptionSet":
                return new DiskEncryptionSet(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:Image":
                return new Image(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:ProximityPlacementGroup":
                return new ProximityPlacementGroup(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:RestorePoint":
                return new RestorePoint(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:RestorePointCollection":
                return new RestorePointCollection(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:SshPublicKey":
                return new SshPublicKey(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachine":
                return new VirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineExtension":
                return new VirtualMachineExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineRunCommandByVirtualMachine":
                return new VirtualMachineRunCommandByVirtualMachine(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineScaleSet":
                return new VirtualMachineScaleSet(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineScaleSetExtension":
                return new VirtualMachineScaleSetExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineScaleSetVM":
                return new VirtualMachineScaleSetVM(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineScaleSetVMExtension":
                return new VirtualMachineScaleSetVMExtension(name, <any>undefined, { urn })
            case "azure-native:compute/v20210401:VirtualMachineScaleSetVMRunCommand":
                return new VirtualMachineScaleSetVMRunCommand(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "compute/v20210401", _module)
