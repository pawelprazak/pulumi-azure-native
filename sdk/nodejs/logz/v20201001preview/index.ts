// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getMonitor";
export * from "./getSubAccount";
export * from "./getSubAccountTagRule";
export * from "./getTagRule";
export * from "./listMonitorMonitoredResources";
export * from "./listMonitorUserRoles";
export * from "./listMonitorVMHosts";
export * from "./listSubAccountMonitoredResources";
export * from "./listSubAccountVMHosts";
export * from "./monitor";
export * from "./subAccount";
export * from "./subAccountTagRule";
export * from "./tagRule";

// Export enums:
export * from "../../types/enums/logz/v20201001preview";

// Import resources to register:
import { Monitor } from "./monitor";
import { SubAccount } from "./subAccount";
import { SubAccountTagRule } from "./subAccountTagRule";
import { TagRule } from "./tagRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:logz/v20201001preview:Monitor":
                return new Monitor(name, <any>undefined, { urn })
            case "azure-native:logz/v20201001preview:SubAccount":
                return new SubAccount(name, <any>undefined, { urn })
            case "azure-native:logz/v20201001preview:SubAccountTagRule":
                return new SubAccountTagRule(name, <any>undefined, { urn })
            case "azure-native:logz/v20201001preview:TagRule":
                return new TagRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "logz/v20201001preview", _module)
