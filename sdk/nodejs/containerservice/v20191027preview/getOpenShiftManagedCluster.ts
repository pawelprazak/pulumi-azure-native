// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * OpenShift Managed cluster.
 */
export function getOpenShiftManagedCluster(args: GetOpenShiftManagedClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetOpenShiftManagedClusterResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:containerservice/v20191027preview:getOpenShiftManagedCluster", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetOpenShiftManagedClusterArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the OpenShift managed cluster resource.
     */
    resourceName: string;
}

/**
 * OpenShift Managed cluster.
 */
export interface GetOpenShiftManagedClusterResult {
    /**
     * Configuration of OpenShift cluster VMs.
     */
    readonly agentPoolProfiles?: outputs.containerservice.v20191027preview.OpenShiftManagedClusterAgentPoolProfileResponse[];
    /**
     * Configures OpenShift authentication.
     */
    readonly authProfile?: outputs.containerservice.v20191027preview.OpenShiftManagedClusterAuthProfileResponse;
    /**
     * Version of OpenShift specified when creating the cluster.
     */
    readonly clusterVersion: string;
    /**
     * Service generated FQDN for OpenShift API server loadbalancer internal hostname.
     */
    readonly fqdn: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Configuration for OpenShift master VMs.
     */
    readonly masterPoolProfile?: outputs.containerservice.v20191027preview.OpenShiftManagedClusterMasterPoolProfileResponse;
    /**
     * Configures Log Analytics integration.
     */
    readonly monitorProfile?: outputs.containerservice.v20191027preview.OpenShiftManagedClusterMonitorProfileResponse;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Configuration for OpenShift networking.
     */
    readonly networkProfile?: outputs.containerservice.v20191027preview.NetworkProfileResponse;
    /**
     * Version of OpenShift specified when creating the cluster.
     */
    readonly openShiftVersion: string;
    /**
     * Define the resource plan as required by ARM for billing purposes
     */
    readonly plan?: outputs.containerservice.v20191027preview.PurchasePlanResponse;
    /**
     * The current deployment or provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Service generated FQDN or private IP for OpenShift API server.
     */
    readonly publicHostname: string;
    /**
     * Allows node rotation
     */
    readonly refreshCluster?: boolean;
    /**
     * Configuration for OpenShift router(s).
     */
    readonly routerProfiles?: outputs.containerservice.v20191027preview.OpenShiftRouterProfileResponse[];
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getOpenShiftManagedClusterOutput(args: GetOpenShiftManagedClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOpenShiftManagedClusterResult> {
    return pulumi.output(args).apply(a => getOpenShiftManagedCluster(a, opts))
}

export interface GetOpenShiftManagedClusterOutputArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the OpenShift managed cluster resource.
     */
    resourceName: pulumi.Input<string>;
}
