// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a published blueprint.
 */
export function getPublishedBlueprint(args: GetPublishedBlueprintArgs, opts?: pulumi.InvokeOptions): Promise<GetPublishedBlueprintResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:blueprint/v20181101preview:getPublishedBlueprint", {
        "blueprintName": args.blueprintName,
        "resourceScope": args.resourceScope,
        "versionId": args.versionId,
    }, opts);
}

export interface GetPublishedBlueprintArgs {
    /**
     * Name of the blueprint definition.
     */
    blueprintName: string;
    /**
     * The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}').
     */
    resourceScope: string;
    /**
     * Version of the published blueprint definition.
     */
    versionId: string;
}

/**
 * Represents a published blueprint.
 */
export interface GetPublishedBlueprintResult {
    /**
     * Name of the published blueprint definition.
     */
    readonly blueprintName?: string;
    /**
     * Version-specific change notes.
     */
    readonly changeNotes?: string;
    /**
     * Multi-line explain this resource.
     */
    readonly description?: string;
    /**
     * One-liner string explain this resource.
     */
    readonly displayName?: string;
    /**
     * String Id used to locate any resource on Azure.
     */
    readonly id: string;
    /**
     * Name of this resource.
     */
    readonly name: string;
    /**
     * Parameters required by this blueprint definition.
     */
    readonly parameters?: {[key: string]: outputs.blueprint.v20181101preview.ParameterDefinitionResponse};
    /**
     * Resource group placeholders defined by this blueprint definition.
     */
    readonly resourceGroups?: {[key: string]: outputs.blueprint.v20181101preview.ResourceGroupDefinitionResponse};
    /**
     * Status of the blueprint. This field is readonly.
     */
    readonly status: outputs.blueprint.v20181101preview.BlueprintStatusResponse;
    /**
     * The scope where this blueprint definition can be assigned.
     */
    readonly targetScope?: string;
    /**
     * Type of this resource.
     */
    readonly type: string;
}

export function getPublishedBlueprintOutput(args: GetPublishedBlueprintOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPublishedBlueprintResult> {
    return pulumi.output(args).apply(a => getPublishedBlueprint(a, opts))
}

export interface GetPublishedBlueprintOutputArgs {
    /**
     * Name of the blueprint definition.
     */
    blueprintName: pulumi.Input<string>;
    /**
     * The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}').
     */
    resourceScope: pulumi.Input<string>;
    /**
     * Version of the published blueprint definition.
     */
    versionId: pulumi.Input<string>;
}
