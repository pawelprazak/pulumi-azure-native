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
export * from "./getVolume";
export * from "./pool";
export * from "./snapshot";
export * from "./snapshotPolicy";
export * from "./volume";

// Export enums:
export * from "../../types/enums/netapp/v20210601";

// Import resources to register:
import { Account } from "./account";
import { Backup } from "./backup";
import { BackupPolicy } from "./backupPolicy";
import { Pool } from "./pool";
import { Snapshot } from "./snapshot";
import { SnapshotPolicy } from "./snapshotPolicy";
import { Volume } from "./volume";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:netapp/v20210601:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:Backup":
                return new Backup(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:BackupPolicy":
                return new BackupPolicy(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:Pool":
                return new Pool(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:SnapshotPolicy":
                return new SnapshotPolicy(name, <any>undefined, { urn })
            case "azure-native:netapp/v20210601:Volume":
                return new Volume(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "netapp/v20210601", _module)
