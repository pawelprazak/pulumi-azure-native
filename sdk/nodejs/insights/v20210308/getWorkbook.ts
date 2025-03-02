// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Application Insights workbook definition.
 */
export function getWorkbook(args: GetWorkbookArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkbookResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights/v20210308:getWorkbook", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetWorkbookArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the Application Insights component resource.
     */
    resourceName: string;
}

/**
 * An Application Insights workbook definition.
 */
export interface GetWorkbookResult {
    /**
     * Workbook category, as defined by the user at creation time.
     */
    readonly category: string;
    /**
     * The description of the workbook.
     */
    readonly description?: string;
    /**
     * The user-defined name (display name) of the workbook.
     */
    readonly displayName: string;
    /**
     * Resource etag
     */
    readonly etag?: {[key: string]: string};
    /**
     * Azure resource Id
     */
    readonly id?: string;
    /**
     * Identity used for BYOS
     */
    readonly identity?: outputs.insights.v20210308.WorkbookManagedIdentityResponse;
    /**
     * The kind of workbook. Choices are user and shared.
     */
    readonly kind?: string;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * Azure resource name
     */
    readonly name?: string;
    /**
     * The unique revision id for this workbook definition
     */
    readonly revision?: string;
    /**
     * Configuration of this particular workbook. Configuration data is a string containing valid JSON
     */
    readonly serializedData: string;
    /**
     * ResourceId for a source resource.
     */
    readonly sourceId?: string;
    /**
     * BYOS Storage Account URI
     */
    readonly storageUri?: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.insights.v20210308.SystemDataResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Date and time in UTC of the last modification that was made to this workbook definition.
     */
    readonly timeModified: string;
    /**
     * Azure resource type
     */
    readonly type?: string;
    /**
     * Unique user id of the specific user that owns this workbook.
     */
    readonly userId: string;
    /**
     * Workbook version
     */
    readonly version?: string;
}

export function getWorkbookOutput(args: GetWorkbookOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWorkbookResult> {
    return pulumi.output(args).apply(a => getWorkbook(a, opts))
}

export interface GetWorkbookOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Application Insights component resource.
     */
    resourceName: pulumi.Input<string>;
}
