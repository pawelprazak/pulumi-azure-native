// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Collector policy resource.
 * API Version: 2022-05-01.
 */
export function getCollectorPolicy(args: GetCollectorPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetCollectorPolicyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:networkfunction:getCollectorPolicy", {
        "azureTrafficCollectorName": args.azureTrafficCollectorName,
        "collectorPolicyName": args.collectorPolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetCollectorPolicyArgs {
    /**
     * Azure Traffic Collector name
     */
    azureTrafficCollectorName: string;
    /**
     * Collector Policy Name
     */
    collectorPolicyName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Collector policy resource.
 */
export interface GetCollectorPolicyResult {
    /**
     * Emission policies.
     */
    readonly emissionPolicies?: outputs.networkfunction.EmissionPoliciesPropertiesFormatResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * Ingestion policies.
     */
    readonly ingestionPolicy?: outputs.networkfunction.IngestionPolicyPropertiesFormatResponse;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.networkfunction.CollectorPolicyResponseSystemData;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getCollectorPolicyOutput(args: GetCollectorPolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCollectorPolicyResult> {
    return pulumi.output(args).apply(a => getCollectorPolicy(a, opts))
}

export interface GetCollectorPolicyOutputArgs {
    /**
     * Azure Traffic Collector name
     */
    azureTrafficCollectorName: pulumi.Input<string>;
    /**
     * Collector Policy Name
     */
    collectorPolicyName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
