// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * URL used to authorize the Developer Hub GitHub App
 * API Version: 2022-04-01-preview.
 */
export function getGitHubOAuth(args: GetGitHubOAuthArgs, opts?: pulumi.InvokeOptions): Promise<GetGitHubOAuthResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:devhub:getGitHubOAuth", {
        "location": args.location,
        "redirectUrl": args.redirectUrl,
    }, opts);
}

export interface GetGitHubOAuthArgs {
    /**
     * The name of Azure region.
     */
    location: string;
    /**
     * The URL the client will redirect to on successful authentication. If empty, no redirect will occur.
     */
    redirectUrl?: string;
}

/**
 * URL used to authorize the Developer Hub GitHub App
 */
export interface GetGitHubOAuthResult {
    /**
     * URL for authorizing the Developer Hub GitHub App
     */
    readonly authURL?: string;
    /**
     * OAuth token used to make calls to GitHub
     */
    readonly token?: string;
}

export function getGitHubOAuthOutput(args: GetGitHubOAuthOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGitHubOAuthResult> {
    return pulumi.output(args).apply(a => getGitHubOAuth(a, opts))
}

export interface GetGitHubOAuthOutputArgs {
    /**
     * The name of Azure region.
     */
    location: pulumi.Input<string>;
    /**
     * The URL the client will redirect to on successful authentication. If empty, no redirect will occur.
     */
    redirectUrl?: pulumi.Input<string>;
}
