// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * List of shared access keys.
 */
export function listIotDpsResourceKeys(args: ListIotDpsResourceKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListIotDpsResourceKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:devices/v20200901preview:listIotDpsResourceKeys", {
        "provisioningServiceName": args.provisioningServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListIotDpsResourceKeysArgs {
    /**
     * The provisioning service name to get the shared access keys for.
     */
    provisioningServiceName: string;
    /**
     * resource group name
     */
    resourceGroupName: string;
}

/**
 * List of shared access keys.
 */
export interface ListIotDpsResourceKeysResult {
    /**
     * The next link.
     */
    readonly nextLink: string;
    /**
     * The list of shared access policies.
     */
    readonly value?: outputs.devices.v20200901preview.SharedAccessSignatureAuthorizationRuleAccessRightsDescriptionResponse[];
}

export function listIotDpsResourceKeysOutput(args: ListIotDpsResourceKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIotDpsResourceKeysResult> {
    return pulumi.output(args).apply(a => listIotDpsResourceKeys(a, opts))
}

export interface ListIotDpsResourceKeysOutputArgs {
    /**
     * The provisioning service name to get the shared access keys for.
     */
    provisioningServiceName: pulumi.Input<string>;
    /**
     * resource group name
     */
    resourceGroupName: pulumi.Input<string>;
}
