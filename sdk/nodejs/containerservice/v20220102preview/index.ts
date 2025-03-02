// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./agentPool";
export * from "./getAgentPool";
export * from "./getMaintenanceConfiguration";
export * from "./getManagedCluster";
export * from "./getPrivateEndpointConnection";
export * from "./getSnapshot";
export * from "./listManagedClusterAdminCredentials";
export * from "./listManagedClusterMonitoringUserCredentials";
export * from "./listManagedClusterUserCredentials";
export * from "./maintenanceConfiguration";
export * from "./managedCluster";
export * from "./privateEndpointConnection";
export * from "./snapshot";

// Export enums:
export * from "../../types/enums/containerservice/v20220102preview";

// Import resources to register:
import { AgentPool } from "./agentPool";
import { MaintenanceConfiguration } from "./maintenanceConfiguration";
import { ManagedCluster } from "./managedCluster";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { Snapshot } from "./snapshot";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:containerservice/v20220102preview:AgentPool":
                return new AgentPool(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220102preview:MaintenanceConfiguration":
                return new MaintenanceConfiguration(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220102preview:ManagedCluster":
                return new ManagedCluster(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220102preview:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:containerservice/v20220102preview:Snapshot":
                return new Snapshot(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "containerservice/v20220102preview", _module)
