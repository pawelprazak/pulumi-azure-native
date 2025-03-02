// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getRoleAssignment";
export * from "./roleAssignment";

// Export enums:
export * from "../../types/enums/authorization/v20200301preview";

// Import resources to register:
import { RoleAssignment } from "./roleAssignment";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:authorization/v20200301preview:RoleAssignment":
                return new RoleAssignment(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "authorization/v20200301preview", _module)
