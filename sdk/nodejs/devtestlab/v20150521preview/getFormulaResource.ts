// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A formula.
 */
/** @deprecated Version 2015-05-21-preview will be removed in v2 of the provider. */
export function getFormulaResource(args: GetFormulaResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetFormulaResourceResult> {
    pulumi.log.warn("getFormulaResource is deprecated: Version 2015-05-21-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:devtestlab/v20150521preview:getFormulaResource", {
        "labName": args.labName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetFormulaResourceArgs {
    /**
     * The name of the lab.
     */
    labName: string;
    /**
     * The name of the formula.
     */
    name: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * A formula.
 */
export interface GetFormulaResourceResult {
    /**
     * The author of the formula.
     */
    readonly author?: string;
    /**
     * The creation date of the formula.
     */
    readonly creationDate?: string;
    /**
     * The description of the formula.
     */
    readonly description?: string;
    /**
     * The content of the formula.
     */
    readonly formulaContent?: outputs.devtestlab.v20150521preview.LabVirtualMachineResponse;
    /**
     * The identifier of the resource.
     */
    readonly id?: string;
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name?: string;
    /**
     * The OS type of the formula.
     */
    readonly osType?: string;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState?: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type?: string;
    /**
     * Information about a VM from which a formula is to be created.
     */
    readonly vm?: outputs.devtestlab.v20150521preview.FormulaPropertiesFromVmResponse;
}

export function getFormulaResourceOutput(args: GetFormulaResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFormulaResourceResult> {
    return pulumi.output(args).apply(a => getFormulaResource(a, opts))
}

export interface GetFormulaResourceOutputArgs {
    /**
     * The name of the lab.
     */
    labName: pulumi.Input<string>;
    /**
     * The name of the formula.
     */
    name: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
