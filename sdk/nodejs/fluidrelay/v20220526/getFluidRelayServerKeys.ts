// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The set of available keys for this server.
 */
export function getFluidRelayServerKeys(args: GetFluidRelayServerKeysArgs, opts?: pulumi.InvokeOptions): Promise<GetFluidRelayServerKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:fluidrelay/v20220526:getFluidRelayServerKeys", {
        "fluidRelayServerName": args.fluidRelayServerName,
        "resourceGroup": args.resourceGroup,
    }, opts);
}

export interface GetFluidRelayServerKeysArgs {
    /**
     * The Fluid Relay server resource name.
     */
    fluidRelayServerName: string;
    /**
     * The resource group containing the resource.
     */
    resourceGroup: string;
}

/**
 * The set of available keys for this server.
 */
export interface GetFluidRelayServerKeysResult {
    /**
     * The primary key for this server
     */
    readonly key1: string;
    /**
     * The secondary key for this server
     */
    readonly key2: string;
}

export function getFluidRelayServerKeysOutput(args: GetFluidRelayServerKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFluidRelayServerKeysResult> {
    return pulumi.output(args).apply(a => getFluidRelayServerKeys(a, opts))
}

export interface GetFluidRelayServerKeysOutputArgs {
    /**
     * The Fluid Relay server resource name.
     */
    fluidRelayServerName: pulumi.Input<string>;
    /**
     * The resource group containing the resource.
     */
    resourceGroup: pulumi.Input<string>;
}
