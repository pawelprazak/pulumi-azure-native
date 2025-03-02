// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Cloud shell console
 * API Version: 2018-10-01.
 */
export function getConsole(args: GetConsoleArgs, opts?: pulumi.InvokeOptions): Promise<GetConsoleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:portal:getConsole", {
        "consoleName": args.consoleName,
    }, opts);
}

export interface GetConsoleArgs {
    /**
     * The name of the console
     */
    consoleName: string;
}

/**
 * Cloud shell console
 */
export interface GetConsoleResult {
    /**
     * Cloud shell console properties.
     */
    readonly properties: outputs.portal.ConsolePropertiesResponse;
}

export function getConsoleOutput(args: GetConsoleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetConsoleResult> {
    return pulumi.output(args).apply(a => getConsole(a, opts))
}

export interface GetConsoleOutputArgs {
    /**
     * The name of the console
     */
    consoleName: pulumi.Input<string>;
}
