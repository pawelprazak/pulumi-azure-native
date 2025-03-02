// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./bandwidthSchedule";
export * from "./device";
export * from "./fileEventTrigger";
export * from "./getBandwidthSchedule";
export * from "./getDevice";
export * from "./getDeviceExtendedInformation";
export * from "./getFileEventTrigger";
export * from "./getIoTRole";
export * from "./getOrder";
export * from "./getPeriodicTimerEventTrigger";
export * from "./getRole";
export * from "./getShare";
export * from "./getStorageAccountCredential";
export * from "./getTrigger";
export * from "./getUser";
export * from "./ioTRole";
export * from "./order";
export * from "./periodicTimerEventTrigger";
export * from "./role";
export * from "./share";
export * from "./storageAccountCredential";
export * from "./trigger";
export * from "./user";

// Export enums:
export * from "../../types/enums/databoxedge/v20190701";

// Import resources to register:
import { BandwidthSchedule } from "./bandwidthSchedule";
import { Device } from "./device";
import { FileEventTrigger } from "./fileEventTrigger";
import { IoTRole } from "./ioTRole";
import { Order } from "./order";
import { PeriodicTimerEventTrigger } from "./periodicTimerEventTrigger";
import { Role } from "./role";
import { Share } from "./share";
import { StorageAccountCredential } from "./storageAccountCredential";
import { Trigger } from "./trigger";
import { User } from "./user";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:databoxedge/v20190701:BandwidthSchedule":
                return new BandwidthSchedule(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:Device":
                return new Device(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:FileEventTrigger":
                return new FileEventTrigger(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:IoTRole":
                return new IoTRole(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:Order":
                return new Order(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:PeriodicTimerEventTrigger":
                return new PeriodicTimerEventTrigger(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:Role":
                return new Role(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:Share":
                return new Share(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:StorageAccountCredential":
                return new StorageAccountCredential(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:Trigger":
                return new Trigger(name, <any>undefined, { urn })
            case "azure-native:databoxedge/v20190701:User":
                return new User(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "databoxedge/v20190701", _module)
