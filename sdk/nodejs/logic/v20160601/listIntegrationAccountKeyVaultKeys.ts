// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Collection of key vault keys.
 */
export function listIntegrationAccountKeyVaultKeys(args: ListIntegrationAccountKeyVaultKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListIntegrationAccountKeyVaultKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:logic/v20160601:listIntegrationAccountKeyVaultKeys", {
        "integrationAccountName": args.integrationAccountName,
        "keyVault": args.keyVault,
        "resourceGroupName": args.resourceGroupName,
        "skipToken": args.skipToken,
    }, opts);
}

export interface ListIntegrationAccountKeyVaultKeysArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: string;
    /**
     * The key vault reference.
     */
    keyVault: inputs.logic.v20160601.KeyVaultReference;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The skip token.
     */
    skipToken?: string;
}

/**
 * Collection of key vault keys.
 */
export interface ListIntegrationAccountKeyVaultKeysResult {
    /**
     * The skip token.
     */
    readonly skipToken?: string;
    /**
     * The key vault keys.
     */
    readonly value?: outputs.logic.v20160601.KeyVaultKeyResponse[];
}

export function listIntegrationAccountKeyVaultKeysOutput(args: ListIntegrationAccountKeyVaultKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIntegrationAccountKeyVaultKeysResult> {
    return pulumi.output(args).apply(a => listIntegrationAccountKeyVaultKeys(a, opts))
}

export interface ListIntegrationAccountKeyVaultKeysOutputArgs {
    /**
     * The integration account name.
     */
    integrationAccountName: pulumi.Input<string>;
    /**
     * The key vault reference.
     */
    keyVault: pulumi.Input<inputs.logic.v20160601.KeyVaultReferenceArgs>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The skip token.
     */
    skipToken?: pulumi.Input<string>;
}
