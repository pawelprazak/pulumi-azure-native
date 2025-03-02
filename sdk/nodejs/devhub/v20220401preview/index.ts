// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getGitHubOAuth";
export * from "./getWorkflow";
export * from "./workflow";

// Export enums:
export * from "../../types/enums/devhub/v20220401preview";

// Import resources to register:
import { Workflow } from "./workflow";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:devhub/v20220401preview:Workflow":
                return new Workflow(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "devhub/v20220401preview", _module)
