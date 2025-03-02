// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getRoleAssignment";
export * from "./getRoleDefinition";
export * from "./roleAssignment";
export * from "./roleDefinition";

// Import resources to register:
import { RoleAssignment } from "./roleAssignment";
import { RoleDefinition } from "./roleDefinition";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:authorization/v20150701:RoleAssignment":
                return new RoleAssignment(name, <any>undefined, { urn })
            case "azure-native:authorization/v20150701:RoleDefinition":
                return new RoleDefinition(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "authorization/v20150701", _module)
