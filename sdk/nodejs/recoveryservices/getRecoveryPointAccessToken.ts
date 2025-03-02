// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * API Version: 2018-12-20.
 */
export function getRecoveryPointAccessToken(args: GetRecoveryPointAccessTokenArgs, opts?: pulumi.InvokeOptions): Promise<GetRecoveryPointAccessTokenResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:recoveryservices:getRecoveryPointAccessToken", {
        "containerName": args.containerName,
        "eTag": args.eTag,
        "fabricName": args.fabricName,
        "location": args.location,
        "properties": args.properties,
        "protectedItemName": args.protectedItemName,
        "recoveryPointId": args.recoveryPointId,
        "resourceGroupName": args.resourceGroupName,
        "tags": args.tags,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetRecoveryPointAccessTokenArgs {
    /**
     * Name of the container.
     */
    containerName: string;
    /**
     * Optional ETag.
     */
    eTag?: string;
    /**
     * Fabric name associated with the container.
     */
    fabricName: string;
    /**
     * Resource location.
     */
    location?: string;
    /**
     * AADPropertiesResource properties
     */
    properties?: inputs.recoveryservices.AADProperties;
    /**
     * Name of the Protected Item.
     */
    protectedItemName: string;
    /**
     * Recovery Point Id
     */
    recoveryPointId: string;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: string;
    /**
     * Resource tags.
     */
    tags?: {[key: string]: string};
    /**
     * The name of the recovery services vault.
     */
    vaultName: string;
}

export interface GetRecoveryPointAccessTokenResult {
    /**
     * Optional ETag.
     */
    readonly eTag?: string;
    /**
     * Resource Id represents the complete path to the resource.
     */
    readonly id: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name associated with the resource.
     */
    readonly name: string;
    /**
     * CrrAccessTokenResource properties
     */
    readonly properties: outputs.recoveryservices.WorkloadCrrAccessTokenResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
     */
    readonly type: string;
}

export function getRecoveryPointAccessTokenOutput(args: GetRecoveryPointAccessTokenOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRecoveryPointAccessTokenResult> {
    return pulumi.output(args).apply(a => getRecoveryPointAccessToken(a, opts))
}

export interface GetRecoveryPointAccessTokenOutputArgs {
    /**
     * Name of the container.
     */
    containerName: pulumi.Input<string>;
    /**
     * Optional ETag.
     */
    eTag?: pulumi.Input<string>;
    /**
     * Fabric name associated with the container.
     */
    fabricName: pulumi.Input<string>;
    /**
     * Resource location.
     */
    location?: pulumi.Input<string>;
    /**
     * AADPropertiesResource properties
     */
    properties?: pulumi.Input<inputs.recoveryservices.AADPropertiesArgs>;
    /**
     * Name of the Protected Item.
     */
    protectedItemName: pulumi.Input<string>;
    /**
     * Recovery Point Id
     */
    recoveryPointId: pulumi.Input<string>;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the recovery services vault.
     */
    vaultName: pulumi.Input<string>;
}
