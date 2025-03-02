// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./advancedThreatProtection";
export * from "./deviceSecurityGroup";
export * from "./getAdvancedThreatProtection";
export * from "./getDeviceSecurityGroup";
export * from "./getIotSecuritySolution";
export * from "./getSecurityContact";
export * from "./getWorkspaceSetting";
export * from "./iotSecuritySolution";
export * from "./securityContact";
export * from "./workspaceSetting";

// Export enums:
export * from "../../types/enums/security/v20170801preview";

// Import resources to register:
import { AdvancedThreatProtection } from "./advancedThreatProtection";
import { DeviceSecurityGroup } from "./deviceSecurityGroup";
import { IotSecuritySolution } from "./iotSecuritySolution";
import { SecurityContact } from "./securityContact";
import { WorkspaceSetting } from "./workspaceSetting";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:security/v20170801preview:AdvancedThreatProtection":
                return new AdvancedThreatProtection(name, <any>undefined, { urn })
            case "azure-native:security/v20170801preview:DeviceSecurityGroup":
                return new DeviceSecurityGroup(name, <any>undefined, { urn })
            case "azure-native:security/v20170801preview:IotSecuritySolution":
                return new IotSecuritySolution(name, <any>undefined, { urn })
            case "azure-native:security/v20170801preview:SecurityContact":
                return new SecurityContact(name, <any>undefined, { urn })
            case "azure-native:security/v20170801preview:WorkspaceSetting":
                return new WorkspaceSetting(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "security/v20170801preview", _module)
