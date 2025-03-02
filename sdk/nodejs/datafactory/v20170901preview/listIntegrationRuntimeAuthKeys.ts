// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The integration runtime authentication keys.
 */
export function listIntegrationRuntimeAuthKeys(args: ListIntegrationRuntimeAuthKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListIntegrationRuntimeAuthKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datafactory/v20170901preview:listIntegrationRuntimeAuthKeys", {
        "factoryName": args.factoryName,
        "integrationRuntimeName": args.integrationRuntimeName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListIntegrationRuntimeAuthKeysArgs {
    /**
     * The factory name.
     */
    factoryName: string;
    /**
     * The integration runtime name.
     */
    integrationRuntimeName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

/**
 * The integration runtime authentication keys.
 */
export interface ListIntegrationRuntimeAuthKeysResult {
    /**
     * The primary integration runtime authentication key.
     */
    readonly authKey1?: string;
    /**
     * The secondary integration runtime authentication key.
     */
    readonly authKey2?: string;
}

export function listIntegrationRuntimeAuthKeysOutput(args: ListIntegrationRuntimeAuthKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIntegrationRuntimeAuthKeysResult> {
    return pulumi.output(args).apply(a => listIntegrationRuntimeAuthKeys(a, opts))
}

export interface ListIntegrationRuntimeAuthKeysOutputArgs {
    /**
     * The factory name.
     */
    factoryName: pulumi.Input<string>;
    /**
     * The integration runtime name.
     */
    integrationRuntimeName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
