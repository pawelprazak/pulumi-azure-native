// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource Sync Rules definition.
 */
export function getResourceSyncRule(args: GetResourceSyncRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetResourceSyncRuleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:extendedlocation/v20210831preview:getResourceSyncRule", {
        "childResourceName": args.childResourceName,
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetResourceSyncRuleArgs {
    /**
     * Resource Sync Rule name.
     */
    childResourceName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Custom Locations name.
     */
    resourceName: string;
}

/**
 * Resource Sync Rules definition.
 */
export interface GetResourceSyncRuleResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Priority represents a priority of the Resource Sync Rule
     */
    readonly priority?: number;
    /**
     * Provisioning State for the Resource Sync Rule.
     */
    readonly provisioningState: string;
    /**
     * A label selector is composed of two parts, matchLabels and matchExpressions. The first part, matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is 'key', the operator is 'In', and the values array contains only 'value'. The second part, matchExpressions is a list of resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist. The values set must be non-empty in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist. All of the requirements, from both matchLabels and matchExpressions must all be satisfied in order to match.
     */
    readonly selector?: outputs.extendedlocation.v20210831preview.ResourceSyncRulePropertiesResponseSelector;
    /**
     * Metadata pertaining to creation and last modification of the resource
     */
    readonly systemData: outputs.extendedlocation.v20210831preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * For an unmapped custom resource, its labels will be used to find matching resource sync rules. If this resource sync rule is one of the matching rules with highest priority, then the unmapped custom resource will be projected to the target resource group associated with this resource sync rule. The user creating this resource sync rule should have write permissions on the target resource group and this write permission will be validated when creating the resource sync rule.
     */
    readonly targetResourceGroup?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getResourceSyncRuleOutput(args: GetResourceSyncRuleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetResourceSyncRuleResult> {
    return pulumi.output(args).apply(a => getResourceSyncRule(a, opts))
}

export interface GetResourceSyncRuleOutputArgs {
    /**
     * Resource Sync Rule name.
     */
    childResourceName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Custom Locations name.
     */
    resourceName: pulumi.Input<string>;
}
