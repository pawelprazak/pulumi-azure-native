// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getMonitor";
export * from "./getTagRule";
export * from "./listDeploymentInfo";
export * from "./listMonitoredResource";
export * from "./listVMHost";
export * from "./monitor";
export * from "./tagRule";

// Export enums:
export * from "../../types/enums/elastic/v20200701preview";

// Import resources to register:
import { Monitor } from "./monitor";
import { TagRule } from "./tagRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:elastic/v20200701preview:Monitor":
                return new Monitor(name, <any>undefined, { urn })
            case "azure-native:elastic/v20200701preview:TagRule":
                return new TagRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "elastic/v20200701preview", _module)
