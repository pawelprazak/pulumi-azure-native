// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource information, as returned by the resource provider.
 */
/** @deprecated Version 2016-06-01 will be removed in v2 of the provider. */
export function getVault(args: GetVaultArgs, opts?: pulumi.InvokeOptions): Promise<GetVaultResult> {
    pulumi.log.warn("getVault is deprecated: Version 2016-06-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:recoveryservices/v20160601:getVault", {
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetVaultArgs {
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: string;
    /**
     * The name of the recovery services vault.
     */
    vaultName: string;
}

/**
 * Resource information, as returned by the resource provider.
 */
export interface GetVaultResult {
    /**
     * Optional ETag.
     */
    readonly eTag?: string;
    /**
     * Resource Id represents the complete path to the resource.
     */
    readonly id: string;
    /**
     * Identity for the resource.
     */
    readonly identity?: outputs.recoveryservices.v20160601.IdentityDataResponse;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name associated with the resource.
     */
    readonly name: string;
    /**
     * Properties of the vault.
     */
    readonly properties: outputs.recoveryservices.v20160601.VaultPropertiesResponse;
    /**
     * Identifies the unique system identifier for each Azure resource.
     */
    readonly sku?: outputs.recoveryservices.v20160601.SkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
     */
    readonly type: string;
}

export function getVaultOutput(args: GetVaultOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVaultResult> {
    return pulumi.output(args).apply(a => getVault(a, opts))
}

export interface GetVaultOutputArgs {
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the recovery services vault.
     */
    vaultName: pulumi.Input<string>;
}
