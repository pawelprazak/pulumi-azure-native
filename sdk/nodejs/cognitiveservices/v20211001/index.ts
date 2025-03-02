// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./account";
export * from "./commitmentPlan";
export * from "./deployment";
export * from "./getAccount";
export * from "./getCommitmentPlan";
export * from "./getDeployment";
export * from "./getPrivateEndpointConnection";
export * from "./listAccountKeys";
export * from "./privateEndpointConnection";

// Export enums:
export * from "../../types/enums/cognitiveservices/v20211001";

// Import resources to register:
import { Account } from "./account";
import { CommitmentPlan } from "./commitmentPlan";
import { Deployment } from "./deployment";
import { PrivateEndpointConnection } from "./privateEndpointConnection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:cognitiveservices/v20211001:Account":
                return new Account(name, <any>undefined, { urn })
            case "azure-native:cognitiveservices/v20211001:CommitmentPlan":
                return new CommitmentPlan(name, <any>undefined, { urn })
            case "azure-native:cognitiveservices/v20211001:Deployment":
                return new Deployment(name, <any>undefined, { urn })
            case "azure-native:cognitiveservices/v20211001:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "cognitiveservices/v20211001", _module)
