// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getService";
export * from "./service";

// Export sub-modules:
import * as v20180216preview from "./v20180216preview";
import * as v20190601 from "./v20190601";

export {
    v20180216preview,
    v20190601,
};

// Import resources to register:
import { Service } from "./service";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:windowsiot:Service":
                return new Service(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "windowsiot", _module)
