// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The workflow trigger callback URL.
 */
export function listIntegrationAccountMapContentCallbackUrl(args: ListIntegrationAccountMapContentCallbackUrlArgs, opts?: pulumi.InvokeOptions): Promise<ListIntegrationAccountMapContentCallbackUrlResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:logic/v20190501:listIntegrationAccountMapContentCallbackUrl", {
        "integrationAccountName": args.integrationAccountName,
        "keyType": args.keyType,
        "mapName": args.mapName,
        "notAfter": args.notAfter,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListIntegrationAccountMapContentCallbackUrlArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: string;
    /**
     * The key type.
     */
    keyType?: string | enums.logic.v20190501.KeyType;
    /**
     * The integration account map name.
     */
    mapName: string;
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
 * The workflow trigger callback URL.
 */
export interface ListIntegrationAccountMapContentCallbackUrlResult {
    /**
     * Gets the workflow trigger callback URL base path.
     */
    readonly basePath: string;
    /**
     * Gets the workflow trigger callback URL HTTP method.
     */
    readonly method: string;
    /**
     * Gets the workflow trigger callback URL query parameters.
     */
    readonly queries?: outputs.logic.v20190501.WorkflowTriggerListCallbackUrlQueriesResponse;
    /**
     * Gets the workflow trigger callback URL relative path.
     */
    readonly relativePath: string;
    /**
     * Gets the workflow trigger callback URL relative path parameters.
     */
    readonly relativePathParameters?: string[];
    /**
     * Gets the workflow trigger callback URL.
     */
    readonly value: string;
}

export function listIntegrationAccountMapContentCallbackUrlOutput(args: ListIntegrationAccountMapContentCallbackUrlOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIntegrationAccountMapContentCallbackUrlResult> {
    return pulumi.output(args).apply(a => listIntegrationAccountMapContentCallbackUrl(a, opts))
}

export interface ListIntegrationAccountMapContentCallbackUrlOutputArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: pulumi.Input<string>;
    /**
     * The key type.
     */
    keyType?: pulumi.Input<string | enums.logic.v20190501.KeyType>;
    /**
     * The integration account map name.
     */
    mapName: pulumi.Input<string>;
    /**
     * The expiry time.
     */
    notAfter?: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
