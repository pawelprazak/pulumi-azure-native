// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

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
export * from "./getWorkspace";
export * from "./hostPool";
export * from "./msixpackage";
export * from "./privateEndpointConnectionByHostPool";
export * from "./privateEndpointConnectionByWorkspace";
export * from "./scalingPlan";
export * from "./workspace";

// Export enums:
export * from "../../types/enums/desktopvirtualization/v20220210preview";

// Import resources to register:
import { Application } from "./application";
import { ApplicationGroup } from "./applicationGroup";
import { HostPool } from "./hostPool";
import { MSIXPackage } from "./msixpackage";
import { PrivateEndpointConnectionByHostPool } from "./privateEndpointConnectionByHostPool";
import { PrivateEndpointConnectionByWorkspace } from "./privateEndpointConnectionByWorkspace";
import { ScalingPlan } from "./scalingPlan";
import { Workspace } from "./workspace";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:desktopvirtualization/v20220210preview:Application":
                return new Application(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:ApplicationGroup":
                return new ApplicationGroup(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:HostPool":
                return new HostPool(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:MSIXPackage":
                return new MSIXPackage(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:PrivateEndpointConnectionByHostPool":
                return new PrivateEndpointConnectionByHostPool(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:PrivateEndpointConnectionByWorkspace":
                return new PrivateEndpointConnectionByWorkspace(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:ScalingPlan":
                return new ScalingPlan(name, <any>undefined, { urn })
            case "azure-native:desktopvirtualization/v20220210preview:Workspace":
                return new Workspace(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "desktopvirtualization/v20220210preview", _module)
