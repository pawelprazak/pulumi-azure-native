// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./azureADMetric";
export * from "./diagnosticSetting";
export * from "./getDiagnosticSetting";
export * from "./getPrivateEndpointConnection";
export * from "./getazureADMetric";
export * from "./getprivateLinkForAzureAd";
export * from "./privateEndpointConnection";
export * from "./privateLinkForAzureAd";

// Export enums:
export * from "../types/enums/aadiam";

// Export sub-modules:
import * as v20170401 from "./v20170401";
import * as v20170401preview from "./v20170401preview";
import * as v20200301 from "./v20200301";
import * as v20200301preview from "./v20200301preview";
import * as v20200701preview from "./v20200701preview";

export {
    v20170401,
    v20170401preview,
    v20200301,
    v20200301preview,
    v20200701preview,
};

// Import resources to register:
import { DiagnosticSetting } from "./diagnosticSetting";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { AzureADMetric } from "./azureADMetric";
import { PrivateLinkForAzureAd } from "./privateLinkForAzureAd";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:aadiam:DiagnosticSetting":
                return new DiagnosticSetting(name, <any>undefined, { urn })
            case "azure-native:aadiam:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:aadiam:azureADMetric":
                return new AzureADMetric(name, <any>undefined, { urn })
            case "azure-native:aadiam:privateLinkForAzureAd":
                return new PrivateLinkForAzureAd(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "aadiam", _module)
