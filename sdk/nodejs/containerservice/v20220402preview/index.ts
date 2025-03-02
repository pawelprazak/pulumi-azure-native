// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./agentPool";
export * from "./getAgentPool";
export * from "./getMaintenanceConfiguration";
export * from "./getManagedCluster";
export * from "./getManagedClusterSnapshot";
export * from "./getPrivateEndpointConnection";
export * from "./getSnapshot";
export * from "./getTrustedAccessRoleBinding";
export * from "./listManagedClusterAdminCredentials";
export * from "./listManagedClusterMonitoringUserCredentials";
export * from "./listManagedClusterUserCredentials";
export * from "./maintenanceConfiguration";
export * from "./managedCluster";
export * from "./managedClusterSnapshot";
export * from "./privateEndpointConnection";
export * from "./snapshot";
export * from "./trustedAccessRoleBinding";

// Export enums:
export * from "../../types/enums/containerservice/v20220402preview";

// Import resources to register:
import { AgentPool } from "./agentPool";
import { MaintenanceConfiguration } from "./maintenanceConfiguration";
import { ManagedCluster } from "./managedCluster";
import { ManagedClusterSnapshot } from "./managedClusterSnapshot";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { Snapshot } from "./snapshot";
import { TrustedAccessRoleBinding } from "./trustedAccessRoleBinding";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:containerservice/v20220402preview:AgentPool":
                return new AgentPool(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:MaintenanceConfiguration":
                return new MaintenanceConfiguration(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:ManagedCluster":
                return new ManagedCluster(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:ManagedClusterSnapshot":
                return new ManagedClusterSnapshot(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220402preview:TrustedAccessRoleBinding":
                return new TrustedAccessRoleBinding(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "containerservice/v20220402preview", _module)
