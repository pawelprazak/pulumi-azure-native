// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The callback url.
 */
export function listIntegrationAccountCallbackUrl(args: ListIntegrationAccountCallbackUrlArgs, opts?: pulumi.InvokeOptions): Promise<ListIntegrationAccountCallbackUrlResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:logic/v20190501:listIntegrationAccountCallbackUrl", {
        "integrationAccountName": args.integrationAccountName,
        "keyType": args.keyType,
        "notAfter": args.notAfter,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListIntegrationAccountCallbackUrlArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: string;
    /**
     * The key type.
     */
    keyType?: string | enums.logic.v20190501.KeyType;
    /**
     * The expiry time.
     */
    notAfter?: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

/**
 * The callback url.
 */
export interface ListIntegrationAccountCallbackUrlResult {
    /**
     * The URL value.
     */
    readonly value?: string;
}

export function listIntegrationAccountCallbackUrlOutput(args: ListIntegrationAccountCallbackUrlOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIntegrationAccountCallbackUrlResult> {
    return pulumi.output(args).apply(a => listIntegrationAccountCallbackUrl(a, opts))
}

export interface ListIntegrationAccountCallbackUrlOutputArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: pulumi.Input<string>;
    /**
     * The key type.
     */
    keyType?: pulumi.Input<string | enums.logic.v20190501.KeyType>;
    /**
     * The expiry time.
     */
    notAfter?: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
