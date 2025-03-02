// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./account";
export * from "./backup";
export * from "./backupPolicy";
export * from "./getAccount";
export * from "./getBackup";
export * from "./getBackupPolicy";
export * from "./getPool";
export * from "./getSnapshot";
export * from "./getSnapshotPolicy";
export * from "./getSubvolume";
export * from "./getSubvolumeMetadata";
export * from "./getVolume";
export * from "./getVolumeGroup";
export * from "./getVolumeQuotaRule";
export * from "./listVolumeReplications";
export * from "./pool";
export * from "./snapshot";
export * from "./snapshotPolicy";
export * from "./subvolume";
export * from "./volume";
export * from "./volumeGroup";
export * from "./volumeQuotaRule";

// Export enums:
export * from "../../types/enums/netapp/v20220101";

// Import resources to register:
import { Account } from "./account";
import { Backup } from "./backup";
import { BackupPolicy } from "./backupPolicy";
import { Pool } from "./pool";
import { Snapshot } from "./snapshot";
import { SnapshotPolicy } from "./snapshotPolicy";
import { Subvolume } from "./subvolume";
import { Volume } from "./volume";
import { VolumeGroup } from "./volumeGroup";
import { VolumeQuotaRule } from "./volumeQuotaRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:netapp/v20220101:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:Backup":
                return new Backup(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:BackupPolicy":
                return new BackupPolicy(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:Pool":
                return new Pool(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:SnapshotPolicy":
                return new SnapshotPolicy(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:Subvolume":
                return new Subvolume(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:Volume":
                return new Volume(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:VolumeGroup":
                return new VolumeGroup(name, <any>undefined, { urn })
            case "azure-native:netapp/v20220101:VolumeQuotaRule":
                return new VolumeQuotaRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "netapp/v20220101", _module)
