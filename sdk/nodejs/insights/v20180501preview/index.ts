// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./component";
export * from "./getComponent";
export * from "./getProactiveDetectionConfiguration";
export * from "./getWebTest";
export * from "./proactiveDetectionConfiguration";
export * from "./webTest";

// Export enums:
export * from "../../types/enums/insights/v20180501preview";

// Import resources to register:
import { Component } from "./component";
import { ProactiveDetectionConfiguration } from "./proactiveDetectionConfiguration";
import { WebTest } from "./webTest";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:insights/v20180501preview:Component":
                return new Component(name, <any>undefined, { urn })
            case "azure-native:insights/v20180501preview:ProactiveDetectionConfiguration":
                return new ProactiveDetectionConfiguration(name, <any>undefined, { urn })
            case "azure-native:insights/v20180501preview:WebTest":
                return new WebTest(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "insights/v20180501preview", _module)
