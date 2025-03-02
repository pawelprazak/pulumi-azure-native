// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getRemediationAtManagementGroup";
export * from "./getRemediationAtResource";
export * from "./getRemediationAtResourceGroup";
export * from "./getRemediationAtSubscription";
export * from "./listRemediationDeploymentsAtManagementGroup";
export * from "./listRemediationDeploymentsAtResource";
export * from "./listRemediationDeploymentsAtResourceGroup";
export * from "./listRemediationDeploymentsAtSubscription";
export * from "./remediationAtManagementGroup";
export * from "./remediationAtResource";
export * from "./remediationAtResourceGroup";
export * from "./remediationAtSubscription";

// Export enums:
export * from "../../types/enums/policyinsights/v20211001";

// Import resources to register:
import { RemediationAtManagementGroup } from "./remediationAtManagementGroup";
import { RemediationAtResource } from "./remediationAtResource";
import { RemediationAtResourceGroup } from "./remediationAtResourceGroup";
import { RemediationAtSubscription } from "./remediationAtSubscription";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:policyinsights/v20211001:RemediationAtManagementGroup":
                return new RemediationAtManagementGroup(name, <any>undefined, { urn })
            case "azure-native:policyinsights/v20211001:RemediationAtResource":
                return new RemediationAtResource(name, <any>undefined, { urn })
            case "azure-native:policyinsights/v20211001:RemediationAtResourceGroup":
                return new RemediationAtResourceGroup(name, <any>undefined, { urn })
            case "azure-native:policyinsights/v20211001:RemediationAtSubscription":
                return new RemediationAtSubscription(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "policyinsights/v20211001", _module)
