// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./getSerialPort";
export * from "./serialPort";

// Export enums:
export * from "../types/enums/serialconsole";

// Export sub-modules:
import * as v20180501 from "./v20180501";

export {
    v20180501,
};

// Import resources to register:
import { SerialPort } from "./serialPort";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:serialconsole:SerialPort":
                return new SerialPort(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "serialconsole", _module)
