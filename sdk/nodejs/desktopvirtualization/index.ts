// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./application";
export * from "./applicationGroup";
export * from "./getApplication";
export * from "./getApplicationGroup";
export * from "./getHostPool";
export * from "./getMSIXPackage";
export * from "./getPrivateEndpointConnectionByHostPool";
export * from "./getPrivateEndpointConnectionByWorkspace";
export * from "./getScalingPlan";
export * from "./getScalingPlanPooledSchedule";
export * from "./getWorkspace";
export * from "./hostPool";
export * from "./msixpackage";
export * from "./privateEndpointConnectionByHostPool";
export * from "./privateEndpointConnectionByWorkspace";
export * from "./scalingPlan";
export * from "./scalingPlanPooledSchedule";
export * from "./workspace";

// Export enums:
export * from "../types/enums/desktopvirtualization";

// Export sub-modules:
import * as v20190123preview from "./v20190123preview";
import * as v20190924preview from "./v20190924preview";
import * as v20191210preview from "./v20191210preview";
import * as v20200921preview from "./v20200921preview";
import * as v20201019preview from "./v20201019preview";
import * as v20201102preview from "./v20201102preview";
import * as v20201110preview from "./v20201110preview";
import * as v20210114preview from "./v20210114preview";
import * as v20210201preview from "./v20210201preview";
import * as v20210309preview from "./v20210309preview";
import * as v20210401preview from "./v20210401preview";
import * as v20210712 from "./v20210712";
import * as v20210903preview from "./v20210903preview";
import * as v20220210preview from "./v20220210preview";
import * as v20220401preview from "./v20220401preview";

export {
    v20190123preview,
    v20190924preview,
    v20191210preview,
    v20200921preview,
    v20201019preview,
    v20201102preview,
    v20201110preview,
    v20210114preview,
    v20210201preview,
    v20210309preview,
    v20210401preview,
    v20210712,
    v20210903preview,
    v20220210preview,
    v20220401preview,
};

// Import resources to register:
import { Application } from "./application";
import { ApplicationGroup } from "./applicationGroup";
import { HostPool } from "./hostPool";
import { MSIXPackage } from "./msixpackage";
import { PrivateEndpointConnectionByHostPool } from "./privateEndpointConnectionByHostPool";
import { PrivateEndpointConnectionByWorkspace } from "./privateEndpointConnectionByWorkspace";
import { ScalingPlan } from "./scalingPlan";
import { ScalingPlanPooledSchedule } from "./scalingPlanPooledSchedule";
import { Workspace } from "./workspace";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:desktopvirtualization:Application":
                return new Application(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:ApplicationGroup":
                return new ApplicationGroup(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:HostPool":
                return new HostPool(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:MSIXPackage":
                return new MSIXPackage(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:PrivateEndpointConnectionByHostPool":
                return new PrivateEndpointConnectionByHostPool(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:PrivateEndpointConnectionByWorkspace":
                return new PrivateEndpointConnectionByWorkspace(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:ScalingPlan":
                return new ScalingPlan(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:ScalingPlanPooledSchedule":
                return new ScalingPlanPooledSchedule(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization:Workspace":
                return new Workspace(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "desktopvirtualization", _module)
