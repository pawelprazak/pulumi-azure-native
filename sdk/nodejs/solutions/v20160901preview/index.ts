// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./appliance";
export * from "./applianceDefinition";
export * from "./getAppliance";
export * from "./getApplianceDefinition";

// Export enums:
export * from "../../types/enums/solutions/v20160901preview";

// Import resources to register:
import { Appliance } from "./appliance";
import { ApplianceDefinition } from "./applianceDefinition";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:solutions/v20160901preview:Appliance":
                return new Appliance(name, <any>undefined, { urn })
            case "azure-native:solutions/v20160901preview:ApplianceDefinition":
                return new ApplianceDefinition(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "solutions/v20160901preview", _module)
