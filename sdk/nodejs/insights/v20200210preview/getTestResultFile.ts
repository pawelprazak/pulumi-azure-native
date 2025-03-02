// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Test result.
 */
export function getTestResultFile(args: GetTestResultFileArgs, opts?: pulumi.InvokeOptions): Promise<GetTestResultFileResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights/v20200210preview:getTestResultFile", {
        "continuationToken": args.continuationToken,
        "downloadAs": args.downloadAs,
        "geoLocationId": args.geoLocationId,
        "resourceGroupName": args.resourceGroupName,
        "testSuccessfulCriteria": args.testSuccessfulCriteria,
        "timeStamp": args.timeStamp,
        "webTestName": args.webTestName,
    }, opts);
}

export interface GetTestResultFileArgs {
    /**
     * The continuation token.
     */
    continuationToken?: string;
    /**
     * The format to use when returning the webtest result.
     */
    downloadAs: string;
    /**
     * The location ID where the webtest was physically run.
     */
    geoLocationId: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The success state criteria for the webtest result.
     */
    testSuccessfulCriteria?: boolean;
    /**
     * The posix (epoch) time stamp for the webtest result.
     */
    timeStamp: number;
    /**
     * The name of the Application Insights webtest resource.
     */
    webTestName: string;
}

/**
 * Test result.
 */
export interface GetTestResultFileResult {
    /**
     * File contents.
     */
    readonly data?: string;
    /**
     * The URI that can be used to request the next section of the result file in the event the file is too large for a single request.
     */
    readonly nextLink?: string;
}

export function getTestResultFileOutput(args: GetTestResultFileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTestResultFileResult> {
    return pulumi.output(args).apply(a => getTestResultFile(a, opts))
}

export interface GetTestResultFileOutputArgs {
    /**
     * The continuation token.
     */
    continuationToken?: pulumi.Input<string>;
    /**
     * The format to use when returning the webtest result.
     */
    downloadAs: pulumi.Input<string>;
    /**
     * The location ID where the webtest was physically run.
     */
    geoLocationId: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The success state criteria for the webtest result.
     */
    testSuccessfulCriteria?: pulumi.Input<boolean>;
    /**
     * The posix (epoch) time stamp for the webtest result.
     */
    timeStamp: pulumi.Input<number>;
    /**
     * The name of the Application Insights webtest resource.
     */
    webTestName: pulumi.Input<string>;
}
